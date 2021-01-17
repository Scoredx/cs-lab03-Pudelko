using System;
using System.Collections;
using System.Collections.Generic;


namespace PudelkoLib
{
    class PEnumerator : IEnumerator<double>
    {
        private readonly Pudelko pudelko;
        private int index = 0;

        public PEnumerator(Pudelko pudelko)
        {
            this.pudelko = pudelko;
        }

        public double Current => pudelko[index++];

        object IEnumerator.Current => pudelko[index++];


        //===================
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return index <= 1;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
