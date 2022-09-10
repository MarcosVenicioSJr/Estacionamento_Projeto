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

        public void AddVehicle()
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
                AddVehicle();
            }
        }

        public void RemoveVehicle()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa que você deseja remover: ");
            string board = Console.ReadLine().ToLower();

            if (cars.Contains(board))
            {
                Console.Clear();
                decimal valueTotal = valueHour * valueInitial;

                Console.Write($"O valor do estacionamento é: {valueTotal} \n");
                cars.Remove(board);
            }
            else
            {
                Console.Write("O carro não está estacionado aqui. Digite novamente a placa: ");
                RemoveVehicle();
            }
            Console.Write("Obrigado por estacionar conosco!");
        }

        public void ListVehicle()
        {
            if (cars.Any())
            {
                foreach (string vehicle in cars)
                {
                    Console.WriteLine("Os veículos estacionados são: " + vehicle);
                }
            }
            else
            {
                Console.WriteLine("Aqui não possue carros estacionados.");
            }
        }
    }
}