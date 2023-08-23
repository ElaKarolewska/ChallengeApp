using ChallengeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTests
{
    internal class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsAverage_ThenReceiveCorrectAverageLetter1()
        {
            var employee = new EmployeeInMemory("Ela", "Karolewska");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('E', statistics.AverageLetter);
        }
        [Test]
        public void WhenGetStatisticsAverage_ThenReciveCorrectAverageLetter2()
        {
            var employee = new EmployeeInMemory("Anna", "Wójcik");
            employee.AddGrade(50);
            employee.AddGrade(30);
            employee.AddGrade(40);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }
        [Test]
        public void CheckIfAddGradeInLetterWorks()
        {
            var employee = new EmployeeInMemory("Marta", "Nowak");
            employee.AddGrade('a');
            employee.AddGrade('C');
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(55, statistics.Average);
        }

        [Test]
        public void MinValueTest()
        {
            var employee = new EmployeeInMemory("Ela", "Karolewska");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);

            Statistics statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Min);

        }

        [Test]

        public void AverageValueTest()
        {
            var employee = new EmployeeInMemory("Ela", "Karolewska");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);

            Statistics statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Average);
        }


        private EmployeeInMemory GetEmployee(string name, string surname)
        {
            return new EmployeeInMemory(name, surname);

        }
    }
}
