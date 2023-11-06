using PetrolStationCounter;

Console.WriteLine("Welcome in PetroSales program designed for Petrol Stations");
Console.WriteLine("===========================================");
Console.WriteLine();

var petrolStation = new PetrolStationCounterInFile("BP", "Kraków");
petrolStation.LitersAdded += PetrolStationLitersAdded;
void PetrolStationLitersAdded(object sender, EventArgs args)
{
    Console.WriteLine("Fuel amount added!");
}

while(true)
{
    Console.WriteLine("\nChoose type of fueal\nA - 95, B - 98, C - Diesel, D - Diesel Ultimate\nTo quit press Q");
    Console.WriteLine();
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        string fileName = petrolStation.ChooseFile(input);

        Console.WriteLine("Select amount of fuel in liters");
        var litersAdded = Console.ReadLine();
        petrolStation.AddLiters(litersAdded, fileName);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

while (true)
{
    Console.WriteLine("\nChoose type of fuel to display statistics\nA - 95, B - 98, C - ON, D - ON Ultimate\nTo quit press Q");
    Console.WriteLine();
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        string fileName = petrolStation.ChooseFile(input);
        var statistics = petrolStation.GetStatistics(fileName);
        Console.WriteLine($"Average: {statistics.Average}");
        Console.WriteLine($"Min: {statistics.Min}");
        Console.WriteLine($"Max: {statistics.Max}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}