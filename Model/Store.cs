using System.Text;

namespace Lab.Rab1.Model
{
    public class Store
    {
        public const string DEFAULT_NAME_STORE = "Socet.by";
        public const string DEFAULT_LOCATION = "Gomel";
        public Computer[] Computers { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Store()
        {
            Computers = new Computer[0];
        }
        public Store(Computer[] computers, string location = DEFAULT_LOCATION, string name = DEFAULT_NAME_STORE)
        {
            Computers = computers;
            Location = location;
            Name = name;
        }

        public int GetSizeComputers()
        {
            return Computers.Length;
        }
        public override string ToString()
        {
            StringBuilder listComputers = new StringBuilder();

            listComputers.Append("Name of Store:").Append(Name).Append("\n");
            listComputers.Append("Location of Store: ").Append(Location).Append("\n");
            listComputers.Append("List of Computers: \n");

            if (GetSizeComputers() == 0)
            {
                listComputers.Append("No computers in store!\n");
            }
            else
            {
                listComputers.Append(Util.Convert.ConvertComputerListToString(Computers));
            }
            return listComputers + "";
        }


    }
}
