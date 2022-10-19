using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("================ESTACIONAMENTO BOM PREÇO=================\n");

Console.Write("DIGITE O PREÇO INICIAL: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("DIGITE O PREÇO POR HORA: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento BomPreco = new Estacionamento(precoInicial, precoPorHora);

int opcao ;
bool exibirMenu = true;

while (exibirMenu)
{  

    Console.WriteLine("=========================");
    Console.WriteLine("1 -> Cadastrar veículo".ToUpper());
    Console.WriteLine("2 -> Remover veículo".ToUpper());
    Console.WriteLine("3 -> Listar veículos".ToUpper());
    Console.WriteLine("4 -> Encerrar".ToUpper());
    Console.WriteLine("=========================");
    Console.Write("Digite a sua opção: ".ToUpper());
    
    opcao = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("=========================");
   if(opcao == 1){
    BomPreco.AdicionarVeiculo();

   }
   else if (opcao == 2){
    BomPreco.RemoverVeiculo();




   }
   else if(opcao == 3){
    BomPreco.ListarVeiculos();

   }


   else if(opcao == 4){

    exibirMenu = false;
   }

   else{

    Console.WriteLine("DIGITE UMA OPÇÃO VALIDA!");
   }
   
   
      

    
}


Console.WriteLine("MUITO OBRIGADO VOLTE SEMPRE!!!");
