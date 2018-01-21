using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    public class Motorcycle : Vehicle
    {
        private int m_EngineCapacity;
        private eLicenseType m_LicenseType;

        public Motorcycle( Person i_Person, Engine i_Engine, Wheel[] i_Whell , eLicenseType i_LicenseType, int i_EngineCapacity) :
            base( i_Person, i_Engine , i_Whell)
        {
            m_EngineCapacity = i_EngineCapacity;
            m_LicenseType = i_LicenseType;
        }

        public int EngineCapacity
        {
            get { return m_EngineCapacity; }
        }

        public eLicenseType LicenseType
        {
            get { return m_LicenseType; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n---Motorcycle---\nEngine Capacity: {0} , License Type : {1}\n", m_EngineCapacity, m_LicenseType);
        }

        protected override string GetType()
        {
            return "Motorcycle";
        }

    }
}
