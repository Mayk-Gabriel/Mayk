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

    public Cliente ClienteReserva { get; set;}

    public void Reserva(Cliente cliente, int quantidadePessoas)
    {
        if (quantidadePessoas > Capacidade)
            throw new Exception ("Capacidade ultrapassada!");

        ClienteReserva = cliente;
        StatusMesa = Status.Reservada;
        Console.WriteLine($"Mesa reservada {cliente.Nome}");
    }

    public void LiberarMesa(int numero)
    {
        if (numero != Numero)
            throw new Exception ("Mesa não encontrada");

        if (StatusMesa == Status.Disponivel)
            throw new Exception ("Mesa ja disponivel!");

        StatusMesa = Status.Disponivel;
    }

    public override string ToString()
    {
        string Nome = ClienteReserva?.Nome;
        return $"Mesa numero: {Numero}, Capacidade: {Capacidade}\nStatus: {StatusMesa} {Nome}";
    }

}
