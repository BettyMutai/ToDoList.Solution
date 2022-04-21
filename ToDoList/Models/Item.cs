using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; set; }
        private static List<Item> _instances = new List<Item> { };

        public Item(string description)
        {
            Description = description;
            _instances.Add(this);
        }
    }
}