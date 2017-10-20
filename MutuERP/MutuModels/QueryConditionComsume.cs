using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutuModels
{
    public class QueryConditionComsume
    {
        private string customerName;
        private string lessonName;
        private string teacherName;
        private string dateBegin;
        private string dateEnd;

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string LessonName
        {
            get
            {
                return lessonName;
            }

            set
            {
                lessonName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return teacherName;
            }

            set
            {
                teacherName = value;
            }
        }

        public string DateBegin
        {
            get
            {
                return dateBegin;
            }

            set
            {
                dateBegin = value;
            }
        }

        public string DateEnd
        {
            get
            {
                return dateEnd;
            }

            set
            {
                dateEnd = value;
            }
        }
    }
}
