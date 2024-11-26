using Tyuiu.SyrtsovaSA.Sprint5.Task3.V27.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task3.V27.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = @"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint5\Tyuiu.SyrtsovaSA.Sprint5.Task3.V27\bin\Debug\OutPutFileTask3.bin";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        Assert.AreEqual(true, fileExists);
    } 
} 
