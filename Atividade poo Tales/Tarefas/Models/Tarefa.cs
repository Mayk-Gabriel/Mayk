namespace Tarefa.Models
{
    class Tarefa
    {
        public Tarefa(string nome, string descricao, DateTime dataDeInicio, DateTime dataDeFim)
        {
            Nome = nome;
            DataDeInicio = dataDeInicio;
            DataDeFim = dataDeFim;
        }

        private int _iD;
        
        public string Nome {get; set;}
        public string Descricao {get; set; }
        public Tipo Tipo {get; set;}
        public Status Status {get; set;}
        public DateTime DataDeInicio {get; set;}
        public DateTime DataDeFim {get; set;}

        public void Cadastro()
        {
            
            

        }

    }
}