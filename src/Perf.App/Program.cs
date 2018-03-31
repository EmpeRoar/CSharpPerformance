using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using System;

namespace Perf.App
{
    [ClrJob(isBaseline: true), CoreJob, MonoJob]
    [RPlotExporter, RankColumn]
    public class Program
    {

        static void Main(string[] args)
        {
          
            var summary = BenchmarkRunner.Run<Program>();
            Console.ReadLine();
        }

        static Program()
        {            
            Perform();
        }

 
        [Benchmark]
        public static void Perform()
        {

            for (var i = 0; i <= 10; i++)
            {
               
            }
        }
    }
}
