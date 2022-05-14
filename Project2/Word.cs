using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    
    public class Word
    {
        string word;

        public int Length()
        {
            return word.Length;
        }

        public string Convert(string w)
        {
            string word = w.ToUpper();
            return word;
        }
        public Word()
        {

        }

    }
}
