using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICustomer
{
    public class ComplexButton : DevExpress.XtraEditors.SimpleButton
    {
        private object dataValue;

        public object DataValue
        {
            get
            {
                return dataValue;
            }

            set
            {
                dataValue = value;
            }
        }
    }
}
