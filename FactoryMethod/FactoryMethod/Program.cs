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

            IInstrument piano = factory.GetInstrument("Piano");
            piano.Play(80);

            Console.ReadKey();
        }
    }
}
