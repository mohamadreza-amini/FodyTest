using BenchmarkDotNet.Attributes;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    public class MyBenchmark
    {
        private readonly Service1 _service = new();

        [Benchmark]
        public void CallWithFody()
        {
            _service.Method1(); 
        }   
    }
}
