using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement
{
    public class BuildCarWheel : BuildWheel
    {
        public BuildCarWheel()
        {
            m_NumOfWheel = 4;
            m_MaximumAmount = 32;
        }
    }
}

