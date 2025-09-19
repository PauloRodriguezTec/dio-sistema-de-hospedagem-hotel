namespace dio_sistema_de_hospedagem_hotel;
using dio_sistema_de_hospedagem_hotel.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 10);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");


    }
}
