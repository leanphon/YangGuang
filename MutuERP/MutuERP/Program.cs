using MutuModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutuERP
{
    static class Program
    {
        //public static FrameMain mainFrame;
        public static MainForm mainForm;
        public static UserBean loginUser;
        

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginUser = new UserBean();
            loginUser.Id = 1;
            loginUser.Name = "admin";

            mainForm = new MainForm();
            Application.Run(mainForm);
            
            //Application.Run(mainFrame);
            //Application.Run(new LoginForm());
            //DataProductor.Product();
            //LoginForm login = new LoginForm();
            //if (login.ShowDialog() == DialogResult.OK)
            //{
            //    mainFrame = new FrameMain();
            //    Application.Run(mainFrame);
            //}
        }
    }
}
