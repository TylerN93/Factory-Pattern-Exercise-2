using System;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "XBox", Price = 350},
            new Product(){Name = "TV", Price = 700},
            new Product(){Name = "Cpmputer", Price = 900},
            new Product(){Name = "Couch", Price = 200},

        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from Mongo Data Access");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from Mongo Data Access");
        }
    }
}

