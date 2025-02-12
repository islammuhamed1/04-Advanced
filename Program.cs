namespace Advanced04
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Employee Emp = new Employee()
			{
            Name = "Islam",
				EmployeeID = 10,
            BirthDate = new DateTime(2002, 9, 28),
				VacationStock = 10
			};

			Employee Emp2 = new Employee()
			{
            Name = "Hamada",
				EmployeeID = 20,
            BirthDate = new DateTime(1999, 12, 9),
				VacationStock = 1
			};

			SalesPerson Sp = new SalesPerson()
			{
            Name = "Hambozo",
				EmployeeID = 30,
            BirthDate = new DateTime(2005, 5, 7),
				VacationStock = 20,
            AchievedTarget = 7000
			};
			BoardMember BEmp = new BoardMember()
			{
            Name = "Tolba",
				EmployeeID = 40,
            BirthDate = new DateTime(1988, 11, 29),
            VacationStock = 10,
			};

			Department Dept01 = new Department()
			{
				DeptID = 2020,
				DeptName = "SD"
			};

			Club C1 = new Club()
			{
            ClubID = 10,
            ClubName = "Real Madrid"
			};

			Dept01.AddStaff(Emp);
			C1.AddMember(Emp);
			Dept01.AddStaff(Emp2);
			C1.AddMember(Emp2);
			Dept01.AddStaff(Sp);
			C1.AddMember(Sp);
			Dept01.AddStaff(BEmp);
			C1.AddMember(BEmp);

        Emp2.BirthDate = new DateTime(1905, 6, 15);
        Console.WriteLine("--------------------------");
			Emp.VacationStock -= 16;
        Console.WriteLine("--------------------------");
			Sp.CheckTarget(100);
         Console.WriteLine("--------------------------");

			BEmp.BirthDate = new DateTime(1900, 11, 1);
			BEmp.Resign();
            Console.WriteLine("--------------------------");
            Console.ReadKey();

		}
    }
}
