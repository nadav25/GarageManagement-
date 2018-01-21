using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    public abstract class AddAction
    {
        protected float m_CurrentAmount, m_MaximumAmount;

        protected void AddingAct(float i_QuantityToAdd)
        {
            if (m_CurrentAmount + i_QuantityToAdd <= m_MaximumAmount + 0.001f)
            {
                m_CurrentAmount += i_QuantityToAdd;
                
            }
        }
    }
}
