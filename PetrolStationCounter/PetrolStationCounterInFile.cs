namespace PetrolStationCounter
{
    public class PetrolStationCounterInFile : BasePetrolStationCounter
    {
        public override event LitersAddedDelegate LitersAdded;

        private const string petrol95File = "95.txt";
        private const string petrol98File = "98.txt";
        private const string dieselFile = "ON.txt";
        private const string dieselUltimateFile = "Ulti.txt";

        public PetrolStationCounterInFile(string name, string location)
            : base(name, location)
        {
        }
        
        public override void AddLiters(double liters, string type)
        {
            if (liters > 0)
            {
                using (var writer = File.AppendText(type))
                {
                    writer.WriteLine(liters);
                    if (LitersAdded != null)
                    {
                        LitersAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddLiters(string liters, string type)
        {
            if(double.TryParse(liters, out double result))
            {
                this.AddLiters(result, type);
            }
            else
            {
                throw new Exception("String is not a double!");
            }
        }      

        public String ChooseFile(string input)
        {
            string fileName = "";

            switch (input)
            {
                case "A":
                case "a":
                    fileName = petrol95File;
                    break;
                case "B":
                case "b":
                    fileName = petrol98File;
                    break;
                case "C":
                case "c":
                    fileName = dieselFile;
                    break;
                case "D":
                case "d":
                    fileName = dieselUltimateFile;
                    break;
                default:
                    throw new Exception("Wrong letter!");
            }

            return fileName;
        }

        private List<double> GetLitersFromFile(string type)
        {
            var liters = new List<double>();
            if(File.Exists(type))
            {
                using(var reader = File.OpenText(type))
                {
                    var line = reader.ReadLine();
                    while(line != null)
                    {
                        double liter = double.Parse(line);
                        liters.Add(liter);
                        line = reader.ReadLine();
                    }
                }
            }
            return liters;
        }

        public override Statistics GetStatistics(string type)
        {
            var litersFromFile = this.GetLitersFromFile(type);
            var statistics = new Statistics();
            
            foreach(var liter in litersFromFile)
            {
                statistics.AddLiters(liter);
            }
            return statistics;
        }
    }
}
