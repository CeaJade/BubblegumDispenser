using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblegumDispenser
{
    class GumMachine
    {
        private GumContainer container;
        private Dispenser dispencer;
        private Handle handle;

        public GumContainer Container
        {
            get { return container; }
            set { container = value; }
        }

        public Dispenser Dispencer
        {
            get { return dispencer; }
            set { dispencer = value; }
        }

        public Handle Handle
        {
            get { return handle; }
            set { handle = value; }
        }

        public GumMachine(bool isFull, bool handleTurned)
        {
            this.container = new GumContainer(isFull, 1, 1, 1, 1, 1, 1);
            this.dispencer = new Dispenser(this.Container);
            this.handle = new Handle(handleTurned);
        }
    }
}
