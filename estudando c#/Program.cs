// Questão 3


// bool loop = true;
// while (loop)
// {

//     Console.Write(@"Digite seu numero da conta: ");
//     int numconta = int.Parse(Console.ReadLine());

//     int novasenha = 0;

//     while (true)
//     {
//         Console.WriteLine(@"Digite sua nova senha: ");
//         novasenha = int.Parse(Console.ReadLine());

//         if (novasenha == numconta)
//         {
//         Console.WriteLine("A senha não pode ser igual ao numero da conta!");
//         }
//         else
//         break;
//     }

//     while (true)
//     {
//         Console.Write("Confirme sua senha: ");
//         int confsenha = int.Parse(Console.ReadLine());

//         if (confsenha != novasenha)
//         {
//             Console.WriteLine("Senha incorreta!");
//         }
//         else
//         {
//         Console.WriteLine("Nova senha cadastrada!");
//         break;
//         }
//     }
// loop = false;
// }

//---------------------------------------------------------

// Questão 4



// using System.Diagnostics.Contracts;

// float valor = 0;

// bool loop = true;
// while (loop)
// {

//     Console.WriteLine("Digite o valor do produto!");
//     valor = float.Parse(Console.ReadLine());
//     valor ++;

// }

//---------------------------------------------------------

// float valormenor = 0;
// float valor50 = 0;
// int produtospremiados = 0;

// bool loop = true;
// while(loop)
// {
//     Console.WriteLine(@"Digite o preço do produto ou um valor negativo para encerrar!
//     ");
//     Console.Write("Digite um valor: ");
//     float valor1 = float.Parse(Console.ReadLine());

//     if(valor1 <0)
//     {
//         Console.WriteLine($"total acima de 50.00 = {valor50}");
//         Console.WriteLine($"total abaixo de 50.00 = {valormenor}");
//         Console.WriteLine($"total = {valor50 + valormenor}");
//         Console.WriteLine("quantidade de produdos participantes do sorteio = " + produtospremiados);
//         break;
//     }

//     if(valor1 > 49.00)
//     {
//         Console.WriteLine("valor cadastado!");
//         valor50 += valor1;

//     }

//     if(valor1 < 49.00)
//     {
//         Console.WriteLine("valor cadastado!");
//         valormenor += valor1;
//     }


// }

//---------------------------------------------------------

// using System.Diagnostics.Contracts;
// List<double> valortotal = new List<double>{};
// List<int>  produtosorteio = new List<int>{};

// bool loop = true;
// while (loop)
// {

// Console.WriteLine(@"Digite o preço do produto ou um valor negativo para encerrar!
// ");

// double valor1 = double.Parse(Console.ReadLine());

//     if (valor1 <0)
//     {

//         Console.WriteLine($"total = {valortotal}");
//         Console.WriteLine("quantidade de produdos participantes do sorteio = " + produtosorteio);
//         break;
//     }

//     if (valor1 >= 50.00)
//     {
//         Console.WriteLine("valor cadastrado!");
//         valortotal.Add(valor1);
//     }
//     else  
//     {
//         Console.WriteLine("Valor cadastrado!");
//         valortotal.Add(valor1);

//     }


// }



// SINTAXE LISTA:

// List<string> frutas = new List<string>() {
//     "Banana",
//     "Maçã",
//     "Uva"
// };

// frutas.Add("Pera");



// SINTAXE ARRAY:

// string[] nomes = new string[3];
// nomes[0] = "Ana";
// nomes[1] = "João";
// nomes[2] = "Clara";

// // =============
// // SINTAXE FOR:

// for (int i = 0; i < frutas.Count; i++)
// {
//     Console.WriteLine(frutas[i]);
// }

// No array

// for (int i = 0; i < numeros.Length; i++)
// {
//     Console.WriteLine(numeros[i]);
// }

// // ============

// // SINTAXE FOREACH:

// foreach (string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }


// No array:

// foreach (int n in numeros)
// {
//     Console.WriteLine(n);
// }




// Console.WriteLine("Digite dez números, apenas os numeros acima de 50 serão somados!");
// int somaDosMaioresValores = 0;

// for (int i = 0; 10 > i; i ++)
// {


//    int numeroDigitado = int.Parse(Console.ReadLine());


//         if (numeroDigitado > 50)
//         {
//             somaDosMaioresValores += numeroDigitado;
//             Console.WriteLine($"soma dos valores maiores que 50 = {somaDosMaioresValores}");

//         }
// }


// Desafio 1: O Validador de Empréstimo "Draconiano"

// double rendaMensal;

// double valorEmprestimo;

// int scoreCredito;

// bool possuiGarantia = false;

// bool nomeSujo = false;

// int idade;



// Console.WriteLine("Porfavor informe seus dados!");



// bool loop = true;

// while (loop)

// {

