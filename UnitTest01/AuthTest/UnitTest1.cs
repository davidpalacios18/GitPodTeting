using AuthTesting;

namespace AuthTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        string result = AuthTesting.Program.Something();

        Assert.AreEqual("Algo", result);
    }


    // * Dos Caminos: Correcto e incorrecto
    [TestMethod]
    public void TestLoginTrue()
    {
        bool result = AuthTesting.Program.Login("dpalacios", "123456");
        Assert.AreEqual(true, result);
    }


    [TestMethod]
    public void TestLoginFalse()
    {
        bool result = AuthTesting.Program.Login("dpalacios2", "123456");
        Assert.AreEqual(false, result);
    }
}