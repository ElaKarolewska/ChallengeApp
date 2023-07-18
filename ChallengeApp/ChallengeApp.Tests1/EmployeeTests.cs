namespace ChallengeApp.Tests1
{
    public class EmployeeTests
    {

        [Test]
        public void WhenScoreAreGranted_ShouldReturnSum()
        {
            var empl1 = new Employee("Justyna", "Kowalska", 38);
            
            empl1.AddScore(5);
            empl1.AddScore(3);
            empl1.AddScore(8);

            var result1 = empl1.Result;

            Assert.AreEqual(16, result1);

        }

        [Test]

        public void WhenScoreAreDeducted_ShouldReturnSum() 
        {
            var empl2 = new Employee("Madalena", "Nowak", 42);

            empl2.AddScore(9);
            empl2.AddScore(-5);
            empl2.AddScore(2);

            var result2 = empl2.Result;

            Assert.AreEqual(6, result2);
        
        }    
         
            
      
        
    }
}