using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Atividade {
    class pessoa {
        
        public string Nome;
        public int Idade;

    }
}

namespace Atividade {
    class program {
        static void Main(string[] args)
        {
            
            pessoa p1 = new pessoa();
            pessoa p2 = new pessoa();

            Console.WriteLine("Digite o nome");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade");
            p2.Idade = int.Parse(Console.ReadLine());


            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"{p1.Nome} é mais velho");
            }
            else
            {
                Console.WriteLine($"{p2.Nome} é mais velho");
            }

        }
    }
}

//----------------------

