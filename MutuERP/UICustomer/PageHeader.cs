using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICustomer
{
    public partial class PageHeader : UserControl
    {
        private int pageTotal;
        private int pageCurrent;
        private int pageNew;

        public delegate void DelegatePageUpdate(object sender, EventArgs e);
        public DelegatePageUpdate PageUpdate;

        public int PageTotal
        {
            get
            {
                return pageTotal;
            }

            set
            {
                pageTotal = value;
            }
        }

        public int PageCurrent
        {
            get
            {
                return pageCurrent;
            }

            set
            {
                pageCurrent = value;
            }
        }

        public PageHeader()
        {
            InitializeComponent();
        }

        public void Reset(int total, int current)
        {
            this.PageTotal = total;
            this.PageCurrent = current;
        }
        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            pageNew = 1;
            ResponseUpdatePage(sender, e);
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            pageNew = pageNew - 1;
            if (pageNew < 1)
            {
                pageNew = 1;
            }
            ResponseUpdatePage(sender, e);
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            pageNew += 1;
            ResponseUpdatePage(sender, e);
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            PageCurrent = pageTotal;

            ResponseUpdatePage(sender, e);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            int page = 0;
            try
            {
                page = Convert.ToInt32(comboBoxEditSelect.Text);
            }
            catch
            { }
            if (page <= 0)
            {
                return;
            }
            pageNew = page;
            if (pageNew > pageTotal)
            {
                pageNew = pageTotal;
            }

            ResponseUpdatePage(sender, e);
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int page = 0;
            try
            {
                page = Convert.ToInt32(comboBoxEditSelect.Text);
            }
            catch
            { }
            if (page <= 0)
            {
                return;
            }
            pageNew = page;
            if (pageNew > pageTotal)
            {
                pageNew = pageTotal;
            }

            ResponseUpdatePage(sender, e);
        }

        private void ResponseUpdatePage(object sender, EventArgs e)
        {
            if (pageNew == PageCurrent)
            {
                return;
            }
            if (PageUpdate != null)
            {
                PageUpdate(sender, e);
            }
        }

        private void WritePageInfo()
        {
            labelControlPage.Text = pageCurrent + "/" + pageTotal;
        }
    }
}
