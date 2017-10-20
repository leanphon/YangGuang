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
    public class StaffDAO
    {
        SqlHelper sh = new SqlHelper();
        DataSet ds;
        private SqlParameter para; //参数

        
        public int AddStaff(StaffBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", SqlDbType.Int),
                    para = new SqlParameter("@StaffNumber", b.StaffNumber),
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Phone", b.Phone),
                    para = new SqlParameter("@IdCard",b.IdCard),
                    para = new SqlParameter("@Sex",b.Sex),
                    para = new SqlParameter("@Birthday",b.Birthday),
                    para = new SqlParameter("@BankCard",b.BankCard),
                    para = new SqlParameter("@DepartmentId",b.Department.Id),
                    para = new SqlParameter("@Status",b.Status),
                    para = new SqlParameter("@DateEntry",b.DateEntry),

                };
                sp[0].Direction = ParameterDirection.Output;
                count = sh.RunSql("PR_Staff_Add", sp);
                b.Id = Convert.ToInt32(sp[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public int UpdateStaff(StaffBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                    para = new SqlParameter("@StaffNumber", b.StaffNumber),
                    para = new SqlParameter("@Name", b.Name),
                    para = new SqlParameter("@Phone", b.Phone),
                    para = new SqlParameter("@IdCard",b.IdCard),
                    para = new SqlParameter("@Sex",b.Sex),
                    para = new SqlParameter("@Birthday",b.Birthday),
                    para = new SqlParameter("@BankCard",b.BankCard),
                    para = new SqlParameter("@DepartmentId",b.BankCard),
                    para = new SqlParameter("@Status",b.BankCard),
                    para = new SqlParameter("@DateEntry",b.DateEntry),
                    para = new SqlParameter("@DateFormal",b.DateFormal),
                    para = new SqlParameter("@DateLeave",b.DateLeave),

                };
                count = sh.RunSql("PR_Staff_Update", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public int UpdateStaffSalary(StaffBean b)
        {
            int count = 0;
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@Id", b.Id),
                    para = new SqlParameter("@PostId", b.Post.Id),
                    para = new SqlParameter("@PerformanceId",b.Performance.Id),
                    para = new SqlParameter("@BenefitId",b.Benefit.Id),
                    para = new SqlParameter("@AttendanceSalary", b.AttendanceSalary),
                    para = new SqlParameter("@SenioritySalary",b.SenioritySalary),
                };
                count = sh.RunSql("PR_Staff_UpdateSalary", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public bool IsExistStaff(StaffBean b)
        {
            try
            {
                SqlParameter[] sp ={
                    para = new SqlParameter("@StaffNumber", b.StaffNumber),

                };
                ds = sh.GetDataSet("PR_Staff_IsExist", sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds.Tables[0].Rows.Count != 0;
        }

        public DataSet GetAllStaff()
        {
            try
            {
                ds = sh.GetDataSet("PR_Staff_GetAll", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public DataSet GetAllStaffSalaryInfo()
        {
            try
            {
                ds = sh.GetDataSet("PR_Staff_GetSalaryInfo", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public DataSet GetAllStaffGroupByDepartment()
        {
            try
            {
                ds = sh.GetDataSet("PR_StaffList_GetAll_Department", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        
    }
}
