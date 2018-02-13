using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    /// <summary>
    /// All the methods in this class were created for the maintenance of vehicles in the garage,
    /// absorption of new vehicles and the release  vehicles from the garage.
    /// All vehicles are held within a data structure - list .
    /// warning!!!
    /// It should be noted that this class is created only once,
    /// so that such a situation of working on several garages will not happen.
    /// In the first part of the work when we create an instance of this class we will create it static.
    /// In the next steps it is possible to use Singleton pattern.
    /// </summary>
    public class FactoryProductionVehicles
    {
        public  List<Vehicle> m_VehiclesList = new List<Vehicle>();

        public FactoryProductionVehicles()
        {

        }

        public void AddVehicles(Vehicle i_VehiclesToAdd)
        {
            m_VehiclesList.Add(i_VehiclesToAdd);
        }

        public void RemoveVehicles(Vehicle i_VehiclesToRemove)
        {
            m_VehiclesList.Remove(i_VehiclesToRemove);
        }

        public bool isExist(Vehicle i_Vehicles)
        {
            bool Exists = false;
            foreach (Vehicle v in m_VehiclesList)
            {
                if (v.Person.LicenseNumber == i_Vehicles.Person.LicenseNumber)
                {
                    Exists = true;
                    break;
                }
            }

            return Exists;
        }

        public string PrintAllVehicles(VehicleStatus i_VehicleStatus)
        {
            string allVehicles = "";
            foreach (Vehicle v in m_VehiclesList)
            {
                if (v.VehicleStatus == i_VehicleStatus)
                {
                    allVehicles += v.Person.LicenseNumber + "\n";
                    //Console.WriteLine(v.ToString());
                }
            }

            return allVehicles;
        }

        public bool ChangeStatus(string i_LicenseNumber, VehicleStatus i_StatusToChange)
        {
            bool ChangeStatus = false;
            foreach (Vehicle v in m_VehiclesList)
            {
                if (v.Person.LicenseNumber == i_LicenseNumber)
                {
                    v.VehicleStatus = i_StatusToChange;
                    ChangeStatus = true;
                }
            }

            return ChangeStatus;
        }

        public string InflateAirToMax(string i_LicenseNumber)
        {
            string status = "Vehicle does not found ";
            foreach (Vehicle v in m_VehiclesList)
            {
                if (v.Person.LicenseNumber == i_LicenseNumber)
                {
                    foreach (Wheel w in v.Wheel)
                    {
                        w.InflatingWheels(w.MaxAirPressure - w.CurrentAirPressure);
                    }
                    status = "Wheels Inflate to Max Complete"; 
                }
            }

            return status;
        }

        public string PrintAllDetails(string i_LicenseNumber)
        {
            string allDetails = "Vehicle does not found ";
            foreach (Vehicle v in m_VehiclesList)
            {
                if (v.Person.LicenseNumber == i_LicenseNumber)
                {
                    allDetails = v.ToString();
                    break;
                }
            }

            return allDetails;
        }

        public string RefuelVehicle(string i_LicenseNumber, eFuelType i_FuelType, float i_FuelingQuantity)
        {
            string status = "Refueling was not performed as required";
            foreach (Vehicle v in m_VehiclesList)
            {
                if (v.Person.LicenseNumber == i_LicenseNumber)
                {
                    if (v.Engine is FuelEngine)
                    {
                        float TestChange = v.Engine.CurrentAmountEnergy;
                        (v.Engine as FuelEngine).refueling(i_FuelingQuantity, i_FuelType);
                        if (v.Engine.CurrentAmountEnergy != TestChange)
                        {
                            status = "Refueling complete Ok ";
                            break;
                        }
                        else
                        {
                            status += " because the amount you entered exceeds the maximum or the fuel type is different\npleese try again";
                        }
                    }
                    else
                    {
                        status += ",because engine is electrick engine";
                    }
                    break;
                }
                else
                {
                    status += ",because Vehicle is not in the garge";
                }
            }

            return status;
        }

        /// <summary>
        /// this method is charging an electric vehicle in the garage,
        /// currently returns a string of the performance status of the charge. 
        /// In the future, exceptions will be added
        /// </summary>
        /// <param name ="i_LicenseNumber"> The license number of the car that will load it</param>
        /// <param name="i_chargingQuantity">The amount of time to charge</param>
        /// <returns> string status </returns>
        public string Recharging(string i_LicenseNumber, float i_chargingQuantity)
        {
            string status = "Recharging was not performed as required";
            foreach (Vehicle v in m_VehiclesList)
            {
                if (v.Person.LicenseNumber == i_LicenseNumber)
                {
                    if (v.Engine is ElectrigEngine)
                    {
                        float IsChange = v.Engine.CurrentAmountEnergy;
                        (v.Engine as ElectrigEngine).charging(i_chargingQuantity);
                        if (v.Engine.CurrentAmountEnergy != IsChange) // A change will not be made if the amount to add exceeds the maximum
                        {
                            status = "Recharging complete Ok ";
                            break;
                        }
                        else
                        {
                            status += " because the amount you entered exceeds the maximum\npleese try again";
                        }
                    }
                    else
                    {
                        status += ",because engine is fuel engine";
                    }
                    break;
                }
                else
                {
                    status += ",because Vehicle is not in the garge";
                }
            }

            return status;
        }

    }
}
