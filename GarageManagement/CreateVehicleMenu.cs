using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class CreateVehicleMenu
    {
        public static FactoryProductionVehicles m_Factory = new FactoryProductionVehicles();
        public void Start(Person i_Person, Engine i_Engine, Wheel[] i_Wheel, int i_VehicleType)
        {
            Vehicle newVehicle;
            switch (i_VehicleType)
            {
                case 1:
                    CreateCar newCar = new CreateCar();
                    newVehicle = newCar.Start(i_Person, i_Engine, i_Wheel);
                    m_Factory.AddVehicles(newVehicle);
                    break;
                case 2:
                    CreateMotorcycle newMotorcycle = new CreateMotorcycle();
                    newVehicle = newMotorcycle.Start(i_Person, i_Engine, i_Wheel);
                    m_Factory.AddVehicles(newVehicle);
                    break;
                case 3:
                    CreateTruck newTruck = new CreateTruck();
                    newVehicle = newTruck.Start(i_Person, i_Engine, i_Wheel);
                    m_Factory.AddVehicles(newVehicle);
                    break;
            }
        }
    }
}
