using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class CreateTruck : AbsorptionAndValidation
    {
        private bool m_IsCarryingDangerousMaterial;
        private float m_MaxWeight;

        public Truck Start(Person i_Person, Engine i_Engine, Wheel[] i_Whell)
        {
            isCarryingDangerousMaterial();
            getMaxWeight();
            Truck newTruck = new Truck(i_Person, i_Engine, i_Whell, m_IsCarryingDangerousMaterial, m_MaxWeight);
            return newTruck;
        }

        private void isCarryingDangerousMaterial()
        {
            m_MaxOption = 2;
            m_MinOption = 1;
            absorption();
            getCarryingDangerousMaterial();

        }

        private void getCarryingDangerousMaterial()
        {
            switch (m_Select)
            {
                case 1:
                    m_IsCarryingDangerousMaterial = true;
                    break;
                case 2:
                    m_IsCarryingDangerousMaterial = false;
                    break;
            }
        }

        public override void printMenu()
        {
            Console.WriteLine("If truck Carrying Dangerous Material press --> 1 ");
            Console.WriteLine("If truck not Carrying Dangerous Material press --> 2 ");
        }

        private void getMaxWeight()
        {
            bool parseOK = false;
            while (!parseOK)
            {
                Console.WriteLine("Pleese enter the Max Weight of the truck ");
                parseOK = float.TryParse(Console.ReadLine(), out m_MaxWeight);
                if (parseOK == false || m_MaxWeight <= 0)
                {
                    Console.WriteLine("wrong input try again");
                    parseOK = false;
                }
            }
        }
    }
}
