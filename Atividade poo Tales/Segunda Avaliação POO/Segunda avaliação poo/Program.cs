using SegundaAvaliacao.Models;

List<Mesa> mesas = new List<Mesa>
{
      new Mesa(1, 4),
      new Mesa(2, 4),
      new Mesa(3, 4),
      new Mesa(4 , 10)
};


Cliente cliente1 = new Cliente("Mike");

cliente1.ReservarMesa(mesas, 2, 4);

foreach (var Mesa in mesas)
{
    Console.WriteLine(Mesa);
}
