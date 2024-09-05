// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryObliviaeQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200115F")]
  [Serializable]
  public sealed class StoryObliviaeQuestMaster : 
    BaseMaster<StoryObliviaeQuestData>,
    IStoryQuestMaster
  {
    [Token(Token = "0x60063EA")]
    [Address(RVA = "0x4AEC2EC", Offset = "0x4AEC2EC", VA = "0x4AEC2EC")]
    public IReadOnlyDictionary<int, StoryObliviaeQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryObliviaeQuestData>) null;
    }

    [Token(Token = "0x60063EB")]
    [Address(RVA = "0x4AEC2F4", Offset = "0x4AEC2F4", VA = "0x4AEC2F4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60063EC")]
    [Address(RVA = "0x4AEC354", Offset = "0x4AEC354", VA = "0x4AEC354", Slot = "5")]
    protected override StoryObliviaeQuestData LoadEntity(IMasterDataReader reader)
    {
      return (StoryObliviaeQuestData) null;
    }

    [Token(Token = "0x60063ED")]
    [Address(RVA = "0x4AEC3AC", Offset = "0x4AEC3AC", VA = "0x4AEC3AC", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x60063EE")]
    [Address(RVA = "0x4AEC404", Offset = "0x4AEC404", VA = "0x4AEC404")]
    public IReadOnlyCollection<StoryObliviaeQuestData> GetListByObliviaeDetailID(
      int obliviaeDetailId)
    {
      return (IReadOnlyCollection<StoryObliviaeQuestData>) null;
    }

    [Token(Token = "0x60063EF")]
    [Address(RVA = "0x4AEC528", Offset = "0x4AEC528", VA = "0x4AEC528")]
    public IEnumerable<StoryObliviaeQuestData> GetAllItem()
    {
      return (IEnumerable<StoryObliviaeQuestData>) null;
    }

    [Token(Token = "0x60063F0")]
    [Address(RVA = "0x4AEC578", Offset = "0x4AEC578", VA = "0x4AEC578")]
    public StoryObliviaeQuestData GetReleaseConditionQuest(int releaseConditionQuestId)
    {
      return (StoryObliviaeQuestData) null;
    }

    [Token(Token = "0x60063F1")]
    [Address(RVA = "0x4AEC680", Offset = "0x4AEC680", VA = "0x4AEC680")]
    public StoryObliviaeQuestMaster()
    {
    }
  }
}
