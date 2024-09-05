// Decompiled with JetBrains decompiler
// Type: Story.MasterExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005BC")]
  public static class MasterExtension
  {
    [Token(Token = "0x60020F5")]
    [Address(RVA = "0x2D959E4", Offset = "0x2D959E4", VA = "0x2D959E4")]
    public static StoryMainQuestYearData Year(this StoryMainQuestCalendarData calendar)
    {
      return (StoryMainQuestYearData) null;
    }

    [Token(Token = "0x60020F6")]
    [Address(RVA = "0x2D95A84", Offset = "0x2D95A84", VA = "0x2D95A84")]
    public static StoryDayOfWeekData DayofWeek(this StoryMainQuestCalendarData calendar)
    {
      return (StoryDayOfWeekData) null;
    }
  }
}
