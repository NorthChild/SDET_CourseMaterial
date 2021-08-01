using NUnit.Framework;
using OperatorsApp;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(64, "Fail")]
        [TestCase(72, "Pass")]
        [TestCase(88, "Distinction")]
        public void GivenMarkReceiveGrade(int mark, string expected)
        {

            Assert.That(Program.Grade(mark), Is.EqualTo(expected));
        }


        [TestCase(3, "Code Red")]
        [TestCase(0, "Code Green")]
        [TestCase(1, "Code Amber")]
        [TestCase(5, "Error")]
        public void GivenLevelReceiveCode(int level, string expected) 
        {
            Assert.That(Program.Priority(level), Is.EqualTo(expected));
        }
             
    }
}