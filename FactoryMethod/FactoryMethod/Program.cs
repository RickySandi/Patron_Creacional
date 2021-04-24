using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();

            IInstrument guitar = factory.GetInstrument("Guitar");
            guitar.Play(96);
            guitar.Sell(120);

            IInstrument piano = factory.GetInstrument("Piano");
            piano.Play(80);
            piano.Sell(1000);

            IInstrument bass = factory.GetInstrument("Bass");
            bass.Play(75);
            bass.Sell(150);

            
        }
    }
}
