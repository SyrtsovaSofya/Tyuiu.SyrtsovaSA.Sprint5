using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task1.V4.Lib;

public class DataService : ISprint5Task1V4
{
    public string SaveToFileTextData(int startValue, int stopValue)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
        FileInfo fileInfo = new FileInfo(path);
        if (fileInfo.Exists)
            File.Delete(path);
        double y;
        string strY;
        for (int x = startValue; x <= stopValue; x++)
        {
            if (x != -1)
                y = Math.Round(Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x, 2);
            else
                y = 0;
            strY = Convert.ToString(y);
            if (x != stopValue)
                File.AppendAllText(path, strY + Environment.NewLine);
            else
                File.AppendAllText(path, strY);
        }
        return path;
    }
} 
