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

    }
}