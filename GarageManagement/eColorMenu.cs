using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class eColorMenu : AbsorptionAndValidation
    {
        private eColor m_Color;

        public eColorMenu()
        {
            m_MaxOption = 4;
            m_MinOption = 1;
        }

        public eColor Start()
        {
            absorption();
            GetColor();
            return m_Color;
        }

        public override void printMenu()
        {
            Console.WriteLine("Please select the color of your car");
            Console.WriteLine("Color Green Click --> 1");
            Console.WriteLine("Color Silver Click--> 2");
            Console.WriteLine("Color White Click --> 3");
            Console.WriteLine("Color Black Click --> 4 ");
        }

        private void GetColor()
        {
            switch (m_Select)
            {
                case 1:
                    m_Color = eColor.Green;
                    break;
                case 2:
                    m_Color = eColor.Silver;
                    break;
                case 3:
                    m_Color = eColor.White;
                    break;
                case 4:
                    m_Color = eColor.Black;
                    break;
            }
        }

    }
}
