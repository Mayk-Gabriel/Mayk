using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Avaliacao.Models
{
    class Mesa
    {
        public Mesa(int numero, int capacidade)
        {
    
            Numero = numero;
            Capacidade = capacidade;
            Ocupado = false;
        }

        private string _nomeCliente;
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public bool Ocupado;

        public void ReservarMesa(string nomeCliente, int capacidade)
        {
            if (string.IsNullOrWhiteSpace(nomeCliente))
                throw new ArgumentException("Informe um nome.");
            if (capacidade > 4 || capacidade <= 0)
                throw new ArgumentException("Capacidade não permitida!");
            if (Ocupado)
                throw new ArgumentException("Mesa Ocupada");

            _nomeCliente = nomeCliente;
            Ocupado = true;
            
            Console.WriteLine($" Nome {nomeCliente} | Mesa {Numero} | Capacidade {capacidade}");
        }

    }
}
