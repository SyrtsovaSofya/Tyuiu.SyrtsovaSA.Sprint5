using Tyuiu.SyrtsovaSA.Sprint5.Task0.V11.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task0.V11; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                     *"); 
        Console.WriteLine("* Задание #0                                                           *"); 
        Console.WriteLine("* Вариант #11                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дано выражение вычислить его значение при x = 3, результат  *"); 
        Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. *"); 
        Console.WriteLine("* Округлить до трёх знаков после запятой.                              *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: x = 3                                               *"); 
        Console.WriteLine("************************************************************************");
        int x = 3;
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    } 
} 
