using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement
{
    public class BuildMotorcycleWheel : BuildWheel
    {
        public BuildMotorcycleWheel()
        {
            m_NumOfWheel = 2;
            m_MaximumAmount = 28;
        }

    }
}