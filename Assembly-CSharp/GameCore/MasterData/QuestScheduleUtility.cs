// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.QuestScheduleUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001432")]
  internal static class QuestScheduleUtility
  {
    [Token(Token = "0x600719E")]
    [Address(RVA = "0x4048DE0", Offset = "0x4048DE0", VA = "0x4048DE0")]
    public static bool IsAvailablePeriod(int questId, QuestTypeEnum questType) => new bool();

    [Token(Token = "0x600719F")]
    [Address(RVA = "0x4048ED8", Offset = "0x4048ED8", VA = "0x4048ED8")]
    public static bool TryGetPeriod(
      int questId,
      QuestTypeEnum questType,
      out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }

    [Token(Token = "0x60071A0")]
    [Address(RVA = "0x40491C0", Offset = "0x40491C0", VA = "0x40491C0")]
    private static bool TryGetPeriod(
      int questId,
      StoryScenarioQuestMainMaster master,
      out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }

    [Token(Token = "0x60071A1")]
    [Address(RVA = "0x40492F4", Offset = "0x40492F4", VA = "0x40492F4")]
    private static bool TryGetPeriod(
      int questId,
      StoryScenarioQuestSubMaster master,
      out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }

    [Token(Token = "0x60071A2")]
    [Address(RVA = "0x4049428", Offset = "0x4049428", VA = "0x4049428")]
    private static bool TryGetPeriod(
      int questId,
      StoryScenarioQuestFreeMaster master,
      out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }

    [Token(Token = "0x60071A3")]
    [Address(RVA = "0x404955C", Offset = "0x404955C", VA = "0x404955C")]
    private static bool TryGetPeriod(
      int questId,
      SpecialQuestMaster master,
      out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }

    [Token(Token = "0x60071A4")]
    [Address(RVA = "0x40496A4", Offset = "0x40496A4", VA = "0x40496A4")]
    private static bool TryGetPeriod(
      int questId,
      LimitedEventQuestStageMaster master,
      out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }

    [Token(Token = "0x60071A5")]
    [Address(RVA = "0x404981C", Offset = "0x404981C", VA = "0x404981C")]
    private static bool TryGetPeriod(int questId, out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }

    [Token(Token = "0x60071A6")]
    [Address(RVA = "0x4049DE0", Offset = "0x4049DE0", VA = "0x4049DE0")]
    private static bool TryGetGuildRaidPeriod(
      int questId,
      out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }

    [Token(Token = "0x60071A7")]
    [Address(RVA = "0x4049914", Offset = "0x4049914", VA = "0x4049914")]
    private static bool TryGetPeriod(
      int questId,
      AreaQuestAreaNodeQuestMaster master,
      out (DateTime beginAt, DateTime endAt) period)
    {
      return new bool();
    }
  }
}
