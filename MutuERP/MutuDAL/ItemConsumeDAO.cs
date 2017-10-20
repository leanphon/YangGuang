using System;
using System.Data;
using System.Data.SqlClient;
using MutuModels;

namespace MutuDAL
{
    public class ItemConsumeDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public int AddItemConsume(ItemConsumeBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@OrderFlowSerial", b.ItemReserve.Order.FlowSerial),
                    para = new SqlParameter("@LessonId", b.ItemReserve.Lesson.Id),
                    para = new SqlParameter("@ItemTotal", b.ItemReserve.Count),
                    para = new SqlParameter("@ConsumeCount", b.ConsumeCount),
                    para = new SqlParameter("@RemainCount", b.RemainCount),
                    para = new SqlParameter("@CustomerId", b.Consumer.Id),
                    para = new SqlParameter("@TeacherId", b.Teacher.Id),
                    para = new SqlParameter("@OperatorId", b.Oper.Id),
                    para = new SqlParameter("@Remark", b.Remark),
                };
                count = sh.RunSql("PR_ItemConsume_Add", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public DataSet GetAllItemConsume(QueryConditionComsume c)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@CustomerName", c.CustomerName),
                    para = new SqlParameter("@LessonName", c.LessonName),
                    para = new SqlParameter("@TeacherName", c.TeacherName),
                    para = new SqlParameter("@DateBegin", c.DateBegin),
                    para = new SqlParameter("@DateEnd", c.DateEnd),
                };

                ds = sh.GetDataSet("PR_ItemConsume_GetAll", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public DataSet GetAllItemConsumeByCustmer(int customerId)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@CustomerId", customerId),
                };
                ds = sh.GetDataSet("PR_ItemConsume_GetAllByCustomer", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public DataSet GetAllItemConsumeByOperator(int OperatorId)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@OperatorId", OperatorId),
                };
                ds = sh.GetDataSet("PR_ItemConsume_GetAllByOperator", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public DataSet GetAllItemConsumeByTeacher(int TeacherId)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@TeacherId", TeacherId),
                };
                ds = sh.GetDataSet("PR_ItemConsume_GetAllByTeacher", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

    }
}
