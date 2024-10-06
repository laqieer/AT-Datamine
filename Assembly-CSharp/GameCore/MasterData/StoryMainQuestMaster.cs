// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200115C")]
  [Serializable]
  public sealed class StoryMainQuestMaster : BaseMaster<StoryMainQuestData>, IStoryQuestMaster
  {
    [Token(Token = "0x4005436")]
    [FieldOffset(Offset = "0x18")]
    private readonly IReadOnlyList<StoryMainQuestData> constEmptylist;
    [Token(Token = "0x4005437")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<StoryMainQuestData>> groupDict;

    [Token(Token = "0x60063D2")]
    [Address(RVA = "0x4AEB748", Offset = "0x4AEB748", VA = "0x4AEB748")]
    public IReadOnlyDictionary<int, StoryMainQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestData>) null;
    }

    [Token(Token = "0x60063D3")]
    [Address(RVA = "0x4AEB750", Offset = "0x4AEB750", VA = "0x4AEB750", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60063D4")]
    [Address(RVA = "0x4AEB808", Offset = "0x4AEB808", VA = "0x4AEB808", Slot = "5")]
    protected override StoryMainQuestData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestData) null;
    }

    [Token(Token = "0x60063D5")]
    [Address(RVA = "0x4AEB7B8", Offset = "0x4AEB7B8", VA = "0x4AEB7B8")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60063D6")]
    [Address(RVA = "0x4AEB878", Offset = "0x4AEB878", VA = "0x4AEB878")]
    private void OnLoadEntity(StoryMainQuestData entity)
    {
    }

    [Token(Token = "0x60063D7")]
    [Address(RVA = "0x4AEBA50", Offset = "0x4AEBA50", VA = "0x4AEBA50", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x60063D8")]
    [Address(RVA = "0x4AEBAA8", Offset = "0x4AEBAA8", VA = "0x4AEBAA8")]
    public IReadOnlyList<StoryMainQuestData> GetGroupList(int questGroupId)
    {
      return (IReadOnlyList<StoryMainQuestData>) null;
    }

    [Token(Token = "0x60063D9")]
    [Address(RVA = "0x4AEBB3C", Offset = "0x4AEBB3C", VA = "0x4AEBB3C")]
    public IReadOnlyCollection<StoryMainQuestData> GetAllItem()
    {
      return (IReadOnlyCollection<StoryMainQuestData>) null;
    }

    [Token(Token = "0x60063DA")]
    [Address(RVA = "0x4AEBB8C", Offset = "0x4AEBB8C", VA = "0x4AEBB8C")]
    public StoryMainQuestData GetReleaseConditionQuest(int releaseConditionQuestId)
    {
      return (StoryMainQuestData) null;
    }

    [Token(Token = "0x60063DB")]
    [Address(RVA = "0x4AEBC94", Offset = "0x4AEBC94", VA = "0x4AEBC94")]
    public StoryMainQuestMaster()
    {
    }
  }
}
