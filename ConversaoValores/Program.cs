//declarando as variáveis
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// O código para definir o resultado1
// Dica: precisa arredondar o resultado para o número inteiro mais próximo (não apenas truncar)
// A classe Convert é melhor para converter números decimais fracionários em números inteiros inteiros
// Convert.ToInt32() arredonda da maneira que você esperaria.
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divida value1 por value2, mostra o resultado como um int: {result1}");

// O código do resultado2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divida value2 por value3, mnostra o resultado como um decimal: {result2}");

// O código do resultado3
float result3 = value3 / value1;
Console.WriteLine($"Divida value3 por value1, mostra o resultado como um float: {result3}");