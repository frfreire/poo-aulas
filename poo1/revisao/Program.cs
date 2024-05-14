using System;
using aulapoo;

namespace geral{

    public class Program
    {
        public static void Main()
        {
            /*
            //Criação de um novo objeto do tipo Carro
            Carro c = new ();
            //Passando valores para os atributos de carro
            c.SetMarca("Ford Fiesta");
            c.SetAno(2012);
            c.SetNumeroPortas(4);
            //Saída do conteúdo
            Console.WriteLine(c.GetMarca());
            Console.WriteLine(c.GetAno());
            Console.WriteLine(c.GetNumeroPortas());
            c.LigarMotor();
            

            Calculadora calc = new();
            Console.WriteLine(calc.Soma(3,2));
            Console.WriteLine(calc.Soma(4,3,2));
            Console.WriteLine(calc.Soma(4.5, 6.3));
            


            Cachorro cachorro = new();
            Gato gato = new();

            cachorro.FazerSom();
            gato.FazerSom();
            */

            Carro carro = new Carro(200);
            carro.LigarMotor();
            carro.DesligarMotor();
        }
    }

}

