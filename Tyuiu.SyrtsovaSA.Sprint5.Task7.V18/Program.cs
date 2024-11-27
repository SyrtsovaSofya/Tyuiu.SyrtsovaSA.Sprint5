using Tyuiu.SyrtsovaSA.Sprint5.Task7.V18.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task7.V18; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #18                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дан файл, в котором есть набор символьных данных. Заменить  *"); 
        Console.WriteLine("* все буквы н на нн. Полученный результат сохранить в файл             *"); 
        Console.WriteLine("* OutPutDataFileTask7V18.txt.                                          *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
        string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V18.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine($"Находится в файле: ");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);
        Console.ReadKey();
    } 
} 
