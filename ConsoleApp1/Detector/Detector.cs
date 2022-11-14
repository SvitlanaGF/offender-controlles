
using ConsoleApp1.WorkWithFiles;
using System.Linq.Expressions;

namespace ConsoleApp1.Detector
{
    internal class Detector
    {
        private List<Driver.Driver> offenders = new List<Driver.Driver>();
        public Action<Driver.Driver> detectorEvent = delegate { };
        public int count = 0;
        public Detector()
        {

        }

        public void readoffenders(FileXMLWorker fileXML)
        {
            var drivers = fileXML.readfile();
            foreach(Driver.Driver driver in drivers)
            {
                if( driver.Speed >= 50)
                {
                    offenders.Add(driver);
                    detectorEvent(driver);
                    writetostatistic(driver);
                    writeoffender(driver);
                    count += 1;

                }
            }
        }
        public void writetostatistic(Driver.Driver driver)
        {
            var fileXML = new FileXMLWorker("static.txt");
            fileXML.writeinfile(driver.ToString());

        }
        public void writeoffender(Driver.Driver driver)
        {
            var fileXML = new FileXMLWorker("offenders.xml");
            fileXML.writeinfile(driver);

        }



    }
}
