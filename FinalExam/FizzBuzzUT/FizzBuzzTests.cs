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
        public void CustomOutputStrategy()
        {
            // Check Standard Output
            // Expecting 3 "Fizz" 
            // 5 "Buzz" 
            // 7 "Foo" 
            // 10 "BuzzBar"
            // 15 "FizzBuzz"...
            ProgramMenu app = new ProgramMenu();

            CreateCustomListStrategy menu = new CreateCustomListStrategy();

            menu.custom_items.Add(new CustomDecorator(3, "Fizz"));
            menu.custom_items.Add(new CustomDecorator(5, "Buzz"));
            menu.custom_items.Add(new CustomDecorator(7, "Foo"));
            menu.custom_items.Add(new CustomDecorator(10, "Bar"));

            for (int i = 1; i < 101; ++i)
                menu.list.Add(i.ToString());

            menu.CreateList();

            app.list = menu.GetNewList();

            app.PrintList();
        }

        [TestMethod]
        public void StandardStrategyTest()
        {
            ProgramMenu app = new ProgramMenu();

            FizzBuzz strategy = new FizzBuzz(new StandardFizzBuzzStrategy());
            strategy.InputHandler();

            app.list = strategy.GetNewList();

            app.PrintList();

            // Check Standard Output
            // Expecting "Any Multiple Strategy implemented."
        }
        [TestMethod]
        public void OddFilteringTest()
        {
            ProgramMenu app = new ProgramMenu();

            FizzBuzz strategy = new FizzBuzz(new StandardFizzBuzzStrategy());
            strategy.InputHandler();

            app.list = strategy.GetNewList();

            app.PrintList();

            // Check Standard Output
            // Expecting "Any Multiple Strategy implemented."
        }
    }
}
