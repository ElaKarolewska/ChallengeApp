using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny kierowników.");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new EmployeeInFile("Ela", "Karolewska");
employee.AddGrade(12);
employee.AddGrade(8);
employee.AddGrade(0.5);
employee.AddGrade(100);



//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę kierownika: ");
//    var input = Console.ReadLine();

//    if (input == "q")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched:{e.Message}");
//    }

//}

//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine(statistics.AverageLetter);

