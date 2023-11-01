using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lala.classes.fabrics
{
	static class AdministratorsFabric
	{
		public static Administrators Create(string name, int age, string organization, int zp)
		{
			return new Administrators(name, age, organization, zp);
		}
	}
}
