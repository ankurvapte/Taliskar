using System.Reflection.Metadata.Ecma335;

namespace Taliskar;

public class FileManager : IFileManager
{
    public FileManager()
    {

    }
    public bool DoesFileExist(string path)
    {
        throw new NotImplementedException();
    }

    public async Task<string> LoadFileContents(string path)
    {
        await Task.Delay(2000);

        return "It took 2 mins for the file to run.";
    }
}
