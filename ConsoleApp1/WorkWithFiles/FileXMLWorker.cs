

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
        public string readfile()
        {
            using(StreamReader sr = new StreamReader(_filepath))
            {
                return sr.ReadToEnd();
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
    }
}
