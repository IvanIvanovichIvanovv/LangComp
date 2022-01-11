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
            var readerStat = new StreamReader("Statistics.csv");
            int i = 0;
            while (!reader.EndOfStream) 
            {
                var line =reader.ReadLine();
                var values = line.Split(',');
                words.Add(new Word(values[0], values[1]));
            }
            while (!readerStat.EndOfStream)
            {
                var lineS = readerStat.ReadLine();
                var valuesS = lineS.Split(',');
                words[i].CorrectAttempts = Convert.ToInt32(valuesS[0]);
                words[i].WrongAttempts = Convert.ToInt32(valuesS[1]);
            }
        }
        public static void SaveData() 
        {

        }
    }
}
