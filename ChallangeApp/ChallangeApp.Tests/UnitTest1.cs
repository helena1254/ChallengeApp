namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckSumOperationWithNegativeAndPositivePoints()
        {
            // arrange
            var employee = new Employee("Adam", "Pawelski", 39);
            employee.AddScore(4);
            employee.AddScore(5);
            employee.AddScore(-10);
            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(-1, result);

        }
    }
} 