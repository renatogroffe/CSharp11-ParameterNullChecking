using System.Runtime.InteropServices;
using ExemploParameterNullChecking;

Console.WriteLine("***** Testes com C# 11 | Parameter null-checking *****");
Console.WriteLine($"Versão do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();
Console.WriteLine("***** Algumas tecnologias Microsoft *****");
var tecnologias = new string[] { "C#", ".NET", null!, "ASP.NET Core", null!, "Azure Functions" };
foreach (var tecnologia in tecnologias)
{
    try
    {
        MessageHelper.Show(tecnologia);
    }
    catch (ArgumentException ex)
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = oldColor;
    }
}

Console.WriteLine();
Console.WriteLine("***** Término dos Testes *****");