namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; set; }
        public int Priority { get; set; }
        public int Id { get; }

        private static readonly List<Item> _instances = new() { };

        public Item(string description)
        {
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public Item(string description, int priority)
            :this(description)
        {
            Priority = priority;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static Item Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}