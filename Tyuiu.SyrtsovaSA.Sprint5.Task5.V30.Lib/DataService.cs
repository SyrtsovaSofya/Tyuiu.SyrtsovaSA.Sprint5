using System;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SyrtsovaSA.Sprint5.Task5.V30.Lib;

public class DataService : ISprint5Task5V30
{
    public double LoadFromDataFile(string path)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        double max = 0;
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] strNums = line.Split();
                foreach (string strNum in strNums)
                {
                    double num = (Convert.ToDouble(strNum));
                    if ((int)num == num && num > max)
                    {
                        bool isPrime = true;
                        for (int i = 2; i <= num / 2; i++)
                            if (num % i == 0)
                                isPrime = false;
                        if (isPrime || num == 2)
                            max = num;
                    }
                }
            }
            return max;
        }
    }
}
