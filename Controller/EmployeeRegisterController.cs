using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Model;

namespace solid.Controller
{
	public class EmployeeRegisterController
	{
		public void EmployeeCreate(EmployeeRegisterModel employeeRegisterModel)
		{
			// some logic
		}

		public EmployeeRegisterModel EmployeeDetail(int id)
		{
			return new EmployeeRegisterModel();
		}

		public List<EmployeeRegisterModel> EmployeeList()
		{
			return new List<EmployeeRegisterModel>();
		}

		public void EmployeeUpdate(EmployeeRegisterModel employeeRegisterModel)
		{
			// some logic
		}

		public void EmployeeDelete(int id)
		{
			// some logic
		}
	}
}
