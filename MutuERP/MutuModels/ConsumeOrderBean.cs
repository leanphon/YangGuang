using System.Collections.Generic;
namespace MutuModels
{
    public class ConsumeOrderBean
    {
        private string serial;
        private string date;
        private float priceTotal;
        private CustomerBean customer;
        private List<ItemReserveBean> items = new List<ItemReserveBean>();

        public string Serial
        {
            get
            {
                return serial;
            }

            set
            {
                serial = value;
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

        public CustomerBean Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        public List<ItemReserveBean> Items
        {
            get
            {
                return items;
            }
        }
    }
}