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
    public partial class LessonConsumeConfirmForm : BaseForm
    {
        public LessonConsumeConfirmForm(CustomerBean b, DataTable tabSelect)
        {
            InitializeComponent();

            gridCtrl.DataSource = tabSelect;

            textEditCustomer.Text = b.Name;
            textEditPhone.Text = b.Phone;
            textEditIdCard.Text = b.IdCard;
        }


        private void simpleButtonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
