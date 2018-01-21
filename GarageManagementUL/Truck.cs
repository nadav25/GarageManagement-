using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    public class Truck : Vehicle
    {
        bool m_IsCarryingDangerousMaterial;
        float m_MaxWeight;

        public Truck(Person i_Person, Engine i_Engine, Wheel[] i_Whell, bool i_IsCarryingDangerousMaterial , float i_MaxWeight ) :
            base ( i_Person, i_Engine, i_Whell)
        {
            m_IsCarryingDangerousMaterial = i_IsCarryingDangerousMaterial;
            m_MaxWeight = i_MaxWeight;
        }

        public bool IsCarryingDangerousMaterial
        {
            get { return m_IsCarryingDangerousMaterial;}
        }

        public float MaxWeight
        {
            get { return m_MaxWeight;}
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n---Truck---\nCarrying Dangerous Material : " + CarryingDangerousMaterial() + ", Max Weight : {0}\n", m_MaxWeight);
        }

        private string CarryingDangerousMaterial()
        {
            string DangerousMaterial;
            if (m_IsCarryingDangerousMaterial == true)
            {
                DangerousMaterial = "yes";
            }
            else
            {
                DangerousMaterial = "no";
            }

            return DangerousMaterial;
        }

        protected override string GetType()
        {
            return "Truck";
        }
    }
}
