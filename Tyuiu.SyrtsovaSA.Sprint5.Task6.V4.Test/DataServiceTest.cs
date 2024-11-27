using Tyuiu.SyrtsovaSA.Sprint5.Task6.V4.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint5.Task6.V4.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalc()
    {
        DataService dataService = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";
        var res = dataService.LoadFromDataFile(path);
        Assert.AreEqual(2, res);
    }

    [TestMethod]
    public void CheckIfFileExists()
    {
        string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        Assert.AreEqual(true, fileExists);
    }
}
