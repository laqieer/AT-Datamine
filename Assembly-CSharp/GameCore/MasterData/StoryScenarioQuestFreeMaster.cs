// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryScenarioQuestFreeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001163")]
  [Serializable]
  public sealed class StoryScenarioQuestFreeMaster : 
    BaseMaster<StoryScenarioQuestFreeData>,
    IStoryQuestMaster
  {
    [Token(Token = "0x6006401")]
    [Address(RVA = "0x4AECCDC", Offset = "0x4AECCDC", VA = "0x4AECCDC")]
    public IReadOnlyDictionary<int, StoryScenarioQuestFreeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryScenarioQuestFreeData>) null;
    }

    [Token(Token = "0x6006402")]
    [Address(RVA = "0x4AECCE4", Offset = "0x4AECCE4", VA = "0x4AECCE4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006403")]
    [Address(RVA = "0x4AECD44", Offset = "0x4AECD44", VA = "0x4AECD44", Slot = "5")]
    protected override StoryScenarioQuestFreeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryScenarioQuestFreeData) null;
    }

    [Token(Token = "0x6006404")]
    [Address(RVA = "0x4AECD9C", Offset = "0x4AECD9C", VA = "0x4AECD9C", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x6006405")]
    [Address(RVA = "0x4AECDF4", Offset = "0x4AECDF4", VA = "0x4AECDF4")]
    public List<StoryScenarioQuestFreeData> GetGroupDataForChapter(int chapter)
    {
      return (List<StoryScenarioQuestFreeData>) null;
    }

    [Token(Token = "0x6006406")]
    [Address(RVA = "0x4AECF18", Offset = "0x4AECF18", VA = "0x4AECF18")]
    public StoryScenarioQuestFreeData GetReleaseConditionQuest(int releaseConditionQuestId)
    {
      return (StoryScenarioQuestFreeData) null;
    }

    [Token(Token = "0x6006407")]
    [Address(RVA = "0x4AED020", Offset = "0x4AED020", VA = "0x4AED020")]
    public IReadOnlyCollection<StoryScenarioQuestFreeData> GetAllItem()
    {
      return (IReadOnlyCollection<StoryScenarioQuestFreeData>) null;
    }

    [Token(Token = "0x6006408")]
    [Address(RVA = "0x4AED070", Offset = "0x4AED070", VA = "0x4AED070")]
    public StoryScenarioQuestFreeMaster()
    {
    }
  }
}
