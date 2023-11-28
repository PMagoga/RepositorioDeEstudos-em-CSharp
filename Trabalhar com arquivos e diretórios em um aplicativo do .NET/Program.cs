using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

//No arquivo Program.cs, crie uma variável chamada salesTotalDir, que contém o caminho para o diretório salesTotalDir:
var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);   // Add this line of code

var salesFiles = FindFiles("stores");

var salesTotal = CalculateSalesTotal(salesFiles);

// No arquivo Program.cs, adicione o código para criar um arquivo vazio chamado totals.txt dentro 
// do diretório salesTotalDir recém-criado. Use uma cadeia de caracteres vazia como o conteúdo do arquivo por enquanto:
// File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);

File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

//loop foreach que faz iterações e grava cada nome de arquivo retornado pela função FindFiles na saída do Console
/* foreach (var file in salesFiles)
{
    Console.WriteLine(file);
} */

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);


    
    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        // The file name will contain the full path, so only check the end of it
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;
    
    // Loop over each file path in salesFiles
    foreach (var file in salesFiles)
    {      
        // Read the contents of the file
        string salesJson = File.ReadAllText(file);
    
        // Parse the contents as JSON
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);
    
        // Add the amount found in the Total field to the salesTotal variable
        salesTotal += data?.Total ?? 0;
    }
    
    return salesTotal;
}

record SalesData (double Total);