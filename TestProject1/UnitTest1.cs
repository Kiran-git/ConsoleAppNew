namespace ConsoleAppNew
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculater c = new Calculater();
            int result = ConsoleAppNew.Calculater.add(10, 20);
            Assert.AreEqual(30, result);
        }
    }
}