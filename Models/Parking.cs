namespace EstacionamentoDIO.Models
{
    public class Parking
    {
        private decimal valueInitial;
        private decimal valueHour;
        private List<string> cars = new List<string>();

        public Parking(decimal valueInitial, decimal valueHour)
        {
            this.valueHour = valueHour;
            this.valueInitial = valueInitial;
        }

        public void addVehicle()
        {
            Console.Clear();
            Console.WriteLine("Digite aqui sua placa: ");
            string board = Console.ReadLine().ToLower();

            if (board != null)
            {
                cars.Add(board);
            }
            else
            {
                Console.WriteLine("Placa inválida. Digite novamente sua placa: ");
                addVehicle();
            }
        }

        public void removeVehicle()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa que você deseja remover: ");
            string board = Console.ReadLine().ToLower();

            if (cars.Contains(board))
            {
                Console.Clear();
                decimal valueTotal = valueHour * valueInitial;

                Console.Write($"O valor do estacionamento é: {valueTotal}");
                cars.Remove(board);
            }
            else
            {
                Console.Write("O carro não está estacionado aqui. Digite novamente a placa: ");
                removeVehicle();
            }
            Console.Write("Obrigado por estacionar conosco!");
        }

        public void searchVehicle()
        {
            Console.WriteLine("Digite a placa do seu veículo: ");
            string board = Console.ReadLine().ToLower();

            if (cars.Contains(board))
            {
                Console.WriteLine($"O carro com a placa: {board}. Está estacionado aqui.");
            }
            else
            {
                Console.WriteLine("O seu carro não está aqui. Sinto muito.");
            }
        }
    }
}