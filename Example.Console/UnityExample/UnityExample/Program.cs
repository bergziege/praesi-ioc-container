using System;

using Microsoft.Practices.Unity;

using UnityExample.Persistence;
using UnityExample.Services;

namespace UnityExample {
    internal class Program {
        private static void Main(string[] args) {

            /* Create new container instance */
            UnityContainer container = new UnityContainer();

            /* Register Types with container */
            RegisterExplicit(container);
            //RegisterByRules(container);

            /* Get the registered implementation for IConsoleService */
            IConsoleService consoleService = container.Resolve<IConsoleService>();

            /* Do something */
            consoleService.Write("42");

            /* Wait for input to keep console open */
            Console.ReadLine();
        }

        private static void RegisterByRules(UnityContainer container) {
            container.RegisterTypes(
                AllClasses.FromAssemblies(typeof(Program).Assembly),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.ContainerControlled);
        }

        public static void RegisterExplicit(UnityContainer container)
        {
            container.RegisterType<IConsoleDao, ConsoleDao>(new ContainerControlledLifetimeManager());
            /* ers (IConsoleDao, String). */
            container.RegisterType<IConsoleService, ConsoleService>(new ContainerControlledLifetimeManager(),
                new InjectionConstructor(
    typeof(IConsoleDao),
    new InjectionParameter<string>("test")));
        }
    }
}