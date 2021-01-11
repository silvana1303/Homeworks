using System;
using NUnit.Framework;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddDriverShouldThrowWhenDataInvalid()
        {
            

            Assert.Throws<InvalidOperationException>(() =>
            {
                var raceEntry = new RaceEntry();
                raceEntry.AddDriver(null);
            });

        }

        [Test]
        public void AddDriverShouldThrowWhenAlreadyExist()
        {


            Assert.Throws<InvalidOperationException>(() =>
            {
                var raceEntry = new RaceEntry();

                var unitCar = new UnitCar("model", 10, 10);
                var unitDriver = new UnitDriver("Gosho", new UnitCar("model", 10, 10));

                raceEntry.AddDriver(unitDriver);
                raceEntry.AddDriver(unitDriver);
            });

        }


        [Test]
        public void AddDriverShouldWork()
        {
            var raceEntry = new RaceEntry();

                var unitCar = new UnitCar("model", 10, 10);
                var unitDriver = new UnitDriver("Gosho",unitCar);

               var result =  raceEntry.AddDriver(unitDriver);
              
                Assert.AreEqual("Driver Gosho added in race.", result);
                Assert.AreEqual(1, raceEntry.Counter);
            

        }


        [Test]
        public void CalculateAverageHorsePowerShouldThrownException()
        {
            var raceEntry = new RaceEntry();

            var unitCar = new UnitCar("VW", 100, 2000);
            var unitDriver = new UnitDriver("Kiro", unitCar);

            var unitCar2 = new UnitCar("VW", 10, 2000);
            var unitDriver2 = new UnitDriver("Stoyan", unitCar);

            var unitCar3 = new UnitCar("VW   ", 100, 2000);
            var unitDriver3 = new UnitDriver("Gosho", unitCar);
            
            raceEntry.AddDriver(unitDriver);
            raceEntry.AddDriver(unitDriver2);
            raceEntry.AddDriver(unitDriver3);

            var result = raceEntry.CalculateAverageHorsePower();

            Assert.AreEqual(100, result);

        }
    }
}