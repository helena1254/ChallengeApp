namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestTwoEmploee()
        {
            var employee1 = GetEmployee("Adam", "Pawłowski", 41);
            var employee2 = GetEmployee("Adam", "Pawłowski", 41);

            Assert.AreEqual(employee1.Surname, employee2.Surname);
        }

        [Test]
        public void TestNumberArethesame()
        {
            var employee1 = GetEmployee("Adam", "Pawłowski", 41);
            var employee2 = GetEmployee("Adam", "Pjarski", 41);

            Assert.AreEqual(employee1.Age, employee2.Age);
        }

        [Test]
        public void AreNumbersNotEqual()
        {
            int number1 = 40;
            int number2 = 41;
                      
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void AreNameOfEmployeesIsTheSame()
        {         
            var employee1 = GetEmployee("Adam", "Pawłowski",40);
            var employee2 = GetEmployee("Adam", "Pawłowski", 40);
                   
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

    }
} 
    

