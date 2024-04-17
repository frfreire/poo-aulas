namespace  discentes
{
    public class Disciplina : IDisciplina {

        private string NomeDisciplina;
        private double Media;

        public string GetNomeDisciplina(){
            return this.NomeDisciplina;
        }
        public double GetMedia(){
            return this.Media;
        }

        public void SetNomeDisciplina(string nome){
            this.NomeDisciplina = nome;
        }

        public void SetMedia(double media) {
            this.Media = media;
        }
        
        public double CalcularMedia(double n1, double n2, double pim){

            return (n1*4 + n2*4 + pim*2)/10;
        }

        public string CheckAprovado(double media){

            if(media < 7) {
                return "Reprovado";
            } else {
                return "Aprovado";
            }
        }
    }
}