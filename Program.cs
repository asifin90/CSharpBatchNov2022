using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Address
    {
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
           
            Program obj = new Program();
            //obj.DeserializeObject(Directory.GetCurrentDirectory()+ @"\XMLFile1.xml");
            //Employee Serialization/Deserialization
            Console.WriteLine("Generic Serialization/Deserialization");
            Console.WriteLine("-----Serialized Employee Data-----");
            Console.WriteLine("--------------------------------------------------------------------------------");
            SerializeDeserialize<Employee> serializeEmployee;
            Employee employee = new Employee { ID = 1001, Name = "Praveen      Raveendran", Profession = "IT Services" };
            serializeEmployee = new SerializeDeserialize<Employee>();
            string serializedEmployee = serializeEmployee.SerializeData(employee);
            Console.WriteLine("Serialized Employee Data : ");
            Console.WriteLine(serializedEmployee);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("-----Deserialized Employee Data-----");
            Employee deserialiedEmployee = serializeEmployee.DeserializeData(serializedEmployee);
            Console.WriteLine("Employee ID : {0} ,  Name :{1} ,Profession : {2}", deserialiedEmployee.ID, deserialiedEmployee.Name, deserialiedEmployee.Profession);
            Console.WriteLine("--------------------------------------------------------------------------------");
            //Address Serialization/Deserialization

          
        }
    }

    public class SerializeDeserialize<T>
    {
        StringBuilder sbData;
        StringWriter swWriter;
        XmlDocument xDoc;
        XmlNodeReader xNodeReader;
        XmlSerializer xmlSerializer;
        public SerializeDeserialize()
        {
            sbData = new StringBuilder();
        }
        public string SerializeData(T data)
        {
            XmlSerializer employeeSerializer = new XmlSerializer(typeof(T));
            swWriter = new StringWriter(sbData);
            employeeSerializer.Serialize(swWriter, data);
            return sbData.ToString();
        }
        public T DeserializeData(string dataXML)
        {
            xDoc = new XmlDocument();
            xDoc.LoadXml(dataXML);
            xNodeReader = new XmlNodeReader(xDoc.DocumentElement);
            xmlSerializer = new XmlSerializer(typeof(T));
            var employeeData = xmlSerializer.Deserialize(xNodeReader);
            T deserializedEmployee = (T)employeeData;
            return deserializedEmployee;
        }
    }


}
