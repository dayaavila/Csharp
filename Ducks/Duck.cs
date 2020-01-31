using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public abstract class Duck
    {
        //Creamos esta propiedades privadas, pasos del uso de la composicion
        private FlyNoWay fnw;
        private FlyWithWings fww;

        //Este es el constructor
        public Duck()
        {

        }
        //Metodos
        public virtual void Quack()
        {
            Console.WriteLine("I am Quackyng");
        }

        public void Swim()
        {
            Console.WriteLine("I am swimming");
        }

        public virtual void Fly()
        {
            Console.WriteLine("I am flying");
        }

        // Estos 2 metodo es usando la composicion
        public void SetFlyNoWay(FlyNoWay fnw)
        {
            this.fnw = fnw;
        }

        public void SetFlyWithWings(FlyWithWings fww)
        {
            this.fww = fww;
        }

        public abstract void Display();

    }
}