﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Converter
    {
        private readonly double usd;
        private readonly double rub;
        private readonly double eur;

        public Converter(double usd, double rub, double eur)
        {
            this.usd = usd;
            this.rub = rub;
            this.eur = eur;
        }

        public double ConvertUsd(double money, bool toUsd = true)
        {
            return toUsd ? money / usd : money * usd;
        }
        public double ConvertEur(double money, bool toEur = true)
        {
            return toEur ? money / eur : money * eur;
        }
        public double ConvertRub(double money, bool toRub = true)
        {
            return toRub ? money / rub : money * rub;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(30.0, 0.60, 32.0);

            //USD
            Console.WriteLine(converter.ConvertUsd(1000));
            Console.WriteLine(converter.ConvertUsd(1000, false));
            Console.WriteLine();

            //EUR
            Console.WriteLine(converter.ConvertEur(1000));
            Console.WriteLine(converter.ConvertEur(1000, false));
            Console.WriteLine();

            //rub
            Console.WriteLine(converter.ConvertRub(1000));
            Console.WriteLine(converter.ConvertRub(1000, false));
        }
    }
}