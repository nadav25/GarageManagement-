using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    public class Person
    {
        private string m_ModelName, m_LicenseNumber, m_OwnerName, m_CellphoneNumber;

        public Person(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_CellphoneNumber)
        {
            m_ModelName = i_ModelName;
            m_LicenseNumber = i_LicenseNumber;
            m_OwnerName = i_OwnerName;
            m_CellphoneNumber = i_CellphoneNumber;
        }

        public string CellphoneNumber
        {
            get { return m_CellphoneNumber; }
        }
        public string OwnerName
        {
            get { return m_OwnerName; }
        }
        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
        }
        public string ModelName
        {
            get { return m_ModelName; }
        }

        public override string ToString()
        {
            return string.Format("---Person ---\nModel Name : {0} , License Number : {1}, Owner Name : {2} ,Cellphone Number {3}\n",
                m_ModelName, m_LicenseNumber, m_OwnerName, m_CellphoneNumber);
        }

    }
}
