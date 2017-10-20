using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MutuERP
{
    class MenuElement : AccordionControlElement
    {
        public MenuElement(string menuName)
        {
            menuName.Trim();
            Name = menuName;
            Text = menuName;

            Appearance.Normal.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Appearance.Pressed.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Appearance.Disabled.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Appearance.Hovered.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

            Appearance.Normal.Options.UseFont = true;
            Appearance.Pressed.Options.UseFont = true;
            Appearance.Disabled.Options.UseFont = true;
            Appearance.Hovered.Options.UseFont = true;

        }
        public MenuElement(string menuName, string formName)
        {
            menuName.Trim();
            formName.Trim();
            Name = menuName;
            Text = menuName;
            FormName = formName;
        }

        private int id;
        private string formName;
        private string name;

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

        public string FormName
        {
            get
            {
                return formName;
            }

            set
            {
                formName = value;
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
    }
}
