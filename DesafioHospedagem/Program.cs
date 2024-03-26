using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = [];

Pessoa pessoa1 = new("Nome1", "Sobrenome1");
Pessoa pessoa2 = new("Nome2", "Sobrenome2");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);

Suite suite = new("Premium", 2, 30);

Reserva reserva = new(hospedes, suite, 10);
reserva.ValidarQuantidadeHospedes();

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");