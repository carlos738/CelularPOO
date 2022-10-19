using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelularPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string modelo,  int memoria,string marca): base( numero, modelo, memoria, marca){

        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp} em um Smartphone NOKIA...");
        } 
    }
}