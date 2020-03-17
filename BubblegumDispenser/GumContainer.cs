using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblegumDispenser
{
    class GumContainer
    {
        private List<Bubblegum> bubblegum;
        private bool isFull;

        public List<Bubblegum> Bubblegum
        {
            get { return bubblegum; }
            set { bubblegum = value; }
        }

        public bool IsFull
        {
            get { return isFull; }
            set { isFull = value; }
        }

        public GumContainer(bool isFull, int numOfGumBlue, int numOfGumPurple, int numOfGumYellow,
            int numOfGumOrange, int numOfGumRed, int numOfGumGreen)
        {
            this.IsFull = isFull;
            Bubblegum = new List<Bubblegum>();
            if (isFull)
            {
                
                for (int i = 0; i < numOfGumBlue; i++)
                {
                    Bubblegum.Add(new Bubblegum("Blueberry"));                   
                }
                for (int i = 0; i < numOfGumPurple; i++)
                {
                    Bubblegum.Add(new Bubblegum("Blackberry"));                    
                }
                for (int i = 0; i < numOfGumYellow; i++)
                {
                    Bubblegum.Add(new Bubblegum("Tutti-Frutti"));                 
                }
                for (int i = 0; i < numOfGumOrange; i++)
                {
                    Bubblegum.Add(new Bubblegum("Orange"));                
                }
                for (int i = 0; i < numOfGumRed; i++)
                {
                    Bubblegum.Add(new Bubblegum("Strawberry"));                
                }
                for (int i = 0; i < numOfGumGreen; i++)
                {
                    Bubblegum.Add(new Bubblegum("Apple"));
                }
            }
        }


        public int CountByType(string type)
        {
            int count = 0;
            for (int i = 0; i < Bubblegum.Count(); i++)
            {
                if (Bubblegum[i].Type == type)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
