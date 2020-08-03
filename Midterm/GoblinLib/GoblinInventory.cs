using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace GoblinLib
{
    //Do not modify this file!
    //-Goblin
    public class GoblinInventory
    {
        public IList<Item> Items { get; set; }

        public void LoadInventory()
        {
            string json = System.IO.File.ReadAllText("inventory.json");
            Items = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Item>>(json);
        }
        public void SaveInventory()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(Items, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("inventory-finished.json", json);
        }
    }
}
