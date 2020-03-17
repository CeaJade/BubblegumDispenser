using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblegumDispenser
{
    class Dispenser
    {
        private Bubblegum dispenseGum;
        private GumContainer gumContainer;

        public GumContainer GumContainer
        {
            get { return gumContainer; }
            set { gumContainer = value; }
        }

        public Dispenser(GumContainer container)
        {
            this.gumContainer = container;
        }

        
        public Bubblegum DispenseGum()
        {
            Random dispence = new Random();
            int dispenceGum = dispence.Next(0, GumContainer.Bubblegum.Count);
            this.dispenseGum = GumContainer.Bubblegum[dispenceGum];
            GumContainer.Bubblegum.RemoveAt(dispenceGum);
            return this.dispenseGum;
        }
    }
}
