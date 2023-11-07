namespace PetrolStationCounter
{
    public class Statistics
    {
        public double Min { get; private set; }
        public double Max { get; private set; }
        public double Sum { get; private set; }
        public int Count { get; private set; }
        public double Average
        {
            get
            {
                return this.Sum/this.Count;
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min = double.MaxValue;
            this.Max = double.MinValue;
        }

        public void AddLiters(double liters)
        {
            this.Count++;
            this.Sum += liters;
            this.Min = Math.Min(liters, this.Min);
            this.Max = Math.Max(liters, this.Max); 
        }
    }
}
