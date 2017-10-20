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
    public class CustomerDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public int AddCustomer(CustomerBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", SqlDbType.Int),
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Phone", b.Phone),
                    para = new SqlParameter("@IdCard", b.IdCard),
                    para = new SqlParameter("@Password", b.Password),
                    para = new SqlParameter("@Sex", b.Sex),
                    para = new SqlParameter("@Email", b.Email),
                    para = new SqlParameter("@ChatId", b.ChatId),
                    para = new SqlParameter("@Address", b.Address),
                    para = new SqlParameter("@BabyName", b.Baby),
                    para = new SqlParameter("@BabyAge", b.BabyAge),
                    para = new SqlParameter("@Relation", b.Relation),
                    para = new SqlParameter("@Remark", b.Remark),
                };
                sp[0].Direction = ParameterDirection.Output;

                count = sh.RunSql("PR_Customer_Add", sp);

                b.Id = Convert.ToInt32(sp[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public int UpdateCustomer(CustomerBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Phone", b.Phone),
                    para = new SqlParameter("@IdCard", b.IdCard),
                    para = new SqlParameter("@Address", b.Address),
                    para = new SqlParameter("@Email", b.Email),
                    para = new SqlParameter("@ChatId", b.ChatId),
                    para = new SqlParameter("@Remark", b.Remark),

                    para = new SqlParameter("@BabyName", b.Baby),
                    para = new SqlParameter("@BabyAge", b.BabyAge),
                    para = new SqlParameter("@Relation", b.Relation),
                };

                count = sh.RunSql("PR_Customer_Update", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }


        public bool FindCustomer(CustomerBean b)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Phone", b.Phone),
                };
                ds = sh.GetDataSet("PR_Customer_Find", sp);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    b.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds.Tables[0].Rows.Count > 0 ;
        }


        public bool DeleteCustomer(CustomerBean b)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                };
                ds = sh.GetDataSet("PR_Customer_Delete", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds.Tables[0].Rows.Count > 0;
        }

        public DataSet GetAllCustomer()
        {
            try
            {
                ds = sh.GetDataSet("PR_Customer_GetAll", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// 查找存在报名课程状态为“正常”的客户
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllCustomerOrder()
        {
            try
            {
                ds = sh.GetDataSet("PR_Customer_FindOrder", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public DataSet GetAllCustomerOrderNormal()
        {
            try
            {
                ds = sh.GetDataSet("PR_Customer_FindOrderNormal", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
