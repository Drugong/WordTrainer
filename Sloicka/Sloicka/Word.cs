using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloicka
{
    public class Word
    {

        public Word(string lang1, string lang2)
        {
            this.Language1 = lang1;
            this.Language2 = lang2;
        }
        public string Language1 { get; set; }

        public string Language2 { get; set; }
    }
}
