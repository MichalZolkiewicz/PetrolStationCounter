using PetrolStationCounter;
using static PetrolStationCounter.PetrolStationCounterInFile;

Console.WriteLine("Witamy w programie XYZ do wprowadzania ilości sprzedanego paliwa");
Console.WriteLine("===========================================");
Console.WriteLine();

var petrolStation = new PetrolStationCounterInFile("BP", "Karków");
petrolStation.LitersAdded += PetrolStationLitersAdded;
void PetrolStationLitersAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano ilość sprzedanego paliwa!");
}

while(true)
{
    Console.WriteLine("Wybierz rodzaj paliwa\nA - 95, B - 98, C - ON, D - ON Ultimate\nAby wyjść wybierz Q");
    var input = Console.ReadLine();
    string fileName = petrolStation.ChooseFile(input);
    
    Console.WriteLine("Wprowadz ilość sprzedanego paliwa");
    var litersAdded = Console.ReadLine();

    try
    {
        petrolStation.AddLiters(litersAdded, fileName);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}