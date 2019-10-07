namespace burgershack.Models
{
    public abstract class MenuItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuItem(string title, string description, double price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

    }
}