using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAnalyser
{
    public class TableEntity
    {
        public TableEntity(int index, string name)
        {
            this.index = index;
            this.name = name;
        }
        protected int index;
        protected string name;
        protected List<ColumnEntity> columnList;

        public List<ColumnEntity> ColumnList
        { get; set; }
    }
}
