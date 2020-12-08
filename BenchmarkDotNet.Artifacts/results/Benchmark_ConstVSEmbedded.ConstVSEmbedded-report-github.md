``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.1397 (1809/October2018Update/Redstone5)
Intel Core i7-8665U CPU 1.90GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


```
|    Method |          Mean |      Error |     StdDev | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------:|-----------:|-----------:|-----:|-------:|------:|------:|----------:|
| ReadConst |     0.1871 ns |  0.0796 ns |  0.1697 ns |    1 |      - |     - |     - |         - |
|  ReadFile | 2,163.1933 ns | 43.2655 ns | 53.1339 ns |    2 | 1.4954 |     - |     - |    6264 B |
