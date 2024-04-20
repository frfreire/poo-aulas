namespace discentes {

    public class Avaliacao : IAvaliacao
    {
        private Aluno aluno;
        private Disciplina disciplina;

        private double Media;

        public Aluno GetAluno(){
            return this.aluno;
        }

        public Disciplina GetDisciplina(){
            return this.disciplina;
        }

        public double GeMedia(){
            return this.Media;
        }

        public void SetAluno(Aluno aluno){
            this.aluno = aluno;
        }

        public void SetDisciplina(Disciplina disciplina){
            this.disciplina = disciplina;
        }

        public void SetMedia(double Media){
            this.Media = Media;
        }


        public double CalcularMedia(double nota1, double nota2, double pim)
        {
            return (nota1*4 + nota2*4 + pim*2)/10;
        }

        public string CheckAprovado(double media)
        {
            if(media < 7) {
                return "Reprovado";
            } else {
                return "Aprovado";
            }
        }
    }
}