using DevExpress.XtraGrid.Views.Grid;
using MutuDAL;
using MutuModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutuERP
{
    public partial class LessonEnrollConfirmForm : BaseForm
    {
        private DataTable tableSelect;
        private string remark;

        public void SetTableSelected(DataTable t)
        {
            tableSelect = t;
            gridControl.DataSource = tableSelect;
        }
        public void SetRemark(string str)
        {
            remark = str;
            memoEditRemark.Text = remark;
        }

        public LessonEnrollConfirmForm()
        {
            InitializeComponent();

            Init();

            LoadData();
        }
        
        private void Init()
        {

        }

        private void LoadData()
        {
            LoadStaff();
        }

        private void LoadStaff()
        {
            gridControl.DataSource = tableSelect;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonConfrim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
