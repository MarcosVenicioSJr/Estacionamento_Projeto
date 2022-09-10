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
            Console.WriteLine("Bem vindo ao Estacionamento.");
            Console.WriteLine("Digite aqui sua placa: ");
            string board = Console.ReadLine();

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

    }
}