using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PudelkoLibrary
{
    public sealed class Pudelko : IFormattable, IEquatable<Pudelko>, IEnumerable<double>, IComparable<Pudelko>
    {
        public double X
        {
            get => Convert.ToDouble(x.ToString("0.000"));
            private set { this.x = value; }
        }
        public double Y
        {
            get => Convert.ToDouble(y.ToString("0.000"));
            private set { y = value; }
        }

        public double Z
        {
            get => Convert.ToDouble(z.ToString("0.000"));
            private set { z = value; }
        }

        private double x, y, z;

        private UnitOfMeasure unit { get; set; }

        public double Objetosc { get => Math.Round((this.X * this.Y * this.Z), 9); }

        public double Pole { get => Math.Round(2 * (this.X * this.Y + this.X * this.Z + this.Y * this.Z), 6); }

        public Pudelko(double? x = null, double? y = null, double? z = null, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            this.X = (double)(x != null ? (rndNumber((double)x / (ushort)unit)) : 0.1);
            this.Y = (double)(y != null ? (rndNumber((double)y / (ushort)unit)) : 0.1);
            this.Z = (double)(z != null ? (rndNumber((double)z / (ushort)unit)) : 0.1);

            if (this.X <= 0 | this.X > 10 | this.Y <= 0 | this.Y > 10 | this.Z <= 0 | this.Z > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.unit = unit;
        }

        private double rndNumber(double number)
        {
            return Math.Floor(number * Math.Pow(10, 3)) / Math.Pow(10, 3);
        }
    }
}
