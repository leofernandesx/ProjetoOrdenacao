using System.Diagnostics;
using System.Text;
using ProjetoOrdenacao.Algorithms;
using ProjetoOrdenacao.Model;
using ProjetoOrdenacao.Util;

int[] sizes = { 1000, 10000, 100000 };
object[] algorithms =
{
    new BubbleSort(), new ImprovedBubbleSort(), new InsertionSort(),
    new SelectionSort(), new MergeSort(), new QuickSort(), new ShellSort()
};

foreach (object algorithm in algorithms)
{
    Console.WriteLine("---------------------------------" +
                      $"\n{StringFormatter.AddSpaceBeforeUppercase(algorithm.GetType().Name)}\n" +
                      "---------------------------------");

    foreach (int size in sizes)
    {
        Console.WriteLine("**********************************\n" +
                          $"{size.ToString("N0")} elementos\n" +
                          "**********************************");

        int[] ascending = CreateArray.Ascending(size);
        int[] random = CreateArray.Random(size);
        int[] descending = CreateArray.Descending(size);

        Dictionary<int[], string> arrayNames = new Dictionary<int[], string>
        {
            { ascending, "Ordenado" },
            { random, "Aleatorio" },
            { descending, "Decrescente" }
        };

        foreach (var entry in arrayNames)
        {
            int[] arr = entry.Key;
            string arrayName = entry.Value;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            algorithm.GetType().GetMethod("Sort").Invoke(algorithm, new object[] { arr });
            stopwatch.Stop();

            Console.WriteLine($"{arrayName}:\nTempo: {stopwatch.Elapsed.ToString(@"m\:ss\.fff")}\n" +
                              $"Comparacoees: {algorithm.GetType().GetProperty("Comparisons").GetValue(algorithm):N0}");

            try
            {
                Console.WriteLine($"Trocas: {algorithm.GetType().GetProperty("Swaps").GetValue(algorithm):N0}\n");
            }
            catch
            {
                Console.WriteLine($"Mesclas: {algorithm.GetType().GetProperty("Merges").GetValue(algorithm):N0}\n");
            }
        }
    }
}