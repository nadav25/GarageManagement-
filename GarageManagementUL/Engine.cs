using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    public abstract class Engine : AddAction
    {
        protected float  m_PercentOfEnergy;

        public Engine(float i_CurrentAmountEnergy, float i_MaximumAmountEnergy)
        {
            m_CurrentAmount = i_CurrentAmountEnergy;
            m_MaximumAmount = i_MaximumAmountEnergy;
            CalculationEnergyPercentage();
        }

        protected void AddEnrgy(float i_EnergyToAdd)
        {
            AddingAct(i_EnergyToAdd);
            CalculationEnergyPercentage();
        }

        protected void CalculationEnergyPercentage()
        {
            m_PercentOfEnergy = (m_CurrentAmount / m_MaximumAmount) * 100;
        }

        public float MaximumAmountEnergy
        {
            get { return m_MaximumAmount; }
        }

        public float CurrentAmountEnergy
        {
            get { return m_CurrentAmount; }
        }

        public override string ToString()
        {
            return string.Format( PrintingEngineData() + " Percent Of Energy {0}", m_PercentOfEnergy);
        }

        protected abstract string PrintingEngineData();
    }

    public class FuelEngine : Engine
    {
        private eFuelType m_FuelType;

        public FuelEngine(float i_CurrentAmountEnergy, float i_MaximumAmountEnergy , eFuelType i_FuelType)
            : base ( i_CurrentAmountEnergy , i_MaximumAmountEnergy) 
        {
            m_FuelType = i_FuelType;
        }

        public void refueling(float i_FuelingQuantity, eFuelType i_FuelType)
        {
            if ( m_FuelType == i_FuelType )
            {
                AddEnrgy( i_FuelingQuantity );
            }
        }

        public eFuelType FuelType
        {
            get { return m_FuelType;}
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Fuel type : {0}\n", m_FuelType.ToString());
        }

        protected override string PrintingEngineData()
        {
            return string.Format("\n---Engine Type : Fuel Engine---\nCurrent fuel quantity : {0} , Max fuel quantity : {1} ", m_CurrentAmount, m_MaximumAmount);
        }
    }

    public class ElectrigEngine : Engine
    {

        public ElectrigEngine(float i_CurrentAmountEnergy, float i_MaximumAmountEnergy):
            base(i_CurrentAmountEnergy, i_MaximumAmountEnergy)
        {
                
        }

        public void charging(float i_TimeToCharge)
        {
            AddEnrgy(i_TimeToCharge);
        }

        protected override string PrintingEngineData()
        {
            return string.Format("\n---Engine Type : Electrig Engine---\nLoad time remains : {0} , Maximum load time : {1} ", m_CurrentAmount, m_MaximumAmount);
        }
    }


}
