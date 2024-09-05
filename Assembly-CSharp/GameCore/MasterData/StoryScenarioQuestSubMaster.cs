// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryScenarioQuestSubMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200116B")]
  [Serializable]
  public sealed class StoryScenarioQuestSubMaster : 
    BaseMaster<StoryScenarioQuestSubData>,
    IStoryQuestMaster
  {
    [Token(Token = "0x6006434")]
    [Address(RVA = "0x4AEE1E0", Offset = "0x4AEE1E0", VA = "0x4AEE1E0")]
    public IReadOnlyDictionary<int, StoryScenarioQuestSubData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryScenarioQuestSubData>) null;
    }

    [Token(Token = "0x6006435")]
    [Address(RVA = "0x4AEE1E8", Offset = "0x4AEE1E8", VA = "0x4AEE1E8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006436")]
    [Address(RVA = "0x4AEE248", Offset = "0x4AEE248", VA = "0x4AEE248", Slot = "5")]
    protected override StoryScenarioQuestSubData LoadEntity(IMasterDataReader reader)
    {
      return (StoryScenarioQuestSubData) null;
    }

    [Token(Token = "0x6006437")]
    [Address(RVA = "0x4AEE2A0", Offset = "0x4AEE2A0", VA = "0x4AEE2A0", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x6006438")]
    [Address(RVA = "0x4AEE2F8", Offset = "0x4AEE2F8", VA = "0x4AEE2F8")]
    public List<StoryScenarioQuestSubData> GetGroupDataForChapter(int chapter)
    {
      return (List<StoryScenarioQuestSubData>) null;
    }

    [Token(Token = "0x6006439")]
    [Address(RVA = "0x4AEE41C", Offset = "0x4AEE41C", VA = "0x4AEE41C")]
    public StoryScenarioQuestSubData GetReleaseConditionQuest(int releaseConditionQuestId)
    {
      return (StoryScenarioQuestSubData) null;
    }

    [Token(Token = "0x600643A")]
    [Address(RVA = "0x4AEE524", Offset = "0x4AEE524", VA = "0x4AEE524")]
    public StoryScenarioQuestSubMaster()
    {
    }
  }
}
