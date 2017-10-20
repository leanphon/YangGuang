
using OperatorBean = MutuModels.StaffBean;

namespace MutuModels
{
    public class ItemConsumeBean
    {
        private ItemReserveBean itemReserve = new ItemReserveBean();
        private CustomerBean consumer = new CustomerBean();
        private TeacherBean teacher = new TeacherBean();
        private OperatorBean oper = new OperatorBean();

        private string consumeFlowSerial;
        private string orderFlowSerial;
        private int consumeCount;
        private int remainCount;
        private string consumeTime;
        private string remark;

        public ItemReserveBean ItemReserve
        {
            get
            {
                return itemReserve;
            }

        }

        public CustomerBean Consumer
        {
            get
            {
                return consumer;
            }

        }

        public string ConsumeFlowSerial
        {
            get
            {
                return consumeFlowSerial;
            }

            set
            {
                consumeFlowSerial = value;
            }
        }

        public int ConsumeCount
        {
            get
            {
                return consumeCount;
            }

            set
            {
                consumeCount = value;
            }
        }

        public int RemainCount
        {
            get
            {
                return remainCount;
            }

            set
            {
                remainCount = value;
            }
        }

        public string ConsumeTime
        {
            get
            {
                return consumeTime;
            }

            set
            {
                consumeTime = value;
            }
        }

        public OperatorBean Oper
        {
            get
            {
                return oper;
            }

        }

        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }

        public TeacherBean Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
            }
        }
    }
}
