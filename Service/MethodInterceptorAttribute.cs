using MethodDecorator.Fody.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public class MethodInterceptorAttribute : Attribute, IMethodDecorator
    {
  
        public void Init(object instance, MethodBase method, object[] args)
        {
            Console.WriteLine($"Preparing to call: {method.Name}");
        }

        public void OnEntry()
        {
            Console.WriteLine("Method execution started.");
        }

        public void OnException(Exception exception)
        {
            Console.WriteLine($"An error occurred: {exception.Message}");
        }

        public void OnExit()
        {
            Console.WriteLine("Method execution finished.");
        }
    }
}
