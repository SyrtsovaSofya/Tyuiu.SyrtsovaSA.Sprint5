using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SyrtsovaSA.Sprint5.Task4.V22.Lib;

public class DataService : ISprint5Task4V22
{
    public double LoadFromDataFile(string path)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string strX= File.ReadAllText(path);
        double x = double.Parse(strX);
        double res = Math.Round(Math.Pow(x, 3) * Math.Sin(x) - 4 * x, 3);
        return res;
    }
}
