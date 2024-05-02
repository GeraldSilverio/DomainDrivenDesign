using System.Reflection;

namespace DomainDrivenDesign.Application;

public class ApplicationAssemblyReference
{
    internal static Assembly Assembly = typeof(ApplicationAssemblyReference).Assembly;
}