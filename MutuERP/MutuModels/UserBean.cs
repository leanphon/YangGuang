
namespace MutuModels
{
    public class UserBean
    {
        private int id;
        private string name;
        private string password;
        private RoleBean role;

        public UserBean()
        {
            role = new RoleBean();
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

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public RoleBean Role
        {
            get
            {
                return role;
            }
        }
    }
}
