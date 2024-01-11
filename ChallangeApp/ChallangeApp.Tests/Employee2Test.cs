namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Marlena", "Lukaszczuk");
            employee.AddGrade(6);
            employee.AddGrade(1);
            employee.AddGrade(2);
            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Marlena", "Lukaszczuk");
            employee.AddGrade(6);
            employee.AddGrade(1);
            employee.AddGrade(2);
            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(1, statistics.Min);

        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("Marlena", "Lukaszczuk");
            employee.AddGrade(6);
            employee.AddGrade(1);
            employee.AddGrade(2);
            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(3, statistics.Average);

        }
    }
} 