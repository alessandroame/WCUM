using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var institute = new Institute();
            institute.Name = "Paradiso";
            institute.Plexus = new List<Plexus>();

            var plexus1 = new Plexus();
            plexus1.Name = "Anna Frank";

            institute.Plexus.Add(plexus1);

            var c1 = new Class();
            c1.Name = "1a";
            var c2 = new Class();
            c2.Name = "2a";

            plexus1.Classes = new List<Class>();
            plexus1.Classes.Add(c1);
            plexus1.Classes.Add(c2);

            var json = JsonConvert.SerializeObject(institute);
            File.WriteAllText("institute.json", json);

            /*var json = File.ReadAllText("test.json");
            var plexus = JsonConvert.DeserializeObject<Plexus>(json);*/

            Console.WriteLine("Json file created");
        }
    }
}
