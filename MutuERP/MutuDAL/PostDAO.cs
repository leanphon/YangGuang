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
    public class PostDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public int AddPost(PostBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Level",b.Level),
                    para = new SqlParameter("@BaseSalary",b.BaseSalary),
                };
                count = sh.RunSql("PR_Post_Add", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public int UpdatePost(PostBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Level",b.Level),
                    para = new SqlParameter("@BaseSalary",b.BaseSalary),
                };
                count = sh.RunSql("PR_Post_Update", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public int DeletePost(PostBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                };
                count = sh.RunSql("PR_Post_Delete", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }


        public DataSet GetAllPost()
        {
            try
            {
                ds = sh.GetDataSet("PR_Post_GetAll", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
