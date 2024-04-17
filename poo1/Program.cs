using System;
using discentes;

namespace AulaUnipInterface
{

    public class Program
    {

        public static void Main(string[] args)
        {
            /*
            Aluno a = new();
            a.SetCpf("085.497.635-88");
            a.SetNome("Chiquinho");

            a.SetMatricula(a.GerarMatricula(a.GetCpf()));
            

            Console.WriteLine("Nome: " + a.GetNome() + "\nCPF: " + a.GetCpf()+ "\nMatrícula: " + a.GetMatricula());
            */

            Disciplina d = new();
            d.SetNomeDisciplina("POO");
            double media = d.CalcularMedia(7, 5, 8);
            d.SetMedia(media);

            Console.WriteLine("Disciplina: " + d.GetNomeDisciplina() + "\nMedia: " + d.GetMedia() + "\nSituação: "+d.CheckAprovado(d.GetMedia()));
        }

    }

}



