using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Notes.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Notes.DataManagement
{
    public class NoteData
    {
        public string filePath = @"..\Notes.txt";
        List<NoteData> allData = new List<NoteData>();
        List<string> outputData = new List<string>();

        public string Title { get; set; }
        public string Content { get; set; }

        public void WriteToFile()
        {
            File.AppendAllText(filePath, $"{this.Title}~{this.Content}");
        }

        public List<NoteData> ReadFromFile()
        {
            if (File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                foreach (string line in lines)
                {
                    string[] li = line.Split('~');

                    NoteData data = new NoteData();
                    data.Title = li[0];
                    data.Content = li[1];
                    allData.Add(data);
                }
            }

            return allData;
        }
    }
}
