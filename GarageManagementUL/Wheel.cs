using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    public class Wheel : AddAction
    {
        private string m_manufacturer;

        public Wheel( string i_manufacturer , float i_CurrentAirPressure, float i_MaxAirPressure )
        {
            m_manufacturer = i_manufacturer;
            m_CurrentAmount = i_CurrentAirPressure;
            m_MaximumAmount = i_MaxAirPressure;
        }
        public string Manufacturer
        {
            get { return m_manufacturer; }
            set { m_manufacturer = value; }
        }
        public float MaxAirPressure
        {
            get { return m_MaximumAmount; }
            set { m_MaximumAmount = value; }
        }
        public float CurrentAirPressure
        {
            get { return m_CurrentAmount; }
            set { m_CurrentAmount = value; }
        }

        public void InflatingWheels( float i_AirToAdd )
        {
             AddingAct(i_AirToAdd);
        }

        

        public override string ToString()
        {
            return string.Format("\n---Wheel---\nmanufacturer : {0}, CurrentAirPressure {1} , : Max Air Pressure : {2}\n"
               , m_manufacturer, m_CurrentAmount, m_MaximumAmount);
        }

    }
}
