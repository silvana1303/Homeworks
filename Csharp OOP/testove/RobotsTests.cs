using NUnit.Framework;

namespace Robots.Tests
{
    using System;

    public class RobotsTests
    {
        [Test]

        public void ConstructorShouldWork() // proverqva property capacity v konstruktor
        {
            //var robot = new Robot("Alex", 100);
            var robotManager = new RobotManager(100);

            Assert.AreEqual(100, robotManager.Capacity);
        }

        [Test]
        public void CapacityShouldThrowExceptionInvalid() // proverqva nevalidno capacity (v seta pishe da e nad 0)
        {
            //zashtoto shte gryme,kogato izvikame konstruktora
            Assert.Throws<ArgumentException>(() => new RobotManager(-100));
        }

        [Test]

        public void RobotsCountShouldWork() // proverqva lista v ctor dali raboti vqrno
        {
            var robot = new Robot("Alex", 100);
            var robotManager = new RobotManager(100);
            robotManager.Add(robot);

            Assert.AreEqual(1, robotManager.Count);
        }
        [Test]
        public void RobotManagerShouldThrowDuplicateNames() // proverqva add method dali raboti vqrno
        {
            var robot = new Robot("John", 80);
            var robotManager = new RobotManager(10);

            robotManager.Add(robot);

            //operation that throws exception is written in the assert line
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }

        //[Test]
        //public void RobotManagerShouldThrowInvalidCapacityAddMethod() // add method s nevalid capacity
        //{
        //    var robot = new Robot("John", 80);
        //    var robotManager = new RobotManager(1);

        //    robotManager.Add(robot);

        //    //operation that throws exception is written in the assert line
        //    Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }

        //[Test]
        //public void RobotManagerShouldWorkRemoveMethod() // remove method dali raboti vqrno
        //{
        //    var robot = new Robot("John", 80);
        //    var robotManager = new RobotManager(1);

        //    robotManager.Add(robot);
        //    robotManager.Remove("John");

        //    Assert.AreEqual(0, robotManager.Count);
        //}

        //[Test]
        //public void RobotManagerShouldThrowInvalidNameRemoveMethod() // throw na remove method
        //{
        //    var robotManager = new RobotManager(1);

        //    Assert.Throws<InvalidOperationException>(() => robotManager.Remove("John"));
        //}

        //[Test]
        //public void WorkShouldDecreaseRobotBattery() // dali methoda vqrno namalq bateriq
        //{
        //    var robot = new Robot("John", 80);
        //    var robotManager = new RobotManager(1);

        //    robotManager.Add(robot);

        //    robotManager.Work("John", "Cleaning", 20);

        //    Assert.AreEqual(60, robot.Battery);
        //}

        //[Test]
        //public void WorkShouldThrowExceptionInvalidRobotBattery() //throw pri nevalidna bateriq
        //{
        //    var robotManager = new RobotManager(1);

        //    Assert.Throws<InvalidOperationException>(() => robotManager.Work("John", "Cleaning", 20));
        //}

        //[Test]
        //public void WorkShouldThrowDecreaseRobotBatteryNotEnough() // throw pri nevalidno namalqne na bateriq
        //{
        //    var robot = new Robot("John", 10);
        //    var robotManager = new RobotManager(1);

        //    robotManager.Add(robot);

        //    Assert.Throws<InvalidOperationException>(() => robotManager.Work("John", "Cleaning", 20));
        //}

        //[Test]
        //public void ChargeShouldThrowExceptionInvalidRobotBattery() //throw pri nevalidna komanda za charge
        //{
        //    var robotManager = new RobotManager(1);

        //    Assert.Throws<InvalidOperationException>(() => robotManager.Charge("Invalid"));


        //}

        //[Test]
        //public void ChargeSetMaximumRobotBattery() // pravilna rabota na charge method
        //{
        //    var robot = new Robot("John", 80);
        //    var robotManager = new RobotManager(1);

        //    robotManager.Add(robot);

        //    robotManager.Work("John", "Cleaning", 20);

        //    robotManager.Charge("John");

        //    Assert.AreEqual(80, robot.Battery);
        //}
    }
}
