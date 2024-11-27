using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SyrtsovaSA.Sprint5.Task6.V4.Lib;

public class DataService : ISprint5Task6V4
{
    public int LoadFromDataFile(string path)
    {
        int count = 0;
        string str = File.ReadAllText(path);
        foreach(char c in str)
        {
            if (char.IsUpper(c) && (Regex.IsMatch(Convert.ToString(c), @"\p{IsCyrillic}")))
                count++;
        }
        return count;
    }
}
