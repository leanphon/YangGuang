using MutuModels;
using System;
using System.Data;
using System.Data.SqlClient;
using Communal;

namespace MutuDAL
{
    public class BenefitDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        public ReturnStatus AddBenefit(BenefitBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Level",b.Level),
                    para = new SqlParameter("@BaseSalary",b.BaseSalary),
                };
                count = sh.RunSql("PR_Benefit_Add", sp);
            }
            catch (Exception ex)
            {
                return ReturnStatus.ERROR_DB_ADD_FAIL;
            }
            return ReturnStatus.OK;
        }

        public ReturnStatus UpdateBenefit(BenefitBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id",b.Id),
                    para = new SqlParameter("@Level",b.Level),
                    para = new SqlParameter("@BaseSalary",b.BaseSalary),
                };
                count = sh.RunSql("PR_Benefit_Update", sp);
            }
            catch (Exception ex)
            {
                return ReturnStatus.ERROR_DB_UPDATE_FAIL;
            }

            return ReturnStatus.OK;
        }

        public ReturnStatus DeleteBenefit(BenefitBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id",b.Id),
                };
                count = sh.RunSql("PR_Benefit_Delete", sp);
            }
            catch (Exception ex)
            {
                return ReturnStatus.ERROR_DB_DELETE_FAIL;
            }

            return ReturnStatus.OK;
        }

        public DataSet GetAllBenefit()
        {
            try
            {
                ds = sh.GetDataSet("PR_Benefit_GetAll", null);
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }

    }
}
