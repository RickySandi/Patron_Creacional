﻿using System;
namespace FactoryMethod
{
    public class Piano : IInstrument
    {
        public void Play(int notes)
        {
            Console.WriteLine("This piano plays up to  : " + notes.ToString() + " notes");
        }

        public void Sell(int price)
        {
            Console.WriteLine("This piano has been sold for  : " + price.ToString() + "$");
        }
    }
}
