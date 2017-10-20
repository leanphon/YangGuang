using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutuERP
{
    public static class DataProductor
    {
        public static DataTable tabLesson = new DataTable();
        public static DataTable tabCustomer = new DataTable();
        public static DataTable tabEnroll = new DataTable();
        public static DataTable tabOrder = new DataTable();

        public static void Product()
        {
            DataRow r;

            // 
            tabLesson.Columns.Add("Check", typeof(bool));
            tabLesson.Columns.Add("Id");
            tabLesson.Columns.Add("Name");
            tabLesson.Columns.Add("Price", typeof(float));
            tabLesson.Columns.Add("Count", typeof(int));
            tabLesson.Columns.Add("PriceTotal", typeof(float));
            tabLesson.Columns.Add("PriceDiscount", typeof(float));
            tabLesson.Columns.Add("PriceReal", typeof(float));

            r = tabLesson.NewRow();
            tabLesson.Rows.Add(r);
            r["Id"] = 1;
            r["Name"] = "英语口语";
            r["Price"] = 150;
            r = tabLesson.NewRow();
            tabLesson.Rows.Add(r);
            r["Id"] = 2;
            r["Name"] = "美术";
            r["Price"] = 120;
            r = tabLesson.NewRow();
            tabLesson.Rows.Add(r);
            r["Id"] = 3;
            r["Name"] = "音乐";
            r["Price"] = 120;
            r = tabLesson.NewRow();
            tabLesson.Rows.Add(r);
            r["Id"] = 4;
            r["Name"] = "数学";
            r["Price"] = 120;

            tabCustomer.Columns.Add("Id");
            tabCustomer.Columns.Add("Name");
            tabCustomer.Columns.Add("Address");
            tabCustomer.Columns.Add("Phone");
            tabCustomer.Columns.Add("Password");
            tabCustomer.Columns.Add("Student");
            tabCustomer.Columns.Add("StudentAge");
            tabCustomer.Columns.Add("Relation");

            tabOrder.Columns.Add("FlowSerial");
            tabOrder.Columns.Add("Date");
            tabOrder.Columns.Add("PriceTotal", typeof(float));
            tabOrder.Columns.Add("CustomerId");
            r = tabOrder.NewRow();
            tabOrder.Rows.Add(r);
            r["FlowSerial"] = "201703210001";
            r["Date"] = "2017-03-21 10:02:31";
            r["PriceTotal"] = 350;
            r["CustomerId"] = 1;
            r = tabOrder.NewRow();
            tabOrder.Rows.Add(r);
            r["FlowSerial"] = "201708210006";
            r["Date"] = "2017-08-21 10:02:31";
            r["PriceTotal"] = 1403;
            r["CustomerId"] = 2;


        }
    }
}
