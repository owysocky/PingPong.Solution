uisng System;
namespace PingPong
{
  public class PingPong
  {
    public bool IsPingPongNumber(int year)
    {

      if(year % 3 == 0 && year % 5 == 0)
      {
        Console.WriteLine("Beep");
        return true;
      }else if(year % 5 == 0)
      {
        return true;
      }else if(year % 3 == 0)
      {
        return true;

      }else
      {
        return false;
      }
    }
  }
}
