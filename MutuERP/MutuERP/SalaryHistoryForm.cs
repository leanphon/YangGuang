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
    public partial class SalaryHistoryForm : BaseForm
    {
  
        public SalaryHistoryForm()
        {
            InitializeComponent();
            InitColumnSelector();

            LoadData();
        }
        
        private void Init()
        {

        }

        private void InitColumnSelector()
        {
            columnSelecetor.UpdateColumnDisplay += UpdateColumnDisplay;

            foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridView.Columns)
            {
                columnSelecetor.AddColumn(c.Caption, true);
            }
        }
        private void UpdateColumnDisplay(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridView.Columns)
            {
                if (columnSelecetor.IsCheck(c.Caption))
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void LoadData()
        {
            SalaryBillDAO d = new SalaryBillDAO();
            DataSet set = d.GetAllSalaryBill(null);
            gridCtrl.DataSource = set.Tables[0];
        }

        private void simpleButtonQuery_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonClear_Click(object sender, EventArgs e)
        {
            ClearEdit(tableLayoutPanelQuery);
        }
    }
}
