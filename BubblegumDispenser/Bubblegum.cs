using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblegumDispenser
{
    class Bubblegum
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Bubblegum(string type)
        {
            this.Type = type;
        }
    }
}
