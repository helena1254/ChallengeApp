using ChallangeApp;

Employee employee1 = new Employee("Adam", "Pawelski", 39);
Employee employee2 = new Employee("Anna", "Kaczorowska", 40);
Employee employee3 = new Employee("Marlena", "Łyczko", 41);

employee1.AddScore(4);
employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(10);

employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(4);

employee3.AddScore(10);
employee3.AddScore(9);
employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(5);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

int maxResult = -1;
Employee employeeWithMaxResult = null;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine("Pracownikiem z najwyższą liczbą ocen zostaje " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " "
    + employeeWithMaxResult.Age + " lat, która zdobyła: " + maxResult +" "+ "punktów.");

