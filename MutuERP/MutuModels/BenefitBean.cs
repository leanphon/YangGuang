namespace MutuModels
{
    public class BenefitBean
    {
        private int id;
        private string level;
        private int baseSalary;

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

        public string Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public int BaseSalary
        {
            get
            {
                return baseSalary;
            }

            set
            {
                baseSalary = value;
            }
        }
    }
}
