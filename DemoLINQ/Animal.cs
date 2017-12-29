using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ
{
    public class Animal
    {

        public Animal(string name, int age=0)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; } = "";
        public int Age = 0;

        public Animal Grow()
        {
            Age++;
            Console.WriteLine("{0} grown up.", Name);
            return this;
        }

        public override string ToString()
        {
            return Name + ":" + Age.ToString();
        }
    }
}
