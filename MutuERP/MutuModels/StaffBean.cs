
namespace MutuModels
{
    public class StaffBean
    {
        private int id;
        private string staffNumber;
        private string name;
        private string sex;
        private string idCard;
        private string phone;
        private string birthday;
        private string bankCard;
        private int attendanceSalary;
        private int senioritySalary;
        private string status;
        private string dateEntry;
        private string dateFormal;
        private string dateLeave;

        private PostBean post;
        private PerformanceBean performance;
        private BenefitBean benefit;
        private DepartmentBean department;
        public StaffBean()
        {
            post = new PostBean();
            performance = new PerformanceBean();
            benefit = new BenefitBean();
            department = new DepartmentBean();
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
        public string StaffNumber
        {
            get
            {
                return staffNumber;
            }

            set
            {
                staffNumber = value;
            }
        }

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

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string IdCard
        {
            get
            {
                return idCard;
            }

            set
            {
                idCard = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public string BankCard
        {
            get
            {
                return bankCard;
            }

            set
            {
                bankCard = value;
            }
        }

        public PostBean Post
        {
            get
            {
                return post;
            }
        }

        public PerformanceBean Performance
        {
            get
            {
                return performance;
            }
        }

        public BenefitBean Benefit
        {
            get
            {
                return benefit;
            }
        }

        public int AttendanceSalary
        {
            get
            {
                return attendanceSalary;
            }

            set
            {
                attendanceSalary = value;
            }
        }

        public int SenioritySalary
        {
            get
            {
                return senioritySalary;
            }

            set
            {
                senioritySalary = value;
            }
        }

        public DepartmentBean Department
        {
            get
            {
                return department;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string DateEntry
        {
            get
            {
                return dateEntry;
            }

            set
            {
                dateEntry = value;
            }
        }

        public string DateFormal
        {
            get
            {
                return dateFormal;
            }

            set
            {
                dateFormal = value;
            }
        }

        public string DateLeave
        {
            get
            {
                return dateLeave;
            }

            set
            {
                dateLeave = value;
            }
        }
    }
}
