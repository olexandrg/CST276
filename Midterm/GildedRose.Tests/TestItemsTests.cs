using System.Collections.Generic;
using Xunit;

using GildedRose.Console;
using GoblinLib;

namespace GildedRose.Tests
{
    //These are sample tests that you can base your own tests off of.  
    //Create new files and classes for your own test and don't just 
    //add more tests do this file.  
    public class TestItemsTests
    {
        [Fact]
        public void TestInventoryLoad()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
                new Item {Name = "Enchanted Shield", SellIn = 10, Quality = 20}
            };

            Program program = new Program();
            program.Inventory.LoadInventory();

            Assert.Equal(Items.Count, program.Inventory.Items.Count);

            for (int i = 0; i < program.Inventory.Items.Count; i++)
            {
                Assert.Equal(Items[i].Name, program.Inventory.Items[i].Name);
                Assert.Equal(Items[i].SellIn, program.Inventory.Items[i].SellIn);
                Assert.Equal(Items[i].Quality, program.Inventory.Items[i].Quality);
            }
        }

        [Fact]
        public void TestExampleItem()
        {
            List<Item> Items = new List<Item>
            {
                new Item() { Name = "Fresh Baked Bread", SellIn = 3, Quality = 10 }
            };

            Program program = new Program();
            program.Inventory.Items = Items;

            //program.UpdateQuality();

            Assert.Equal(2, program.Inventory.Items[0].SellIn);
            Assert.Equal(9, program.Inventory.Items[0].Quality);
        }

        [Theory]
        [InlineData(3, 10, 9)]
        [InlineData(0, 10, 8)]
        [InlineData(-1, 10, 8)]
        public void TestExampleItem2(int sellin, int quality, int expectedquality)
        {
            List<Item> Items = new List<Item>
            {
                new Item() { Name = "Fresh Baked Bread", SellIn = sellin, Quality = quality }
            };

            Program program = new Program();
            program.Inventory.Items = Items;

            //program.UpdateQuality();

            Assert.Equal(sellin - 1, program.Inventory.Items[0].SellIn);
            Assert.Equal(expectedquality, program.Inventory.Items[0].Quality);
        }
    }
}