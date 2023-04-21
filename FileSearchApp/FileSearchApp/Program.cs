string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
string[] folders = Directory.GetDirectories(appDataFolder);
string publicKeyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mycert.crt");
string[] publicKey = File.ReadAllLines(publicKeyPath);

List<string> certificates = new();
List<FileInfo> files = new();
foreach (string folder in folders)
{
    try
    {
        certificates.AddRange(Directory.GetFiles(folder, "myAuthority.pem", searchOption: SearchOption.AllDirectories));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

foreach (var item in certificates)
{
    if (!File.ReadAllLines(item).Contains(publicKey[0]))
    {

        File.AppendAllText(item, Environment.NewLine);
        File.AppendAllLines(item, publicKey);
        Console.WriteLine(item);
        Console.WriteLine("Done");
    }
    else
    {
        Console.WriteLine(item);
        Console.WriteLine("Already done");
    }
}

Console.ReadKey();
