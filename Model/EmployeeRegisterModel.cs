using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Model
{
	public class EmployeeRegisterModel
	{
		public Int32 Id { get; set; }
		public String IdNumber { get; set; }
		public String FullName { get; set; }
		public DateTime BirthDate { get; set; }
		public String Gender { get; set; }
		public String Address { get; set; }
		public String ContactNumber { get; set; }
		public String EmailAddress { get; set; }
	}
}
