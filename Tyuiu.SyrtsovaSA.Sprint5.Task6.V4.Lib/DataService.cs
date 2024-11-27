using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SyrtsovaSA.Sprint5.Task6.V4.Lib;

public class DataService : ISprint5Task6V4
{
    public int LoadFromDataFile(string path)
    {
        int count = 0;
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
                count += line.Where(c => c >= '�' && c <= '�' || c == '�').Count();
        }
        return count;
    }
}