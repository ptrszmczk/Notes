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
        public string Date { get; set; }

        public void WriteToFile()
        {
            File.AppendAllText(filePath, $"{this.Title}~#{this.Content}~#{this.Date}~~");
        }

        public List<NoteData> ReadFromFile()
        {
            if (File.Exists(filePath))
            {
                string allText = File.ReadAllText(filePath);
                List<string> lines = allText.Split(new[] { "~~" }, StringSplitOptions.None).ToList();

                if (lines != null)
                {
                    foreach (string line in lines)
                    {
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            string[] li = line.Split(new[] { "~#" }, StringSplitOptions.None);

                            NoteData data = new NoteData();
                            data.Title = li[0];
                            data.Content = li[1];
                            data.Date = li[2];
                            allData.Add(data);
                        }
                    }
                }
            }

            return allData;
        }
    }
}
