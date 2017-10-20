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
    public partial class SalaryInputForm : BaseForm
    {
        private DataTable tabStaff;
        private DataTable tabPost;
        private DataTable tabPerformance;
        private DataTable tabBenefit;

        public SalaryInputForm()
        {
            InitializeComponent();

            Init();

            InitColumnSelector();

            LoadData();
        }
        
        private void Init()
        {
            tabStaff = new DataTable();
            tabStaff.Columns.Add("BillNumber");
            tabStaff.Columns.Add("StaffId");
            tabStaff.Columns.Add("PersonName");
            tabStaff.Columns.Add("StaffNumber");
            tabStaff.Columns.Add("PostName");
            tabStaff.Columns.Add("PostSalary");
            tabStaff.Columns.Add("PerformanceLevel");
            tabStaff.Columns.Add("PerformanceScore");
            tabStaff.Columns.Add("PerformanceSalary");
            tabStaff.Columns.Add("BenefitLevel");
            tabStaff.Columns.Add("BenefitScore");
            tabStaff.Columns.Add("BenefitSalary");
            tabStaff.Columns.Add("AttendanceSalary");
            tabStaff.Columns.Add("SenioritySalary");
            tabStaff.Columns.Add("ReissueSalary");
            tabStaff.Columns.Add("SalaryTotal");

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

        private void LoadBaseInfo()
        {
            PostDAO d = new PostDAO();
            DataSet set = d.GetAllPost();
            tabPost = set.Tables[0];

            PerformanceDAO ado = new PerformanceDAO();
            set = ado.GetAllPerformance();
            tabPerformance = set.Tables[0];

            BenefitDAO bd = new BenefitDAO();
            set = bd.GetAllBenefit();
            tabBenefit = set.Tables[0];
        }


        private void LoadData()
        {
            LoadBaseInfo();
            LoadStaff();
        }
        private void LoadStaff()
        {
            StaffDAO d = new StaffDAO();
            DataSet set = d.GetAllStaffSalaryInfo();
            tabStaff.Rows.Clear();
            DataRow newRow;
            foreach (DataRow r in set.Tables[0].Rows)
            {
                newRow = tabStaff.NewRow();
                newRow["PersonName"] = r["PersonName"];
                newRow["StaffId"] = r["StaffId"];
                newRow["StaffNumber"] = r["StaffNumber"];
                newRow["PostName"] = r["PostName"];
                newRow["PostSalary"] = r["PostBaseSalary"];
                newRow["PerformanceLevel"] = r["PerformanceLevel"];
                newRow["PerformanceSalary"] = 0;
                newRow["BenefitLevel"] = r["BenefitLevel"];
                newRow["BenefitSalary"] = 0;
                newRow["AttendanceSalary"] = r["AttendanceSalary"];
                newRow["SenioritySalary"] = r["SenioritySalary"];
                newRow["ReissueSalary"] = 0;
                newRow["SalaryTotal"] = 0;

                tabStaff.Rows.Add(newRow);
            }

            gridCtrl.DataSource = tabStaff;
        }

        private void repositoryItemButtonEditSave_Click(object sender, EventArgs e)
        {
            DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
            SalaryBillBean b = new SalaryBillBean();
            b.StaffNumber = r["StaffNumber"].ToString();
            //b.BillNumber = r["BillNumber"].ToString();
            try
            {
                b.StaffId = Convert.ToInt32((r["StaffId"].ToString()));
                b.PostSalary = Convert.ToInt32((r["PostSalary"].ToString()));
                b.PerformanceSalary = Convert.ToInt32((r["PerformanceSalary"].ToString()));
                b.BenefitSalary = Convert.ToInt32((r["BenefitSalary"].ToString()));
                b.AttendanceSalary = Convert.ToInt32((r["AttendanceSalary"].ToString()));
                b.SenioritySalary = Convert.ToInt32((r["SenioritySalary"].ToString()));
                b.ReissueSalary = Convert.ToInt32((r["ReissueSalary"].ToString()));
                b.SalaryTotal = Convert.ToInt32((r["SalaryTotal"].ToString()));
                b.DateBegin = dateEdit.Text;
                b.DateEnd = dateEdit.Text;
                b.BelongMonth = dateEdit.Text;

                b.InputStaffNumber = "hehe";
            }
            catch
            {
                MessageBox.Show("工资输入有误", "信息提示", MessageBoxButtons.OK);
                return;
            }
            

            if (DialogResult.OK != MessageBox.Show("是否保存修改", "信息提示", MessageBoxButtons.OKCancel))
            {
                return;
            }

            SalaryBillDAO d = new SalaryBillDAO();
            if (string.IsNullOrEmpty(b.BillNumber))
            {
                d.AddSalaryBill(b);
                r["BillNumber"] = b.BillNumber;
            }
            else
            {
                d.UpdateSalaryBill(b);
            }
        }

        #region 输入工资参数时，刷新最终工资
        private void gridViewStaff_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "PerformanceScore":
                    UpdatePerformance();
                    break;
                case "BenefitScore":
                    UpdateBenefit();
                    break;
                case "AttendanceSalary":
                case "ReissueSalary":

                    break;
                default:
                    return;
            }
            UpdateSalaryTotal();

        }

        private void UpdateSalaryTotal()
        {
            DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
            int total = 0;
            try
            {
                total += Convert.ToInt32(r["PostSalary"].ToString());
                total += Convert.ToInt32(r["PerformanceSalary"].ToString());
                total += Convert.ToInt32(r["BenefitSalary"].ToString());
                total += Convert.ToInt32(r["AttendanceSalary"].ToString());
                total += Convert.ToInt32(r["SenioritySalary"].ToString());
                total += Convert.ToInt32(r["ReissueSalary"].ToString());
            }
            catch
            {
                MessageBox.Show("工资输入有误", "信息提示", MessageBoxButtons.OK);
                return;
            }
            
            r["SalaryTotal"] = total;
        }

        private void UpdatePerformance()
        {
            DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
            string level = r["PerformanceLevel"].ToString();

            DataRow[] matches = tabPerformance.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;

            int salary = 0;
            try
            {
                int baseSalary = Convert.ToInt32(matches[0]["BaseSalary"].ToString());
                int score = Convert.ToInt32(r["PerformanceScore"].ToString());
                salary = baseSalary * score / 100;
            }
            catch
            {}

            r["PerformanceSalary"] = salary;
        }
        private void UpdateBenefit()
        {
            DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
            string level = r["BenefitLevel"].ToString();

            DataRow[] matches = tabBenefit.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;
            int salary = 0;
            try
            {
                int baseSalary = Convert.ToInt32(matches[0]["BaseSalary"].ToString());
                int score = Convert.ToInt32(r["BenefitScore"].ToString());
                salary = baseSalary * score / 100;
            }
            catch
            { }

            r["BenefitSalary"] = salary;
        }

        #endregion
    }
}
