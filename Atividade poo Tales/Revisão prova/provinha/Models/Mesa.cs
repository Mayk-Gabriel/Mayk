namespace provinha.Models;

public class Mesa
{
    public Mesa(int quantidadePessoas)
    {
        _contagemDeMesas ++;
        Id = _contagemDeMesas;
        QuantidadePessoas = ValidadeQuantidadePessoas(quantidadePessoas);
        _reservas = [];
    }

    private List<Reserva> _reservas;
    private static int _contagemDeMesas;
    public int Id { get; }
    public int QuantidadePessoas { get; }
    
    public void AdicionarReserva(Reserva reserva)
    {
        if (SeReservado(reserva))
        {
            throw new InvalidOperationException("Já existe uma reserva para este dia.");
        }

        _reservas.Add(reserva);
        Console.WriteLine($"Mesa #{Id} reservada para {reserva.ClienteReservador.Nome} ({reserva.NumeroDePessoas} pessoas).");
    }

    public void ExibirReservas()
    {
        Console.WriteLine("Reservas: ");
        Console.WriteLine("-----------------------------------------------------");
        foreach (Reserva reserva in _reservas)
        {
            Console.WriteLine(reserva);
        }
    }

    public void CancelarReserva(DateTime data)
    {
        var reserva = _reservas.FirstOrDefault(reserva => reserva.DataReserva == data);

        if (reserva == null)
        {
            throw new ArgumentNullException(nameof(data), "A mesa já está disponível nesta data.");
        }
        
        _reservas.Remove(reserva);
    }

    public bool SeReservado(Reserva novaReserva)
    {
        return _reservas.Any(reserva => reserva.DataReserva == novaReserva.DataReserva);
    }

    // Validações --------------------------------------------------------------

    private int ValidadeQuantidadePessoas(int quantidadePessoas)
    {
        if (quantidadePessoas <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantidadePessoas), "O número de pessoas não pode ser menor que 1");

        if (quantidadePessoas > 10)
            throw new ArgumentOutOfRangeException(nameof(quantidadePessoas), "A mesa não pode suportar mais que 10 pessoas");

        return quantidadePessoas;
    }
}
