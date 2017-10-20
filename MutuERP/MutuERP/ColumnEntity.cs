using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyser
{
    public class ColumnEntity
    {
        protected int columnIndex;
        protected string colunName;

        public int ColumnIndex
        {
            get
            {
                return columnIndex;
            }
            set
            {
                columnIndex = value;
            }
        }
        public string ColumnNndex
        {
            get
            {
                return colunName;
            }
            set
            {
                colunName = value;
            }
        }
    }
}
