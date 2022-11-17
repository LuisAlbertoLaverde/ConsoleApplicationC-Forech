// See https://aka.ms/new-console-template for more information
using ConsoleApplicationCShardForech;


Employee Employee1 = new Employee("1010", "Sara", "Laverde", 8100000, new DateTime(2022, 3, 25));
Employee Employee2 = new Employee("1020", "Albert", "Laverde", 8200000, new DateTime(2020, 8, 23));
Employee Employee3 = new Employee("1030", "Cristhian", "Laverde", 8300000, new DateTime(2021, 6, 15));
Employee Employee4 = new Employee("1040", "Andres", "Castro", 8400000, new DateTime(2020, 4, 25));
Employee Employee5 = new Employee("1050", "ADA", "Piedrahita", 8500000, new DateTime(2023, 7, 05));
Employee Employee6 = new Employee();

Employee6.IDEmployee = "1060";
Employee6.Name = "Jorge";
Employee6.LastName = "Martinez";
Employee6.Salary = 8600000;
Employee6.ContractDate = new DateTime(2024, 12, 31);

Employee[] employees = new Employee[6];
employees[0] = Employee1;
employees[1] = Employee2;
employees[2] = Employee3;
employees[3] = Employee4;
employees[4] = Employee5;
employees[5] = Employee6;

//Mostrar los empleados
Console.WriteLine("EMPLEADO SIN EL AUMENTO ***********>");
foreach (var employee in employees)
{
    Console.WriteLine(employee.ToString());
}

//Incrementar el salario
foreach (var employee in employees)
{
    employee.Salary=(long)(employee.Salary*1.25);
}
Console.WriteLine("EMPLEADO CON EL AUMENTO ***********>");

foreach (var employee in employees)
{
    Console.WriteLine(employee.ToString());
}

