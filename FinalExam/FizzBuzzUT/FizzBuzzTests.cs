using System;
using FinalExam;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzUT
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzOutput()
        {
            FizzBuzz app = new FizzBuzz(new FizzStrategy());
            Assert.AreEqual("Fizz", app.InputHandler());
        }
        [TestMethod]
        public void BuzzOutput()
        {
            FizzBuzz app = new FizzBuzz(new BuzzStrategy());
            Assert.AreEqual("Buzz", app.InputHandler());
        }
        [TestMethod]
        public void FizzBuzzOutput()
        {
            FizzBuzz app = new FizzBuzz(new FizzBuzzStrategy());
            Assert.AreEqual("FizzBuzz", app.InputHandler());
        }
    }
}
