using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Model
{
	public class EmployeeMemoModel
	{
		public Int32 Id { get; set; }
		public Int32 EmployeeId { get; set; }
		public DateTime MemoDate { get; set; }
		public String Particulars { get; set; }
		public String AttachmentURL { get; set; }
	}
}
