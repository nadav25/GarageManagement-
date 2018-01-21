using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageManagementUL;

namespace GarageManagement
{
    public class BuildPerson
    {
        private string m_ModelName, m_LicenseNumber, m_OwnerName, m_CellphoneNumber;
        public Person Start()
        {
            Console.WriteLine("Pleese enter your full name : ");
            m_OwnerName = Console.ReadLine();
            Console.WriteLine(" Pleese enter your Model name : ");
            m_ModelName = Console.ReadLine();
            Console.WriteLine("Pleese enter your License Number : ");
            m_LicenseNumber = Console.ReadLine();
            Console.WriteLine("Pleese enter your Cell phone Number  : ");
            m_CellphoneNumber = Console.ReadLine();
            Person newPerson = new Person(m_ModelName, m_LicenseNumber, m_OwnerName, m_CellphoneNumber);
            return newPerson;
        }
    }
}
