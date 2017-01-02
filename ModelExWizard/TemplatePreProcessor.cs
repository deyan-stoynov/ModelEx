using System.Collections.Generic;
using System.IO;
using System.Linq;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TemplateWizard;

namespace ModelExWizard
{
    public class TemplatePreProcessor : IWizard
    {
        #region Constants

        private const string SERVICES_FOLDER = "Services";
        private const string REPOSITORIES_FOLDER = "Repositories";
        private const string DOMAIN_FOLDER = "Domain";

        private const string REPOSITORY_NAME = "Repository";
        private const string SERVICE_NAME = "Service";
        private const string DOMAIN_NAME = "Domain";

        #endregion

        #region Fields

        private readonly DTE _dte;
        private IEnumerable<Project> _allProjects;
        private ProjectItem _tempFolder;

        private string _modelName;

        /// <summary>
        /// The project containing all repositories (data access layer).
        /// </summary>
        private string _dataProject;

        /// <summary>
        /// The project containing all models.
        /// </summary>
        private string _modelsProject;

        /// <summary>
        /// The project containing all interfaces.
        /// </summary>
        private string _coreProject;

        /// <summary>
        /// The project containing all services (business layer).
        /// </summary>
        private string _businessProject;

        #endregion

        #region Ctor

        public TemplatePreProcessor()
        {
            _dte = (DTE)Package.GetGlobalService(typeof(DTE));
        }

        #endregion

        #region IWizard Methods

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            string itemName = Path.GetFileNameWithoutExtension(projectItem.Name);
            string folder = string.Empty;
            Project project = null;

            if (itemName == _modelName)
            {
                project = GetProjectByName(_modelsProject);
                folder = DOMAIN_FOLDER;
            }
            else if (itemName == "I" + _modelName + SERVICE_NAME)
            {
                project = GetProjectByName(_coreProject);
                folder = SERVICES_FOLDER;
            }
            else if (itemName == "I" + _modelName + REPOSITORY_NAME)
            {
                project = GetProjectByName(_coreProject);
                folder = REPOSITORIES_FOLDER;
            }
            else if (itemName.EndsWith(REPOSITORY_NAME))
            {
                project = GetProjectByName(_dataProject);
                folder = REPOSITORIES_FOLDER;
            }
            else if (itemName.EndsWith(SERVICE_NAME))
            {
                project = GetProjectByName(_businessProject);
                folder = SERVICES_FOLDER;
            }

            project.AddToFolder(projectItem, folder);
            _tempFolder = (ProjectItem)projectItem.Collection.Parent;
        }

        public void RunStarted(
            object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind,
            object[] customParams)
        {
            _allProjects = _dte.Solution.GetProjects();

            OptionsForm form = new OptionsForm(_allProjects.Select(it => it.Name));
            form.ShowDialog();

            _businessProject = form.SelectedBusinessProject;
            _coreProject = form.SelectedCoreProject;
            _dataProject = form.SelectedDataProject;
            _modelsProject = form.SelectedModelsProject;

            _modelName = replacementsDictionary["$safeitemname$"];
            _modelName = char.ToUpperInvariant(_modelName[0]) + _modelName.Substring(1);

            SetParameters(replacementsDictionary);
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        public void BeforeOpeningFile(ProjectItem projectItem) { }

        public void ProjectFinishedGenerating(Project project) { }

        public void RunFinished()
        {
            _tempFolder?.Remove();
            _tempFolder?.Delete();
        }

        #endregion

        #region Private Methods       

        private void SetParameters(Dictionary<string, string> replacementsDictionary)
        {
            replacementsDictionary.Add(
                        "$propname$",
                        string.Concat("_", char.ToLowerInvariant(_modelName[0]), _modelName.Substring(1), REPOSITORY_NAME));

            replacementsDictionary.Add("$DomainNamespace$", string.Concat(_modelsProject, ".", DOMAIN_NAME));
            replacementsDictionary.Add("$CoreRepoNamespace$", string.Concat(_coreProject, ".", REPOSITORIES_FOLDER));
            replacementsDictionary.Add("$CoreServiceNamespace$", string.Concat(_coreProject, ".", SERVICES_FOLDER));
            replacementsDictionary.Add("$BuisnessNamespace$", string.Concat(_businessProject, ".", SERVICES_FOLDER));
            replacementsDictionary.Add("$DataNamespace$", string.Concat(_dataProject, ".", REPOSITORIES_FOLDER));
        }

        private Project GetProjectByName(string projectName)
        {
            return _allProjects.FirstOrDefault(it => it.Name == projectName);
        }

        #endregion
    }
}