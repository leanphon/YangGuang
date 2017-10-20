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
    public partial class DataViewer : Form
    {

        protected List<TableEntity> tableList;
        protected DataTable tabSource;
        public List<TableEntity> TableList
        {
            get; set;
        }

        public DataViewer()
        {
            tabSource = new DataTable();
            InitializeComponent();
            FillComboBoxTable();
        }

        public void FillComboBoxTable()
        {
            try
            {
                string queryString = "select TableIndex,TableName from TableList";
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "server=localhost;database=MuTu;uid=sa;pwd=123456";
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBoxTableName.DisplayMember = "TableName";
                comboBoxTableName.ValueMember = "TableIndex";
                comboBoxTableName.DataSource = dt;
                //foreach (DataRow r in dt.Rows)
                //{
                //    //TableList.Add(new TableEntity((int)r["TableIndex"], r["TableName"].ToString()));
                //    comboBoxTableName.Items.Add(r["TableName"].ToString());
                //}

                sqlCon.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void FillDataGridHeader(int tableIndex)
        {
            try
            {
                string queryString = "select ColumnName from TableColumns where TableIndex=" + tableIndex;
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "server=localhost;database=MuTu;uid=sa;pwd=123456";
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    tabSource.Columns.Add(r["ColumnName"].ToString());
                    //dataGridView.Columns.Add(r["ColumnName"].ToString(), r["ColumnName"].ToString());
                }

                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void FillDataGridItem(int tableIndex)
        {
            int index = -1;
            int rowIndex = 0;
            int colIndex = 0;
            DataRow dr = null;
            try
            {
                string queryString = "select RowIndex,ColumnIndex,CellValue from TableCells where TableIndex=" + tableIndex + " order by RowIndex asc, ColumnIndex asc";
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "server=localhost;database=MuTu;uid=sa;pwd=123456";
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    rowIndex = (int)r["RowIndex"];
                    colIndex = (int)r["ColumnIndex"];
                    if (index != rowIndex)
                    {
                        dr = tabSource.NewRow();
                        tabSource.Rows.Add(dr);
                        index = rowIndex;
                    }
                    dr[colIndex-1] = r["CellValue"];
                }

                tabSource.AcceptChanges();
                dataGridView.DataSource = tabSource;

                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void FillDataGrid(int tableIndex)
        {
            tabSource.Clear();
            tabSource.Columns.Clear();

            FillDataGridHeader(tableIndex);
            FillDataGridItem(tableIndex);
        }

        private void comboBoxTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tableIndex = (int)comboBoxTableName.SelectedValue;

            FillDataGrid(tableIndex);
            
        }
    }
}
