using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Helper;

namespace solid.Controller
{
	public class EmployeeDailyRateController : EmployeeRateHelper
	{
		decimal MonthlySalary;
		int NoOfWorkDays;

		public decimal Compute()
		{
			return MonthlySalary / NoOfWorkDays;
		}
	}
}
