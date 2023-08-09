using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny kierowników.");
Console.WriteLine("============================================");
Console.WriteLine();

var supervisor = new Supervisor("Ela", "Karolewska");

while (true) 
{
    Console.WriteLine("Podaj kolejną ocenę kierownika: ");
    var input = Console.ReadLine();

    if (input == "q") 
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched:{e.Message}");
    }
    
}

var statistics = supervisor.GetStatistics(); 
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine(statistics.AverageLetter);

