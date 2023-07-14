﻿using ChallengeApp;

Employee empl1 = new Employee ("Justyna", "Kowalska", 38);
Employee empl2 = new Employee ("Magdalena", "Nowak", 42);
Employee empl3 = new Employee("Anna", "Wójcik", 50);

empl1.AddScore(5);
empl1.AddScore(1);
empl1.AddScore(2);
empl1.AddScore(1);
empl1.AddScore(3);

empl2.AddScore(2);
empl2.AddScore(6);
empl2.AddScore(4);
empl2.AddScore(1);
empl2.AddScore(3);

empl3.AddScore(9);
empl3.AddScore(6);
empl3.AddScore(5);
empl3.AddScore(3);
empl3.AddScore(7);

List<Employee> employees = new List<Employee>()
{
    empl1, empl2, empl3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees) 
{
   if (employee.Result > maxResult) 
   {
        employeeWithMaxResult = employee;
   }
}

Console.WriteLine("Najwyższą liczbę ocen otrzymała-" + " " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname +" " + employeeWithMaxResult.Age +
                 " " + "lat z wynikiem" + " " + employeeWithMaxResult.Result + " " + "punktów.");


