﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lulu = new Animal();
            Animal lulu1 = new Animal();
            Animal lulu2 = new Animal();
            Animal tota = new Animal();
            Animal tota2 = new Animal();
            Animal tota3= new Animal();
        }
    }
    class Animal
    {
        public static int UltimoCodigo = 0;
        public int Código;

        public Animal()
        {
            UltimoCodigo++;
            Código = UltimoCodigo;
        }
    }
}
