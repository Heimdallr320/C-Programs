using Lab.Rab1.Model;
using System;
using System.Text;

namespace Lab.Rab1.Util
{
    public class Convert
    {
        public static StringBuilder ConvertComputerListToString(Computer[] computers)
        {
            StringBuilder listComputers = new StringBuilder();

            foreach (Computer computer in computers)
            {
                listComputers.Append("\n" +computer + "".PadLeft(35, '='));
            }

            return listComputers;
        }
    }
}
