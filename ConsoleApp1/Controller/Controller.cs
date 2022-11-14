

using ConsoleApp1.Driver;
using ConsoleApp1.WorkWithFiles;

namespace ConsoleApp1.Controller
{
    internal class Controller
    {
        private List<Driver.Driver> offenders = new List<Driver.Driver>();
        private readonly Detector.Detector detector;
        private Dictionary<int, List<Driver.Driver>> offendersByHours = new Dictionary<int, List<Driver.Driver>>();
        public void Start()
        {
            detector.detectorEvent += detectoffender;
        }
        public void detectoffender(Driver.Driver driver)
        {
            FileXMLWorker fileXML = new FileXMLWorker();
            var drivers = fileXML.readfile();
            if (driver.Speed >= 50)
                {
                    offenders.Add(driver);
                    writeoffender(driver);
              
                    if(offendersByHours.ContainsKey(driver.hour.Hour) == false)
                    {
                          
                        offendersByHours.Add(driver.hour.Hour, drivers.Where(s => s.hour.Hour == driver.hour.Hour).ToList());
                     
                    }

                }
            foreach(KeyValuePair<int, List<Driver.Driver>> entry in offendersByHours)
            {
                writetostatistic($"{entry.Key}--{entry.Value.Count}");
            }
            
        }
        public void writeoffender(Driver.Driver driver)
        {
            var fileXML = new FileXMLWorker("offendersforcontroller.xml");
            fileXML.writeinfile(driver);

        }
        public void writetostatistic(Driver.Driver driver)
        {
            var fileXML = new FileXMLWorker("static.txt");
            fileXML.writeinfile(driver.ToString());

        }
        public void writetostatistic(string driver)
        {
            var fileXML = new FileXMLWorker("static.txt");
            fileXML.writeinfile(driver);

        }

    }
}
