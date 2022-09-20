using System.Text;
using ProgHotelPottencial.Models;


Console.OutputEncoding = Encoding.UTF8;


// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

//Criando menu das suites
int tipo;
string Tipo;
bool successo;
int dias;
string Dias;
do
{
Console.WriteLine("Digite a preferência da suite:");
Console.WriteLine("1 - Para Standard");
Console.WriteLine("2 - Para Master");
Console.WriteLine("3 - Para Deluxe");
Tipo = Console.ReadLine();

successo = Int32.TryParse(Tipo, out tipo);
  
switch (tipo){
    case 1:Console.WriteLine("Standard");
        Tipo="Standard";break;
    case 2:Console.WriteLine("Master");
        Tipo = "Master";break;
    case 3:Console.WriteLine("Deluxe");
        Tipo = "Deluxe";break;
    default:Console.WriteLine("Seleção Inválida!");
            break;

    } 
    Console.Write("Pressione Enter para continuar...");
    Console.ReadLine();
    Console.WriteLine();
    Console.Clear();
    
} 
while (tipo >= 4 != tipo <=0);



// Cria a suíte
Suite suite = new Suite(tipoSuite: Tipo , capacidade: 5, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.WriteLine("Digite a quantidade de dias para reserva:");

Dias = Console.ReadLine();
successo = Int32.TryParse(Dias, out dias);

Reserva reserva = new Reserva(diasReservados: dias);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("\n--------- CONFIRA SUA RESERVA ANTES DE CONFIRMAR! ---------------\n");
Console.Write("Pressione Enter para continuar...");
Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Você escolheu a suite: {Tipo.ToUpper()}");
Console.WriteLine($"Serão {reserva.ObterQuantidadeHospedes()} hóspedes.");
Console.WriteLine($"O valor total para {reserva.DiasReservados} dias ficará em "
    + $"{reserva.CalcularValorDiaria().ToString("C")}");