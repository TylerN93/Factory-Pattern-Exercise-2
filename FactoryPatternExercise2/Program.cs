namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What database would you like?");
            Console.WriteLine($"Type: sql, mongo, or list");

            var input = Console.ReadLine();

           IDataAccess db = DataAccessFactory.GetDataAccessType(input);
            var products = db.LoadData();
            db.SaveData();

            foreach (var item in products)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
            }
        }
    }
}
