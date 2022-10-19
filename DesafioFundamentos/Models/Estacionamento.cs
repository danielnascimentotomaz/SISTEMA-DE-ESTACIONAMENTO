namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            Console.Write("Digite a placa do veículo para estacionar:".ToUpper());
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
           
            string placa = "";
            Console.Write("DIGITE A PLACA DO VEICULO PRA REMOVER: ");
            placa = Console.ReadLine();


            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                int horas = 0;
                decimal valorTotal = 0; 
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ".ToUpper());
                horas =int.Parse(Console.ReadLine());

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                valorTotal = precoInicial +(precoPorHora * horas);
               

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente".ToUpper());
            
        }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: \n".ToUpper());
                int L = 1;
                foreach(string x in veiculos){
                    Console.WriteLine($"{L}° VEICULO PLACA = {x.ToUpper()}\n");
                    L++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.".ToUpper());
            }
        }
    }
}
