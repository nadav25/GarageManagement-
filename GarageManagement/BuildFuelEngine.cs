using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class BuildFuelEngine : BuildEngine
    {
        private eFuelType m_FuelType;

        public Engine BuildFuelCarEngine()
        {
            m_MaximumAmount = 50;  //Work guidelines
            m_FuelType = eFuelType.Ocatan98; //Work guidelines
            GetCurrentAmount();
            m_NewEngine = new FuelEngine(m_CurrentAmount, m_MaximumAmount, m_FuelType);
            return m_NewEngine;
        }

        public Engine BuildFuelMotorcycleEngine()
        {
            m_MaximumAmount = 5.5f;  //Work guidelines
            m_FuelType = eFuelType.Ocatan95;  //Work guidelines
            GetCurrentAmount();
            m_NewEngine = new FuelEngine(m_CurrentAmount, m_MaximumAmount, m_FuelType);
            return m_NewEngine;
        }

        public Engine BuildFuelTruckEngine()
        {
            m_MaximumAmount = 130.0f;  //Work guidelines
            m_FuelType = eFuelType.Soler;  //Work guidelines
            GetCurrentAmount();
            m_NewEngine = new FuelEngine(m_CurrentAmount, m_MaximumAmount, m_FuelType);
            return m_NewEngine;
        }

        public override void AmountEnergy()
        {
            Console.WriteLine("Please insert the Current fuel quantity in the vehicle\n*Just you to know the maximum you can get its {0}", m_MaximumAmount);
        }

        public override void wrongInput()
        {
            Console.WriteLine("The fuel amount can not be greater than {0} or less then 0 pleese try again", m_MaximumAmount);
        }


    }
}

