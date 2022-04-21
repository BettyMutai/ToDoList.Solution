namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; set; }
        private static readonly List<Item> _instances = new() { };

        public Item(string description)
        {
            Description = description;
            _instances.Add(this);
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }
    }
}