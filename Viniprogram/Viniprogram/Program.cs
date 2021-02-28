using System;

namespace Viniprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome");

            string nome = Console.ReadLine();

            Console.WriteLine("olá" + " " +nome + ", " + "Entre com seu ano de nascimento");

            int ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você Já fez aniversarios esse ano ? SIM - S / NÃO - N ");

            string sn = Console.ReadLine();

            string snu = sn.ToUpper();

            int idade;

            
            if (snu == "N")
            {
                idade = 2020 - ano;

            }
           else
            {
                idade = 2021 - ano;

            }

            
            if (idade <= 18)
            {

                Console.WriteLine("Sua idade é, " + idade + ", " + "Portanto você é menor de idade");
            }
            else
            {
                Console.WriteLine("Sua idade é,  " + idade + ", " + "Portanto você é maior de idade");
            }


                    }
    }
}
