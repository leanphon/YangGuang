using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutuERP
{
    public class BaseForm : DevExpress.XtraEditors.XtraForm
    {

        public virtual void RefreshForm()
        {

        }

        protected void ClearEdit(Control c)
        {
            foreach (Control sub in c.Controls)
            {
                if (sub.GetType() == typeof(Button)
                    || sub.GetType() == typeof(SimpleButton)
                    || sub.GetType().IsSubclassOf(typeof(Button))
                    || sub.GetType().IsSubclassOf(typeof(SimpleButton))
                    || sub.GetType() == typeof(Label)
                    || sub.GetType() == typeof(LabelControl)
                    || sub.GetType().IsSubclassOf(typeof(Label))
                    || sub.GetType().IsSubclassOf(typeof(LabelControl))
                    )
                {
                    continue;
                }
                sub.Text = "";
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 338);
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
    }
}
