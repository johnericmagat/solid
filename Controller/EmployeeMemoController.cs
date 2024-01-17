using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Model;

namespace solid.Controller
{
	public class EmployeeMemoController
	{
		public void EmployeeMemoCreate(EmployeeMemoModel employeeMemoModel)
		{
			// some logic
		}

		public EmployeeMemoController EmployeeMemoDetail(int id)
		{
			return new EmployeeMemoController();
		}

		public List<EmployeeMemoController> EmployeeMemoList()
		{
			return new List<EmployeeMemoController>();
		}

		public void EmployeeMemoUpdate(EmployeeMemoModel employeeMemoModel)
		{
			// some logic
		}

		public void EmployeeMemoDelete(int id)
		{
			// some logic
		}

		public void EmployeeMemoUploadFile()
		{
			// some logic
			// upload to cloud storage and save path to AttachmentURL
		}
	}
}
