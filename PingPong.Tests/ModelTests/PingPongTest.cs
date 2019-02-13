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
      Assert.AreEqual("Ping-Pong", testPingPong.IsPingPongNumber(15));
    }

    [TestMethod]
    public void IsPingPongNumber_NumberDivisibleByFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("Pong", testPingPong.IsPingPongNumber(10));
    }

    [TestMethod]
    public void IsPingPongNumber_NumberDivisibleByThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("Ping", testPingPong.IsPingPongNumber(6));
    }
  }
}
