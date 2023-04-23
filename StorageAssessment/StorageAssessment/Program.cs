using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using StorageAssessment.Databse;
using StorageAssessment.Models;
using StorageAssessment.Provider;
using StorageAssessment.Repository;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class Program
{
    private static readonly IFileNameProvider fileNameProvider;
    private static readonly IFileRepository fileRepository;
    private static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        BuildConfig(builder);

        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton(new DatabaseConfig { Name = "Data Source=FileInfoDB.sqlite" });
                services.AddScoped<IDatabaseBootstrap, DatabaseBootstrap>();
                services.AddScoped<IFileNameProvider, FileNameProvider>();
                services.AddScoped<IFileRepository, FileRepository>();
            })
            .Build();

        var dbBootStrap = ActivatorUtilities.CreateInstance<DatabaseBootstrap>(host.Services);
        dbBootStrap.Setup();

        IFileRepository fileRepo = ActivatorUtilities.CreateInstance<FileRepository>(host.Services);

        //string location = Console.ReadLine();
        string location = @"c:\test";

        Stopwatch stopWatch = new();
        stopWatch.Start();

        TransverseDirectory(location, fileRepo);

        stopWatch.Stop();
        Console.WriteLine(stopWatch.Elapsed);
    }

    private static void TransverseDirectory(string? location, IFileRepository fileRepo)
    {
        if (location == null)
        {
            return;
        }
        foreach (var filePath in Directory.GetFiles(location))
        {
            var fileInfo = new FileInfo(filePath);
            var doesExist = fileRepo.EntryExists(fileInfo.Name, fileInfo.DirectoryName);
            if (!doesExist.Result)
            {
                FileModel model = new(fileInfo.Name, fileInfo.DirectoryName, 1);
                fileRepo.Create(model);
            }

        }
        foreach (var subDir in Directory.GetDirectories(location))
        {
            var fileInfo = new FileInfo(subDir);
            var doesExist = fileRepo.EntryExists(fileInfo.Name, fileInfo.DirectoryName);
            if (!doesExist.Result)
            {
                FileModel model = new(fileInfo.Name, fileInfo.DirectoryName, 2);
                fileRepo.Create(model);
            }

            TransverseDirectory(subDir, fileRepo);
        }
    }

    static void BuildConfig(IConfigurationBuilder builder)
    {
        builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
            .AddEnvironmentVariables();
    }


}