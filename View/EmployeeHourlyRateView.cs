using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Helper;

namespace solid.View
{
	public class EmployeeHourlyRateView : EmployeeRateHelper
	{
		decimal MonthlySalary;
		int NoOfWorkDays;
		int NoOfHours;

		public decimal ComputeRate()
		{
			return (MonthlySalary / NoOfWorkDays) / NoOfHours;
		}
	}
}
