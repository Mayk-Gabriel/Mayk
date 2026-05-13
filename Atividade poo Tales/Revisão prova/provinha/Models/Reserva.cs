namespace provinha.Models;

public class Reserva
{
    public Reserva(Cliente cliente, int numeroDePessoas, Mesa mesa, DateTime dataReserva)
    {
        ClienteReservador = ValidarCliente(cliente);
        MesaReservada = mesa;
        NumeroDePessoas = ValidarNumeroDePessoas(numeroDePessoas);
        DataReserva = ValidarData(dataReserva);

        mesa.AdicionarReserva(this);

    }

    public Cliente ClienteReservador { get; }
    public int NumeroDePessoas { get; } 
    public Mesa MesaReservada { get; }
    public DateTime DataReserva;

    public override string ToString()
    {
        return $"data: {DataReserva} | cliente: {ClienteReservador.Nome} | pessoas: {NumeroDePessoas}";
    }


    // Validações --------------------------------------------------------------

    private Cliente ValidarCliente(Cliente cliente)
    {
        if (cliente == null)
            throw new ArgumentNullException(nameof(cliente), "É necessário um cliente para fazer a reserva");

        return cliente;
    }

    private int ValidarNumeroDePessoas(int numeroDePessoas)
    {
        if(numeroDePessoas <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(numeroDePessoas), "O número de pessoas deve ser maior que 0");
        }

        if (numeroDePessoas > MesaReservada.QuantidadePessoas)
        {
            throw new ArgumentOutOfRangeException("O número de pessoas excedeu o limite da mesa");
        }

        return numeroDePessoas;
    }

    private DateTime ValidarData(DateTime data)
    {
        if (data < DateTime.Today)
        {
            throw new InvalidOperationException("A data não pode ser anterior a data de hoje");
        }

        return data;
    }
     
}
