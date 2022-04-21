using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; }

        public Item(string description)
        {
            Description = description;
        }
    }
}