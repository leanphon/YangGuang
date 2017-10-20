
namespace MutuModels
{
    public class DepartmentBean
    {
        private int id;
        private int parentId;
        private string name;
        private string code;

        public int ParentId
        {
            get
            {
                return parentId;
            }

            set
            {
                parentId = value;
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

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
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
    }
}
