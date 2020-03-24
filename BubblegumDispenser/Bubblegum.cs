using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Hvor er dine kodekommentar?
namespace BubblegumDispenser
{
    class Bubblegum
    {
        private string type;

        public string Type
        {
            get { return type; }
            
            //Skal denne virkelig være public?
            set { type = value; }
        }

        public Bubblegum(string type)
        {
            this.Type = type;
        }
    }
}
