//Exercícios do curso do Prof Macoratti
// Escreva um programa para exibir os 10 primeiros números inteiros naturais e calcular a sua soma usando os loop while, do-while e for.

//Usando loop while
// int i=1, soma = 0;
// Console.Write("Os 10 primeiros números naturais são :\n");
// while (i <= 10)
// {
//     soma = soma + i;
//     Console.Write($"{i} "); i++;
// }
// Console.Write($"\nA soma dos números é : {soma}\n");

// Console.Write()

//Usando loop do-while
// int i = 1, soma = 0;
// Console.Write("Os 10 primeiros números naturais são :\n");
// do
// {
//     soma = soma + i1;
//     Console.Write($"{i} "); i++;
// } while (i <= 10);
// Console.Write($"\nA soma dos números é : {soma}\n");


//Usando o loop for

int i, soma = 0;
Console.Write("Os 10 primeiros números naturais são :\n");
for (i = 1; i <= 10; i++)
{
    soma = soma + i;
    Console.Write($"{i} ");
}
Console.Write($"\nA soma dos números é : {soma}\n");
