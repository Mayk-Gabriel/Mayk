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

// using System.Collections;

// double precoOriginal = 0;
// string categoria;
// bool clienteVip;
// string cupom;
// int itensNoCarrinho = 0;
// double PrecoFinal = 0;

// bool loop = true;
// while (loop)
// {

//     Console.WriteLine(@"Categorias!

//     1 Eletronico 5%
//     2 Livro 10% 
//     3 Vestuario 15%
//     4 Alimneto 0%
//     5 Encerrar!
//     ");



//     Console.WriteLine("Qual a categoria do produto?");
//     categoria = Console.ReadLine();

//     if (categoria == "5" )
//     {
//         if (PrecoFinal == 0)
//             {
//                 break;
//             }
//         break;

//     }
//         Console.Write("Digite o Valor do produto!");
//         precoOriginal = double.Parse(Console.ReadLine());

//     switch (categoria)
//     {

//         case "1":
//         double porcentagemEletronico = 5;
//         double descontoEletronico = (precoOriginal * porcentagemEletronico) / 100;
//         PrecoFinal = precoOriginal - descontoEletronico;
//         itensNoCarrinho += 1;
//         break;

//         case "2":
//         double porcentagemLivro = 10;
//         double descontoDeLivros = (precoOriginal * porcentagemLivro) / 100;
//         itensNoCarrinho += 1;
//         PrecoFinal += descontoDeLivros;
//         break;

//         case "3":
//         double porcentagemVestuario = 15;
//         double descontoVestuario = (precoOriginal * porcentagemVestuario) / 100;
//         itensNoCarrinho += 1;
//         PrecoFinal += descontoVestuario;
//         break;

//         case "4":
//         double porcentagemAlimento = 0;
//         double descontoAlimento = (precoOriginal * porcentagemAlimento) / 100;
//         itensNoCarrinho += 1;
//         PrecoFinal += descontoAlimento;
//         break;

//     }

// }


// Console.WriteLine($"Carrinho {itensNoCarrinho}");
// Console.WriteLine($"Total = {PrecoFinal}");


//---------------------------------------------------

// Exercicio 

using System.Net.Http.Headers;
using System.Runtime.InteropServices;

bool loop = true;
while (loop)
{

    Console.WriteLine(@"Escolha uma opção!

    1 - Calculadora!
    2 - Verificar se um número é par ou impar!
    3 - Contagem Regressiva!
    4 - Médioa de notas!
    5 - Procurar um valor da lista!
    6 - sair!
    ");
    Console.Write("Digite sua opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        Console.WriteLine("Escolha uma formula calcular.");
        Console.WriteLine(@"
        1 - Soma.
        2 - subtração.
        3 - Multiplicação.
        4 - Divisão.
        5 - Sair!
        ");

        string opcaoCalculo = Console.ReadLine();

        switch (opcaoCalculo)
            {
                case "1":
                Console.Write("Digite o primeiro número!");
                int primeiroNumeroDaSoma = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número!");
                int segundoroNumeroDaSoma = int.Parse(Console.ReadLine());

                int soma = primeiroNumeroDaSoma + segundoroNumeroDaSoma;

                Console.WriteLine($"Soma = {soma}");
                break;


                case "2":
                Console.Write("Digite o primeiro número!");
                int primeiroNumeroDaSubtracao = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número!");
                int segundoroNumeroDaSubtracao = int.Parse(Console.ReadLine());

                int subtracao = primeiroNumeroDaSubtracao - segundoroNumeroDaSubtracao;

                Console.WriteLine($"Subtração = {subtracao}");
                break;


                case "3":
                Console.Write("Digite o primeiro número!");
                int primeiroNumeroDaMultipicacao = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número!");
                int segundoroNumeroDaMultiplicacao = int.Parse(Console.ReadLine());

                int multiplicacao = primeiroNumeroDaMultipicacao * segundoroNumeroDaMultiplicacao;

                Console.WriteLine($"Multiplicação = {multiplicacao}");
                break;


                case "4":
                Console.Write("Digite o primeiro número!");
                int primeiroNumeroDaDivisao = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número!");
                int segundoroNumeroDaDivisao = int.Parse(Console.ReadLine());

                int divisao = primeiroNumeroDaDivisao / segundoroNumeroDaDivisao;

                Console.WriteLine($"Divisão = {divisao}");
                break;


                case "5":
                break;
            }
        break;

        case "2":
        Console.WriteLine("Verifique se um numero é impar ou par.");
        Console.Write("Digite seu numero: ");
        int numeroImparOuPar = int.Parse(Console.ReadLine());

        if (numeroImparOuPar % 2 == 0)
            {
                Console.WriteLine($"Seu numero {numeroImparOuPar} é par!");
            }
        else
            {
                Console.WriteLine($"Seu numero {numeroImparOuPar} é impar!");
            }
        break;

        case "3":
        Console.WriteLine("Digite um numero para iniciar  cponmtagem regreciva!");
        Console.Write("Digite o numero que iniciarar a contagem: ");
        int contagem = int.Parse(Console.ReadLine());

        for (int i = contagem; i >= 0; i --)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        break;


        case "4":
        Console.WriteLine("vamos Calcular a media do aluno.\n");
        Console.Write("Digite a primeira nota: ");
        double primeiraNota = double.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        double segundasNota = double.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        double terceiraNota = double.Parse(Console.ReadLine());
        Console.WriteLine("");


        double somaDasNotas = primeiraNota + segundasNota + terceiraNota;
        double media = somaDasNotas / 3;

        if (media >= 7.0)
            {
                Console.WriteLine($"Media {media:f1} Aprovado!\n");
            }
        else if (media > 6.0)
            {
                Console.WriteLine($"Media {media:f1} Recuperação!\n");
            }
        else
            {
                Console.WriteLine($"Media {media:f1} Reprovado!\n");
            }
        break;


        case "5":

        int[] valores = { 5, 8, 12, 3, 9 };
        Console.Write("Verifique se um valor esta na lista: ");
        int valorDigitado = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < valores.Length; i ++)
            {
                if (valores[i] == valorDigitado)     
                {          
                    Console.WriteLine($"Valor {valorDigitado} esta na lista.\n");
                    break;
                }
               
                else
                {               
                    Console.WriteLine($"{valorDigitado} não esta na lista.\n");
                    break;
                }
                
            }
            break;

        
        case "6":
        Console.WriteLine("Saindo!");
        loop = false;
        break;
    }
}