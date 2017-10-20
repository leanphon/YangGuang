using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalyser
{
    public partial class SaleHistoryForm : Form
    {
        private DataTable dtTradeHistory;
        public SaleHistoryForm()
        {
            InitializeComponent();

            dtTradeHistory = new DataTable();

            InitData();
        }

        public void InitData()
        {
            try
            {
                string queryString = "select * from MaterialHistoryView";
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "server=localhost;database=MutuERP;uid=sa;pwd=123456";
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlCon);
                adapter.Fill(dtTradeHistory);

                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            gridControlTrade.DataSource = dtTradeHistory;
        }
    }
}
