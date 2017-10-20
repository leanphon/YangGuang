using System.Collections.Generic;

namespace MutuModels
{
    public class OrderBean
    {
        private string flowSerial;
        private string date;
        private float priceDiscount;
        private float priceTotal;
        private CustomerBean customer;
        private List<ItemReserveBean> items = new List<ItemReserveBean>();

        public string FlowSerial
        {
            get
            {
                return flowSerial;
            }

            set
            {
                flowSerial = value;
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

        public float PriceDiscount
        {
            get
            {
                return priceDiscount;
            }

            set
            {
                priceDiscount = value;
            }
        }
    }
}
