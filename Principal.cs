using EstacionamentoDIO.Models;
class Principal
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor do estacionamento: ");
        decimal valueInitial = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor por hora: ");
        decimal valueHour = decimal.Parse(Console.ReadLine());


    }
}
