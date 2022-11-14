

using ConsoleApp1.Methods;

namespace ConsoleApp1.Driver
{
    public class Driver
    {
        public TimeOnly hour { get; set; } 
        public string NumberOfAuto { get; set; }
        public string TypeOfAuto { get; set; }
        public double Speed { get; set; }
        public Driver() { }
public Driver(TimeOnly hour, string numberOfAuto, string typeOfAuto, double speed)
        {
            this.hour = hour;
            NumberOfAuto = numberOfAuto;
            TypeOfAuto = typeOfAuto;
            Speed = speed;
        }
    }
}
