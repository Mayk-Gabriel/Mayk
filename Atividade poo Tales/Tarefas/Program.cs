using ex.Models;


    User user1 = new User("Mike", "mayk@gmail.com");
    User user2 = new User("Gabs", "gabs@outlook.com");
    User user3 = new User("Luiz", "luiz@hotmail.com");
    User user4 = new User("Cel", "cel@gmail.com");
    User user5 = new User("Kevin", "kevin@hotmail.com");
    User user6 = new User("Nick", "nick@outlook.com");

    List <User> oi = [user1, user2, user3, user4, user5, user6];

    // var gmail = oi.Where(u => u.Email.Contains("gmail"));
    // Console.WriteLine("Usuários com gmail:");
    // foreach (var user in gmail)
    // {
    //     Console.WriteLine(user.Nome);
    // }

    // Console.WriteLine("");

    // var hotmail = oi.Where(u => u.Email.Contains("hotmail"));
    // Console.WriteLine("Usuários com hotmial:");
    // foreach (var user in hotmail)
    // {
    //     Console.WriteLine(user.Nome);
    // }

    // Console.WriteLine("");

    // var outlook = oi.Where(u => u.Email.Contains("outlook"));
    // Console.WriteLine("Usuários com outlook:");
    // foreach (var user in outlook)
    // {
    //     Console.WriteLine(user.Nome);
    // }

    // ----

    // var usuario = oi.FirstOrDefault(u => u.Nome == "Mike");

    // Console.WriteLine(usuario?.Nome);

    // ----

    // var emails = oi.Select(u => u.Email);

    // foreach (var email in emails)
    // {
    //     Console.WriteLine(email);
    // }

    // ----

    // var ordenados = oi.OrderBy( u => u.Nome);

    // foreach (var user in ordenados)
    // {
    //     Console.WriteLine(user.Nome);
    // }

    // ----

    // int quantidade = oi.Count(u => u.Email.Contains("gmail"));

    // Console.WriteLine(quantidade);

    // ------------


    List<Aluno> alunos = new List<Aluno>
    {
        new Aluno { Nome = "Mike", Notas = new List<double>{7,8,9}},
        new Aluno { Nome = "Gabs", Notas = new List<double>{7,10,9}},
        new Aluno { Nome = "Luiz", Notas = new List<double>{8,8,9}}
    };



    foreach (var aluno in alunos)
{
    double media = aluno.Notas.Average();
    Console.WriteLine($"{aluno.Nome} {media:f1}");
}


