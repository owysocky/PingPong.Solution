using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPongNumber_NumberDivisibleByThreeAndFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPongNumber(15));
    }

    [TestMethod]
    public void IsPingPongNumber_NumberDivisibleByFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPongNumber(9));
    }

    [TestMethod]
    public void IsPingPongNumber_NumberDivisibleByThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPongNumber(8));
    }
  }
}
