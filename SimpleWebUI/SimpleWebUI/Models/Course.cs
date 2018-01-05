using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebUI.Models
{
    public class Course
    {
		public Course(string Name, int CreditHours)
		{
			this.Name = Name;
			this.CreditHours = CreditHours;
		}
		public string Name;
		public int CreditHours;
	}
}
