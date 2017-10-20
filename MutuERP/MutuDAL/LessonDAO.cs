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
    public class LessonDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public int AddLesson(LessonBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Price", b.Price),
                    para = new SqlParameter("@TimeLength", b.TimeLength),
                    para = new SqlParameter("@Description", b.Description),

                };
                count = sh.RunSql("PR_Lesson_Add", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public int UpdateLesson(LessonBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Price", b.Price),
                    para = new SqlParameter("@TimeLength", b.TimeLength),
                    para = new SqlParameter("@Description", b.Description),

                };
                count = sh.RunSql("PR_Lesson_Add", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public int DeleteLesson(LessonBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),

                };
                count = sh.RunSql("PR_Lesson_Delete", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public DataSet GetAllLesson()
        {
            try
            {
                ds = sh.GetDataSet("PR_Lesson_GetAll", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
