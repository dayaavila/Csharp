using System;

namespace Ducks
{
    class DecoyDock : Duck
    {
        public override void Quack()
        {
            throw new Exception();
        }

        //Se borra ya que al usar la composicion, este metod se crea en la clases FlyNoWay y FlyWithWings y en Duck como SetFlyNoWay
        // public override void Fly()
        // {
        //     throw new Exception();
        // }

        public override void Display()
        {
             Console.WriteLine("I am a decoy duck");
        }

    }

}
