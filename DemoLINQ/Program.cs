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
            CreateAndExecute();

            Console.ReadKey();
        }

        public static void CreateAndExecute()
        {
            var animals = new Animal[] { new Animal("dog", 0), new Animal("cat", 1), new Animal("rabbit", 1) };
            var query = from animal in animals where animal.Age > 0 select animal;
            foreach (var animal in query)
            {
                Console.WriteLine(animal);
            }
        }

        public static void DeferredExecution()
        {
            var animals = new Animal[] { new Animal("dog", 0), new Animal("cat", 1), new Animal("rabbit", 1) };
            var query = from animal in animals where animal.Live().Age > 0 select animal;
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            foreach (var animal in query)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
