using NUnit.Framework;
using OperatorsApp;
using System;

namespace StoneTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(156, 11)]
        [TestCase(13, 0)]
        [TestCase(14, 1)]
        [TestCase(200, 14)]
        [TestCase(1000, 71)]
        public void GivingXamountOfPoundsToGetStones(int pounds, int expected)
        {
            // the first part gets access to the method in the stones.cs
            // then checks the what is returned follows the testcase parameters
            var result = Stones.GetStones(pounds);
            Assert.That(result, Is.EqualTo(expected));
        }


        [TestCase(-1)]
        public void FeedingNegativeValsToGetStonesGetException(int stones)
        {
            // the ()=> runs the first part, then compares it to the second part

            Assert.That(() => Stones.GetStones(stones), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Invalid Input"));
        }

        [TestCase(-1)]
        public void FeedingNegativeValsToGetPoundsGetException(int stones)
        {
            // the ()=> runs the first part, then compares it to the second part

            Assert.That(() => Stones.GetPounds(stones), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Invalid Input"));
        }


        [TestCase(13, 13)]
        [TestCase(14, 0)]
        [TestCase(156, 2)]
        [TestCase(123, 11)]
        [TestCase(400, 8)]
        [TestCase(21, 7)]
        public void GivingXamountOfStonesToGetStonesRemaining(int pounds, int expected)
        {
            // quicker method to assert
            Assert.That(Stones.GetPounds(pounds), Is.EqualTo(expected));
        }


        





    }
}