namespace DesafioProjetoHospedagem.Models;

public class Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
{
    public List<Pessoa> Hospedes { get; set; } = hospedes;
    public Suite Suite { get; set; } = suite;
    public int DiasReservados { get; set; } = diasReservados;

    public void ValidarQuantidadeHospedes()
    {
        int quantidadeHospedes = ObterQuantidadeHospedes();
        if (quantidadeHospedes > Suite.Capacidade)
        {
            throw new Exception("Capacidade é menor que o número de hóspedes recebido.");
        }
    }

    public int ObterQuantidadeHospedes()
    {
        return hospedes.Count();
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10)
        {
            decimal desconto = valor * 0.10M;
            valor -= desconto;
        }

        return valor;
    }
}