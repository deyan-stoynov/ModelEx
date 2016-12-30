using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModelExWizard
{
    public partial class OptionsForm : Form
    {
        private IEnumerable<string> _projectList;

        public OptionsForm(IEnumerable<string> projectList)
        {
            InitializeComponent();

            _projectList = projectList;
        }

        public string SelectedDataProject
        {
            get
            {
                return DataProject.SelectedValue.ToString();
            }
        }

        public string SelectedModelsProject
        {
            get
            {
                return ModelsProject.SelectedValue.ToString();
            }
        }

        public string SelectedCoreProject
        {
            get
            {
                return CoreProject.SelectedValue.ToString();
            }
        }

        public string SelectedBusinessProject
        {
            get
            {
                return BusinessProject.SelectedValue.ToString();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            ModelsProject.DataSource = _projectList.ToList();
            ModelsProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Models"));

            CoreProject.DataSource = _projectList.ToList();
            CoreProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Core"));

            BusinessProject.DataSource = _projectList.ToList();
            BusinessProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Business"));

            DataProject.DataSource = _projectList.ToList();
            DataProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Data"));

            base.OnLoad(e);
        }
    }
}
