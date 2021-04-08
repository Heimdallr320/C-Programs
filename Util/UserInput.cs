using System;

namespace Lab.Rab1.Util
{
    class UserInput
    {
        public static string Input(String msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

    }
}
