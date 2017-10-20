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
    public class TeacherDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        
        public int AddTeacher(TeacherBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                    para = new SqlParameter("@Remark", ""),
                };
                count = sh.RunSql("PR_TeacherList_Add", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public int DeleteTeacher(TeacherBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                };
                count = sh.RunSql("PR_TeacherList_Delete", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public DataSet GetAllTeacher()
        {
            try
            {
                ds = sh.GetDataSet("PR_TeacherList_GetAll", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

    }
}
