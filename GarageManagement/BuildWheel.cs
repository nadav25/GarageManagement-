using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public abstract class BuildWheel : CurrentAmount
    {
        protected int m_NumOfWheel;
        protected Wheel[] newWheel;
        protected string m_manufacturer;

        public override void AmountEnergy()
        {
            Console.WriteLine("Please Insert current air pressure in the Wheel\n*Just you to know the maximum you can get its {0}", m_MaximumAmount);
        }

        public override void wrongInput()
        {
            Console.WriteLine("The charge time can not be greater than {0} or less then 0 pleese try again", m_MaximumAmount);
        }

        protected void getManufacturer()
        {
            Console.WriteLine("Plesse enter manufacturer name ");
            m_manufacturer = Console.ReadLine();
        }

        public Wheel[] Start()
        {
            newWheel = new Wheel[m_NumOfWheel];
            GetCurrentAmount();
            getManufacturer();
            for (int i = 0; i < newWheel.Length; i++)
            {
                newWheel[i] = new Wheel(m_manufacturer, m_CurrentAmount, m_MaximumAmount);
            }

            return newWheel;
        }
    }
}
