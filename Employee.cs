using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04

{

	public enum LayOffCause
	{
		VacationStock=1,
		Age,
		TargetFailed,
		Resigned
		

	}
	public class EmployeeLayOffEventArgs : EventArgs
	{
		public LayOffCause Cause { get; set; }
	}
	public class Employee
	{
		public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
		protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
		{
			EmployeeLayOff.Invoke(this, e);
			
		}
		public int EmployeeID { get; set; }
		public string Name { get; set; }
		DateTime birthDate;
		public DateTime BirthDate
		{
			get =>birthDate;
			set
			{
				if (DateTime.Now.Year - value.Year >= 60)
					OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age });
				birthDate = value;
			}

		}
		int vacationStock;
		public virtual int VacationStock
		{
			get => vacationStock;

			set
			{
				if(value<0)
					OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VacationStock });
					vacationStock = value;


			}
		}
		public bool RequestVacation(DateTime date1, DateTime date2)
		{
			if (date2.Day - date1.Day > vacationStock)
			{
				OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VacationStock });
				return false;
			}
			VacationStock-=(date2.Day- date1.Day);
			return true;

		}



		public void EndOfYearOperation()
		{
			if(DateTime.Now.Year-birthDate.Year >= 60)
			{
				OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age });
				Console.WriteLine($"EmployeeID={EmployeeID}, EmployeeName={Name} has been layed off");

			}
			else
				Console.WriteLine($"EmployeeID={EmployeeID}, EmployeeName={Name} Still Here ");






		}
		public override string ToString()
		{
			return $"EmployeeID: {EmployeeID}, EmployeeName: {Name}";
		}

	}

}
