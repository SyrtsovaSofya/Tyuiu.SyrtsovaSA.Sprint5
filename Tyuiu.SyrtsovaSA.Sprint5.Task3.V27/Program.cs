using Tyuiu.SyrtsovaSA.Sprint5.Task3.V27.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task3.V27; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                  *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #27                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дано выражение вычислить его значение при x = 3, результат  *"); 
        Console.WriteLine("* сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль.  *"); 
        Console.WriteLine("* Округлить до трёх знаков после запятой.                              *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        int x = 3;
        Console.WriteLine("x = " + x);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
    } 
} 
