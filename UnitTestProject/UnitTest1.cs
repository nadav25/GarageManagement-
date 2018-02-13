using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using GarageManagement;
using GarageManagementUL;

namespace TestNinga
{
    /// <summary>
    ///  /// This method checks the addition of air to the wheel. 
    /// the same code also checks the addition of fuel to an electric motor and fuel
    /// </summary>
    [TestFixture]
    public class AddActionTest
    {
        private Wheel m_WheelTest;

        [SetUp]
        public void SetUp()
        {
            m_WheelTest = new Wheel("honda", 5, 10);
        }

        [Test]
        [TestCase(4.5f)]
        [TestCase(6.3f)]
        [TestCase(5.0f)]
        public void AddAction_AddingQuantity_BlockActionIfAboveMax(float a)
        {
            float old = m_WheelTest.CurrentAirPressure;
            m_WheelTest.InflatingWheels(a);
           
            Assert.That(m_WheelTest.CurrentAirPressure, Is.InRange(0, m_WheelTest.MaxAirPressure));
        }

    }

    [TestFixture]
    public class GargeTest
    {
        FactoryProductionVehicles m_GargeTest;
        Person m_Person;
        Wheel[] m_Wheel;
        Engine m_Engine;
        Vehicle m_Vehicle;

        [SetUp]
        public void SetUp()
        {
            m_GargeTest = new FactoryProductionVehicles();
            m_Person = new Person("honda", "1996165", "nadav", "0528600970");
            m_Wheel = new Wheel[1];
            m_Wheel[0] = new Wheel("Tayer", 5, 10);
            m_Engine = new FuelEngine(50, 65, eFuelType.Ocatan95);
            m_Vehicle = new Car(m_Person, m_Engine, m_Wheel,eColor.Black,eDoors.Five);
            m_GargeTest.AddVehicles(m_Vehicle);
        }

        [Test]
        [TestCase("1996165", eFuelType.Ocatan95, 20)]   // Greater than the permitted quantity
        [TestCase("199616", eFuelType.Ocatan95, 10)]    // License number (vehicle) does not exist in the garage
        [TestCase("1996165", eFuelType.Ocatan98, 10)]   // Incorrect fuel type
        public void RefuelVehicle_AddFuelToVehicle_PreventsIllegalRefueling( string i_LicenseNumber ,eFuelType i_FuelType, float i_FuelingQuantity)
        {
            string status = m_GargeTest.RefuelVehicle(i_LicenseNumber, i_FuelType, i_FuelingQuantity);
            Assert.That(status, Does.Not.Contain("Refueling complete Ok"));   
        }

        //[Test]
        //[TestCase("1996165")] 
        //[TestCase("199")]
        //public void InflateAirToMax_WhenCalld_InflateAirToMaxDone(string i_LicenseNumber)
        //{
        //    m_GargeTest.InflateAirToMax(i_LicenseNumber);

        //    Assert.That(m_GargeTest.m_VehiclesList[0].Wheel[0].CurrentAirPressure, Is.EqualTo(m_GargeTest.m_VehiclesList[0].Wheel[0].MaxAirPressure));
        //}
    }
}