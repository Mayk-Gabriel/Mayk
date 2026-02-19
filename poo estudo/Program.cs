<<<<<<< HEAD
﻿// using System;
// using System.Globalization;
// using System.Security.Cryptography.X509Certificates;
=======
﻿// // using System;
// // using System.Globalization;
// // using System.Security.Cryptography.X509Certificates;
>>>>>>> 13e0fd0fa593629f8143e0e275e886ff8e36a13b

// namespace Atividade {
//     class pessoa {

//         public string Nome;
//         public int Idade;

//     }
// }

// namespace Atividade {
//     class program {
//         static void Main(string[] args)
//         {

//             pessoa p1 = new pessoa();
//             pessoa p2 = new pessoa();

//             Console.WriteLine("Digite o nome");
//             p1.Nome = Console.ReadLine();
//             Console.WriteLine("Digite a Idade");
//             p1.Idade = int.Parse(Console.ReadLine());

//             Console.WriteLine("Digite o nome");
//             p2.Nome = Console.ReadLine();
//             Console.WriteLine("Digite a Idade");
//             p2.Idade = int.Parse(Console.ReadLine());


//             if (p1.Idade > p2.Idade)
//             {
//                 Console.WriteLine($"{p1.Nome} é mais velho");
//             }
//             else
//             {
//                 Console.WriteLine($"{p2.Nome} é mais velho");
//             }

//         }
//     }
// }

// //----------------------

<<<<<<< HEAD
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.CompilerServices;
// using System.Text.RegularExpressions;

// class Aluno{

//     private String _Nome;
//     private int _Idade;
//     private String _Turma;

//     public String Nome
//     {
//         get { return _Nome; }
//         set { _Nome = value; }
//     }
//     public int Idade
//     {
//         get { return _Idade; }
//         set { _Idade = value; }
//     }
//     public String Turma
//     {
//         get { return _Turma; }
//         set { _Turma = value; }
//     }



//     public void ApresentarSe()
//     {
//         Console.WriteLine($"Olá, meu nome é {_Nome}, tenho {_Idade} anos e estudo na turma {_Turma}.");
//     }


// }

// class program {

//     static void Main(String[] args)
//     {

//         Aluno aluno1 = new Aluno();

//         aluno1.Nome = "João";
//         aluno1.Idade = 18;
//         aluno1.Turma = "B2";

//         aluno1.ApresentarSe();

//     }

//     }

// --------------------------------------

// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.CompilerServices;
// using System.Text.RegularExpressions;

// class Aluno{

//     private String _Nome;
//     private int _Idade;
//     private String _Turma;

//     public String Nome
//     {
//         get { return _Nome; }
//         set { _Nome = value; }
//     }
//     public int Idade
//     {
//         get { return _Idade; }
//         set { _Idade = value; }
//     }
//     public String Turma
//     {
//         get { return _Turma; }
//         set { _Turma = value; }
//     }



//     public void ApresentarSe()
//     {
//         Console.WriteLine($"Olá, meu nome é {_Nome}, tenho {_Idade} anos e estudo na turma {_Turma}.");

//     }


// }

// class program {

//     static void Main(String[] args)
//     {

//         Aluno aluno1 = new Aluno();
//         Aluno aluno2 = new Aluno();

//         Console.WriteLine("Digite as dadosdo Aluno.");
//         Console.Write("Nome: ");
//         aluno1.Nome = Console.ReadLine();
//         Console.Write("Idade: ");
//         aluno1.Idade = int.Parse(Console.ReadLine());
//         Console.Write("Turma: ");
//         aluno1.Turma = Console.ReadLine();

//         Console.WriteLine("Digite os Dados do segundo Aluno.");
//         Console.Write("Nome: ");
//         aluno2.Nome = Console.ReadLine();
//         Console.Write("Idade: ");
//         aluno2.Idade = int.Parse(Console.ReadLine());
//         Console.Write("Turma: ");
//         aluno2.Turma = Console.ReadLine();

//         aluno1.ApresentarSe();
//         aluno2.ApresentarSe();

//     }

// }

// ----------------------------

using System.Runtime.InteropServices;
using System.Windows.Markup;

class Funcionario
{
    private string _Nome;
    private decimal _Salario;

    public string Nome
    {
        get {return _Nome; }
        set {_Nome = value; }
=======
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;
using Aluno;

namespace Aluno
{
    class Mayk{
    public String NomeCompleto;
    public int Idade;
    public String Proficao;
>>>>>>> 13e0fd0fa593629f8143e0e275e886ff8e36a13b
    }

    public decimal Salario
    {
        get {return _Salario; }
        set {_Salario = value; }
    }

}

<<<<<<< HEAD
class Program
{
    static void Main(string[] arge){

        Funcionario funcionario1 = new Funcionario();
        Funcionario funcionario2 = new Funcionario();

        Console.WriteLine("Digite as informções do primeiro funcionario.");
        Console.Write("Nome: ");
        funcionario1.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        funcionario1.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite as Informações do segundo funcionario.");
        Console.Write("Nome: ");
        funcionario2.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        funcionario2.Salario = decimal.Parse(Console.ReadLine());

        decimal mediaDeSalario = (funcionario1.Salario + funcionario2.Salario) / 2;

        Console.WriteLine($"A Media de salario dos funcionarios é {mediaDeSalario}");

    }
    
=======
namespace Funcao
{
    using Aluno;
    class code{
    static void Main(string[] args)
        {
        
        Mayk m1 = new Mayk();

        Console.WriteLine("Vamos Começar");
        Console.Write("Digite o nome Completo:");
        m1.NomeCompleto = Console.ReadLine();
        Console.Write("Digite a Idade");
        m1.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Você Digitol {m1.NomeCompleto} e {m1.Idade}");
        }

    }
>>>>>>> 13e0fd0fa593629f8143e0e275e886ff8e36a13b
}