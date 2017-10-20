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
    public partial class CustomerRegisterForm : BaseForm
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

        public CustomerRegisterForm()
        {
            InitializeComponent();

            Init();

        }

        private void Init()
        {
            comboBoxEditSex.SelectedIndex = 0;
        }

        private bool CheckData()
        {
            customer = textEditCustomer.Text.Trim();
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
            idCard = textEditIdCard.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("身份证为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(passwd))
            {
                MessageBox.Show("密码为空", "信息提示", MessageBoxButtons.OK);
                return false;
            }

            address = textEditAddress.Text.Trim();
            sex = comboBoxEditSex.Text;
            chatId = textEditChatId.Text.Trim();
            email = textEditEmail.Text.Trim();
            age = 0;
            try
            {
                age = Convert.ToInt32(textEditAge.Text.Trim());
            }
            catch { }

            student = textEditStudent.Text.Trim();
            relation = textEditRelation.Text.Trim();
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
            if (f.ShowDialog() == DialogResult.OK)
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
                if (dao.AddCustomer(c) == 1)
                {
                    MessageBox.Show("注册成功", "信息提示", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            Program.mainForm.OpenLink("LessonEnrollForm", "课程报名");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearEdit(tableLayoutPanelInput);
        }

    }
}
