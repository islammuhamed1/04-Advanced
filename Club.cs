using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04

{
	internal class Club
	{
		public int ClubID { get; set; }
		public String ClubName { get; set; }
		List<Employee> Members;

		public Club()
		{
			Members = new List<Employee>();
		}

		public void AddMember(Employee emp)
		{
			if (emp != null && !Members.Contains(emp))
			{
				Members.Add(emp);
                emp.EmployeeLayOff += this.RemoveMember;


			}
		}
		public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
		{
			if (sender is Employee emp && Members.Contains(E) && e.Cause==LayOffCause.VacationStock)
			{
				Members.Remove(emp);
				Console.WriteLine($"{emp} Removed From Club: {this.ClubName}");
				Console.WriteLine($"Because: {e.Cause}");
			}
		}
	}
}
