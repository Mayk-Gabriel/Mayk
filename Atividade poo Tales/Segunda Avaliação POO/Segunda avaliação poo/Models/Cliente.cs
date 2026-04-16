namespace SegundaAvaliacao.Models;

class Cliente
{
    public Cliente(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException ("Informe um nome!");

            value = field;
        }
    }

    public void ReservarMesa(List<Mesa> mesas, int numeroMesa)
    {
        var mesa = mesas.FirstOrDefault(m => m.Numero == numeroMesa);

    if (mesa == null)
    {
        Console.WriteLine("Mesa não encontrada!");
        return;
    }

    if (mesa.StatusMesa == Status.Reservada)
    {
        Console.WriteLine("Mesa já está reservada!");
        return;
    }

    mesa.StatusMesa = Status.Reservada;
    mesa.ClienteReserva = this;

    Console.WriteLine($"Mesa {numeroMesa} reservada por {Nome}");
    }

}