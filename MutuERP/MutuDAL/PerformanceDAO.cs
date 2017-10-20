using MutuModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutuDAL
{
    public class PerformanceDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public int AddPerformance(PerformanceBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Level",b.Level),
                    para = new SqlParameter("@BaseSalary",b.BaseSalary),
                };
                count = sh.RunSql("PR_Performance_Add", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public int UpdatePerformance(PerformanceBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id",b.Id),
                    para = new SqlParameter("@Level",b.Level),
                    para = new SqlParameter("@BaseSalary",b.BaseSalary),
                };
                count = sh.RunSql("PR_Performance_Update", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public int DeletePerformance(PerformanceBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id",b.Id),
                };
                count = sh.RunSql("PR_Performance_Delete", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

        public DataSet GetAllPerformance()
        {
            try
            {
                ds = sh.GetDataSet("PR_Performance_GetAll", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
