using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lala.classes
{
	class Administrators : Workers
	{
		public Administrators(string name, int age, string organization, int zp)
		{
			Name = name;
			Age = age;
			Organization = organization;
			Zp = zp;
		}
	}
}
