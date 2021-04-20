using System;

namespace DoadordeSangue
{
    class Program
    {
        static void Main(string[] args)
        {
           int idade;
           string valordigitado;

            Console.WriteLine("--DOADOR DE SANGUE--");
            Console.WriteLine();
            Console.Write("Digite sua idade: ");
            valordigitado= Console.ReadLine();
            idade= Int32.Parse(valordigitado);

            if(idade>=18 && idade<=67)
            {
                Console.WriteLine("Você pode doar sangue, eba!");
            }

            else
            {
                Console.WriteLine("Infelizmente, você não pode doar sangue.");
            }
        }
    }
}
