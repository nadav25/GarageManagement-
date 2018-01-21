using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class CreateCar
    {
        private eColor m_Color;
        private eDoors m_NumOfDoors;

        public Car Start(Person i_Person, Engine i_Engine, Wheel[] i_Whell)
        {
            getColor();
            getDoors();
            Car newCar = new Car(i_Person, i_Engine, i_Whell, m_Color, m_NumOfDoors);
            return newCar;
        }

        private void getColor()
        {
            eColorMenu newColor = new eColorMenu();
            m_Color = newColor.Start();
        }

        private void getDoors()
        {
            eDoorsMenu NumOfDoors = new eDoorsMenu();
            m_NumOfDoors = NumOfDoors.Start();
        }
    }
}
