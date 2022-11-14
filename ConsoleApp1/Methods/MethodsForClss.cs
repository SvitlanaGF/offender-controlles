using System.Xml.Serialization;

namespace ConsoleApp1.Methods
{
    internal class MethodsForClss
    {
        public string rand_str() //random string generator
        {
            Random random = new Random();
            string str = "";
            for (int j = 0; j < random.Next(5, 15); j++)
            {
                str += Convert.ToChar(random.Next(48, 91));
            }
            return str;
        }
        public List<Driver.Driver> dr_list(int n)
        {
            List<Driver.Driver> drivers = new List<Driver.Driver>();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                List<string> TypeOfAuto = new List<string>() { "Car", "Truck", "Bus"};
                TimeOnly start = new TimeOnly(random.Next(1, 24), random.Next(1, 60));
                string numberofautomobile = rand_str();
                string tf = TypeOfAuto[random.Next(0,3)];
                double speed = random.Next(0,100) + random.NextDouble();
                Driver.Driver dr = new Driver.Driver(start, tf, numberofautomobile, speed);
                drivers.Add(dr);
            }
            return drivers;


        }
    }
}
