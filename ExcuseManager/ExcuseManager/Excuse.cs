using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExcuseManager
{

    [Serializable]
    class Excuse
    {
        public string CurrentDescription { get; set; }
        public string Results { get; set; }
        public System.DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            Load(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.excuse");
            Load(fileNames[random.Next(fileNames.Length)]);
        }

        public void Save(string excusePath)
        {
            ExcusePath = excusePath;
            BinaryFormatter formatter = new BinaryFormatter();
            using(Stream output = File.OpenWrite(excusePath))
            {
                formatter.Serialize(output, this);
            }
        }

        private void Load(string excusePath)
        {
            ExcusePath = excusePath;
            BinaryFormatter formatter = new BinaryFormatter();
            Excuse tempExcuse;
            using (Stream input = File.OpenRead(excusePath))
            {
                tempExcuse = (Excuse)formatter.Deserialize(input);
            }
            CurrentDescription = tempExcuse.CurrentDescription;
            Results = tempExcuse.Results;
            LastUsed = tempExcuse.LastUsed;
        }

    }
}
