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
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            textEditName.Text = "admin";

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = textEditName.Text;
            string pwd = textEditPassword.Text;

            UserBean u = new UserBean();
            u.Name = name;
            Program.loginUser = u;

            if (name == "admin")
            {
                DialogResult = DialogResult.OK;
                u.Role.Id = 1;
            }
            else if (name == "xs")
            {
                u.Role.Id = 2;
                DialogResult = DialogResult.OK;
            }
            else
            {
                return;
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
