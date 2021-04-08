using System.Text;

namespace Lab.Rab1.Model
{
    public class Manager
    {
        public static decimal CalculateAvgCost(Store store)
        {
            decimal costAllComputer = 0;

            foreach(Computer computer in store.Computers)
            {
                costAllComputer += computer.Cost;
            }

            decimal avgCost = 0;

            if(costAllComputer != 0)
            {
                avgCost = costAllComputer / store.Computers.Length;
            }

            return avgCost;
        }

        public static decimal DetermineHighestPrice(Store store)
        {
            decimal highestPrice = 0;

            if (store.Computers.Length != 0)
            {
                highestPrice = store.Computers[0].Cost;
            }

            foreach(Computer computer in store.Computers)
            {
                if(computer.Cost>highestPrice)
                {
                    highestPrice = computer.Cost;
                }
            }
            return highestPrice;
        }

        public static decimal DetermineLowestPrice(Store store)
        {
            decimal lowestPrice = 0;

            if (store.Computers.Length != 0)
            {
                lowestPrice = store.Computers[0].Cost;
            }

            foreach (Computer computer in store.Computers)
            {
                if (computer.Cost < lowestPrice)
                {
                    lowestPrice = computer.Cost;
                }
            }
            return lowestPrice;
        }

        public static Computer[] PrintComputersHigherAvgCost(Store store)
        {
            decimal avgCost = CalculateAvgCost(store);
            int countComputers = 0;

            for(int i = 0; i<store.Computers.Length; i++)
            {
                if(store.Computers[i].Cost > avgCost)
                {
                    countComputers++;
                }
            }

            Computer[] computers = new Computer[countComputers];

            int j = 0;

            for (int i = 0; i<store.Computers.Length; i++)
            {
                if(store.Computers[i].Cost > avgCost)
                {
                    computers[j] = store.Computers[i];
                    j++;
                }
            }

            return computers;
        }

        public static Computer[] PrintComputersSatisfyingBuyerPrice(Store store, decimal price)
        {
            int countComputers = 0;

            for (int i = 0; i < store.Computers.Length; i++)
            {
                if (store.Computers[i].Cost < price)
                {
                    countComputers++;
                }
            }

            Computer[] computers = new Computer[countComputers];

            int j = 0;

            for (int i = 0; i < store.Computers.Length; i++)
            {
                if (store.Computers[i].Cost < price)
                {
                    computers[j] = store.Computers[i];
                    j++;
                }
            }

            return computers;
        }
    }
}
