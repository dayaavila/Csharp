using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializamos
            List<Duck> listDucks = new List<Duck>();

            //Creamos los objetos
            listDucks.Add(new MallarDuck());
            listDucks.Add(new RedheadDuck());
            listDucks.Add(new RubberDuck());
            listDucks.Add(new DecoyDock());

            //Itineraremos
            foreach (var duck in listDucks)
            {
                duck.Quack();
                duck.Swim();
                duck.Fly();
            }
        }
    }
}
