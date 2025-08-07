using System;
using System.Globalization;
partial class Program
{
    static void Main(string[] args)
    {
        int N;
        double[] A;

        N = int.Parse(Console.ReadLine());
        A = new double[N]; // Aqui a gente coloca a quantidade de elementos que o vetor A terá, então são N elementos

        string[] str = Console.ReadLine().Split(' ');
        for(int i=0; i<N; i++)
        {
            A[i] = double.Parse(str[i], CultureInfo.InvariantCulture); // Aqui eu vou fazer o vetor A, na posição i (contagem que inicia com 0), receber o double do vetor STR na posição i. 
        }

        for(int i=0; i<N; i++)
        {
            Console.Write(A[i] + " "); // Eu vou imprimir o vetor A, na posição i com um espaço em branco, e detalhe que é só o console.WRITE pois não tem quebra de linha
        }
        Console.WriteLine(); // Saindo do for, uso o console.WriteLine para quebra de linha

        double soma = 0.0; // Aqui eu criei uma variável soma que inicia com 0.0, pois é um double
        for(int i=0; i<N; i++)
        {
            soma = soma + A[i]; // Aqui declaramos a variável soma que vai receber ela mesma MAIS o vetor A na posição i
        }
        double media = soma / N; // Aqui eu criei uma variável média que vai receber a soma dividida por N, ou seja, a média dos números do vetor A
        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture)); // Aqui eu imprimo a variável soma com duas casas decimais, e o CultureInfo.InvariantCulture para não dar erro de formatação
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture)); // Aqui eu imprimo a variável média com duas casas decimais, e o CultureInfo.InvariantCulture para não dar erro de formatação
        Console.ReadLine(); // Aqui eu uso o console.ReadLine para que o programa não feche imediatamente após a execução, permitindo ver o resultado

    }
}