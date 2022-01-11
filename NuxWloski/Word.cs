using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxWloski
{
    public class Word
    {
        public string Italian { get; set; }
        public string Polish { get; set; }
        public int CorrectAttempts { get; set; } = 0;
        public int WrongAttempts { get; set; } = 0; 
        public Word(string Italian, string Polish) 
        {
            this.Italian = Italian;
            this.Polish = Polish;   
        }
    }
}
