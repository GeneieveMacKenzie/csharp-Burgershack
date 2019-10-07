using System;
using burgershack.Services;

namespace burgershack.Controllers
{
    public class DrinkController
    {
        private MenuItemService _menuItemService { get; set; } = new MenuItemService();
        public void UserInput()
        {
            _menuItemService.GetDrinks();
            Print();
            string choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch(choice)
            {
                case "q":
                    Environment.Exit(1);
                    break;
                default:
                    if (int.TryParse(choice, out int index))
                    {
                        //print drink deets
                        _menuItemService.GetDrinks(index - 1);
                        Print();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid"); 
                    }
                    break;
            }
            
        }
        private void Print()
        {
            foreach(string message in _menuItemService.Messages)
            {
                System.Console.WriteLine(message);
            }
            _menuItemService.Messages.Clear();
            System.Console.WriteLine();
        }
    }
}