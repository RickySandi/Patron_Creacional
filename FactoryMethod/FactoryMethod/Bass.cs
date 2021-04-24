using System;
namespace FactoryMethod
{
    public class Bass : IInstrument
    {
        public void Play(int notes)
        {
            Console.WriteLine("This bass plays up to  : " + notes.ToString() + " notes");
        }

        public void Sell(int price)
        {
            Console.WriteLine("This bass has been sold for  : " + price.ToString() + "$");
        }
    }
}
