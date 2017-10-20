
namespace MutuModels
{
    public class LogItemBean
    {
        private string serial;
        private string content;
        private string date;
        private UserBean operUser;

        public LogItemBean()
        {
            operUser = new UserBean();
        }
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

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
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

        public UserBean OperUser
        {
            get
            {
                return operUser;
            }
        }
    }
}
