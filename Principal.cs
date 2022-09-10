using EstacionamentoDIO.Models;
class Principal
{
    static void Main(string[] args)
    {
        Console.Write("Seja bem vindo ao sistema de estacionamento!");

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
                    parking.addVehicle();
                    break;
            }
        }
    }
}
