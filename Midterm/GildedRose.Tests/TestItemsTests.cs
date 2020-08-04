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
        public void TestItem_FreshBakedBread()
        {
            List<Item> Items = new List<Item>
            {
                new Item() { Name = "Fresh Baked Bread", SellIn = 3, Quality = 10 }
            };

            Program program = new Program();
            InventoryUpdater update = new InventoryUpdater();
            program.Inventory.Items = Items;

            update.UpdateQuality(program);

            Assert.Equal(2, program.Inventory.Items[0].SellIn);
            Assert.Equal(9, program.Inventory.Items[0].Quality);
        }
        [Fact]
        public void TestItem_AgedBrie()
        {
            List<Item> Items = new List<Item>
            {
                new Item() { Name = "Aged Brie", SellIn = 3, Quality = 10 }
            };

            Program program = new Program();
            InventoryUpdater update = new InventoryUpdater();
            program.Inventory.Items = Items;

            update.UpdateQuality(program);

            Assert.Equal(2, program.Inventory.Items[0].SellIn);
            Assert.Equal(11, program.Inventory.Items[0].Quality);
        }
        [Fact]
        public void TestItem_Sulfuras()
        {
            List<Item> Items = new List<Item>
            {
                new Item() { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }
            };

            Program program = new Program();
            InventoryUpdater update = new InventoryUpdater();
            program.Inventory.Items = Items;

            update.UpdateQuality(program);

            Assert.Equal(0, program.Inventory.Items[0].SellIn);
            Assert.Equal(80, program.Inventory.Items[0].Quality);
        }
        [Fact]
        public void TestItem_BackStagePass_QualityIncrease()
        {
            List<Item> Items = new List<Item>
            {
                new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 20 }
            };

            Program program = new Program();
            InventoryUpdater update = new InventoryUpdater();
            program.Inventory.Items = Items;

            update.UpdateQuality(program);

            // Test Increase by 1, when there are more than 10 days of Sell-In
            Assert.Equal(19, program.Inventory.Items[0].SellIn);
            Assert.Equal(21, program.Inventory.Items[0].Quality);

            Items.Clear();

            // Test Increase by 2, when there are 10 days of less of Sell-In
            Items.Add(new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 });

            update.UpdateQuality(program);

            Assert.Equal(9, program.Inventory.Items[0].SellIn);
            Assert.Equal(22, program.Inventory.Items[0].Quality);

            Items.Clear();

            // Test Increase by 3, when there are 5 days of less of Sell-In
            Items.Add(new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 });

            update.UpdateQuality(program);

            Assert.Equal(4, program.Inventory.Items[0].SellIn);
            Assert.Equal(23, program.Inventory.Items[0].Quality);

            // Drop Sell-In down to 0 and test that quality goes to 0
            Items.Clear();
            Items.Add(new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 });

            update.UpdateQuality(program);
            Assert.Equal(-1, program.Inventory.Items[0].SellIn);
            Assert.Equal(0, program.Inventory.Items[0].Quality);
        }
        [Fact]
        public void TestItem_ConjuredItems()
        {
            // Conjured items should degrade in Quality by 2 each Inventory Update
            List<Item> Items = new List<Item>
            {
                new Item() { Name = "Conjured Mana Cake", SellIn = 5, Quality = 20 }
            };

            Program program = new Program();
            InventoryUpdater update = new InventoryUpdater();
            program.Inventory.Items = Items;

            update.UpdateQuality(program);

            Assert.Equal(4, program.Inventory.Items[0].SellIn);
            Assert.Equal(18, program.Inventory.Items[0].Quality);
        }
        [Fact]
        public void TestItem_EnchantedItems()
        {
            // Conjured items should degrade in Quality by 1 every two days, and by 1 every day after sell-in date
            List<Item> Items = new List<Item>
            {
                new Item() { Name = "Enchanted Shield", SellIn = 5, Quality = 20 }
            };

            Program program = new Program();
            InventoryUpdater update = new InventoryUpdater();
            program.Inventory.Items = Items;

            update.UpdateQuality(program);

            Assert.Equal(4, program.Inventory.Items[0].SellIn);
            Assert.Equal(20, program.Inventory.Items[0].Quality);

            update.UpdateQuality(program);

            Assert.Equal(3, program.Inventory.Items[0].SellIn);
            Assert.Equal(19, program.Inventory.Items[0].Quality);

            Items.Clear();
            Items.Add(new Item() { Name = "Enchanted Shield", SellIn = 0, Quality = 20 });
            update.UpdateQuality(program);

            Assert.Equal(-1, program.Inventory.Items[0].SellIn);
            Assert.Equal(19, program.Inventory.Items[0].Quality);
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
            InventoryUpdater update = new InventoryUpdater();

            program.Inventory.Items = Items;

            update.UpdateQuality(program);

            Assert.Equal(sellin - 1, program.Inventory.Items[0].SellIn);
            Assert.Equal(expectedquality, program.Inventory.Items[0].Quality);
        }
    }
}