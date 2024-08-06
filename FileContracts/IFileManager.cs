namespace Taliskar;

public interface IFileManager
{
    bool DoesFileExist(string path);
    Task<string> LoadFileContents(string path);
}
