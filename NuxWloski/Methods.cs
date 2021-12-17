using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxWloski
{
    public static class Methods
    {
        public static List<Word> words = new List<Word>();
        public static Word SelectedWord;
        public static int Language; // 0 ITA 1 Pol
        public static void LoadData() 
        {
            var reader = new StreamReader(@"Dictionary.csv");
            while (!reader.EndOfStream) 
            {
                var line =reader.ReadLine();
                var values = line.Split(',');
                words.Add(new Word(values[0], values[1]));
            }
        }
    }
}
