
namespace ChallengeApp.Tests1
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsAverage_ThenReceiveCorrectAverageLetter1()
        {
            var employee = new Employee("Ela", "Karolewska");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('E', statistics.AverageLetter);
        }
        [Test]
        public void WhenGetStatisticsAverage_ThenReciveCorrectAverageLetter2() 
        {
            var employee = new Employee("Anna","Wójcik");
            employee.AddGrade(50);
            employee.AddGrade(30);
            employee.AddGrade(40);
           
            var statistics = employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }
         [Test]
        public void CheckIfAddGradeInLetterWorks()
        {
            var employee = new Employee("Marta", "Nowak");
            employee.AddGrade('a');
            employee.AddGrade('C');
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(55, statistics.Average);
        }
       
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
