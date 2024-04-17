

namespace discentes {

    public class Aluno : Pessoa {

        private string? Matricula;

        public string? GetMatricula(){
            return this.Matricula;
        }

        public void SetMatricula(string? Matricula){
            this.Matricula = Matricula;
        }

        public string? GerarMatricula(string? Cpf){
           
            return "U"+ Cpf.Substring(0,3);
        }
    }

}