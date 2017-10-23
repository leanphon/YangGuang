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
    public partial class MainMenuForm : BaseForm
    {
        public MainMenuForm()
        {
            InitializeComponent();

            if (Program.loginUser.Role.Id > 1)
            {
                buttonPolicy.Enabled = false;
                buttonSetup.Enabled = false;
            }
        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            //Program.mainFrame.LoadFrame_Enroll();
        }

        private void buttonLesson_Click(object sender, EventArgs e)
        {
            //Program.mainFrame.LoadFrame_Lesson();
        }

        private void buttonPolicy_Click(object sender, EventArgs e)
        {
            //Program.mainFrame.LoadFrame_Policy();
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            //Program.mainFrame.LoadFrame_Setup();
        }
    }
}
