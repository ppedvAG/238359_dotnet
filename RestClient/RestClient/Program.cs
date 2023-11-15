// See https://aka.ms/new-console-template for more information
using RestClient;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

var url = "https://www.googleapis.com/books/v1/volumes?q=katze&maxResults=40&startIndex=40";

var http = new HttpClient();
var json = http.GetStringAsync(url).Result;

var br = System.Text.Json.JsonSerializer.Deserialize<BooksResult>(json);

XmlSerializer xmlSerializer = new XmlSerializer(typeof(BooksResult));
var sw = new StreamWriter("test.xml");
xmlSerializer.Serialize(sw, br);

Console.WriteLine($"Books: {br.totalItems}");

foreach (var book in br.items.Select(x => x.volumeInfo))
    Console.WriteLine($"{book.title}");
