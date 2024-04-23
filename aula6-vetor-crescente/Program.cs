//faça um programa que leia 5 numeros, quarde os num vetor e ordene os de forma crescente em um novo vetor

int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o {0}° número: ", i + 1);
    numeros[i] = int.Parse(Console.ReadLine());
}

int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write(numeros[i] + " ");
}
Array.Sort(numeros);
foreach (int i in numeros)
{
    Console.Write(" " + i);
}
