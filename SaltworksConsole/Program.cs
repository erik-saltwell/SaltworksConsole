using Autofac.Core;
using Autofac;
using Serilog;
using Serilog.Extensions.Autofac.DependencyInjection;
using Serilog.Configuration;
using CommandLine;


namespace SaltworksConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create your builder.
            ContainerBuilder builder = new ContainerBuilder();
            LoggerConfiguration log_configuration = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console();
            builder.RegisterSerilog(log_configuration);

            IContainer service = builder.Build();


            Parser.Default.ParseArguments<CommandLineArgurments>(args).WithParsed<CommandLineArgurments>(arguments =>
            {
                //do work here
            });
        }
    }
}
