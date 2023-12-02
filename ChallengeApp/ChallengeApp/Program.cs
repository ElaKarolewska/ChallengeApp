using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników.\n" + "=======================================\n" + "");
Console.WriteLine("Podaj imię pracownika:");
var name = Console.ReadLine();
Console.WriteLine("Podaj nazwisko pracownika:");
var surname = Console.ReadLine();

var employee = new EmployeeInFile(name, surname); 
var employee1 = new EmployeeInMemory(name, surname) ;
employee.GradeAdded += EmployeeGradeAdded;
//var supervisor = new Supervisor(name, surname);

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine($"Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine($"Podaj kolejną ocenę pracownika {employee. Name} {employee.Surname} \n lub naciśnij q żeby zakończyć: ");
    var input = Console.ReadLine();

    if (input.ToLower() == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched:{e.Message}");
    }

}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine(statistics.AverageLetter);

