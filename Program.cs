using System.Security.Cryptography;
using CoreEntity.Models;


namespace CoreEntity;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
        using var context = new DatabaseContext();
        var groups = context.TGroups.ToList();
        foreach (var group in groups) Console.WriteLine($"Group: {group.Name}");
    }
}