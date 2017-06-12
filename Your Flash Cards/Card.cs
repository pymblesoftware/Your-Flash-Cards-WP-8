using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Your_Flash_Cards
{
    public abstract class Card
    {
        // public abstract void write();
        // public abstract void read();

        // Front of card data.

        // Back of card data.


        public abstract void presentFront();
        public abstract void presentBack();

        public virtual void write(string setName )
        {

        }

        public virtual void read(string setName)
        {
           
        }
    }
}
