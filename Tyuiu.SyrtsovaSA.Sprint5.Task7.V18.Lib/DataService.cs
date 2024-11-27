using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task7.V18.Lib;

public class DataService : ISprint5Task7V18
{
    public string LoadDataAndSave(string path)
    {
        string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V18.txt");
        FileInfo fileInfo = new FileInfo(pathSaveFile);
        if (fileInfo.Exists)
            File.Delete(pathSaveFile);
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string str = line.Replace("н", "нн");
                File.AppendAllText(pathSaveFile, str);
            }
        }
        return pathSaveFile;
    }
} 
