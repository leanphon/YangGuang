using DevExpress.XtraGrid.Views.Grid;
using MutuDAL;
using MutuModels;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using UICustomer;

namespace MutuERP
{
    public partial class LessonConsumeForm : BaseForm
    {
        private DataTable tabSelect;
        private DataTable tabItemLesson;
        private DataTable tabCustomer;
        private DataTable tabTeacher;
        private int customerId = -1;

        public LessonConsumeForm()
        {
            InitializeComponent();

            Init();

            LoadEnrollCustomer();
            LoadTeacher();
        }
        
        private void Init()
        {
            tabSelect = new DataTable();
            tabSelect.Columns.Add("FlowSerial");
            tabSelect.Columns.Add("LessonId");
            tabSelect.Columns.Add("LessonName");
            tabSelect.Columns.Add("ItemTotal");
            tabSelect.Columns.Add("LessonConsumed");
            tabSelect.Columns.Add("CurrentConsume");
            tabSelect.Columns.Add("Remain");
            tabSelect.Columns.Add("TeacherId");
            tabSelect.Columns.Add("TeacherName");

            gridCtrl.DataSource = tabSelect;
        }

        private void LoadEnrollCustomer()
        {
            CustomerDAO cd = new CustomerDAO();
            DataSet set = cd.GetAllCustomerOrder();
            tabCustomer = set.Tables[0];
            lookUpEdit.Properties.DataSource = tabCustomer;
        }

        private void LoadTeacher()
        {
            StaffDAO cd = new StaffDAO();
            DataSet set = cd.GetAllStaff();
            tabTeacher = set.Tables[0];
            repositoryItemLookUpEditTeacher.DataSource = tabTeacher;
        }


        private void LoadEnrollLesson(int customerId)
        {
            ItemReserveDAO cd = new ItemReserveDAO();
            DataSet set = cd.GetAllItemLessonNormal(customerId);
            tabItemLesson = set.Tables[0];
            foreach (DataRow r in tabItemLesson.Rows)
            {
                ComplexButton b = new ComplexButton();
                b.Location = new System.Drawing.Point(3, 3);
                b.Name = "complexButtonLesson" + r["LessonId"].ToString();
                b.Size = new System.Drawing.Size(107, 48);
                b.TabIndex = 0;
                b.Text = r["LessonName"].ToString();
                b.DataValue = r;
                b.Click += new System.EventHandler(complexButtonLesson_Click);

                flowLayoutPanelLesson.Controls.Add(b);
            }
            //tabCustomer = set.Tables[0];
            //lookUpEdit.Properties.DataSource = tabCustomer;
        }

        private bool CheckData()
        {
            if (tabSelect.Rows.Count == 0)
            {
                MessageBox.Show("客户名字为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            foreach (DataRow r in tabSelect.Rows)
            {
                try
                {
                    Convert.ToInt32(r["TeacherId"]);
                }
                catch
                {
                    MessageBox.Show("请选择授课老师", "信息提示", MessageBoxButtons.OK);
                    return false;
                }
            }
            
            return true;
        }
        private void SaveConsume()
        {
            ItemConsumeDAO d = new ItemConsumeDAO();
            ItemConsumeBean b = new ItemConsumeBean();
            b.Consumer.Id = customerId;

            foreach(DataRow r in tabSelect.Rows)
            {
                b.ItemReserve.Order.FlowSerial = r["FlowSerial"].ToString();
                b.ItemReserve.Lesson.Id = Convert.ToInt32(r["LessonId"].ToString());
                b.Consumer.Id = customerId;
                b.RemainCount = Convert.ToInt32(r["Remain"].ToString());
                b.ConsumeCount = Convert.ToInt32(r["CurrentConsume"].ToString());
                b.Teacher.Id = Convert.ToInt32(r["TeacherId"].ToString());
                b.Oper.Id = Program.loginUser.Id;
                b.Remark = "";

                d.AddItemConsume(b);
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

            tabSelect.Rows.Clear();
            LoadEnrollLesson(customerId);
        }

        
        
        private void repositoryItemLookUpEditTeacher_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = sender as DevExpress.XtraEditors.LookUpEdit;
            if (le == null)
            {
                return;
            }
            DataRow r = gridView.GetFocusedDataRow();
            if (r == null)
            {
                return;
            }
            DataRowView rv = (DataRowView)le.GetSelectedDataRow();
            if (rv == null)
            {
                return;
            }

            r["TeacherId"] = rv["Id"];
            r["TeacherName"] = rv["Name"];
        }
        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
            if (r == null)
            {
                return;
            }
            string name = "complexButtonLesson" + r["LessonId"].ToString();
            Control[] matchs = flowLayoutPanelLesson.Controls.Find(name, true);
            if (matchs.Length > 0)
            {
                matchs[0].Enabled = true;
            }
            tabSelect.Rows.Remove(r.Row);

        }

        private void simpleButtonSubmit_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }
            CustomerBean b = new CustomerBean();
            b.Name = textEditCustomer.Text;
            b.Phone = textEditPhone.Text;
            b.IdCard = textEditIdCard.Text;
            LessonConsumeConfirmForm f = new LessonConsumeConfirmForm(b, tabSelect);
            if (f.ShowDialog() == DialogResult.OK)
            {
                SaveConsume();
            }
        }
        private void complexButtonLesson_Click(object sender, EventArgs e)
        {
            ComplexButton b = sender as ComplexButton;
            if (b == null)
            {
                return;
            }
            DataRow r = b.DataValue as DataRow;
            if (r == null)
            {
                return;
            }
            DataRow newRow = tabSelect.NewRow();
            tabSelect.Rows.Add(newRow);

            newRow["FlowSerial"] = r["FlowSerial"];
            newRow["LessonId"] = r["LessonId"];
            newRow["LessonName"] = r["LessonName"];
            newRow["ItemTotal"] = r["ItemTotal"];
            newRow["CurrentConsume"] = 1;
            int remain = 0;
            int consumed = 0;
            try
            {
                remain = Convert.ToInt32(r["RemainCount"].ToString());
                consumed = Convert.ToInt32(r["ItemTotal"].ToString()) - remain;
            }
            catch { }

            // 每次消费一个课时
            newRow["Remain"] = remain - 1;
            newRow["LessonConsumed"] = consumed;

            b.Enabled = false;
        }

    }
}
