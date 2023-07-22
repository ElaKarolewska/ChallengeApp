
namespace ChallengeApp.Tests1
{
    public class EmployeeTests
    {
        [Test]
        public void MinValueTest() 
        {
            var employee = new Employee("Ela", "Karolewska");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);

            Statistics statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
        
        }

        [Test]
        public void MaxValueTest() 
        {
            var employee = new Employee("Ela", "Karolewska");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);

            Statistics statistics = employee.GetStatistics();
            
            Assert.AreEqual(6, statistics.Max);
        
        }

        [Test]

        public void AverageValueTest() 
        {
            var employee = new Employee("Ela", "Karolewska");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);

            Statistics statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Average);
        }
        
         
        private Employee GetEmployee(string name,string surname)
         {
            return new Employee (name, surname);
        
         }
     }
}
