using Newtonsoft.Json;
using Raven.Client.Documents;

string json = JsonConvert.SerializeObject("123", Formatting.Indented);

var store = new DocumentStore();
Console.WriteLine("PAR nuget test project");