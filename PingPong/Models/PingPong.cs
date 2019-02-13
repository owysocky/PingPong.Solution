
namespace PingPong
{
  public class PingPong
  {
    public string IsPingPongNumber(int year)
    {

      if(year % 3 == 0 && year % 5 == 0)
      {
        return "Ping-Pong";
      }else if(year % 5 == 0)
      {
        return "Pong";
      }else if(year % 3 == 0)
      {
        return "Ping";
      }else
      {
        return "false";
      }
    }
  }
}
