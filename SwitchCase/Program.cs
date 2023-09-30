Console.WriteLine("##Estrutura switch-case##");

Console.WriteLine("Informe o nome do mês\t");

var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Estes mês tem 28 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}
Console.WriteLine("\nFim do processamento");
Console.ReadKey();