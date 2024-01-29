using solid.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.View
{
	public class EmployeeView
	{
		private BankHelper bankHelper;

		public EmployeeView(BankHelper bankHelper)
		{
			this.bankHelper = bankHelper;
		}

		public void LoanMoney()
		{
			// some logic
			bankHelper.LoanMoney();
		}
	}
}
