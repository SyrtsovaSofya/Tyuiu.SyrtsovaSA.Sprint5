using Tyuiu.SyrtsovaSA.Sprint5.Task1.V4.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task1.V4.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = @"C:\Users\Linn\AppData\Local\Temp\OutPutFileTask0.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        Assert.AreEqual(true, fileExists);
    } 
} 
