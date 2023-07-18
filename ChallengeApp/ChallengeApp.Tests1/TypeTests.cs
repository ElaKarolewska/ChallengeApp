
namespace ChallengeApp.Tests1
{
    public class TypeTests
    {
        [Test]
        public void IntAreDifferent() 
        {
            int number1 = 5568;
            int number2 = 8309;


            Assert.AreNotEqual(number1, number2);
        
        }

        [Test]
        public void FloatAreTheSame() 
        {
            float number1 = 1.2485f;
            float number2 = 1.2485f;

            Assert.AreEqual(number1, number2);
        
        }

        [Test]

        public void StringAreDiffrent() 
        {
            string name1 = "Ela";
            string name2 = "Monika";

            Assert.AreNotEqual(name1, name2);
        
        }
        
         [Test]

        public void GetEmployeeShouldReturnDifferentObjects() 
        {
            var empl1 = GetEmployee("Justyna", "Kowalska", 38);
            var empl2 = GetEmployee("Magdalena", "Nowak", 42);


            Assert.AreNotEqual(empl1, empl2);
        
        }

        private Employee GetEmployee(string name,string surname, int age)
         {
            return new Employee(name, surname, age);
        
         }
     }
}
