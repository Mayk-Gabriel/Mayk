using SegundaAvaliacao.Models;
namespace SegundaAvaliacao.Models;

class Mesa
{
    public Mesa(int numero, int capacidade)
    {
        Numero = numero;
        Capacidade = capacidade;
        
        StatusMesa = Status.Disponivel;
    }

    public int Numero {get; private set;}
    public int Capacidade {get; private set
        {
            if (value > 10)
                throw new Exception ("Capacisdade Maxima não pode passar de 10");
            
            if (value <= 0)
                throw new Exception ("Capaciade deve ser pelo menos 1");
            

            field = value;
        }
    }

    public Status StatusMesa {get; set;}


    public override string ToString()
    {
        return $"Mesa numero: {Numero}, Capacidade: {Capacidade}, Status: {StatusMesa}";
    }

}
