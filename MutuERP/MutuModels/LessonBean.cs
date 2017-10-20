
namespace MutuModels
{
    public class LessonBean
    {
        private int id;
        private string name;
        private float price;
        private float timeLength;
        private string description;
        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public float TimeLength
        {
            get
            {
                return timeLength;
            }

            set
            {
                timeLength = value;
            }
        }
    }
}
