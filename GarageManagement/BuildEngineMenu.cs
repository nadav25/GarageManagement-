using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    class BuildEngineMenu : AbsorptionAndValidation
    {
        Engine m_NewEngine;
        int m_VehicleType;

        public Engine Build(int i_VehicleType)
        {
            m_VehicleType = i_VehicleType;
            m_MaxOption = 2;
            m_MinOption = 1;
            absorption();
            buildEngine(m_Select); // m_Select init in a absorption()
            return m_NewEngine;
        }

        private void buildEngine(int i_EngineType)
        {
            int electrick = 1;
            int fuel = 2;
            if (i_EngineType == electrick)
            {
                if (m_VehicleType != 3)
                {
                    GeneratesElectricMotor();
                }
                else
                {
                    Console.WriteLine("This garage does not provide services for electric truck, we will build fuel truck");
                    GeneratesFuelMotor();
                }
            }
            else if (i_EngineType == fuel)
            {
                GeneratesFuelMotor();
            }

        }

        private void GeneratesFuelMotor()
        {
            BuildFuelEngine newBuildEngine = new BuildFuelEngine();
            switch (m_VehicleType) // Vehicle Type can be only between 1-3
            {
                case 1:
                    m_NewEngine = newBuildEngine.BuildFuelCarEngine();
                    break;
                case 2:
                    m_NewEngine = newBuildEngine.BuildFuelMotorcycleEngine();
                    break;
                case 3:
                    m_NewEngine = newBuildEngine.BuildFuelTruckEngine();
                    break;
            }
        }

        private void GeneratesElectricMotor()
        {
            BuildElectrickEngine newBuildEngine = new BuildElectrickEngine();
            switch (m_VehicleType)
            {
                case 1:
                    m_NewEngine = newBuildEngine.BuildElectrickMotorcycleEngine();
                    break;
                case 2:
                    m_NewEngine = newBuildEngine.BuildElectrickCarEngine();
                    break;
            }
        }

        public override void printMenu()
        {
            Console.WriteLine("To build Electrick Engine press 1");
            Console.WriteLine("To build Fuel Engine press 2");
        }



    }
}

