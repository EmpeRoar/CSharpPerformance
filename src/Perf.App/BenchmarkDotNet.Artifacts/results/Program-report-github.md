``` ini

BenchmarkDotNet=v0.10.13, OS=Windows 10.0.17127
Intel Core i3-4005U CPU 1.70GHz (Haswell), 1 CPU, 4 logical cores and 2 physical cores
Frequency=1656323 Hz, Resolution=603.7470 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host] : .NET Core 2.0.5 (CoreCLR 4.6.26020.03, CoreFX 4.6.26018.01), 64bit RyuJIT  [AttachedDebugger]
  Core   : .NET Core 2.0.5 (CoreCLR 4.6.26020.03, CoreFX 4.6.26018.01), 64bit RyuJIT


```
|  Method |     Job | Runtime | IsBaseline |     Mean |     Error |    StdDev | Scaled | ScaledSD | Rank |
|-------- |-------- |-------- |----------- |---------:|----------:|----------:|-------:|---------:|-----:|
| Perform | Default |     Clr |       True |       NA |        NA |        NA |      ? |        ? |    ? |
| Perform |    Core |    Core |    Default | 18.83 ns | 0.5957 ns | 0.6374 ns |      ? |        ? |    1 |
| Perform |    Mono |    Mono |    Default |       NA |        NA |        NA |      ? |        ? |    ? |

Benchmarks with issues:
  Program.Perform: Job-LPWYUF(Runtime=Clr, IsBaseline=True)
  Program.Perform: Mono(Runtime=Mono)
