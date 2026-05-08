namespace ex.Models
{
    class User
    {
        public User(string nome, string email)
        {
            Nome = nome;
            Email = email;

        }
        public string Nome {get; set;}
        public string Email {get; set;}

        public static void DeletarUser(List<User> users, string nome)
        {
            users.RemoveAll(u => u.Nome == nome);

            Console.WriteLine("User Deletado");
        }

    }
}