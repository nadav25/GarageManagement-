using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement
{
    /// <summary>
    /// Any class that is a menu or enum select must inherit from this class. In this ABSTRACT CLASS there are two methods that verify 
    /// that the value we have received in each menu is valid.
    /// In this class there are three variables :  minimum, maximum and the value we received.
    /// In each successor class it is necessary to initialize the maximum and minimum values,And implement the method printMenu
    /// </summary>
    public abstract class AbsorptionAndValidation
    {
        protected int m_MaxOption, m_MinOption, m_Select;

        protected void absorption()
        {
            printMenu();
            bool legal = false;
            while (!legal)
            {
                legal = int.TryParse(Console.ReadLine(), out m_Select);
                if (!(ValidationCheck(m_Select, legal)))
                {
                    legal = false;
                    Console.WriteLine("Wrong input pleese try again");
                }
            }
        }

        protected bool ValidationCheck(int i_ActionNumber, bool i_LegalInput)
        {
            bool Legal = false;
            if (i_ActionNumber <= m_MaxOption && i_ActionNumber >= m_MinOption && i_LegalInput == true) //Legal input
            {
                Legal = true;
            }

            return Legal;
        }

        public abstract void printMenu();
    }
}
