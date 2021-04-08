namespace Lab.Rab1.Model
{
    public class Computer
    {
        public const int MAX_YEAR = 2021;
        public const int MIN_YEAR = 1981;
        public const int MIN_MEMORY = 2;
        public const int MAX_MEMORY = 64;
        public const int MIN_POWER = 100;
        public const int MAX_POWER = 500;
        public const int MIN_COST = 500;
        public const int MAX_COST = 5000;

        public const int DEFAULT_MEMORY = 4;
        public const int DEFAULT_YEAR = 2018;
        public const int DEFAULT_POWER = 120;
        public const int DEFAULT_COST = 890;
        public const string DEFAULT_MODEL = "DESKTOP-USER";
        public const string DEFAULT_PROCESSOR = "Intel";
        public const string DEFAULT_GRAPHICS_CARD = "Nvidia";

        private int year;
        private int memory;
        private int power;
        private decimal cost;

        public string Model { get; set; }
        public string Processor { get; set; }
        public string GraphicsCard { get; set; }

        public Computer(){ }

        public Computer(string model = DEFAULT_MODEL, string processor = DEFAULT_PROCESSOR, string graphicsCard = DEFAULT_GRAPHICS_CARD,
                        int memory = DEFAULT_MEMORY, int year = DEFAULT_YEAR, int power = DEFAULT_POWER, int cost = DEFAULT_COST)
        {
            Model = model;
            Processor = processor;
            GraphicsCard = graphicsCard;
            Memory = memory;
            Year = year;
            Power = power;
            Cost = cost;
        }
        public int Memory
        {
            get => memory;
            set
            {
                if (value >= MIN_MEMORY && value <= MAX_MEMORY)
                {
                    memory = value;
                }
            }
        }
        public int Year
        {
            get => year;
            set
            {
                if (value >= MIN_YEAR && value <= MAX_YEAR)
                {
                    year = value;
                }
            }
        }

        public int Power
        {
            get => power;
            set
            {
                if (value >= MIN_POWER && value <= MAX_POWER)
                {
                    power = value;
                }
            }
        }

        public decimal Cost
        {
            get => cost;
            set
            {
                if (value > MIN_COST && value < MAX_COST)
                {
                    cost = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Computer model: {Model}\nProcessor: {Processor}\n"+
                $"Graphics card: {GraphicsCard}\nMemory: {Memory}\n" +
                $"Build Date: {Year}\nEnergy Consumption: {Power}\n" +
                $"BYN: {Cost}\n";
        }
    }
}
