using System;
using discentes;

namespace AulaUnipInterface
{

    public class Program
    {

        public static void Main(string[] args)
        {
            string? disciplina;
            string? nomeAluno;
            string? cpf;
            string? matricula;
            double nota1;
            double nota2;
            double notapim;
            double media;

            Console.WriteLine("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite o CPF do aluno: ");
            cpf = Console.ReadLine();

            Console.Write("Digite o nome da disciplina: ");
            disciplina = Console.ReadLine();

            Console.Write("Digite a nota da NP1: ");
            nota1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da NP2: ");
            nota2 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do PIM: ");
            notapim = Double.Parse(Console.ReadLine());

            Aluno a = new();
            a.SetNome(nomeAluno);
            a.SetCpf(cpf);
            matricula = a.GerarMatricula(a.GetCpf());
            a.SetMatricula(matricula);


            Disciplina d = new();
            d.SetNomeDisciplina(disciplina);

            Avaliacao avaliacao = new();
            avaliacao.SetAluno(a);
            avaliacao.SetDisciplina(d);

            media = avaliacao.CalcularMedia(nota1,nota2,notapim);
            avaliacao.SetMedia(media);

            avaliacao.CheckAprovado(media);

            Console.WriteLine("Aluno: {3}\nMatrícula: {4}\nDisciplina: '{0}'\nMédia: {1}\nSituação: {2}", d.GetNomeDisciplina(), avaliacao.GeMedia(), avaliacao.CheckAprovado(media), a.GetNome(), a.GetMatricula());


            //Console.WriteLine("Disciplina: '{2}'\nMédia: '{1}'\nSituação: '{0}'",d.GetNomeDisciplina(), d.GetMedia(),d.CheckAprovado(d.GetMedia()));

           // Console.WriteLine("Disciplina: " + d.GetNomeDisciplina() + "\nMedia: " + d.GetMedia() + "\nSituação: "+d.CheckAprovado(d.GetMedia()));
        }

    }

}



