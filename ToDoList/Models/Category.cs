﻿namespace ToDoList.Models
{
    public class Category
    {
        private static List<Category> _instances = new List<Category> { };

        public string Name { get; set; }
        public int Id { get; }
        public List<Item> Items { get; set; }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public Category(string categoryName)
        {
            Name = categoryName;
            _instances.Add(this);
            Id = _instances.Count;
            Items = new List<Item> { };
        }

        public static List<Category> GetAll()
        {
            return _instances;
        }
    }
}