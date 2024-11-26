using Tyuiu.SyrtsovaSA.Sprint5.Task2.V6.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task2.V6.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = @"C:\Users\Linn\AppData\Local\Temp\OutPutFileTask2.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        Assert.AreEqual(true, fileExists);
    } 
} 
