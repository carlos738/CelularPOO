using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CelularPOO.Models;

namespace CelularPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero,string modelo,int memoria, string marca) : base(numero, modelo,  memoria,marca){

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo" + nomeApp + "no Iphone");
        }
    }
}