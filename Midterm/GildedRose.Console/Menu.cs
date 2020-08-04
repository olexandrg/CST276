﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class Menu
    {
        public void UpdateQuality(Program game)
        {
            for (var i = 0; i < game.Inventory.Items.Count; i++)
            {
                if (game.Inventory.Items[i].Name != "Aged Brie" && game.Inventory.Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (game.Inventory.Items[i].Quality > 0)
                    {
                        if (game.Inventory.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            game.Inventory.Items[i].Quality = game.Inventory.Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (game.Inventory.Items[i].Quality < 50)
                    {
                        game.Inventory.Items[i].Quality = game.Inventory.Items[i].Quality + 1;

                        if (game.Inventory.Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (game.Inventory.Items[i].SellIn < 11)
                            {
                                if (game.Inventory.Items[i].Quality < 50)
                                {
                                    game.Inventory.Items[i].Quality = game.Inventory.Items[i].Quality + 1;
                                }
                            }

                            if (game.Inventory.Items[i].SellIn < 6)
                            {
                                if (game.Inventory.Items[i].Quality < 50)
                                {
                                    game.Inventory.Items[i].Quality = game.Inventory.Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (game.Inventory.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    game.Inventory.Items[i].SellIn = game.Inventory.Items[i].SellIn - 1;
                }

                if (game.Inventory.Items[i].SellIn < 0)
                {
                    if (game.Inventory.Items[i].Name != "Aged Brie")
                    {
                        if (game.Inventory.Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (game.Inventory.Items[i].Quality > 0)
                            {
                                if (game.Inventory.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    game.Inventory.Items[i].Quality = game.Inventory.Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            game.Inventory.Items[i].Quality = game.Inventory.Items[i].Quality - game.Inventory.Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (game.Inventory.Items[i].Quality < 50)
                        {
                            game.Inventory.Items[i].Quality = game.Inventory.Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
