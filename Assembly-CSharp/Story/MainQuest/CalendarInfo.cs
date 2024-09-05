// Decompiled with JetBrains decompiler
// Type: Story.MainQuest.CalendarInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.MainQuest.Calendar;

#nullable disable
namespace Story.MainQuest
{
  [Token(Token = "0x2000677")]
  public class CalendarInfo
  {
    [Token(Token = "0x17000560")]
    public Date CurrentDate
    {
      [Token(Token = "0x60024FB"), Address(RVA = "0x2F35598", Offset = "0x2F35598", VA = "0x2F35598")] get
      {
        return new Date();
      }
      [Token(Token = "0x60024FC"), Address(RVA = "0x2F355AC", Offset = "0x2F355AC", VA = "0x2F355AC")] private set
      {
      }
    }

    [Token(Token = "0x17000561")]
    public bool Valid
    {
      [Token(Token = "0x60024FD"), Address(RVA = "0x2F355C0", Offset = "0x2F355C0", VA = "0x2F355C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000562")]
    public int CalendarID
    {
      [Token(Token = "0x60024FE"), Address(RVA = "0x2F355D0", Offset = "0x2F355D0", VA = "0x2F355D0")] get
      {
        return new int();
      }
      [Token(Token = "0x60024FF"), Address(RVA = "0x2F355D8", Offset = "0x2F355D8", VA = "0x2F355D8")] private set
      {
      }
    }

    [Token(Token = "0x6002500")]
    [Address(RVA = "0x2F355E0", Offset = "0x2F355E0", VA = "0x2F355E0")]
    public void Set(int calendarID)
    {
    }

    [Token(Token = "0x6002501")]
    [Address(RVA = "0x2F357D4", Offset = "0x2F357D4", VA = "0x2F357D4")]
    public bool IsExpired(Date termBegin, Date termEnd, Date current) => new bool();

    [Token(Token = "0x6002502")]
    [Address(RVA = "0x2F357F8", Offset = "0x2F357F8", VA = "0x2F357F8")]
    public CalendarInfo()
    {
    }
  }
}
