using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MutuModels;

namespace MutuDAL
{
    public class OrderDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public int AddOrder(OrderBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@FlowSerial", SqlDbType.VarChar, 30),
                    para = new SqlParameter("@PriceTotal", b.PriceTotal),
                    para = new SqlParameter("@CustomerId", b.Customer.Id),
                };
                sp[0].Direction = ParameterDirection.Output;
                count = sh.RunSql("PR_Order_Add", sp);

                b.FlowSerial = sp[0].Value.ToString();

                ItemReserveDAO d = new ItemReserveDAO();
                foreach (ItemReserveBean lesson in b.Items)
                {
                    d.AddItemLesson(lesson);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public DataSet GetAllOrder()
        {
            try
            {
                ds = sh.GetDataSet("PR_Order_GetAll", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
