namespace SegundaAvaliacao.Models;

class Cliente
{
    public Cliente(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; private set
        {
<<<<<<< HEAD
            if (string.IsNullOrWhiteSpace(value))
=======
            if (value == null)
>>>>>>> 175e904a3a9b4691043342824297191b246ef810
                throw new ArgumentException ("Informe um nome!");

            field = value;
        }
    }

<<<<<<< HEAD
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
=======
    public void ReservarMesa(List<Mesa> mesas, int numeroMesa, int quantidadePessoas)
    {
        var mesa = mesas.FirstOrDefault(m => m.Numero == numeroMesa);
        
        if (mesa == null)
            throw new Exception("Mesa não encontrada!");

        mesa.Reserva(this, quantidadePessoas);
        
>>>>>>> 175e904a3a9b4691043342824297191b246ef810
    }

}