using System.Reflection;

namespace beecrowd.Models
{
    class Produto
    {
        public Produto(string cliente)
        {
            Cliente = cliente; 
        }
        private List<string> _produto;
        private List<decimal> _valor;

        public string Cliente { get; set; }

        public void AdicionarItensAoCarrinho(string produto, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(produto))
                throw new ArgumentException("Selcione um produto produto!");

            if (valor >= 0)
                throw new Exception("Invalido");

            _produto.Add(produto);
            _valor.Add(valor);
        }

        public void FinalizarCompra()
        {
            Console.WriteLine("Produtos: ");
            foreach (var produto in _produto)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine("Valor: ");
            foreach( var valor in _valor)
            {
                Console.WriteLine(valor);
            }
        }
    }
}