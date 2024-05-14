namespace aulapoo{

    //Relação de Herança entre Carro e Veículo - uso do operador ":" para definir a relação
    public class Carro : Veiculo {
        private int NumeroPortas;

        //Uso da classe motor como composição - processo para garantir um menor acoplamento entre as classes
        private Motor motor;

        public Carro(int potencia){
            //Criação do objeto e inclusão de valor no atributo Potencia
            motor = new Motor();
            motor.SetPotencia(potencia);
        }

        public int GetNumeroPortas(){
            return this.NumeroPortas;
        }

        public void SetNumeroPortas(int NumeroPortas){
            this.NumeroPortas = NumeroPortas;
        }

        public void LigarMotor(){
            //Chamada que exemplifica a Composição
            motor.Ligar();
        }

        public void DesligarMotor(){
            //Chamada que exemplifica a Composição
            motor.Desligar();
        }


    }
}
