namespace SegundaAvaliacao.Models;

class Cliente
{
    public Cliente(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; private set
        {
            if (Nome == null)
                throw new ArgumentException ("Informe um nome!");

            value = field;
        }
    }

    public void ReservarMesa()
    {
        
    }

}