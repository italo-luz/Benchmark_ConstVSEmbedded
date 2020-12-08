using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

namespace Benchmark_ConstVSEmbedded
{
    [RankColumn]
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class ConstVSEmbedded
    {
        private const string insert = "INSERT INTO xpto(Column1, Column2, Column3, Column4, Column5) VALUES(@Column1, @Column2, @Column3, @Column4, @Column4);" +
            "INSERT INTO xpto(Column1, Column2, Column3, Column4, Column5) VALUES(@Column1, @Column2, @Column3, @Column4, @Column4);" +
            "INSERT INTO xpto(Column1, Column2, Column3, Column4, Column5) VALUES(@Column1, @Column2, @Column3, @Column4, @Column4);" +
            "INSERT INTO xpto(Column1, Column2, Column3, Column4, Column5) VALUES(@Column1, @Column2, @Column3, @Column4, @Column4);" +
            "INSERT INTO xpto(Column1, Column2, Column3, Column4, Column5) VALUES(@Column1, @Column2, @Column3, @Column4, @Column4);";

        [Benchmark]
        public string ReadConst() => insert;

        [Benchmark]
        public string ReadFile() => Resource.GetScript("Insert");
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ConstVSEmbedded>();
        }
    }
}
