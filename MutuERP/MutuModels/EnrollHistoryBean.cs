using System.Collections.Generic;

namespace MutuModels
{
    public class EnrollHistoryBean
    {
        private CustomerBean customer = new CustomerBean();
        private UserBean Oper = new UserBean();
        private List<LessonBean> lessList = new List<LessonBean>();
        private float priceTotal;
        private string date;
        private string remark;

        public CustomerBean Customer
        {
            get
            {
                return customer;
            }

        }

        public UserBean Oper1
        {
            get
            {
                return Oper;
            }

        }

        public List<LessonBean> LessList
        {
            get
            {
                return lessList;
            }

        }

        public float PriceTotal
        {
            get
            {
                return priceTotal;
            }

            set
            {
                priceTotal = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }
    }
}
