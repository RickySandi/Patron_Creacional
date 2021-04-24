using System;
namespace FactoryMethod
{
    public class Guitar: IInstrument
    {
        public void Play(int notes){
            Console.WriteLine("This guitar plays up to  : " + notes.ToString() + " notes");
        }

        public void Sell(int price){
            Console.WriteLine("This guitar has been sold for  : " + price.ToString() + "$");
        }
    }
}
