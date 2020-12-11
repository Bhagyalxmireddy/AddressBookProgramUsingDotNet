using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBook
{
    public class FileRead_Write
    {
        public void WriteText(string fileName ,List<ContactPerson> addressbook)
        {
            string path = @"C:\Users\USER\source\repos\AddressBook\" + fileName;
            StreamWriter writer = new StreamWriter(path);
            string[] a = { "firstName", "lastName", "address", "city", "state", "zip", "phoneNumber" };
            string c = string.Join(",", a);
            writer.WriteLine(c);
            for (int num = 0; num < addressbook.Count; num++)
            {
                ContactPerson index = addressbook[num];
                string[] b = { index.firstName, index.lastName, index.address,  index.city, index.state, index.zip, index.phoneNumber };
                string d = string.Join(",", b);
                writer.WriteLine(d);

            }
            writer.Flush();
            writer.Close();
        }
        public List<ContactPerson> ReadData(string fileName)
        {
            string path = @"C:\Users\USER\source\repos\AddressBook\" + fileName;
            StreamReader reader = new StreamReader(path);
            List<ContactPerson> person = new List<ContactPerson>();
            string line = null;
            int lineNum = 0;
            while ((line = reader.ReadLine()) != null)
            {
                lineNum = lineNum + 1;
                if (lineNum != 1)
                {
                    string[] value = line.Split(",");
                    person.Add(new ContactPerson(value[0], value[1], value[2], value[3], value[4], value[5], value[6]));
                }
            }
            reader.Close();
            return person;
        }
        public void ShowFiles()
        {
            string path = @"C:\Users\USER\source\repos\AddressBook\";
            string[] array = Directory.GetFiles(path, "*.txt");
            string[] arrayJson = Directory.GetFiles(path, "*.json");
            foreach (string file in array)
                Console.WriteLine(Path.GetFileName(file));
            foreach (string file in arrayJson)
                Console.WriteLine(Path.GetFileName(file));
        }
        public void WriteToJson(string filename, List<ContactPerson> person)
        {
            string path = @"C:\Users\USER\source\repos\AddressBook\" + filename;
            string json = JsonConvert.SerializeObject(person.ToArray());
            File.WriteAllText(path, json);
        }
        public List<ContactPerson> ReadFromJson(string filename)
        {
            string path = @"C:\Users\USER\source\repos\AddressBook\" + filename;
            string jsonFile = File.ReadAllText(path);
            List<ContactPerson> person = JsonConvert.DeserializeObject<List<ContactPerson>>(jsonFile);
            return person;
        }
    }
}
