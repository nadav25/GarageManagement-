using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class BuildMenu : AbsorptionAndValidation
    {
        BuildPerson newBuildPerson = new BuildPerson();
        BuildEngineMenu newBuildEngine = new BuildEngineMenu();
        BuildWheelMenu newWheelMenu = new BuildWheelMenu();
        CreateVehicleMenu newVehicleMenu = new CreateVehicleMenu();

        public void Start()
        {

            Console.Clear();
            m_MaxOption = 3;
            m_MinOption = 1;
            //printMenuVehicle();
            absorption();
            Person newPerson = newBuildPerson.Start();
            Engine newEngine = newBuildEngine.Build(m_Select);  // m_Select init in absorption --> Car = 1 , Motorcycle = 2 , Track = 3.
            Wheel[] newWheel = newWheelMenu.Start(m_Select);    //  m_Select init in absorption  --> Car = 1 , Motorcycle = 2 , Track = 3.
            newVehicleMenu.Start(newPerson, newEngine, newWheel, m_Select);
        }


        public override void printMenu()
        {
            Console.WriteLine("Pleese Select what type of vehicle you want to insert into the garage ");
            Console.WriteLine("To insert a Car into the garage select 1");
            Console.WriteLine("To insert a Motorcycle into the garage select 2");
            Console.WriteLine("To insert a Truck into the garage select 3");
        }
    }
}
