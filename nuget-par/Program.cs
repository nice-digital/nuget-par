using Newtonsoft.Json;
using Raven.Abstractions.Data;

var test = new RavenConnectionStringOptions(){};
string json = JsonConvert.SerializeObject("123", Formatting.Indented);


Console.WriteLine("PAR nuget test project");