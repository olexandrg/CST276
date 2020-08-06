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
            FizzDecorator fizz = new FizzDecorator();
            BuzzDecorator buzz = new BuzzDecorator();

            buzz.SetComponent(fizz);
            buzz.ProduceOutput();
        }
        [TestMethod]
        public void CustomOutput()
        {
            // Check Standard Output
            // Expecting 3 "Fizz" 
            // 5 "Buzz" 
            // 7 "Foo" 
            // 10 "BuzzBar"
            // 15 "FizzBuzz"...
            ProgramMenu menu = new ProgramMenu();

            menu.custom_items.Add(new CustomDecorator(3, "Fizz"));
            menu.custom_items.Add(new CustomDecorator(5, "Buzz"));
            menu.custom_items.Add(new CustomDecorator(7, "Foo"));
            menu.custom_items.Add(new CustomDecorator(10, "Bar"));

            menu.CreateList();

            menu.PrintListInAscendingOrder();
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
