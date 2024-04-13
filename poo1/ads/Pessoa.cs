
namespace fce {

    public class Pessoa {
        private string? Nome;
        private string? Cpf;

        public string? GetNome(){
            return Nome;
        }

        public string? GetCpf(){
            return Cpf;
        }

        public void SetNome(string Nome){

            this.Nome = Nome;

        }

        public void SetCpf(string Cpf){

            this.Cpf = Cpf;

        }
    }

}
