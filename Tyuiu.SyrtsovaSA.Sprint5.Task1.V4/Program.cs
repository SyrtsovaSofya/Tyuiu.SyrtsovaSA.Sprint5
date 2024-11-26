using Tyuiu.SyrtsovaSA.Sprint5.Task1.V4.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task1.V4; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл.             *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #4                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine($"startValue = {startValue}");
        Console.WriteLine($"stopValue = {stopValue}");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
    } 
} 
