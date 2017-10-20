using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutuModels
{
    static public class ErrorMessage
    {
        static DataTable errors;

        public enum ErrorCode
        {
            ERROR_OK,
            ERROR_DB_ADD_FAIL,
            ERROR_DB_UPDATE_FAIL,
            ERROR_DB_DELETE_FAIL,
            ERROR_DB_QUERY_FAIL,

        }
        private class ErrorRow
        {
            public static DataRow NewRow(DataTable t, ErrorCode code, string msg)
            {
                DataRow r = t.NewRow();
                r["ErrorId"] = code;
                r["ErrorMessage"] = msg;

                return r;
            }
        }

        public static DataTable Errors
        {
            get
            {
                if (errors == null)
                {
                    errors = new DataTable();
                    errors.Columns.Add("ErrorId");
                    errors.Columns.Add("ErrorMessage");

                    errors.Rows.Add(new object[] {
                        ErrorRow.NewRow(errors, ErrorCode.ERROR_DB_ADD_FAIL,        "添加数据库失败"),
                        ErrorRow.NewRow(errors, ErrorCode.ERROR_DB_UPDATE_FAIL,     "修改数据库失败"),
                        ErrorRow.NewRow(errors, ErrorCode.ERROR_DB_DELETE_FAIL,     "删除数据库失败"),
                        ErrorRow.NewRow(errors, ErrorCode.ERROR_DB_QUERY_FAIL,      "查询数据库失败"),
                    });

                }
                return errors;
            }

        }
    }
}
