// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200116F")]
  [Serializable]
  public sealed class StorySubQuestMaster : BaseMaster<StorySubQuestData>, IStoryQuestMaster
  {
    [Token(Token = "0x600644C")]
    [Address(RVA = "0x4AEEAAC", Offset = "0x4AEEAAC", VA = "0x4AEEAAC")]
    public IReadOnlyDictionary<int, StorySubQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubQuestData>) null;
    }

    [Token(Token = "0x600644D")]
    [Address(RVA = "0x4AEEAB4", Offset = "0x4AEEAB4", VA = "0x4AEEAB4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600644E")]
    [Address(RVA = "0x4AEEB14", Offset = "0x4AEEB14", VA = "0x4AEEB14", Slot = "5")]
    protected override StorySubQuestData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubQuestData) null;
    }

    [Token(Token = "0x600644F")]
    [Address(RVA = "0x4AEEB6C", Offset = "0x4AEEB6C", VA = "0x4AEEB6C", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x6006450")]
    [Address(RVA = "0x4AEEBC4", Offset = "0x4AEEBC4", VA = "0x4AEEBC4")]
    public IReadOnlyCollection<StorySubQuestData> GetAllItem()
    {
      return (IReadOnlyCollection<StorySubQuestData>) null;
    }

    [Token(Token = "0x6006451")]
    [Address(RVA = "0x4AEEC14", Offset = "0x4AEEC14", VA = "0x4AEEC14")]
    public StorySubQuestData GetReleaseConditionQuest(int releaseConditionQuestId)
    {
      return (StorySubQuestData) null;
    }

    [Token(Token = "0x6006452")]
    [Address(RVA = "0x4AEED1C", Offset = "0x4AEED1C", VA = "0x4AEED1C")]
    public StorySubQuestMaster()
    {
    }
  }
}
