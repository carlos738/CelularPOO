using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CelularPOO.Models;

namespace CelularPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; }
        
        public int Memoria  { get; }
        public string Marca { get; }

        public Smartphone(string numero,string modelo, int memoria,string marca){
           
           Numero = numero;
           Modelo = modelo;
           
           Memoria = memoria;
           Marca = marca;

        }
        
        public Smartphone(string numero,string modelo, string imei, int memoria,string marca){
          Numero = numero;
          Modelo = modelo;
          
          Memoria = memoria;
          Marca = marca;
        }
        public void Ligar(){
            Console.WriteLine("Ligando...");

        }
        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
        }
        public void MostrarNumero(){
            Console.WriteLine(this.Numero);
        }
        public void MostrarMarca(){
            Console.WriteLine("Marca");
        }
        public abstract void InstalarAplicativo(string nomeApp);
        
        
        
        
        
           
    }
}