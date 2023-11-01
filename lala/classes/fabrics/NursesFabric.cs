using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lala.classes.fabrics
{
	static class NursesFabric
	{
		public static Nurses Create(string name, int age, string organization, int zp)
		{
			return new Nurses(name, age, organization, zp);
		}
	}
}
