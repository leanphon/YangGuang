using DevExpress.XtraGrid.Views.Grid;
using MutuDAL;
using MutuModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutuERP
{
    public partial class LessonEnrollForm : BaseForm
    {
        private DataTable tabSelect;
        private DataTable tabLesson;
        private DataTable tabCustomer;
        private int customerId = -1;

        public LessonEnrollForm()
        {
            InitializeComponent();

            Init();

            LoadLesson();
            LoadCustomer();
        }
        
        private void Init()
        {
            tabSelect = new DataTable();
            tabSelect.Columns.Add("Check", typeof(bool));
            tabSelect.Columns.Add("Id");
            tabSelect.Columns.Add("Name");
            tabSelect.Columns.Add("Price", typeof(float));
            tabSelect.Columns.Add("Count", typeof(int));
            tabSelect.Columns.Add("PriceTotal", typeof(float));
            tabSelect.Columns.Add("PriceDiscount", typeof(float));
            tabSelect.Columns.Add("PriceReal", typeof(float));

            tabLesson = new DataTable();
            tabLesson.Columns.Add("Check", typeof(bool));
            tabLesson.Columns.Add("Id");
            tabLesson.Columns.Add("Name");
            tabLesson.Columns.Add("Price", typeof(float));
            tabLesson.Columns.Add("Count", typeof(int));
            tabLesson.Columns.Add("PriceTotal", typeof(float));
            tabLesson.Columns.Add("PriceDiscount", typeof(float));
            tabLesson.Columns.Add("PriceReal", typeof(float));

        }

        public override void RefreshForm()
        {
            base.RefreshForm();

            LoadCustomer();
        }
        private void LoadLesson()
        {
            LessonDAO d = new LessonDAO();
            DataSet set = d.GetAllLesson();

            DataRow newRow;
            foreach (DataRow r in set.Tables[0].Rows)
            {
                newRow = tabLesson.NewRow(); 
                newRow["Id"] = r["Id"];
                newRow["Name"] = r["Name"];
                newRow["Price"] = r["Price"];
                newRow["Count"] = 0;
                newRow["PriceDiscount"] = 0;

                tabLesson.Rows.Add(newRow);
            }

            gridControl.DataSource = tabLesson;

            CustomerDAO cd = new CustomerDAO();
            set = cd.GetAllCustomer();
            lookUpEdit.Properties.DataSource = set.Tables[0];

        }
        private void LoadCustomer()
        {
            CustomerDAO cd = new CustomerDAO();
            DataSet set = cd.GetAllCustomer();
            tabCustomer = set.Tables[0];
            lookUpEdit.Properties.DataSource = tabCustomer;

        }

        private bool CheckData()
        {
            if (customerId == -1)
                return false;

            return true;
        }

        private void SaveEnroll()
        {
            OrderBean o = new OrderBean();
            ItemReserveBean item;
            float discount = 0;
            float total = 0;
            CustomerBean c = new CustomerBean();
            c.Id = customerId;

            foreach(DataRow varRow in tabSelect.Rows)
            {
                item = new ItemReserveBean();
                item.Count = Convert.ToInt32(varRow["Count"].ToString());
                item.Lesson.Id = Convert.ToInt32(varRow["Id"].ToString());
                item.PriceDiscount = (float)Convert.ToDouble(varRow["PriceDiscount"].ToString());
                item.PriceTotal = (float)Convert.ToDouble(varRow["PriceReal"].ToString());
                item.Order = o;
                o.Items.Add(item);

                discount += item.PriceDiscount;
                total += item.PriceTotal;
            }
            o.PriceTotal = total;
            o.PriceDiscount = discount;
            o.Customer = c;

            OrderDAO d = new OrderDAO();
            d.AddOrder(o);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }
            tabSelect.Rows.Clear();
            DataRow newRow;
            foreach (DataRow r in tabLesson.Rows)
            {
                bool check = false;
                try
                {
                    check = Convert.ToBoolean(r["Check"]);
                }
                catch { }
                int count = 0;
                try
                {
                    count = Convert.ToInt32(r["Count"]);
                }
                catch { }
                if (check == true && count > 0)
                {

                    newRow = tabSelect.NewRow();
                    tabSelect.Rows.Add(newRow);
                    newRow["Check"] = r["Check"];
                    newRow["Id"] = r["Id"];
                    newRow["Name"] = r["Name"];
                    newRow["Price"] = r["Price"];
                    newRow["Count"] = r["Count"];
                    newRow["PriceTotal"] = r["PriceTotal"];
                    newRow["PriceDiscount"] = r["PriceDiscount"];
                    newRow["PriceReal"] = r["PriceReal"];

                }
            }
            LessonEnrollConfirmForm f = new LessonEnrollConfirmForm();
            f.SetTableSelected(tabSelect);
            f.RefreshForm();
            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            SaveEnroll();
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);

            switch (e.Column.FieldName)
            {
                case "Count":
                    {
                        float price = 0;
                        int count = 0;
                        int discount = 0;
                        try
                        {
                            count = Convert.ToInt32(r["Count"].ToString());
                        }
                        catch { }
                        try
                        {
                            price = Convert.ToInt32(r["Price"].ToString());
                        }
                        catch { }
                        try
                        {
                            discount = Convert.ToInt32(r["PriceDiscount"].ToString());
                        }
                        catch { }
                        if (discount < 0)
                        {
                            discount = 0;
                        }
                        float sum = price * count;
                        r["PriceTotal"] = sum;
                        r["PriceReal"] = sum - discount;
                    }
                    break;
                case "PriceDiscount":
                    {
                        int sum = 0;
                        try
                        {
                            sum = Convert.ToInt32(r["PriceTotal"].ToString());
                        }
                        catch { }

                        int discount = 0;
                        try
                        {
                            discount = Convert.ToInt32(r["PriceDiscount"].ToString());
                        }
                        catch { }

                        if (discount < 0)
                        {
                            discount = 0;
                        }
                        if (discount > sum)
                        {
                            discount = sum;
                            r["PriceDiscount"] = discount;
                        }
                        r["PriceReal"] = sum - discount;
                    }
                    break;
                default:
                    return;
            }
        }

        private void repositoryItemCheckEditCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckState check = (sender as DevExpress.XtraEditors.CheckEdit).CheckState;
            DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
            if (r == null)
            {
                return;
            }
            if (check == CheckState.Checked)
            {
                r["Check"] = true;
            }
        }


        private void lookUpEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            object item = lookUpEdit.EditValue;
            if (item == null)
            {
                return;
            }
            customerId = (int)item;

            DataRowView r = (DataRowView)lookUpEdit.GetSelectedDataRow();
            textEditCustomer.Text = r["Name"].ToString();
            textEditPhone.Text = r["Phone"].ToString();
            textEditIdCard.Text = r["IdCard"].ToString();

        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            textEditCustomer.Text = "";
            textEditPhone.Text = "";
            textEditIdCard.Text = "";
            lookUpEdit.Text = "";
        }

        private void simpleButtonRemark_Click(object sender, EventArgs e)
        {

        }
    }
}
