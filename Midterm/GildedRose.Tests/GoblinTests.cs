using System;
using Xunit;
using GoblinLib;
using System.Reflection;

namespace GildedRose.Tests
{
    //Do not modify this file!
    //-Goblin
    public class GoblinTests
    {
        [Fact]
        public void ItemHasExactlyThreeTypes()
        {
            Type type = typeof(Item);

            PropertyInfo[] props = type.GetProperties();

            Assert.Equal(props.Length, 3);
        }

        [Fact]
        public void ItemPropertyNamesStayTheSame()
        {
            Type type = typeof(Item);

            PropertyInfo[] props = type.GetProperties();

            Assert.Equal(props[0].Name, "Name");
            Assert.Equal(props[1].Name, "SellIn");
            Assert.Equal(props[2].Name, "Quality");
        }

        [Fact]
        public void ItemPropertyTypesStayTheSame()
        {
            Type type = typeof(Item);

            PropertyInfo[] props = type.GetProperties();

            Assert.Equal(props[0].PropertyType, typeof(string));
            Assert.Equal(props[1].PropertyType, typeof(int));
            Assert.Equal(props[2].PropertyType, typeof(int));
        }

        [Fact]
        public void ItemHasNoMethods()
        {
            Type type = typeof(Item);

            MethodInfo[] methods = type.GetMethods();

            //Should be no other methods than built-in Object methods and property getters/setters
            Assert.Equal(10, methods.Length);
        }
    }
}
