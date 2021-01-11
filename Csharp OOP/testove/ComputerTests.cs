using System;
using System.Linq;

namespace Computers.Tests
{
    using NUnit.Framework;

    public class ComputerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor_SetCorrectNameProperty() // proverka na ctor s property name
        {
            Computer computer = new Computer("a");
            Assert.AreEqual("a", computer.Name);
        }

        [Test]
         public void Constructor_PartsCollectionIsEmpty() // proverka dali kolekciata e prazna v ctor
         {
             Computer computer = new Computer("a");
             Assert.IsEmpty(computer.Parts);
         }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
        public void NameProperty_EmptyValue_ShouldThrow(string name) // proverka na null property name
        {
            Assert.Throws<ArgumentNullException>(() => new Computer(name));
        }

        [Test]
        public void PartsProperty_AddTwoCollection() // proverka dali kolekciata se dobavq varno
        {
            Computer computer = new Computer("a");
            computer.AddPart(new Part("w", 1));
            computer.AddPart(new Part("q", 1));

            Assert.AreEqual(2,computer.Parts.Count);
        }

        [Test]
        public void TotalPriceProperty_CorrectResult() // proverka na method, koito sumira cena
        {
            Computer computer = new Computer("a");
            computer.AddPart(new Part("w", 1));
            computer.AddPart(new Part("q", 2));
            computer.AddPart(new Part("z", 3));

            Assert.AreEqual(6, computer.TotalPrice);
        }

        [Test]
        public void AddPartMethod_NullPart_ShouldThrowInvalidOperationException() // dobavqna na null element kym kolekcia
        {
            Computer computer = new Computer("a");

            Assert.Throws<InvalidOperationException>(() => computer.AddPart(null));
        }

        [Test]
        public void AddPartMethod_ShouldAddPart()
        {
            Computer computer = new Computer("a");
            computer.AddPart(new Part("w", 1));

            Assert.AreEqual(1, computer.Parts.Count);
        }

        [Test]
        public void AddPartMethod_ShouldAddCorrectPart() // dobavqne na korektna chast
        {
            Computer computer = new Computer("a");
            computer.AddPart(new Part("w", 1));

            Part actualPart = computer.Parts.FirstOrDefault(p => p.Name == "w");

            Assert.IsNotNull(actualPart);
        }

        [Test]
        public void RemovePartMethod_ShouldRemoveValidPart() // premahvane na korektna chast
        {
            Computer computer = new Computer("a");
            Part part = new Part("w", 1);
            computer.AddPart(part);

            bool actualRes = computer.RemovePart(part);

            Assert.IsTrue(actualRes);
        }

        [Test]
        public void RemovePartMethod_ShouldRemoveInvalidPart() // premaghvane na greshna chast
        {
            Computer computer = new Computer("a");
            Part part = new Part("w", 1);
            Part two = new Part("q", 1);
            computer.AddPart(part);

            bool actualRes = computer.RemovePart(two);

            Assert.IsFalse(actualRes);
        }

        [Test]
        public void RemovePartMethod_ShouldRemovePart() // premahvane na korektna chast/ proverka na kolekciata
        {
            Computer computer = new Computer("a");
            Part part = new Part("w", 1);
            computer.AddPart(part);

            computer.RemovePart(part);

            Assert.AreEqual(0, computer.Parts.Count);
        }

        [Test]
        public void RemovePartMethod_ShouldRemoveCorrectPart() // premahvane na korektna chast / proverka dali chastta e null
        {
            Computer computer = new Computer("a");
            Part part = new Part("w", 1);
            computer.AddPart(part);

            computer.RemovePart(part);

            Part actualPart = computer.Parts.FirstOrDefault(p => p.Name == "w");

            Assert.IsNull(actualPart);
        }

        [Test]
        public void GetPartMethod_ValidPart() // proverka na metod getpart i cenata
        {
            Computer computer = new Computer("a");
            Part part = new Part("w", 1);
            computer.AddPart(part);

            Part actualPart = computer.GetPart("w");

            Assert.AreEqual("w", actualPart.Name);
            Assert.AreEqual(1, actualPart.Price);
        }

        [Test]
        public void GetPartMethod_InValidPart_ReturnNull() // proverka na get metod pri greshna vyvejdane
        {
            Computer computer = new Computer("a");
            Part part = new Part("w", 1);
            computer.AddPart(part);

            Part actualPart = computer.GetPart("q");

            Assert.IsNull(actualPart);
        }

    }
}