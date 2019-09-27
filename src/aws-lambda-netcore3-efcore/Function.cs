using System;
using System.Collections.Generic;
using System.Net;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.Json;

using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace aws_lambda_netcore3_efcore
{
    public class Function
    {
        private ServiceProvider _service;

        public Function() : this (Bootstrap.CreateInstance()) {}

        public Function(ServiceProvider service)
        {
            _service = service;
        }

        private static async Task Main(string[] args)
		{
            Func<ILambdaContext, List<Member>> func = FunctionHandler;
			using(var handlerWrapper = HandlerWrapper.GetHandlerWrapper(func, new JsonSerializer()))
			{
				using(var lambdaBootstrap = new LambdaBootstrap(handlerWrapper))
				{
					await lambdaBootstrap.RunAsync();
				}
			}
		}
        
        public static List<Member> FunctionHandler(ILambdaContext context)
        {
            Function fn = new Function();
            var service = fn._service.GetService<Services>();
            List<Member> members = service.List_member();

            Console.WriteLine("Log: Count: " + members.Count);

            return members;
        }
        
    }
}
