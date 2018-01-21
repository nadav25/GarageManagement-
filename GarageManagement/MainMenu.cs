using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class MainMenu : AbsorptionAndValidation
    {
        bool m_FinishProgram = false;
        BuildMenu m_NewCar = new BuildMenu();
        public void startMenu()
        {
            m_MaxOption = 8;
            m_MinOption = 1;
            while (m_FinishProgram == false)
            {
                absorption();
                Act();
            }
        }
        private void Act()
        {
            switch (m_Select)
            {
                case 1:
                    m_NewCar.Start();
                    break;
                case 2:
                    eVehicleStatus newStatus = new eVehicleStatus();
                    string allVehicles = CreateVehicleMenu.m_Factory.PrintAllVehicles(newStatus.Start());
                    Console.WriteLine(allVehicles);
                    break;
                case 3:
                    eVehicleStatus newChangeStatus = new eVehicleStatus();
                    bool ChangeOK = CreateVehicleMenu.m_Factory.ChangeStatus(GetLicenseNumber(), newChangeStatus.Start());
                    newChangeStatus.StatusChange(ChangeOK);
                    break;
                case 4:
                    Console.WriteLine("inflate air");
                    string status = CreateVehicleMenu.m_Factory.InflateAirToMax(GetLicenseNumber());
                    Console.WriteLine(status);
                    break;
                case 5:
                    Console.WriteLine("refuel a vehicle");
                    eFuelTypeMenu newFuelType = new eFuelTypeMenu();
                    string statusRefuel = CreateVehicleMenu.m_Factory.RefuelVehicle(GetLicenseNumber(), newFuelType.Start(), GetQuantityToAdd());
                    Console.WriteLine(statusRefuel);
                    break;
                case 6:
                    Console.WriteLine("charge an electric vehicle");
                    Console.WriteLine("refuel a vehicle");
                    string statusCharging = CreateVehicleMenu.m_Factory.Recharging(GetLicenseNumber(), GetQuantityToAdd());
                    Console.WriteLine(statusCharging);
                    break;
                case 7:
                    Console.WriteLine("view full data of a vehicle");
                    string allDetails = CreateVehicleMenu.m_Factory.PrintAllDetails(GetLicenseNumber());
                    Console.WriteLine(allDetails);
                    break;
                case 8:
                    Console.WriteLine("");
                    m_FinishProgram = true;
                    break;
            }

        }

        public override void printMenu()
        {
            Console.WriteLine("----------Welcome to Nadav Garge----------");
            Console.WriteLine("1. To insert a new car to the garage  press : 1");
            Console.WriteLine("2. To display list of vehicles in the garage according to a Vehicle Status press : 2");
            Console.WriteLine("3. To change status of a car in the garage press : 3");
            Console.WriteLine("4. To inflate air in the wheels of a vehicle to the maximum press : 4");
            Console.WriteLine("5. To refuel a vehicle press : 5");
            Console.WriteLine("6. To charge an electric vehicle press : 6");
            Console.WriteLine("7. To view full data of a vehicle press : 7");
            Console.WriteLine("TO EXIT press : 8");
        }

        private string GetLicenseNumber()
        {
            Console.WriteLine("pleese enter the License Number of the vehicle");
            string newLicenseNumber = Console.ReadLine();
            return newLicenseNumber;
        }

        private float GetQuantityToAdd()
        {
            float newQuantity = 0;
            bool parseOk = false;
            Console.WriteLine("Please enter the amount added");
            while (!parseOk)
            {
                parseOk = float.TryParse(Console.ReadLine(), out newQuantity);
                if (parseOk == false)
                {
                    Console.WriteLine("wrong input pleese try again");
                }
            }
            return newQuantity;
        }


    }
}
