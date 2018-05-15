using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask2.Unit
{
    public class WordUnit : TextUnit
    {
        public WordUnit(string word)
        {
            Text = word;
        }

        private int lenght;
        public int Lenght
        {
            get { return Text.Length; }
        }
    }
}
