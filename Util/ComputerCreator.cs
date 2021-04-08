using Lab.Rab1.Model;

namespace Lab.Rab1.Util
{
    class ComputerCreator
    {
        public const int MIN_COUNT_COMPUTERS = 1;
        public const int MAX_COUNT_COMPUTERS = 25;

        public static Computer[] CreateComputers(int size)
        {

            if (!CheckSizeComputers(size))
            {
                return new Computer[0];
            }

            Computer[] computers = new Computer[size];

            for (int i = 0; i < size; i++)
            {
                computers[i] = new Computer();
            }
            return computers;
        }
        private static bool CheckSizeComputers(int size)
        {
            return size >= MIN_COUNT_COMPUTERS & size <= MAX_COUNT_COMPUTERS;
        }
    }
}
