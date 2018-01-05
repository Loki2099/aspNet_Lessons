using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebUI.Models
{
    public class Student
    {
		public Student(string FirstName, string LastName)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
		}
		public object FirstName;
		public string LastName;
	}
}
