using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement
{
    public abstract class CurrentAmount
    {
        protected float m_CurrentAmount, m_MaximumAmount;

        protected void GetCurrentAmount()
        {
            AmountEnergy();
            bool parseOK = false;
            while (parseOK == false)
            {
                parseOK = float.TryParse(Console.ReadLine(), out m_CurrentAmount);
                if (parseOK == false)
                {
                    Console.WriteLine("wrong input try again");
                }
                if (m_CurrentAmount > m_MaximumAmount || m_CurrentAmount < 0)
                {
                    parseOK = false;
                    wrongInput();
                }
            }
        }

        public abstract void AmountEnergy();

        public abstract void wrongInput();
    }
}
