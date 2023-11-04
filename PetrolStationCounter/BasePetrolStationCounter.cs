namespace PetrolStationCounter
{
    public abstract class BasePetrolStationCounter : IPetrolStationCounter
    {
        public delegate void LitersAddedDelegate(object sender, EventArgs args);

        public abstract event LitersAddedDelegate LitersAdded;
        public string Name { get; private set; }
        public string Location { get; private set; }

        public BasePetrolStationCounter(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }

        public abstract void AddLiters(double liters, string fileName);
        public abstract void AddLiters(string liters, string fileName);
        public abstract Statistics GetStatistics(string fileName);
    }
}
