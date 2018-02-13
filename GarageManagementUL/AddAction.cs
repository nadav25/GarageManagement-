using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagementUL
{
    /// <summary>
    /// This abstract class is created to prevent code duplication. 
    /// The Classes that are inherited from this abstract class are: engine and wheel,
    /// and they also inherit two variables that are common to both of them (the current quantity and maximum quantity).
    /// Wheel use this method to inflate air
    /// and Engine use this abstract class to refuel a vehicle or to charge an electric vehicle.
    /// In all of the above actions we need to prevent action when we want to go through the maximum.
    /// </summary>
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
