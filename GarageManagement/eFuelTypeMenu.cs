using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class eFuelTypeMenu : AbsorptionAndValidation
    {
        private eFuelType m_FuelType;

        public eFuelTypeMenu()
        {
            m_MaxOption = 3;
            m_MinOption = 1;
        }

        public eFuelType Start()
        {
            absorption();
            GetColor();
            return m_FuelType;
        }

        public override void printMenu()
        {
            Console.WriteLine("Please select the Fuel Type of your car");
            Console.WriteLine("Fuel Type Ocatan95 Click --> 1");
            Console.WriteLine("Fuel Type Ocatan98 Click--> 2");
            Console.WriteLine("Fuel Type Soler Click --> 3");
        }

        private void GetColor()
        {
            switch (m_Select)
            {
                case 1:
                    m_FuelType = eFuelType.Ocatan95;
                    break;
                case 2:
                    m_FuelType = eFuelType.Ocatan98;
                    break;
                case 3:
                    m_FuelType = eFuelType.Soler;
                    break;
            }
        }
    }
}
