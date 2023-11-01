using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lala.classes.fabrics
{
	static class DoctorsFabric
	{
		public static Doctors Create(string name, int age, string organization, int zp)
		{
			return new Doctors(name, age, organization, zp);
		}
	}
}
