using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class BuildWheelMenu
    {
        private Wheel[] m_newWheel;
        private int m_VehicleType;

        public Wheel[] Start(int i_VehicleType)
        {
            m_VehicleType = i_VehicleType;
            buildWheel();
            return m_newWheel;
        }

        private void buildWheel()
        {
            switch (m_VehicleType)
            {
                case 1:
                    BuildCarWheel newCarWheel = new BuildCarWheel();
                    m_newWheel = newCarWheel.Start();
                    break;
                case 2:
                    BuildMotorcycleWheel newMotorcycleWheel = new BuildMotorcycleWheel();
                    m_newWheel = newMotorcycleWheel.Start();
                    break;
                case 3:
                    BuildTruckWheel newTruckWheel = new BuildTruckWheel();
                    m_newWheel = newTruckWheel.Start();
                    break;
            }
        }
    }
}
