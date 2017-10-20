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
    public partial class MessageForm : BaseForm
    {
        private string message;

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public MessageForm(string title)
        {
            InitializeComponent();
            this.Text = title;
        }
        public MessageForm(string title, string msgShow)
        {
            InitializeComponent();

            this.Text = title;
            message = msgShow;
            memoEditMessage.Enabled = false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            message = memoEditMessage.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
