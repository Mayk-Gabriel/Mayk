using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

String nome = "";

Console.WriteLine("Vamos começar!");

Console.WriteLine(@"Escolha uam opção!

    1 - Iniciar!
    2 - Sair!");

String Opecao = Console.ReadLine();

switch (Opecao)
{
    case "1":
    Console.WriteLine("Olá, qual é seu nome?");
    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();

    if (nome == "Gabs")
        {
            Console.WriteLine(@"Ah Gabs! É você!
            Devo dizer, sua prezensa me deixa felis ^^");
            Console.WriteLine(@"Eu...
            Eu fico atem senjeito sabendo que vc esta vendo esse código, mas ainda assim eu fico feliz.");

        }
    else if (nome == "Luiz || Crinsom")
        {
            Console.WriteLine(@"Ah é você, uma das pessoas mais legais desse mundo, é um prazer telo aqui ^^");
        }

    else if (nome == "")
        {
            Console.WriteLine("Você não disse seu nome!");
        }

    else
        {
        Console.WriteLine($"Olá {nome} É um prazer te conhecer");
        }

    Console.WriteLine(@"obrigado por esta aqui :3");
    Console.WriteLine(@"Eu gostaria de saber uma coisa...
O que vc acha do Mike?
    
    1 - Eu gosto dele.  2 - Eu acho ele legal.
    3 - Não conheço ele.  4 - Eu não gosto dele.");

    Console.Write("Digite sua resposat:");
    string opcaoMike = Console.ReadLine();

    switch (opcaoMike)
    {
        case "1":

        if (nome == "Gabs")
            {
                Console.WriteLine("Awwwwww eu não tinha duvidas disso, saiba que ele te ama muito, seu gatinho mala <3");
            }
        else if (nome == "Luiz || Crinsom")
            {
              Console.WriteLine($"Awwww claro que sim {nome} isso era obvio, o Mike acha que você é uma das pessoas mais legais que ele conheçe, saiba que ele te ama muito <3");     
            }
        
        else
            Console.WriteLine(@"Oh Que legal, ele ficaria feliz em saber disso.  Acho ate que você deveria dizer isso a ele, tenho certeza que ele ficaria muito feliz."); 
        
        break;

        case "2":
        
        Console.WriteLine("Ah bom saber, você também deve ser bem legal.");
        break;

        case "3":

        Console.WriteLine("Tudo bem, eu entendo. Acho que ele adoraria te conhecer.");
        break;

        case "4":

        Console.WriteLine("Poxa, você deve ter seus motivos.");
        break;

    }

    Console.WriteLine("É isso por enquanto, obrigado pela atenção ;3");
    

    break;
    

    case "2":
    Console.WriteLine("Saindo!");
    Console.ReadLine();
    break;
}
