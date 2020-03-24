using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hvor er dine kodekommentar?
namespace BubblegumDispenser
{
    class Dispenser
    {
        private Bubblegum dispenseGum;
        private GumContainer gumContainer;

        public GumContainer GumContainer
        {
            get { return gumContainer; }
            //Skal denne være public?
            set { gumContainer = value; }
        }

        public Dispenser(GumContainer container)
        {
            this.gumContainer = container;
        }

        
        //Flot at du får tyggegummiet ud af maskinen
        //Og at du indkapsler tyggegummiet
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
