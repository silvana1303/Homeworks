using System;
using NUnit.Framework;

namespace Computers.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddMethodShouldWorkNotBecauseNull() // proverka na add kogato null
        {
            ComputerManager computerManager = new ComputerManager();

            Assert.Throws<ArgumentNullException>(() => computerManager.AddComputer(null));

        }

        [Test]
        public void AddMethodShouldWorkNotBecauseDuplicate() // dublirane na add method
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);

            computerManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => computerManager.AddComputer(computer));


        }

        [Test]
        public void AddMethodShouldWork() // pravilno rabotene na add method
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);

           Assert.AreEqual(computerManager.Count, 1);
           Assert.AreEqual(computerManager.Computers.Count, 1);

        }

        [Test]
        public void GetComputerShouldThrow() //throw na get method
        {
            ComputerManager computerManager = new ComputerManager();

            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer("test", null));
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer(null, "test"));
            Assert.Throws<ArgumentException>(() => computerManager.GetComputer("Test", "test"));

        }

        [Test]
        public void GetComputerShouldWork() // pravilno rabotene na get method
        {
            ComputerManager computerManager = new ComputerManager();

           var computer = new Computer("Test", "Test", 10);
           computerManager.AddComputer(computer);
           var computerFromManager = computerManager.GetComputer("Test", "Test");

           Assert.AreEqual(computer, computerFromManager);

        }

        [Test]
        public void RemoveComputerShouldWork() // pravilno rabotene na remove method
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);


            var computerFromManager = computerManager.RemoveComputer("Test", "Test");

            Assert.AreEqual(computer, computerFromManager);
            Assert.AreEqual(computerManager.Computers.Count, 0);
            Assert.AreEqual(computerManager.Count, 0);

        }

        [Test]
        public void GetComputersShouldWork() // pravilno rabotene na manufacturer
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            var computer2 = new Computer("Test", "Test12", 10);
            var computer3 = new Computer("Test1", "Test12", 10);

            computerManager.AddComputer(computer);
            computerManager.AddComputer(computer2);
            computerManager.AddComputer(computer3);

            var computerFromManager = computerManager.GetComputersByManufacturer("Test");


            CollectionAssert.Contains(computerFromManager, computer);
            CollectionAssert.Contains(computerFromManager, computer2);
            CollectionAssert.DoesNotContain(computerFromManager, computer3);

        }

        [Test]
        public void RemoveComputerShoulThrow() //throw na remove method
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);

            Assert.Throws<ArgumentNullException>( () => computerManager.RemoveComputer(null, "Test"));
            Assert.Throws<ArgumentNullException>(() => computerManager.RemoveComputer("Test", null));
            Assert.Throws<ArgumentException>(() => computerManager.RemoveComputer("wow", "wow"));


        }


    }
}