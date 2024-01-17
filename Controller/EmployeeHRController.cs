using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Model;

namespace solid.Controller
{
	public class EmployeeHRController
	{
		public void EmployeeHRCreate(EmployeeHRModel employeeHRModel)
		{
			// some logic
		}

		public EmployeeHRModel EmployeeHRDetail(int id)
		{
			return new EmployeeHRModel();
		}

		public List<EmployeeHRModel> EmployeeHRList()
		{
			return new List<EmployeeHRModel>();
		}

		public void EmployeeHRUpdate(EmployeeHRModel employeeHRModel)
		{
			// some logic
		}

		public void EmployeeHRDelete(int id)
		{
			// some logic
		}
	}
}
