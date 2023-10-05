// Exercícios práticos do Curso do Professor Macoratti
//Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

int num1, num2, num3;

Console.Write("\nEncontre o maior número dentre 3 números:\n");

Console.Write("Primeiro Número:\t");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Segundo Número:\t");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Terceiro Número:\t");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
        Console.Write($"O primeiro número {num1} é o maior\n");
    else
        Console.Write($"O terceiro número {num3} é o maior\n");
}

else if (num2 > num3)
    Console.Write($"O segundo número {num2} é o maior \n");
else
    Console.Write($"O terceiro número {num3} é o maior \n");