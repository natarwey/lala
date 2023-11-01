using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lala.classes
{
    abstract class Workers
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Organization { get; set; }
        public int Zp { get; set; }
  
        public void PrintP()
        {
            Console.WriteLine($"{Name}, Возраст: {Age}, Организация: {Organization}, Зарплата: {Zp} рублей");
        }
    }

}
