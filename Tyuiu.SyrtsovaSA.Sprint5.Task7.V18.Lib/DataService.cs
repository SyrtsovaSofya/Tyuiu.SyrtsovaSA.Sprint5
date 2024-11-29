﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SyrtsovaSA.Sprint5.Task7.V18.Lib;

public class DataService : ISprint5Task7V18
{
    public string LoadDataAndSave(string path)
    {
        string str = File.ReadAllText(path);
        str = str.Replace("н", "нн");
        string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V18.txt");
        File.WriteAllText(pathSaveFile, str);
        return pathSaveFile; 
    }
}