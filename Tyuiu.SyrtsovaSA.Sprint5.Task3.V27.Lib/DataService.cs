using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SyrtsovaSA.Sprint5.Task3.V27.Lib;

public class DataService : ISprint5Task3V27
{
    public string SaveToFileTextData(int x)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        double y = Math.Round(Math.Pow(x - 1, 3 * x + 1), 3);
        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
        {
            writer.Write(BitConverter.GetBytes(y));
        }
        return path;
    }
}
