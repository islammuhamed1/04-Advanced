using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04
{
	public class Department
	{
		public int DeptID { get; set; }
		public string DeptName { get; set; }

		List<Employee> Staff;

		public Department()
		{
			Staff= new List<Employee>();

		}

		public void AddStaff(Employee emp)
		{
			if(E != null && !Staff.Contains(emp))
			{
				Staff.Add(emp);
                emp.EmployeeLayOff += this.RemoveStaff;
			}

		}
		public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
		{
			if(sender is Employee emp && Staff.Contains(emp))
			{
				Staff.Remove(emp);
				Console.WriteLine($"{emp} Removed From Dept: {this.DeptName}");
				Console.WriteLine($"Because: {e.Cause}");
			}
			

		}
	}
}
