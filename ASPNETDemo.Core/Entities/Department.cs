using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETDemo.Core.Entities
{
	public class Department
	{
		public int? DepartmentID { get; set; }
		public string DepartmentName { get; set; }
		public string GroupName { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}
