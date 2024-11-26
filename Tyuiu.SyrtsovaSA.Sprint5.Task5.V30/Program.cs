using Tyuiu.SyrtsovaSA.Sprint5.Task5.V30.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task5.V30; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                       *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #30                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Найти максимальное целое число в файле, которое является    *"); 
        Console.WriteLine("* простым числом.Полученный результат вывести на консоль.              *"); 
        Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine(ds.LoadFromDataFile(path));
        Console.ReadKey();
    } 
} 
