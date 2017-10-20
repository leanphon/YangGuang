
namespace MutuModels
{
    public class LessonSaledBean
    {
        private LessonBean lesson = new LessonBean();
        private int count;
        private float discount;
        private float finishPrice;

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

        public float Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public float FinishPrice
        {
            get
            {
                return finishPrice;
            }

            set
            {
                finishPrice = value;
            }
        }
    }
}
