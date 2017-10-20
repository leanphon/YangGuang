using DevExpress.XtraGrid.Columns;
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
    public partial class CustomerListForm : BaseForm
    {
        private DataTable tabCustomer;
        private DataTable tabOper;

        enum OperType
        {
            ModifyStatus = 1,
            ModifyPassword,
            ModifyCustomer,
            ReturnMoney,
            SwitchAddress,
            ShowLog,
        };

        public CustomerListForm()
        {
            InitializeComponent();

            Init();
            InitColumnSelector();

            LoadData();
        }

        public override void RefreshForm()
        {
            base.RefreshForm();

            LoadData();
        }

        private void Init()
        {
            tabOper = new DataTable();
            tabOper.Columns.Add("OperId", typeof(OperType));
            tabOper.Columns.Add("OperName");

            DataRow r = tabOper.NewRow();
            r["OperId"] = OperType.ModifyStatus;
            r["OperName"] = "状态修改";
            tabOper.Rows.Add(r);
            repositoryItemComboBoxOper.Items.Add(r["OperName"].ToString());

            r = tabOper.NewRow();
            r["OperId"] = OperType.ModifyPassword;
            r["OperName"] = "密码修改";
            tabOper.Rows.Add(r);
            repositoryItemComboBoxOper.Items.Add(r["OperName"].ToString());

            r = tabOper.NewRow();
            r["OperId"] = OperType.ReturnMoney;
            r["OperName"] = "退费";
            tabOper.Rows.Add(r);
            repositoryItemComboBoxOper.Items.Add(r["OperName"].ToString());

            r = tabOper.NewRow();
            r["OperId"] = OperType.ReturnMoney;
            r["OperName"] = "调店";
            tabOper.Rows.Add(r);
            repositoryItemComboBoxOper.Items.Add(r["OperName"].ToString());

            r = tabOper.NewRow();
            r["OperId"] = OperType.ShowLog;
            r["OperName"] = "日志";
            tabOper.Rows.Add(r);
            repositoryItemComboBoxOper.Items.Add(r["OperName"].ToString());

            r = tabOper.NewRow();
            r["OperId"] = OperType.ModifyCustomer;
            r["OperName"] = "资料维护";
            tabOper.Rows.Add(r);
            repositoryItemComboBoxOper.Items.Add(r["OperName"].ToString());
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
            foreach (GridColumn c in gridView.Columns)
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
            CustomerDAO cd = new CustomerDAO();
            DataSet set = cd.GetAllCustomer();
            tabCustomer = set.Tables[0];
            gridCtrl.DataSource = tabCustomer;
        }

        private void repositoryItemButtonEditConsume_Click(object sender, EventArgs e)
        {
            LessonConsumeForm f = new LessonConsumeForm();
            if (f.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void repositoryItemButtonEditRemark_Click(object sender, EventArgs e)
        {
            MessageForm f = new MessageForm("备注信息", "");
            if (f.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void repositoryItemComboBoxOper_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
