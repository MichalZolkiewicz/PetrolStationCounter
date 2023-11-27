using static PetrolStation.BasePetrolStation;

namespace PetrolStationCounter
{
    public interface IPetrolStationCounter
    {
        string Name { get; }
        string Location { get; }

        void AddLiters(double liters, string type);
        void AddLiters(string liters, string type);
        Statistics GetStatistics(string type);

        event LitersAddedDelegate LitersAdded;
    }
}
