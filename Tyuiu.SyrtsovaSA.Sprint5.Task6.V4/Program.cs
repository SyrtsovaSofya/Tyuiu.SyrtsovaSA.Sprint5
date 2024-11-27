using Tyuiu.SyrtsovaSA.Sprint5.Task6.V4.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task6.V4; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Обработка текстовых файлов                                     *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #4                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дан файл в котором есть набор символьных данных. Найти      *"); 
        Console.WriteLine("* количество заглавных русских букв в заданной строке.                 *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine(ds.LoadFromDataFile(path));
        Console.ReadKey();
    } 
} 
