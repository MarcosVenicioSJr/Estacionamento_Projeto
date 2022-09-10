using EstacionamentoDIO.Models;
using System.Threading;
class Principal
{
    static void Main(string[] args)
    {
        Console.Write("Seja bem vindo ao sistema de estacionamento! \n");

        Console.Write("Digite o valor do estacionamento: ");
        decimal valueInitial = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor por hora: ");
        decimal valueHour = decimal.Parse(Console.ReadLine());

        Parking parking = new Parking(valueInitial, valueHour);

        bool display = true;

        while (display)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    parking.AddVehicle();
                    break;
                case "2":
                    parking.RemoveVehicle();
                    Thread.Sleep(5000);
                    break;
                case "3":
                    parking.ListVehicle();
                    Thread.Sleep(5000);
                    break;
                case "4":
                    Console.WriteLine("Até logo!");
                    display = false;
                    break;
                default:
                    Console.WriteLine("Opção não é válida!");
                    break;
            }
        }
        Console.Clear();
    }
}
