using ChallengeApp;

Console.WriteLine("Witamy w programie WYZ do oceny pracowników.");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee("Ela", "Karolewska");

while (true) 
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();

    if (input == "q") 
    {
        break;
    }

    employee.AddGrade(input);

}

var statistics = employee.GetStatistics(); 
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine(statistics.AverageLetter);

