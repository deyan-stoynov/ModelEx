using System.Collections.Generic;
using EnvDTE;
using EnvDTE80;

namespace ModelExWizard
{
    public static class DteExtentions
    {
        /// <summary>
        /// Gets the project item.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="name">The name of the project item.</param>
        /// <param name="kind">The kind of project item located in EndDTE.Constatns class.</param>
        public static ProjectItem GetProjectItem(this Project project, string name, string kind)
        {
            foreach (ProjectItem item in project.ProjectItems)
            {
                if (item.Name == name && item.Kind == kind)
                {
                    return item;
                }
            }

            return null;
        }

        /// <summary>
        /// Adds project item to folder.
        /// </summary>
        /// <param name="proj">The project.</param>
        /// <param name="item">The project item.</param>
        /// <param name="folder">The destination folder.</param>
        public static void AddToFolder(this Project proj, ProjectItem item, string folder)
        {
            ProjectItem folderItem = proj.GetProjectItem(folder, Constants.vsProjectItemKindPhysicalFolder);

            folderItem = folderItem ?? proj.ProjectItems.AddFolder(folder);
            folderItem.ProjectItems.AddFromFileCopy(item.FileNames[0]);
        }

        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <param name="solution">The solution.</param>
        public static IEnumerable<Project> GetProjects(this Solution solution)
        {
            var projectList = new List<Project>();
            foreach (Project project in solution.Projects)
            {
                if (project.Kind == ProjectKinds.vsProjectKindSolutionFolder)
                {
                    projectList.AddRange(GetSolutionFolderProjects(project));
                }
                else
                {
                    projectList.Add(project);
                }
            }

            return projectList;
        }

        private static IEnumerable<Project> GetSolutionFolderProjects(Project solutionFolder)
        {
            List<Project> list = new List<Project>();

            foreach (ProjectItem item in solutionFolder.ProjectItems)
            {
                if (item.SubProject != null)
                {
                    var subProject = item.SubProject;

                    if (subProject.Kind == ProjectKinds.vsProjectKindSolutionFolder)
                    {
                        list.AddRange(GetSolutionFolderProjects(subProject));
                    }
                    else
                    {
                        list.Add(subProject);
                    }
                }
            }

            return list;
        }
    }
}