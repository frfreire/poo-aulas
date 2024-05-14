using System;

namespace aulapoo{

    public class Veiculo {
        private string Marca;
        private int Ano;

        public string GetMarca(){
            return this.Marca;
        }

        public int GetAno(){
            return this.Ano;
        }
        
        public void SetMarca(string Marca){
            this.Marca = Marca;
        }
        public void SetAno(int Ano){
            this.Ano = Ano;
        }

        public void LigarMotor() {
            Console.WriteLine("Motor Ligado");
        }
    }
}
