using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyser
{
    public class CategoryEntity
    {
        private int id;
        private int level;
        private int parentId;
        private string name;

        protected int Id
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

        protected int Level
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

        protected int ParentId
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

        protected string Name
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

        public CategoryEntity(int id, int level, int parentId, string name)
        {
            this.Id = id;
            this.Level = level;
            this.ParentId = parentId;
            this.Name = name;
        }
    }
}
