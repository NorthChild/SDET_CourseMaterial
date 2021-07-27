using NUnit.Framework;
using Lab_Unit_Test;

namespace AgeCheckerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // testing cases where user is beneath first threashold (> 15)
        [TestCase(0)]
        [TestCase(6)]
        [TestCase(13)]
        [TestCase(14)]

        public void expectingAvailableU_PG_12(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG & 12 films are available."));
            
        }

        // testing cases where user is beneath second threashold (> 18)
        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]

        public void expectingAvailableU_PG_12_15(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG, 12 & 15 films are available."));

        }

        // testing cases where user is above last threashold (>= 18)
        [TestCase(18)]
        [TestCase(22)]
        [TestCase(43)]

        public void expectingAvailableU_PG_12_15_18(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("All films are available."));

        }








    }
}