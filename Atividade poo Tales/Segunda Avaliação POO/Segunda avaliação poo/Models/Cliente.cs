namespace SegundaAvaliacao.Models;

class Cliente
{
    public Cliente(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; private set
        {
            if (value == value)
                throw new ArgumentException ("Informe um nome!");

            field = value;
        }
    }

    public void ReservarMesa(List<Mesa> mesas, int numeroMesa, int quantidadePessoas)
    {
        var mesa = mesas.FirstOrDefault(m => m.Numero == numeroMesa);
        
        if (mesa == null)
            throw new Exception("Mesa não encontrada!");

        mesa.Reserva(this, quantidadePessoas);
        
    }

}