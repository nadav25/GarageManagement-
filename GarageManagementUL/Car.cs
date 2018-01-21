using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    public class Car : Vehicle
    {
        private eColor m_Color;
        private eDoors m_NumOfDoors;

        public Car(Person i_Person, Engine i_Engine, Wheel[] i_Whell , eColor i_Color , eDoors i_NumOfDoors):
            base( i_Person , i_Engine , i_Whell)
        {
            m_Color = i_Color;
            m_NumOfDoors = i_NumOfDoors;
        }

        public eColor Color
        {
            get { return m_Color;}
        }

        public eDoors NumOfDoors
        {
            get { return m_NumOfDoors; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n---Car---\nColor: {0} , Num Of Doors : {1}\n",m_Color,m_NumOfDoors);
        }

        protected override string GetType()
        {
            return "Car";
        }



    }
}
