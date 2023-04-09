using TCPData;
using TCPExtensions;

List<Employee> employeeList = Data.GetEmployees();

var filteredEmployees = employeeList.Filter(x => x.IsManager == true);

foreach (var employee in filteredEmployees)
{
    Console.WriteLine($"First name: {employee.FirstName}");
    Console.WriteLine($"Last name: {employee.LastName}");
    Console.WriteLine($"Annual salary: {employee.AnnualSalary}");
    Console.WriteLine($"Manager: {employee.IsManager}");
    Console.WriteLine();
}

List<Department> departmentsList = Data.GetDepartments();

var filteredDepartments = departmentsList.Filter(x => x.ShortName == "HR" || x.ShortName == "FN");

foreach (var dep in filteredDepartments)
{
    Console.WriteLine($"Id: {dep.Id}");
    Console.WriteLine($"Short name: {dep.ShortName}");
    Console.WriteLine($"Long name: {dep.LongName}");
    Console.WriteLine();
}

//query syntax
var resultList = from emp in employeeList
                 join dept in departmentsList
                 on emp.DepartmentId equals dept.Id
                 select new
                 {
                     FirstName = emp.FirstName,
                     LastName = emp.LastName,
                     AnnualSalary = emp.AnnualSalary,
                     Manager = emp.IsManager,
                     Department = emp.DepartmentId,
                 };

foreach (var empl in resultList)
{
    Console.WriteLine($"First name: {empl.FirstName}");
    Console.WriteLine($"Last name: {empl.LastName}");
    Console.WriteLine($"Annual salary: {empl.AnnualSalary}");
    Console.WriteLine($"Manager: {empl.Manager}");
    Console.WriteLine($"Department: {empl.Department}");
    Console.WriteLine();

}
//Cannot be done with query syntax
var vaerageAnnualSalary = resultList.Average(a => a.AnnualSalary);
var hisgestAnnualSalary = resultList.Max(a => a.AnnualSalary);
var lowestAnnualSalary = resultList.Min(a => a.AnnualSalary);

Console.WriteLine($"Average annual salary: {vaerageAnnualSalary}");
Console.WriteLine($"Highest annual salary: {hisgestAnnualSalary}");
Console.WriteLine($"Lowest annual salary: {lowestAnnualSalary}");

Console.ReadKey();
