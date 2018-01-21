using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class BuildElectrickEngine : BuildEngine
    {
        public Engine BuildElectrickCarEngine()
        {
            m_MaximumAmount = 2.8f;  //Work guidelines
            GetCurrentAmount();
            m_NewEngine = new ElectrigEngine(m_CurrentAmount, m_MaximumAmount);
            return m_NewEngine;
        }

        public Engine BuildElectrickMotorcycleEngine()
        {
            m_MaximumAmount = 1.6f;  //Work guidelines
            GetCurrentAmount();
            m_NewEngine = new ElectrigEngine(m_CurrentAmount, m_MaximumAmount);
            return m_NewEngine;
        }

        public override void AmountEnergy()
        {
            Console.WriteLine("Please insert the remaining charge time in the vehicle\n*Just you to know the maximum you can get its {0}", m_MaximumAmount);
        }

        public override void wrongInput()
        {
            Console.WriteLine("The charge time can not be greater than {0} or less then 0 pleese try again", m_MaximumAmount);
        }

    }
}
