using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string filePath = "./books.json";
        // Кирилиця не работає
        string jsonString = File.ReadAllText(filePath, Encoding.UTF8);
        List<Book> books = JsonSerializer.Deserialize<List<Book>>(jsonString);
        var serializedBooks = new List<object>();
        foreach (var book in books)
        {
            serializedBooks.Add(book.ToSerializedObject());
        }
        string resultJson = JsonSerializer.Serialize(serializedBooks, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(resultJson);
    }
}