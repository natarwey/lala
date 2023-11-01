using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lala.classes
{
    class Doctors : Workers
    {
        public Doctors(string name, int age, string organization, int zp)
        {
            Name = name;
            Age = age;
            Organization = organization;
            Zp = zp;
        }
    }
}
