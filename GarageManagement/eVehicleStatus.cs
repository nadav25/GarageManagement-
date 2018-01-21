using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class eVehicleStatus : AbsorptionAndValidation
    {
        private VehicleStatus m_VehicleStatus;

        public eVehicleStatus()
        {
            m_MaxOption = 3;
            m_MinOption = 1;
        }

        public VehicleStatus Start()
        {
            absorption();
            GetColor();
            return m_VehicleStatus;
        }

        public override void printMenu()
        {
            Console.WriteLine("Please select the Status you want to serch");
            Console.WriteLine("In Amendment Click --> 1");
            Console.WriteLine("Fixed Click--> 2");
            Console.WriteLine("PaidUp Click --> 3");
        }

        private void GetColor()
        {
            switch (m_Select)
            {
                case 1:
                    m_VehicleStatus = VehicleStatus.InTheAmendment;
                    break;
                case 2:
                    m_VehicleStatus = VehicleStatus.Fixed;
                    break;
                case 3:
                    m_VehicleStatus = VehicleStatus.PaidUp;
                    break;
            }
        }

        public void StatusChange(bool i_ChangeStatus)
        {
            if (i_ChangeStatus == true)
            {
                Console.WriteLine("Status change successfully completed\n ");
            }
            else
            {
                Console.WriteLine("A vehicle does not exist in the garage\n");
            }
        }

    }
}
