using Lab.Rab1.Model;
using Lab.Rab1.Util;
using Lab.Rab1.View;
using System;
using System.Text;

namespace Lab.Rab1.Controller
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int size;

            bool checkSize;
            do
            {
                checkSize = Int32.TryParse(UserInput.Input("Enter the count of computers: "), out size);
            }
            while (checkSize != true || size < 1);

            Store store = new Store(ComputerCreator.CreateComputers(size));
            ComputerInitialization.Initialization(store);

            decimal customerPrice;
            bool checkCustomerPrice;
            do
            {
                checkCustomerPrice = Decimal.TryParse(UserInput.Input("Enter your maximum price: "), out customerPrice);
            }
            while (checkCustomerPrice != true || customerPrice < 1);

            Printer.Print($"============== Store ==============\n" +
                          $"{store.ToString()}\n" +
                          $"\nMost expensive computer: {Manager.DetermineHighestPrice(store)}\n" +
                          $"Сheapest computer: {Manager.DetermineLowestPrice(store)}\n" +
                          $"Average cost of all computers: {Manager.CalculateAvgCost(store)}\n" +
                          $"\nComputers that higher average cost: \n{Util.Convert.ConvertComputerListToString(Manager.PrintComputersHigherAvgCost(store))}\n" +
                          $"\nComputers that you can buy: \n{Util.Convert.ConvertComputerListToString(Manager.PrintComputersSatisfyingBuyerPrice(store,customerPrice))}");

            Console.ReadKey();
        }
    }
}
