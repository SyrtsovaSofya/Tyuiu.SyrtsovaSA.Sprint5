using Tyuiu.SyrtsovaSA.Sprint5.Task0.V11.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task0.V11.Test; 
 
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
