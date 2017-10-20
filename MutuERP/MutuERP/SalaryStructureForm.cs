using DevExpress.XtraEditors;
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
    public partial class SalaryStructureForm : BaseForm
    {
        private DataTable tabPost;
        private DataTable tabPerformance;
        private DataTable tabBenefit;

        public SalaryStructureForm()
        {
            InitializeComponent();

            Init();

            LoadData();
        }
        
        private void Init()
        {
        }

        public override void RefreshForm()
        {
            base.RefreshForm();

            LoadData();
        }

        private void LoadBaseInfo()
        {
            PostDAO d = new PostDAO();
            DataSet set = d.GetAllPost();
            tabPost = set.Tables[0];
            repositoryItemLookUpEditPost.DataSource = tabPost;

            PerformanceDAO ado = new PerformanceDAO();
            set = ado.GetAllPerformance();
            tabPerformance = set.Tables[0];
            repositoryItemLookUpEditPerformance.DataSource = tabPerformance;

            BenefitDAO bd = new BenefitDAO();
            set = bd.GetAllBenefit();
            tabBenefit = set.Tables[0];
            repositoryItemLookUpEditBenefit.DataSource = tabBenefit;

            //repositoryItemComboBoxPost.Items.Clear();
            //PostDAO d = new PostDAO();
            //DataSet set = d.GetAllPost();
            //tabPost = set.Tables[0];
            //foreach (DataRow r in tabPost.Rows)
            //{
            //    repositoryItemComboBoxPost.Items.Add(r["Level"].ToString());
            //}

            //repositoryItemComboBoxPerformance.Items.Clear();
            //PerformanceDAO ado = new PerformanceDAO();
            //set = ado.GetAllPerformance();
            //tabPerformance = set.Tables[0];
            //foreach (DataRow r in tabPerformance.Rows)
            //{
            //    repositoryItemComboBoxPerformance.Items.Add(r["Level"].ToString());
            //}
            //repositoryItemComboBoxBenefit.Items.Clear();
            //BenefitDAO bd = new BenefitDAO();
            //set = bd.GetAllBenefit();
            //tabBenefit = set.Tables[0];
            //foreach (DataRow r in tabBenefit.Rows)
            //{
            //    repositoryItemComboBoxBenefit.Items.Add(r["Level"].ToString());
            //}
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

            gridCtrl.DataSource = set.Tables[0];
        }

        private void repositoryItemButtonEditSave_Click(object sender, EventArgs e)
        {
            DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
            StaffBean b = new StaffBean();
            try
            {
                b.Id = Convert.ToInt32(r["StaffId"].ToString());
            }
            catch
            {
                MessageBox.Show("出现错误", "信息提示", MessageBoxButtons.OK);
                return;
            }

            
            b.StaffNumber = r["StaffNumber"].ToString();

            string level = r["PostLevel"].ToString();
            DataRow[] matches = tabPost.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;
            try
            {
                b.Post.Id = Convert.ToInt32((matches[0]["Id"].ToString()));
            }
            catch
            {
                MessageBox.Show("请选择岗位层级", "信息提示", MessageBoxButtons.OK);
                return;
            }
            

            level = r["PerformanceLevel"].ToString();
            matches = tabPerformance.Select("Level='" + level + "'");
            if (matches.Length == 0)
            {
                MessageBox.Show("请选择绩效层级", "信息提示", MessageBoxButtons.OK);
                return;
            }
            try
            {
                b.Performance.Id = Convert.ToInt32((matches[0]["Id"].ToString()));
            }
            catch
            {
                MessageBox.Show("请选择绩效层级", "信息提示", MessageBoxButtons.OK);
                return;
            }

            level = r["BenefitLevel"].ToString();
            matches = tabBenefit.Select("Level='" + level + "'");
            if (matches.Length == 0)
            {
                MessageBox.Show("请选择效益层级", "信息提示", MessageBoxButtons.OK);
                return;
            }
            try
            {
                b.Benefit.Id = Convert.ToInt32((matches[0]["Id"].ToString()));
            }
            catch
            {
                MessageBox.Show("请选择效益层级", "信息提示", MessageBoxButtons.OK);
                return;
            }
            b.AttendanceSalary = 0;
            b.SenioritySalary = 0;
            try
            {
                b.AttendanceSalary = Convert.ToInt32((r["AttendanceSalary"].ToString()));
                b.SenioritySalary = Convert.ToInt32((r["SenioritySalary"].ToString()));
            }
            catch {}

            if (DialogResult.OK != MessageBox.Show("是否保存修改", "信息提示", MessageBoxButtons.OKCancel))
            {
                return;
            }

            StaffDAO d = new StaffDAO();
            d.UpdateStaffSalary(b);
        }

        #region 级联更新岗位、绩效、效益
        private void gridViewStaff_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "PostLevel")
            //{
            //    UpdatePost();
            //}
            //else if (e.Column.FieldName == "PerformanceLevel")
            //{
            //    UpdatePerformance();
            //}
            //else if (e.Column.FieldName == "BenefitLevel")
            //{
            //    UpdateBenefit();
            //}

        }

        private void UpdatePost()
        {
            DataRow r = (DataRow)gridView.GetFocusedDataRow();

            string level = r["PostLevel"].ToString();

            DataRow[] matches = tabPost.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;
            r["PostName"] = matches[0]["Name"];
            r["PostBaseSalary"] = matches[0]["BaseSalary"];


            gridView.RefreshData();
        }
        private void UpdatePerformance()
        {
            DataRow r = (DataRow)gridView.GetFocusedDataRow();

            string level = r["PerformanceLevel"].ToString();

            DataRow[] matches = tabPerformance.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;
            r["PerformanceBaseSalary"] = matches[0]["BaseSalary"];
        }
        private void UpdateBenefit()
        {
            DataRow r = (DataRow)gridView.GetFocusedDataRow();

            string level = r["BenefitLevel"].ToString();

            DataRow[] matches = tabBenefit.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;
            r["BenefitBaseSalary"] = matches[0]["BaseSalary"];
        }


        private void repositoryItemLookUpEditPost_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit le = sender as LookUpEdit;
            string level = le.EditValue.ToString();

            DataRow[] matches = tabPost.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;

            gridView.SetFocusedRowCellValue("PostName", matches[0]["Name"]);
            gridView.SetFocusedRowCellValue("PostBaseSalary", matches[0]["BaseSalary"]);

            //gridView.RefreshData();
        }
        private void repositoryItemLookUpEditPerformance_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit le = sender as LookUpEdit;
            string level = le.EditValue.ToString();

            DataRow[] matches = tabPerformance.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;

            gridView.SetFocusedRowCellValue("PerformanceBaseSalary", matches[0]["BaseSalary"]);

        }
        private void repositoryItemLookUpEditBenefit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit le = sender as LookUpEdit;
            string level = le.EditValue.ToString();

            DataRow[] matches = tabBenefit.Select("Level='" + level + "'");
            if (matches.Length == 0)
                return;

            gridView.SetFocusedRowCellValue("BenefitBaseSalary", matches[0]["BaseSalary"]);
        }
        #endregion
    }
}
