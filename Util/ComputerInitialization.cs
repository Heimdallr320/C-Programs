using Lab.Rab1.Model;
using System;

namespace Lab.Rab1.Util
{
    class ComputerInitialization
    {
        public static readonly string[] namesOfModel = {"DESKTOP-NN32","DESKTOP-NL23","DESKTOP-GH56","DESCTOP-99LS","DESKTOP-67JK"};
        public static readonly string[] namesOfProcessor = { "Intel", "AMD" };
        public static readonly string[] namesOfGraphicsCard = { "Nvidia", "Radeon" };  // названия константными

        public const int MAX_YEAR = 2021;
        public const int MIN_YEAR = 1981;
        public const int MIN_MEMORY = 2;
        public const int MAX_MEMORY = 64;
        public const int MIN_POWER = 100;
        public const int MAX_POWER = 500;
        public const int MIN_COST = 500;
        public const int MAX_COST = 5000;

        public static void Initialization(Store store)
        {
            Random random = new Random();

            foreach (Computer computer in store.Computers)
            {
                computer.Model = namesOfModel[random.Next(namesOfModel.Length)];
                computer.Processor = namesOfProcessor[random.Next(namesOfProcessor.Length)];
                computer.GraphicsCard = namesOfGraphicsCard[random.Next(namesOfGraphicsCard.Length)];
                computer.Power = random.Next(MIN_POWER, MAX_POWER);
                computer.Cost = random.Next(MIN_COST,MAX_COST);
                computer.Year = random.Next(MIN_YEAR, MAX_YEAR);
                computer.Memory = random.Next(MIN_MEMORY,MAX_MEMORY);
            }
        }
    }
}
