using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Helper;

namespace solid.Controller
{
	public class EmployeeHourlyRateController : EmployeeRateHelper
	{
		decimal MonthlySalary;
		int NoOfWorkDays;
		int NoOfHours;

		public decimal Compute()
		{
			return (MonthlySalary / NoOfWorkDays) / NoOfHours;
		}
	}
}
