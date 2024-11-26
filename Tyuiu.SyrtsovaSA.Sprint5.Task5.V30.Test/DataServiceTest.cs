using Tyuiu.SyrtsovaSA.Sprint5.Task5.V30.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint5.Task5.V30.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        Assert.AreEqual(true, fileExists);
    } 
} 
