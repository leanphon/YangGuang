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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutuERP
{
    public partial class CustomerInfoForm : BaseForm
    {
        private DataTable tabSelect;
        private DataTable tabData;

        private int customerId;
        private string customer;
        private string idCard;
        private string phone;
        private string sex;
        private string email;
        private string chatId;
        private string address;
        private string remark;
        private string passwd;
        private int age;

        private string student;
        private int babyAge;
        private string relation;

        public CustomerInfoForm()
        {
            InitializeComponent();

            Init();

            InitColumnSelector();

            LoadData();
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

            tabData = new DataTable();
            tabData.Columns.Add("Check", typeof(bool));
            tabData.Columns.Add("Id");
            tabData.Columns.Add("Name");
            tabData.Columns.Add("Price", typeof(float));
            tabData.Columns.Add("Count", typeof(int));
            tabData.Columns.Add("PriceTotal", typeof(float));
            tabData.Columns.Add("PriceDiscount", typeof(float));
            tabData.Columns.Add("PriceReal", typeof(float));

            comboBoxSex.SelectedIndex = 0;
        }

        private void InitColumnSelector()
        {
            columnSelecetor.UpdateColumnDisplay += UpdateColumnDisplay;

            foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridView.Columns)
            {
                columnSelecetor.AddColumn(c.Caption, true);
            }
            //columnSelecetor.Reload();
        }
        private void LoadData()
        {
            LessonDAO d = new LessonDAO();
            DataSet set = d.GetAllLesson();

            DataRow newRow;
            foreach (DataRow r in set.Tables[0].Rows)
            {
                newRow = tabData.NewRow();
                newRow["Id"] = r["Id"];
                newRow["Name"] = r["Name"];
                newRow["Price"] = r["Price"];
                newRow["Count"] = 0;
                newRow["PriceDiscount"] = 0;

                tabData.Rows.Add(newRow);
            }

            gridCtrl.DataSource = tabData;
        }
        private bool CheckData()
        {
            customer = textBoxCustomer.Text.Trim();
            if (string.IsNullOrEmpty(customer))
            {
                MessageBox.Show("客户名字为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            phone = textEditPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("客户电话为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(passwd))
            {
                MessageBox.Show("密码为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            address = textBoxAddress.Text.Trim();
            sex = comboBoxSex.Text;
            chatId = textEditChatId.Text.Trim();
            email = textEditEmail.Text.Trim();
            age = 0;
            try
            {
                age = Convert.ToInt32(textEditAge.Text.Trim());
            }
            catch { }

            student = textBoxStudent.Text.Trim();
            relation = textBoxRelation.Text.Trim();
            babyAge = 0;
            try
            {
                babyAge = Convert.ToInt32(textEditBabyAge.Text.Trim());
            }
            catch { }

            return true;
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            PasswordSetupForm f = new PasswordSetupForm(false);
            if (f.DialogResult == DialogResult.OK)
            {
                passwd = f.Password;
            }
            else
            {
                passwd = "";
            }
        }

        private void buttonRemark_Click(object sender, EventArgs e)
        {
            MessageForm f = new MessageForm("备注信息");
            if (f.ShowDialog() == DialogResult.OK)
            {
                remark = f.Message.Trim();
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


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }

            CustomerBean c = new CustomerBean();

            c.Name = customer;
            c.Phone = phone;
            c.Sex = sex;
            c.IdCard = idCard;
            c.Email = email;
            c.Address = address;
            c.Remark = remark;
            c.Age = age;

            MD5 md5 = MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(passwd));
            c.Password = Convert.ToBase64String(s);

            c.Baby = student;
            c.BabyAge = age;
            c.Relation = relation;

            CustomerDAO dao = new CustomerDAO();
            if (dao.FindCustomer(c) == false)
            {
                dao.AddCustomer(c);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }

            CustomerBean c = new CustomerBean();

            c.Name = customer;
            c.Phone = phone;
            c.Sex = sex;
            c.IdCard = idCard;
            c.Email = email;
            c.Address = address;
            c.Remark = remark;
            c.Age = age;


            c.Baby = student;
            c.BabyAge = age;
            c.Relation = relation;

            CustomerDAO dao = new CustomerDAO();
            dao.UpdateCustomer(c);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        private void buttonForward_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearEdit(tableLayoutPanelInput);
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataRowView r = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
                textBoxCustomer.Text = r["Name"].ToString();
                textEditPhone.Text = r["Phone"].ToString();
                textBoxIDCard.Text = r["IdCard"].ToString();
                textBoxAddress.Text = r["Address"].ToString();
                textEditAge.Text = r["Age"].ToString();
                textEditEmail.Text = r["Email"].ToString();
                textEditChatId.Text = r["ChatId"].ToString();
                textBoxStudent.Text = r["Baby"].ToString();
                textEditBabyAge.Text = r["BabyAge"].ToString();
                textBoxRelation.Text = r["Relation"].ToString();
                //comboBoxSex.FindString(r["Sex"].ToString());
                comboBoxSex.SelectedText = r["Sex"].ToString();

            }
        }
    }
}
