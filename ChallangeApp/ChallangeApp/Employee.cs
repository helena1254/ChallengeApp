namespace ChallangeApp
{
    public class Employee
    {
        Employee employee1 = new Employee("Adam", "Małysz", 30);
        Employee employee2 = new Employee("Anna", "Adamska", 31);
        Employee employee3 = new Employee("Damian", "Rompalski", 32);

        employee1.AddScore(4);
employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(1);

employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(4);

employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(5);
//var result = employee1.Result;
//Console.WriteLine(result);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};
        int maxResult = -1;
        Empoloyee emploeeWithMaxResult = null;
foreach(var employee in employees)
{
    if (employee.Result > maxResult)
    {
        emploeeWithMaxResult= employee;
        maxResult=employee.Result;

    }
}
    }
}
