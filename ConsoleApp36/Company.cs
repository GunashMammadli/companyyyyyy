namespace ConsoleApp36;
internal class Company 
{
    public string Name { get; set; }
    List<Employee> employees = new List<Employee>();
    
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public bool GetEmployeeID(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.ID == id)
            {
                Console.WriteLine(emp.ID + " " + emp.Name + " " + emp.Surname);
            }
            return true;
        }
        return false;
    }
   

    public void GetAllEmployee()
    {
       foreach(Employee emp in employees) 
       {
            Console.WriteLine(emp.ID + " " + emp.Name + " " + emp.Surname);   
       }
    }

    //public void UpdateEmployee(Employee employees)
    //{
    //    foreach (Employee emp in employees)
    //    {
    //        if (GetEmployeeID(emp.ID))
    //        {
    //            Console.WriteLine("What do you want to update?");
    //            Console.WriteLine("Name - Update Name");
    //            Console.WriteLine("Gender - Update Gender");
    //            Console.WriteLine("Salary - Update Salary");
    //            Console.WriteLine("Position - Update Position");
    //            string update = Console.ReadLine();
    //            switch (update)
    //            {
    //                case "Name":
    //                    emp.Name = Console.ReadLine();
    //                    break;
    //                case "Gender":

    //                    break;
    //                case "Salary":
    //                    emp.Salary = Convert.ToInt32(Console.ReadLine());
    //                    break;
    //                case "Position":
    //                    emp.Position = Console.ReadLine();
    //                    break;
    //            }
    //        }
    //        else
    //        {
    //            throw new EmployeeNotFoundException("Employee doesn't exist!");
    //        }
    //    }
    //}

    //public void RemoveEmployee(int id)
    //{
    //    foreach (var  emp in employees) 
    //    { 
    //        if (emp.ID.Equals(id))
    //        {
    //            employees.Remove(emp);
    //            return;
    //        }
    //    }
    //}

   
}
