using Tyuiu.SyrtsovaSA.Sprint5.Task4.V22.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task4.V22; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Чтение данных из текстового файла                              *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #22                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дан файл в котором есть вещественное значение. Прочитать    *"); 
        Console.WriteLine("* значение из файла и подставить вместо Х в формуле. Вычислить         *"); 
        Console.WriteLine("* значение по формуле и вернуть полученный результат на консоль.       *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine(ds.LoadFromDataFile(path));
        Console.ReadKey();
    } 
} 
