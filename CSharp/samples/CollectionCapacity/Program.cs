using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

Console.WriteLine("Benchmark");

var _ = BenchmarkRunner.Run<CollectionCapacity>();

public class CollectionCapacity
{
    [Params(10, 100, 1000, 1000000)]
    public int Capacity { get; set; }

    [Benchmark]
    public List<int> Fixed()
    {
        var list = new List<int>(Capacity);
        for (int i = 0; i < Capacity; i++)
            list.Add(i);
        return list;
    }

    [Benchmark]
    public List<int> Dynamic()
    {
        var list = new List<int>();
        for (int i = 0; i < Capacity; i++)
            list.Add(i);
        return list;
    }

    [Benchmark]
    public IEnumerator<int> Yield()
    {
        for (int i = 0; i < Capacity; i++)
            yield return i;
    }
}
