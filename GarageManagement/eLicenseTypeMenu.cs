using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class eLicenseTypeMenu : AbsorptionAndValidation
    {
        private eLicenseType m_LicenseType;

        public eLicenseTypeMenu()
        {
            m_MaxOption = 4;
            m_MinOption = 1;
        }

        public eLicenseType Start()
        {
            absorption();
            GetLicenseType();
            return m_LicenseType;
        }

        public override void printMenu()
        {
            Console.WriteLine("Please select the License Type of your Motorcycle");
            Console.WriteLine("License Type A1 Click --> 1");
            Console.WriteLine("License Type B1 Click --> 2");
            Console.WriteLine("License Type AA Click --> 3");
            Console.WriteLine("License Type BB Click --> 4 ");

        }

        private void GetLicenseType()
        {
            switch (m_Select)
            {
                case 1:
                    m_LicenseType = eLicenseType.A1;
                    break;
                case 2:
                    m_LicenseType = eLicenseType.B1;
                    break;
                case 3:
                    m_LicenseType = eLicenseType.AA;
                    break;
                case 4:
                    m_LicenseType = eLicenseType.BB;
                    break;
            }
        }

    }
}
