namespace Tyuiu.SyrtsovaSA.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckIfFileExists()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V18.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}