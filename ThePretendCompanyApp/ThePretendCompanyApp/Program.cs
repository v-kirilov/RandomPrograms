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

}
Console.ReadKey();
