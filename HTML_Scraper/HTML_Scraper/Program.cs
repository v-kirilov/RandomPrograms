using AngleSharp;
using AngleSharp.Dom;

//Set up AngleSharp
var config = Configuration.Default.WithDefaultLoader();
var context = BrowsingContext.New(config);

string url = string.Empty;

//Parallel for doing async function in different proccess!
Parallel.For(1, 10, (i) =>
{
    Console.WriteLine(i);
    //await GetRecipe(context,i);
});

while (true)


{
    Console.WriteLine("Enter city:");
    Console.WriteLine("s-Sofia ; p-Plovdiv ; k-Kyustendil");
    url = Console.ReadLine();

    if (url == "s")
    {
        url = "https://www.sinoptik.bg/sofia-bulgaria-100727011/10-days";
        break;
    }
    else if (url == "p")
    {
        url = "https://www.sinoptik.bg/plovdiv-bulgaria-100728193/10-days";
        break;
    }
    else if (url == "k")
    {
        url = "https://www.sinoptik.bg/kyustendil-bulgaria-100729730/10-days";
        break;
    }
    else
    {
        Console.WriteLine("Input valid city!");
    }
}



//Take url
await GetWeather(context, url);

static async Task GetWeather(IBrowsingContext context, string url)
{
    var document = await context.OpenAsync(url);
    var recipeNameAndCategory = document
        .QuerySelectorAll("a.wf10dayRight");

    foreach (var item in recipeNameAndCategory)
    {
        var data = item.TextContent.Split("\n", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
        Console.WriteLine($"Date: {data[1]}");
        Console.WriteLine($"Max temp: {data[3]}");
        Console.WriteLine($"Min temp: {data[5]}");
        Console.WriteLine($"Wind speed: {data[8]}");
        Console.WriteLine();

    }
}