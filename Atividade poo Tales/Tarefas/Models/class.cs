namespace ex.Models
{
    class nick
    {
        public nick(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public string Nome {get; set;}
        public string Email {get; set;}
    }
}