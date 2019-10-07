using burgershack.Interfaces;

namespace burgershack.Models
{
    public class Drink : MenuItem, IConsumable
    {

        public Drink(string title, string size, double price, int calories, int fat, int protein, int carbohydrates) : base (title, size, price, calories, fat, protein, carbohydrates)
        {

        }
    }
}