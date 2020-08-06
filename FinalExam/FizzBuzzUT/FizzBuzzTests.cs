using System;
using FinalExam;
using FizzBuzzLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzUT
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzOutput()
        {
            // Check Standard Output
            // Expecting "Fizz"
            FizzDecorator fizz = new FizzDecorator();
            fizz.ProduceOutput();
        }
        [TestMethod]
        public void BuzzOutput()
        {
            // Check Standard Output
            // Expecting "Buzz"
            BuzzDecorator buzz = new BuzzDecorator();
            buzz.ProduceOutput();
        }
        [TestMethod]
        public void FizzBuzzOutput()
        {
            // Check Standard Output
            // Expecting "FizzBuzz"
            ConcreteComponent app = new ConcreteComponent();
            FizzDecorator fizz = new FizzDecorator();
            BuzzDecorator buzz = new BuzzDecorator();

            buzz.SetComponent(fizz);
            buzz.ProduceOutput();
        }
        [TestMethod]
        public void IteratorOutput()
        {
            FizzBuzz app = new FizzBuzz();

            for (int i = 0; i < 100; ++i)
                Assert.AreEqual(i, app.InputHandler(i));
        }
        [TestMethod]
        public void AnyMultipleStrategyTest()
        {
            FizzBuzz strategy = new FizzBuzz(new AnyMultipleStrategy());
            strategy.InputHandler();

            // Check Standard Output
            // Expecting "Any Multiple Strategy implemented."
        }
    }
}
