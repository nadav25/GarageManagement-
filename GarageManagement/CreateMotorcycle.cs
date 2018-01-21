using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    class CreateMotorcycle
    {
        eLicenseType m_LicenseType;
        int m_EngineCapacity;

        public Motorcycle Start(Person i_Person, Engine i_Engine, Wheel[] i_Whell)
        {
            getLicenseType();
            getEngineCapacity();
            Motorcycle newMotorcycle = new Motorcycle(i_Person, i_Engine, i_Whell, m_LicenseType, m_EngineCapacity);
            return newMotorcycle;
        }

        private void getLicenseType()
        {
            eLicenseTypeMenu newLicenseType = new eLicenseTypeMenu();
            m_LicenseType = newLicenseType.Start();
        }

        private void getEngineCapacity()
        {
            bool parseOK = false;
            while (!parseOK)
            {
                Console.WriteLine("Pleese enter engine Capacity ");
                parseOK = int.TryParse(Console.ReadLine(), out m_EngineCapacity);
                if (parseOK == false || m_EngineCapacity <= 0)
                {
                    Console.WriteLine("wrong input try again");
                    parseOK = false;
                }
            }
        }
    }
}
