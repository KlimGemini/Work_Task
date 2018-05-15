using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask2.Unit
{
    public abstract class TextUnit
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
