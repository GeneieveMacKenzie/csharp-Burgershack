using System.Collections.Generic;
using burgershack.Models;

namespace burgershack.Services
{
    public class MenuItemService
    {
        public List<MenuItem> MenuItems { get; private set; }
        public List<string> Messages { get; set; }
        public void Setup()
        {
            Drink Coke = new Drink("Coke", "Pairs well with our bacon burger!", 1.25);
            Drink Sprite = new Drink("Sprite", "Perfect for dipping nuggets", 1.25);
            Drink RootBeer = new Drink("RootBeer", "This is an alright option", 1.25);
            Drink Pepsi = new Drink("Pepsi", "Don't bother", 1.25);

            Entree BaconBurger = new Entree("Bacon Burger", "Comes with bacon", 7.99);
            Entree Nuggets = new Entree("Chicken Nuggets", "Too good", 4.99);
            Entree Salad = new Entree("Salad", "For when youre jeans are too tight", 11.99);

            Side Fries = new Side("Fries", "Comes with the perfect crisp", 2.00);

            MenuItems.AddRange(new MenuItem[] { Coke, Sprite, RootBeer, Pepsi, BaconBurger, Nuggets, Salad, Fries });
        }

        public void GetDrinks()
        {
            Messages.Add("BurgerShack Menu");
            for (int i = 0; i < MenuItems.Count; i++)
            {
                MenuItem m = MenuItems[i];
                Messages.Add($"{i + 1}: {m.Title} {m.Price}");
            }
            Messages.Add("Type a number to see details or Q to quit");
        }
        internal void GetDrinks(int index)
        {
            if (index < MenuItems.Count && index > -1)
            {
                MenuItem m = MenuItems[index];
                Messages.Add($@"
Title: {m.Title}
Description: {m.Description}
Price: {m.Price}

press any key to return to the main menu.
");
            }
            else
            {
                Messages.Add("Invalid Choice...");
            }
        }
        public MenuItemService()
        {
            Messages = new List<string>();
            MenuItems = new List<MenuItem>();
            Setup();
        }
    }
}