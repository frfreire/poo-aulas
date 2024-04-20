namespace discentes{


    interface IAvaliacao{

         public double CalcularMedia(double nota1, double nota2, double pim);
         public string CheckAprovado(double media);
    }
}