using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MutuERP
{
    public partial class PasswordSetupForm : BaseForm
    {
        private string password;
        private string passwordOld;

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string PasswordOld
        {
            get
            {
                return passwordOld;
            }

            set
            {
                passwordOld = value;
            }
        }

        public PasswordSetupForm(bool modify)
        {
            InitializeComponent();
            if (modify)
            {
                textEditPasswordOld.Enabled = true;
            }
            else
            {
                textEditPasswordOld.Enabled = false;
            }
        }

        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string pwdReinput = textEditReInput.Text.Trim();
            Password = textEditPassword.Text.Trim();
            
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("密码为空", "信息提示", MessageBoxButtons.OK);
                return ;
            }
            if (Password != pwdReinput)
            {
                MessageBox.Show("两次输入的密码不一致", "信息提示", MessageBoxButtons.OK);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}