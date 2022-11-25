// See https://aka.ms/new-console-template for more information
using CheckAttendance;
using CheckAttendance.Sevices;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

Console.WriteLine("Attedance check!");

var services = new ServiceCollection();

Assembly.GetEntryAssembly().GetAssainableTypes<IAttnendant>().ForEach(t =>
{
    services.AddTransient(typeof(IAttnendant), t);
});

var builder = services.BuildServiceProvider();

var attendants = builder.GetServices<IAttnendant>();

foreach(var a in attendants)
{
    Console.WriteLine(a.Name);
}