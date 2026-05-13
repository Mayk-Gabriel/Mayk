// bool loop = true;
// while (loop)
// {
//     Console.WriteLine(@"Escolha uma Opção!

//     1 - codificar!
//     2 - decodificar! 
//     3 - Sair!");

//     Console.Write("Digite sua opção: ");
//     String opcao = Console.ReadLine();

//     switch (opcao)
//     {
        
//         case "1":

//         string alfabeto = "abcdefghijklmnopqrstuvwxyz";
//         string resultadoCodificado = "";

//         Console.Write("Digite o texto: ");
//         string codigo = Console.ReadLine().ToLower();

//         Console.WriteLine("Quantas casas deseja pular? ");
//         int deslocamento = int.Parse(Console.ReadLine());
        
//         for (int i = 0; i < codigo.Length; i++)
//             {
//                 char letra = codigo[i];

//                 int posicao = alfabeto.IndexOf(letra);

//                 int novaPosicao = (posicao + deslocamento + 26) % 26;

//                 char novaLetra = alfabeto[novaPosicao];

//                 resultadoCodificado += novaLetra;
//             }

//             Console.WriteLine($" Resultado {resultadoCodificado}");

        

//         break;

//         case "2":

//         string alfabeto1 = "abcdefghijklmnopqrstuvwxyz";
//         string resultadoDecodificado = "";

//         Console.Write("Digite o texto: ");
//         string codigo2 = Console.ReadLine().ToLower();

//         Console.WriteLine("Quantas casas deseja voltar? ");
//         int deslocamentoVolta = int.Parse(Console.ReadLine())
        
//         for (int i = 0; i < codigo2.Length; i++)
//             {
//                 char letra = codigo2[i];

//                 int posicao = alfabeto1.IndexOf(letra);

//                 int novaPosicao = (posicao - deslocamentoVolta + 26) % 26;

//                 char novaLetra = alfabeto1[novaPosicao];

//                 resultadoDecodificado += novaLetra;
//             }

//             Console.WriteLine($" Resultado {resultadoDecodificado}");

        

//         break;

//         case "3":

//         Console.WriteLine("Saindo!");

//         loop = false;

//         break;

//     }
// }

Console.WriteLine("Hello World!");

int numero1 = 0;
int numero2 = 0;

Console.Write("Digite o primeiro número:");
numero1 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo número:");
numero2 = int.Parse(Console.ReadeLine());

int soma = numero1 + numero2;

Console.WriteLine($"Soma dos números é {soma}");
