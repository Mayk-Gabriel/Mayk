using provinha.Models;

Mesa mesa = new Mesa(11);
Cliente cliente = new Cliente("Josefino");

DateTime data = DateTime.Now;
Reserva reserva = new Reserva(cliente, 6, mesa, data);
mesa.CancelarReserva(data);
Reserva reserva2 = new Reserva(cliente, 6, mesa, data);

mesa.ExibirReservas();