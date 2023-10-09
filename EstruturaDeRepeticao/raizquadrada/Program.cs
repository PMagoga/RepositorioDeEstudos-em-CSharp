// Exercício proposto no curso C# do Prof. Macoratti

// - Escreva um programa para calcular a raiz da equação quadrática : ax^2 +bx + x = 0
// - Considere a, b e c números inteiros apenas
// - Para calcular as raízes use a fórmula de Báskara : x = (-b +- sqrt(delta))/2.a delta = b^2 -4.a.c
// - Solicite a entrada de a , b e c e informe se existe ou não raiz real
// Dica: Utilize os recursos da classe Math e use a instrução if-elseif

int a, b, c;
double d, x1, x2;

Console.WriteLine("Cálculo de uma equação do segundo Grau:\n");

Console.WriteLine("Digite o valor de a:\t");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de b:\t");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de c:\t");
c = Convert.ToInt32(Console.ReadLine());

d = b * b - 4 * a * c;

if (d == 0)
{
    x1 = - b / (2.0 * a);
    Console.Write($"As duas raízes são iguais a: {x1}\n");
}
else if (d > 0)
{
    Console.WriteLine("Ambas as raízes são reais e diferentes\n");
    x1 = (-b + Math.Sqrt(d))/(2 * a);
    x2 = (-b - Math.Sqrt(d))/(2 * a);
    Console.Write($"A primeira raiz é x1 = {x1}\n");
    Console.Write($"A segunda raiz é x2 = {x2}\n");
}
else
{
    Console.Write("As raízes são imaginárias;\nSem solução nos números reais. \n\n");
}