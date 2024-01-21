using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Helper;

namespace solid.View
{
	public class EmployeeDailyRateView : EmployeeRateHelper
	{
		decimal MonthlySalary;
		int NoOfWorkDays;

		public decimal ComputeRate()
		{
			return MonthlySalary / NoOfWorkDays;
		}
	}
}
