using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblegumDispenser
{
    class Handle
    {
        //Useless handle here to sumilate real life
        private bool turn;

        public bool Turn
        {
            get { return turn; }
            set { turn = value; }
        }

        //Idea to add a click sound playing whenever handle is turned to give it a purpose
        public Handle(bool isTurned)
        {
            this.Turn = isTurned;
        }
    }
}
