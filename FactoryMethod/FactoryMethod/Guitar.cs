using System;
namespace FactoryMethod
{
    public class Guitar: IInstrument
    {
        public void Play(int notes)
        {
            Console.WriteLine("This guitar plays up to  : " + notes.ToString() + "notes");
        }
    }
}
