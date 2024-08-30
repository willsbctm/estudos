// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using FluentResults;

//var summary = BenchmarkRunner.Run<BigO>();

var summary = BenchmarkRunner.Run<ExpectionXvalidation>(
    ManualConfig.Create(DefaultConfig.Instance)
    .WithOptions(ConfigOptions.DisableOptimizationsValidator));


[MemoryDiagnoser]
public class ExpectionXvalidation
{
    [Benchmark]
    public Result<object> ValidationAsResult()
    {
        var value = new {
            Age = 0
        };
        if(value.Age < 1)
            return Result.Fail("Error");

        return Result.Ok();
    }

    [Benchmark]
    public bool ValidationAsException()
    {
        var value = new {
            Age = 0
        };
        try
        {
            if (value.Age < 1)
                throw new Exception("Error");

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}

[RPlotExporter]
[SimpleJob(RuntimeMoniker.Net80)]
public class BigO {

    [Params(1000, 10000, 100000)]
    public int Value;


    [Benchmark]
    public void OneFor(){
        int max = int.MinValue; 
        int min = int.MaxValue; 
        for (var x = 0; x < Value; x++) { 
            if (x < min) min = x; 
            if (x > max) max = x; 
        }
    }

    [Benchmark]
    public void TwoFors(){
        int max = int.MaxValue; 
        int min = int.MinValue; 
        for (var x = 0; x < Value; x++) { 
            if (x > max) max = x; 
        }
        for (var x = 0; x < Value; x++) { 
            if (x < min) min = x; 
        }
    }

    [Benchmark]
    public void TwoChainFors(){
        int max = int.MaxValue; 
        int min = int.MinValue; 
        for (var x = 0; x < Value; x++) { 
            if (x > max) max = x; 
            for (var y = 0; y < Value; y++) { 
                if (y < min) min = y; 
            }
        }
    }
}