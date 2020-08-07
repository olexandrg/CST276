using System;
using System.Collections.Generic;
using FinalExam;
using FizzBuzzLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzUT
{
    [TestClass]
    public class FizzBuzzTests
    {
        static List<string> ListFactory()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 101; ++i)
            {
                list.Add(i.ToString());
            }
            return list;
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
            // Check Standard Output
            // Expecting Original FizzBuzz output
            ProgramMenu app = new ProgramMenu();

            FizzBuzz strategy = new FizzBuzz(new StandardFizzBuzzStrategy());
            strategy.InputHandler();

            app.list = strategy.GetNewList();

            app.PrintList();
            
        }
        [TestMethod]
        public void ReverseTest()
        {
            // Check Standard Output
            // Expecting reversed FizzBuzz output

            // Check Standard Output
            // Expecting Original FizzBuzz output
            ProgramMenu app = new ProgramMenu();

            FizzBuzz strategy = new FizzBuzz(new StandardFizzBuzzStrategy());
            strategy.InputHandler();

            app.list = strategy.GetNewList();
            app.ReverseList();

            app.PrintList();
        }
        [TestMethod]
        public void OddFilteringTest()
        {
            // Check Standard Output
            // Should not be any odd number in output

            ProgramMenu app = new ProgramMenu();

            List<string> list = ListFactory();
            FizzBuzz strategy = new FizzBuzz(new FilterOddStrategy(list));

            app.list = strategy.GetNewList();

            app.PrintList();
        }
        [TestMethod]
        public void EvenFilteringTest()
        {
            // Check Standard Output
            // Should not be any odd number in output

            ProgramMenu app = new ProgramMenu();

            List<string> list = ListFactory();
            FizzBuzz strategy = new FizzBuzz(new FilterEvenStrategy(list));

            app.list = strategy.GetNewList();

            app.PrintList();
        }
    }
}
