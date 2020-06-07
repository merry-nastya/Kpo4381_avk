using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4381_avk.Lib;

namespace Kpo4381_avk.Main
{
    public partial class FrmProject : Form
    {
        public FrmProject()
        {
            InitializeComponent();
            _searchProject = null;

        }

        private SearchProject _searchProject = null;

        public SearchProject searchProject
        {
            get { return _searchProject; }
        }

        public void SetSearchProject(SearchProject searchProject)
        {
            this._searchProject = searchProject;
            //this.txtboxYear.Text = _searchProject.year;
        }

        private void FrmProject_Load(object sender, EventArgs e)
        {

        }
    }
}
