using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsolEAppEmployment
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Human(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public virtual void ShowInfo() 
        {
            Console.WriteLine($"Ad: {this.Name}, Soyad: {this.Surname}, Yash: {this.Age}");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname}";
        }
    }


}

