using Tyuiu.YakovlevVAa.Sprint0.Task2.V0.Lib;
namespace Tyuiu.YakovlevVAa.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Виктор";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Виктор", res);
        }
    }
}