using System;

namespace Ducks
{
    public class RubberDuck : Duck
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
            Console.WriteLine("I am rubber duck");
        }
    }
}