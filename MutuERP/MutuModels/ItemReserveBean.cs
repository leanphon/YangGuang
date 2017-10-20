

namespace MutuModels
{
    public class ItemReserveBean : ItemBean
    {
        private OrderBean order = new OrderBean();
        private LessonBean lesson = new LessonBean();
        private int count;
        private float priceDiscount;
        private float priceTotal;

        public OrderBean Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }

        public LessonBean Lesson
        {
            get
            {
                return lesson;
            }

        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
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
    }
}
