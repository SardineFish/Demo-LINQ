using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ReuseLINQforList();

            Console.ReadKey();
        }

        public static void CreateAndExecute()
        {
            // Create a data source
            var animals = new Animal[] { new Animal("dog", 0), new Animal("cat", 1), new Animal("rabbit", 1) };

            // Create a LINQ query variable
            var query = from animal in animals where animal.Age > 0 select animal;

            // Execute LINQ query
            foreach (var animal in query)
            {
                Console.WriteLine(animal);
            }
        }

        public static void DeferredExecution()
        {
            // Create a data source
            var animals = new Animal[] { new Animal("dog", 0), new Animal("cat", 1), new Animal("rabbit", 1) };

            // Create a LINQ query variable
            var query = from animal in animals where animal.Grow().Age > 0 select animal;

            // Do a normal query
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            // Execute LINQ query
            foreach (var animal in query)
            {
                Console.WriteLine(animal);
            }
        }

        public static void ReuseLINQ()
        {
            var animals = new Animal[] { new Animal("dog", 0), new Animal("cat", 1), new Animal("rabbit", 1) };

            var query = from animal in animals where animal.Age > 0 select animal;

            // Execute LINQ query
            foreach (var animal in query)
            {
                Console.WriteLine(animal);
            }

            // Resize the data source
            Array.Resize(ref animals, 4);
            animals[3] = new Animal("sheep", 5);

            // Modify the data source
            foreach (var animal in animals)
            {
                animal.Grow();
            }

            // Execute LINQ query again
            foreach (var animal in query)
            {
                Console.WriteLine(animal);
            }
        }

        public static void ReuseLINQforList()
        {
            // Data source
            var animals = new List<Animal>(new Animal[] { new Animal("dog", 0), new Animal("cat", 1), new Animal("rabbit", 1) });

            // LINQ query variable
            var query = from animal in animals where animal.Age > 0 select animal;

            // Execute LINQ query
            foreach (var animal in query)
            {
                Console.WriteLine(animal);
            }

            animals.Add(new Animal("sheep", 5));

            // Execute LINQ query again
            foreach (var animal in query)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
