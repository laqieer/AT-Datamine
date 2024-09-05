// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryScenarioQuestMainMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001167")]
  [Serializable]
  public sealed class StoryScenarioQuestMainMaster : 
    BaseMaster<StoryScenarioQuestMainData>,
    IStoryQuestMaster
  {
    [Token(Token = "0x600641C")]
    [Address(RVA = "0x4AED914", Offset = "0x4AED914", VA = "0x4AED914")]
    public IReadOnlyDictionary<int, StoryScenarioQuestMainData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryScenarioQuestMainData>) null;
    }

    [Token(Token = "0x600641D")]
    [Address(RVA = "0x4AED91C", Offset = "0x4AED91C", VA = "0x4AED91C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600641E")]
    [Address(RVA = "0x4AED97C", Offset = "0x4AED97C", VA = "0x4AED97C", Slot = "5")]
    protected override StoryScenarioQuestMainData LoadEntity(IMasterDataReader reader)
    {
      return (StoryScenarioQuestMainData) null;
    }

    [Token(Token = "0x600641F")]
    [Address(RVA = "0x4AED9D4", Offset = "0x4AED9D4", VA = "0x4AED9D4", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x6006420")]
    [Address(RVA = "0x4AEDA2C", Offset = "0x4AEDA2C", VA = "0x4AEDA2C")]
    public List<StoryScenarioQuestMainData> GetGroupDataForChapter(int chapter)
    {
      return (List<StoryScenarioQuestMainData>) null;
    }

    [Token(Token = "0x6006421")]
    [Address(RVA = "0x4AEDB50", Offset = "0x4AEDB50", VA = "0x4AEDB50")]
    public StoryScenarioQuestMainData GetReleaseConditionQuest(int releaseConditionQuestId)
    {
      return (StoryScenarioQuestMainData) null;
    }

    [Token(Token = "0x6006422")]
    [Address(RVA = "0x4AEDC58", Offset = "0x4AEDC58", VA = "0x4AEDC58")]
    public StoryScenarioQuestMainMaster()
    {
    }
  }
}
