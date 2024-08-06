// See https://aka.ms/new-console-template for more information
using Taliskar;

IFileManager fileManager = new FileManager();

Console.WriteLine("This line is written before the file is about to be read.");
var filecontents = fileManager.LoadFileContents("LongFile.txt");
Console.WriteLine("This line is written immediately after the longest file on planet is read. ");
Console.WriteLine("The file reading is now complete and this is the content - {0}", filecontents.Result);