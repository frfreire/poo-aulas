using System;

namespace aulapoo{

    public class Motor {

        public int Potencia;

        public int GetPotencia(){
            return this.Potencia;
        }

        public void SetPotencia(int Potencia){
            this.Potencia = Potencia;
        }

        public void Ligar(){
            Console.WriteLine("Ligando o motor");
            Console.WriteLine("...");
            Console.WriteLine("Motor ligado com potencia de "+Potencia+ " cavalos");
        }

        public void Desligar(){
            Console.WriteLine("Desligando o motor");
            Console.WriteLine("...");
            Console.WriteLine("Motor desligado");
        }
    }
}