using System;
using PudelkoLib;


namespace PudelkoApp
{
    public static class NewPudelko
    {
        public static Pudelko Kompresuj(this Pudelko pudelko)
        {
            double size = Math.Cbrt(pudelko.Objetosc);

            return new Pudelko(size, size, size);
        }
    }
}