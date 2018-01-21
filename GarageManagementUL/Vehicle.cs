using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    public abstract class Vehicle
    {
        protected Person m_Person;
        protected Wheel[] m_Wheel;
        protected Engine m_Engine;
        private VehicleStatus m_VehicleStatus;

        public Vehicle( Person i_Person, Engine i_Engine , Wheel[] i_Whell )
        {
            m_Wheel = i_Whell;
            m_Engine = i_Engine;
            m_Person = i_Person;
            m_VehicleStatus = VehicleStatus.InTheAmendment;
        }

        public Person Person
        {
            get { return m_Person; }
        }

        public Wheel[] Wheel
        {
            get { return m_Wheel; }
        }

        public Engine Engine
        {
            get { return m_Engine; }
        }

        public VehicleStatus VehicleStatus
        {
            get { return m_VehicleStatus; }
            set { m_VehicleStatus = value; }
        }

        private string Status()
        {
            return string.Format("\nVehicle Status : {0}\n", m_VehicleStatus);
        }

        private string StartMenu()
        {
            return string.Format("-------------Vehicle Type : " + GetType() + "------------     \n");
        }

        protected abstract string GetType();

        public override string ToString()
        {
            return StartMenu() + m_Person.ToString() + m_Engine.ToString() + Status() + m_Wheel[0].ToString() ;
        }


    }
}
