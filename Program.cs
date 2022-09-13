using System;

namespace MeuApp
{
    struct product
    {
        public product(int id, string name, double price, string brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Brand = brand;
        }

        public int Id;
        public string Name;
        public double Price;
        public string Brand;

        public double PriceInDolar(double dolar)

        {
            return Price * dolar;
        }

        class Program
        {
            static void Main(String[] args)

            {
                var mouse = new product(1, ("Mouse Gamer"), 299.99, ("hyperX"));


                mouse.Id = 88;

                Console.WriteLine(mouse.Id);
                Console.WriteLine(mouse.Brand);
                Console.WriteLine(mouse.Name);
                Console.WriteLine(mouse.Price);
            }

        }


    }

}
