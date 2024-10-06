// Decompiled with JetBrains decompiler
// Type: Story.MainQuest.Calendar.Date
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.MainQuest.Calendar
{
  [Token(Token = "0x2000678")]
  public struct Date
  {
    [Token(Token = "0x17000563")]
    public readonly Year Year
    {
      [Token(Token = "0x6002503"), Address(RVA = "0x2F35800", Offset = "0x2F35800", VA = "0x2F35800")] get
      {
        return (Year) null;
      }
    }

    [Token(Token = "0x17000564")]
    public readonly int Month
    {
      [Token(Token = "0x6002504"), Address(RVA = "0x2F35808", Offset = "0x2F35808", VA = "0x2F35808")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000565")]
    public readonly int DateNum
    {
      [Token(Token = "0x6002505"), Address(RVA = "0x2F35810", Offset = "0x2F35810", VA = "0x2F35810")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000566")]
    public readonly DayOfWeek DayOfWeek
    {
      [Token(Token = "0x6002506"), Address(RVA = "0x2F35818", Offset = "0x2F35818", VA = "0x2F35818")] get
      {
        return (DayOfWeek) null;
      }
    }

    [Token(Token = "0x17000567")]
    public readonly int HolidayFlg
    {
      [Token(Token = "0x6002507"), Address(RVA = "0x2F35820", Offset = "0x2F35820", VA = "0x2F35820")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000568")]
    public readonly string HolidayName
    {
      [Token(Token = "0x6002508"), Address(RVA = "0x2F35828", Offset = "0x2F35828", VA = "0x2F35828")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000569")]
    public readonly int CalendarId
    {
      [Token(Token = "0x6002509"), Address(RVA = "0x2F35830", Offset = "0x2F35830", VA = "0x2F35830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700056A")]
    public readonly int ThroughoutDays
    {
      [Token(Token = "0x600250A"), Address(RVA = "0x2F35838", Offset = "0x2F35838", VA = "0x2F35838")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600250B")]
    [Address(RVA = "0x2F35628", Offset = "0x2F35628", VA = "0x2F35628")]
    public Date(int calendarId)
    {
    }
  }
}