//     // idade
//     Console.Write("Digite sua idade: ");
//     idade = int.Parse(Console.ReadLine());

//     // renda
//     Console.Write("Informe sua renda mensal: ");
//     rendaMensal = double.Parse(Console.ReadLine());

//     // scorecredito
//     Console.Write("Informe seu escore credito:");
//     scoreCredito = int.Parse(Console.ReadLine());

//     // valor do emprestimo
//     Console.Write("Qual o valor do emprestimo? ");
//     valorEmprestimo = double.Parse(Console.ReadLine());

//     // garantia
//     Console.Write(@" Responda com sim ou não!

//     Você possui algum bem como garantia? ");
//     string respostaGarantia = Console.ReadLine();

//     // nome sujo
//     Console.WriteLine(@" REsponda co sim ou não!

//     Você possui nome no SPC/Serasa? ");
//     string respostaNomeSujo = Console.ReadLine();

//     // A parcela (assuma 24 meses sem juros para simplificar: valorEmprestimo / 24 ) não pode exceder 30% da renda mensal.

//     double valorEmprestimoParcelas = valorEmprestimo / 24;

//     double porcentagem = 30;
//     double rendaporcentagem = (rendaMensal * porcentagem) / 100;

//         if (idade < 18 || idade > 80)
//         {
//             Console.WriteLine("Seu emprestimos foi negado! Sua idade não permite o emprestimo!");
//             break;
//         }

//         if (valorEmprestimoParcelas > rendaporcentagem)
//         {
//             Console.WriteLine("Negado!");
//             break;
//         }

//         else if (scoreCredito > 700)
//         {
//             Console.WriteLine("Você ira para Analise Manual!");
//             break;
//         }

//         else if (scoreCredito > 600)
//         {
//             Console.WriteLine("Emprestimo aprovado!");
//             break;
//         }

//         if (respostaNomeSujo == "sim")
//         {
//             nomeSujo = true;
//             Console.WriteLine("Seu emprestimos foi negado!");
//             break;
//         }

//         else if (scoreCredito > 900 && respostaGarantia == "sim")
//         {
//             Console.WriteLine("Você ira para Analise Manual!");
//             break;
//         }

//         else
//             Console.WriteLine("Você ira para Analise Manual!");
//             break;
//   }


// Desafio 2: O Analisador de Logs de Servidor (State Machine)

// string[]logs = {"INFO", "WARN", "ERROR", "INFO", "ERROR", "ERROR", "CRITICAL", "INFO" };

// int somaTotal = 0;

// bool status = () 
// for (int i = 0; i < logs.Length; i ++)
// {
//     if (logs[i] == "WARN")
//     {
//         somaTotal += 1;
//     }
//     else if (logs[i] == "ERROR")
//     {
//         somaTotal += 3;
//     }
//     else if (logs[i] == "CRITICAL")
//     {
//         somaTotal += 10;
//     }
//     else
//     {

//     }

//     Console.WriteLine(somaTotal);
// }

using System.Collections;

double precoOriginal = 0;
string categoria;
bool clienteVip;
string cupom;
int itensNoCarrinho = 0;
double PrecoFinal = 0;

bool loop = true;
while (loop)
{

    Console.WriteLine(@"Categorias!

    1 Eletronico 5%
    2 Livro 10% 
    3 Vestuario 15%
    4 Alimneto 0%
    5 Encerrar!
    ");



    Console.WriteLine("Qual a categoria do produto?");
    categoria = Console.ReadLine();

    if (categoria == "5" )
    {
        if (PrecoFinal == 0)
            {
                break;
            }
        break;
                
    }
        Console.Write("Digite o Valor do produto!");
        precoOriginal = double.Parse(Console.ReadLine());
   
    switch (categoria)
    {
        
        case "1":
        double porcentagemEletronico = 5;
        double descontoEletronico = (precoOriginal * porcentagemEletronico) / 100;
        PrecoFinal = precoOriginal - descontoEletronico;
        itensNoCarrinho += 1;
        break;

        case "2":
        double porcentagemLivro = 10;
        double descontoDeLivros = (precoOriginal * porcentagemLivro) / 100;
        itensNoCarrinho += 1;
        PrecoFinal += descontoDeLivros;
        break;

        case "3":
        double porcentagemVestuario = 15;
        double descontoVestuario = (precoOriginal * porcentagemVestuario) / 100;
        itensNoCarrinho += 1;
        PrecoFinal += descontoVestuario;
        break;

        case "4":
        double porcentagemAlimento = 0;
        double descontoAlimento = (precoOriginal * porcentagemAlimento) / 100;
        itensNoCarrinho += 1;
        PrecoFinal += descontoAlimento;
        break;
            
    }

}


Console.WriteLine($"Carrinho {itensNoCarrinho}");
Console.WriteLine($"Total = {PrecoFinal}");


//---------------------------------------------------

