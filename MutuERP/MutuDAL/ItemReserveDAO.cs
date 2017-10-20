using System;
using System.Data;
using System.Data.SqlClient;
using MutuModels;

namespace MutuDAL
{
    public class ItemReserveDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public int AddItemLesson(ItemReserveBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@FlowSerial", b.Order.FlowSerial),
                    para = new SqlParameter("@LessonId", b.Lesson.Id),
                    para = new SqlParameter("@LessonCount", b.Count),
                    para = new SqlParameter("@PriceDiscount", b.PriceDiscount),
                    para = new SqlParameter("@PriceTotal", b.PriceTotal),
                };
                count = sh.RunSql("PR_ItemLesson_Add", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public DataSet GetAllItemLesson(string orderSerial)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@FlowSerial", orderSerial),
                };
                ds = sh.GetDataSet("PR_ItemLesson_GetAll", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public DataSet GetAllItemLessonNormal(int customerId)
        {
            try
            { 
                SqlParameter[] sp ={
                    para = new SqlParameter("@CustomerId", customerId),
                };
                ds = sh.GetDataSet("PR_ItemLessonList_Normal_GetAll", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        
    }
}
