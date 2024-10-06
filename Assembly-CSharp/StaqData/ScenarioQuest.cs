// Decompiled with JetBrains decompiler
// Type: StaqData.ScenarioQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020C5")]
  public class ScenarioQuest
  {
    [Token(Token = "0x17002A86")]
    public static int ViewEventId
    {
      [Token(Token = "0x600C67E"), Address(RVA = "0x1CD7264", Offset = "0x1CD7264", VA = "0x1CD7264")] get
      {
        return new int();
      }
      [Token(Token = "0x600C67F"), Address(RVA = "0x1CD72AC", Offset = "0x1CD72AC", VA = "0x1CD72AC")] set
      {
      }
    }

    [Token(Token = "0x17002A87")]
    public static string TextOutsideThePeriod
    {
      [Token(Token = "0x600C680"), Address(RVA = "0x1CD72F8", Offset = "0x1CD72F8", VA = "0x1CD72F8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600C681")]
    [Address(RVA = "0x1CD7378", Offset = "0x1CD7378", VA = "0x1CD7378")]
    public static IOrderedEnumerable<StoryScenarioQuestData> GetActiveEvents()
    {
      return (IOrderedEnumerable<StoryScenarioQuestData>) null;
    }

    [Token(Token = "0x600C682")]
    [Address(RVA = "0x1CD7740", Offset = "0x1CD7740", VA = "0x1CD7740")]
    public static StoryScenarioQuestData[] GetActiveEventArray() => (StoryScenarioQuestData[]) null;

    [Token(Token = "0x600C683")]
    [Address(RVA = "0x1CD7784", Offset = "0x1CD7784", VA = "0x1CD7784")]
    public static StoryScenarioQuestData GetActiveEventData(int eventId)
    {
      return (StoryScenarioQuestData) null;
    }

    [Token(Token = "0x600C684")]
    [Address(RVA = "0x1CD7868", Offset = "0x1CD7868", VA = "0x1CD7868")]
    public static StoryScenarioQuestData GetActiveEventData() => (StoryScenarioQuestData) null;

    [Token(Token = "0x600C685")]
    [Address(RVA = "0x1CD796C", Offset = "0x1CD796C", VA = "0x1CD796C")]
    public static StoryScenarioQuestData GetActiveEventTop() => (StoryScenarioQuestData) null;

    [Token(Token = "0x600C686")]
    [Address(RVA = "0x1CD79B0", Offset = "0x1CD79B0", VA = "0x1CD79B0")]
    public static IEnumerable<int> GetEventIds() => (IEnumerable<int>) null;

    [Token(Token = "0x600C687")]
    [Address(RVA = "0x1CD7AB4", Offset = "0x1CD7AB4", VA = "0x1CD7AB4")]
    public static bool IsAvailableScenarioQuest(int id) => new bool();

    [Token(Token = "0x600C688")]
    [Address(RVA = "0x1CD7B34", Offset = "0x1CD7B34", VA = "0x1CD7B34")]
    public static bool IsManyActiveScenarioQuest() => new bool();

    [Token(Token = "0x600C689")]
    [Address(RVA = "0x1CD7B84", Offset = "0x1CD7B84", VA = "0x1CD7B84")]
    public static void PlayBGM()
    {
    }

    [Token(Token = "0x600C68A")]
    [Address(RVA = "0x1CD7DB4", Offset = "0x1CD7DB4", VA = "0x1CD7DB4")]
    public ScenarioQuest()
    {
    }
  }
}
