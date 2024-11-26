using Tyuiu.SyrtsovaSA.Sprint5.Task4.V22.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task4.V22.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        Assert.AreEqual(true, fileExists);
    } 
} 
