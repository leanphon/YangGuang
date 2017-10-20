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
    public class SalaryBillDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数


        public int AddSalaryBill(SalaryBillBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@BillNumber", SqlDbType.VarChar, 30),
                    para = new SqlParameter("@StaffId", b.StaffId),
                    para = new SqlParameter("@StaffNumber", b.StaffNumber),
                    para = new SqlParameter("@PostSalary", b.PostSalary),
                    para = new SqlParameter("@PerformanceSalary",b.PerformanceSalary),
                    para = new SqlParameter("@BenefitSalary",b.BenefitSalary),
                    para = new SqlParameter("@AttendanceSalary", b.AttendanceSalary),
                    para = new SqlParameter("@SenioritySalary",b.SenioritySalary),
                    para = new SqlParameter("@ReissueSalary",b.ReissueSalary),
                    para = new SqlParameter("@SalaryTotal",b.SalaryTotal),
                    para = new SqlParameter("@BelongMonth", b.BelongMonth),
                    para = new SqlParameter("@DateBegin",b.DateBegin),
                    para = new SqlParameter("@DateEnd",b.DateEnd),
                    para = new SqlParameter("@InputStaffNumber",b.InputStaffNumber),

                };
                sp[0].Direction = ParameterDirection.Output;

                count = sh.RunSql("PR_SalaryBill_Add", sp);
                b.BillNumber = sp[0].Value.ToString();
            }
            catch (Exception ex)
            {
                return (int)ErrorMessage.ErrorCode.ERROR_DB_ADD_FAIL;
            }
            return count;
        }
        public int UpdateSalaryBill(SalaryBillBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@BillNumber", b.BillNumber),
                    para = new SqlParameter("@PostSalary", b.PostSalary),
                    para = new SqlParameter("@PerformanceSalary",b.PerformanceSalary),
                    para = new SqlParameter("@BenefitSalary",b.BenefitSalary),
                    para = new SqlParameter("@AttendanceSalary", b.AttendanceSalary),
                    para = new SqlParameter("@SenioritySalary",b.SenioritySalary),
                    para = new SqlParameter("@ReissueSalary",b.ReissueSalary),
                    para = new SqlParameter("@SalaryTotal",b.SalaryTotal),
                    para = new SqlParameter("@InputStaffNumber",b.InputStaffNumber),
                    
                }; 
                count = sh.RunSql("PR_SalaryBill_Update", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public DataSet GetAllSalaryBill(string condition)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@condition",condition)
                };
                ds = sh.GetDataSet("PR_SalaryBill_GetAll", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

    }
}
