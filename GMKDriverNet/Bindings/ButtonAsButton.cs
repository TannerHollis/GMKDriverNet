using GMKDriverNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMKDriverNET.Bindings
{
    public class ButtonAsButton
    {
        public ButtonIO input { get; set; }
        public ButtonIO output { get; set; }

        override public string ToString()
        {
            return input.ToString() + " -> " + output.ToString();
        }

        public ButtonAsButton(ButtonIO input, ButtonIO output)
        {
            this.input = input;
            this.output = output;
        }
    }
}
