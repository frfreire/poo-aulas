using System;
using fce;

namespace exemploaula {


    public class Program {

        static void Main(string[] args){

            Pessoa p = new();
            p.SetNome("Maria");
            p.SetCpf("123456789-00");

            Console.WriteLine("Nome: "+p.GetNome()+"\nCPF: "+p.GetCpf());
        }

    }

}
