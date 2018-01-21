using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class eDoorsMenu : AbsorptionAndValidation
    {
        private eDoors m_NumOfDoors;

        public eDoorsMenu()
        {
            m_MaxOption = 4;
            m_MinOption = 1;
        }

        public eDoors Start()
        {
            absorption();
            GetNumOfDoors();
            return m_NumOfDoors;
        }

        public override void printMenu()
        {
            Console.WriteLine("Please insert the number of doors in the vehicle");
            Console.WriteLine("For 2 doors press 1");
            Console.WriteLine("For 3 doors press 2");
            Console.WriteLine("For 4 doors press 3");
            Console.WriteLine("for 5 doors press 4 ");
        }

        private void GetNumOfDoors()
        {
            switch (m_Select)
            {
                case 1:
                    m_NumOfDoors = eDoors.Two;
                    break;
                case 2:
                    m_NumOfDoors = eDoors.Three;
                    break;
                case 3:
                    m_NumOfDoors = eDoors.Four;
                    break;
                case 4:
                    m_NumOfDoors = eDoors.Five;
                    break;
            }
        }
    }
}
