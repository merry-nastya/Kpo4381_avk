using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4381_avk.Lib;
using Kpo4381_avk.Lib.source.MyClasses;
using Castle.Windsor;

namespace Kpo4381_avk.Main
{
    public partial class FrmMain : Form
    {

        private List<SearchProject> searchProjectsList = null;
        private BindingSource bsSearchProject = new BindingSource();
        
        public FrmMain()
        {
            InitializeComponent();
            txtLogPath.Text = AppGlobalSettings.logPath;
            txtDataFileName.Text = AppGlobalSettings.dataFileName;
            txtTypeFactory.Text = AppGlobalSettings.searchProjectFactory;
            

        }
        
        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                ISearchProjectListLoader loader = IOCcontainer.container.Resolve<ISearchProjectListLoader>();
                loader.Execute();
                searchProjectsList = loader.searchProjectList;
                bsSearchProject.DataSource = searchProjectsList;
                dgvMockSearchProjectListCommand.DataSource = bsSearchProject;
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                LogUtility.ErrorLog(ex);
            }
        }

        private void mnOpenProject_Click(object sender, EventArgs e)
        {
            FrmProject frmProject = new FrmProject();
            SearchProject searchProject = (bsSearchProject.Current as SearchProject);
            frmProject.SetSearchProject(searchProject);
            frmProject.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnSaveSearchProjects_Click(object sender, EventArgs e)
        {
            ISearchProjectListSaver saver = IOCcontainer.container.Resolve<ISearchProjectListSaver>();
            saver.SaveFile(searchProjectsList);
        }
    }
}
