// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestPeriod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.MainQuest;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020F1")]
  public class SubQuestPeriod
  {
    [Token(Token = "0x17002B08")]
    public CalendarInfo Begin
    {
      [Token(Token = "0x600C7A9"), Address(RVA = "0x1CE067C", Offset = "0x1CE067C", VA = "0x1CE067C")] get
      {
        return (CalendarInfo) null;
      }
    }

    [Token(Token = "0x17002B09")]
    public CalendarInfo End
    {
      [Token(Token = "0x600C7AA"), Address(RVA = "0x1CE0684", Offset = "0x1CE0684", VA = "0x1CE0684")] get
      {
        return (CalendarInfo) null;
      }
    }

    [Token(Token = "0x600C7AB")]
    [Address(RVA = "0x1CE068C", Offset = "0x1CE068C", VA = "0x1CE068C")]
    public bool InRange(int calendarID) => new bool();

    [Token(Token = "0x600C7AC")]
    [Address(RVA = "0x1CDF188", Offset = "0x1CDF188", VA = "0x1CDF188")]
    public SubQuestPeriod(int beginCalendarID, int endCalendarID)
    {
    }
  }
}
