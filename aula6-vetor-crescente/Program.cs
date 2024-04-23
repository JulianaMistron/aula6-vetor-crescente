//faça um programa que leia 5 numeros, quarde os num vetor e ordene os de forma crescente em um novo vetor
int size = 50, aux = 0;
int[] vetorOriginal = new int[size];
int[] vetorOrdenado = new int[size];

for (int i = 0; i < size; i++)
{
    vetorOriginal[i] = new Random().Next(0, 50);
    vetorOrdenado[i] = vetorOriginal[i];
}
Console.WriteLine("Vetor original");
for (int i = 0; i < size; i++)
    Console.Write(vetorOriginal[i] + " ");

Console.ReadLine();

for (int referencia = 0; referencia < size; referencia++)//laço de referencia = 1
{
    for (int comparacao = referencia + 1; comparacao < size; comparacao++)//laço de comparação = j
    {
        if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
        {
            aux = vetorOrdenado[referencia];
            vetorOrdenado[referencia] = vetorOrdenado[comparacao];
            vetorOrdenado[comparacao] = aux;
        }
    }
}


Console.WriteLine("Ordenado");
for (int i = 0; i < size; i++)
    Console.Write(vetorOrdenado[i] + " ");

Console.ReadLine();