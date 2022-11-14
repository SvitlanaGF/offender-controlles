

using System.Xml.Serialization;

namespace ConsoleApp1.WorkWithFiles
{
    public class FileXMLWorker
    {
        private string _filepath { get; set; }
        public FileXMLWorker()
        {
            _filepath = "MyFile.xml";
        }

        public FileXMLWorker(string filepath)
        {
            _filepath = filepath;
        }
        public List<Driver.Driver> readfile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Driver.Driver[]));
            
            using (Stream reader = new FileStream(_filepath, FileMode.Open))
            {
                var drivers = (Driver.Driver[])serializer.Deserialize(reader);
                return drivers.ToList();
            }
        }

        public void writeinfile(string information)
        {
            using(StreamWriter sr = new StreamWriter(_filepath))
            {
                sr.WriteLine(information);
            }
        }
        public void writeinfile(List<Driver.Driver> drivers)
        {
            var arrdrivers = drivers.ToArray();
            var arrSerializer = new XmlSerializer(typeof(Driver.Driver[]));
            using (var writer = new StreamWriter(_filepath))
            {
                arrSerializer.Serialize(writer, arrdrivers);
            }
        }
        public void writeinfile(Driver.Driver driver)
        {
            
            var drSerializer = new XmlSerializer(typeof(Driver.Driver));
            using (var writer = new StreamWriter(_filepath))
            {
                drSerializer.Serialize(writer, driver);
            }
        }
    }
}
