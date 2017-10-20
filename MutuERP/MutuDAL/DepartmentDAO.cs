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
    public class DepartmentDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public int AddDepartment(DepartmentBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Code",b.Code),
                    para = new SqlParameter("@ParentId",b.ParentId),
                };
                count = sh.RunSql("PR_Department_Add", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public int UpdateDepartment(DepartmentBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Code",b.Code),
                    para = new SqlParameter("@ParentId",b.ParentId),
                };
                count = sh.RunSql("PR_Department_Update", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public DataSet GetAllDepartment()
        {
            try
            {
                ds = sh.GetDataSet("PR_Department_GetAll", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public int DeleteDepartment(DepartmentBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                };
                count = sh.RunSql("PR_Department_Delete", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
    }
}
