// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001154")]
  [Serializable]
  public sealed class StoryFreeQuestMaster : BaseMaster<StoryFreeQuestData>, IStoryQuestMaster
  {
    [Token(Token = "0x4005414")]
    [FieldOffset(Offset = "0x18")]
    private readonly IReadOnlyList<StoryFreeQuestData> constEmptylist;
    [Token(Token = "0x4005415")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<StoryFreeQuestData>> groupDict;

    [Token(Token = "0x600639E")]
    [Address(RVA = "0x4AE9BAC", Offset = "0x4AE9BAC", VA = "0x4AE9BAC")]
    public IReadOnlyDictionary<int, StoryFreeQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeQuestData>) null;
    }

    [Token(Token = "0x600639F")]
    [Address(RVA = "0x4AE9BB4", Offset = "0x4AE9BB4", VA = "0x4AE9BB4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60063A0")]
    [Address(RVA = "0x4AE9C6C", Offset = "0x4AE9C6C", VA = "0x4AE9C6C", Slot = "5")]
    protected override StoryFreeQuestData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeQuestData) null;
    }

    [Token(Token = "0x60063A1")]
    [Address(RVA = "0x4AE9C1C", Offset = "0x4AE9C1C", VA = "0x4AE9C1C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60063A2")]
    [Address(RVA = "0x4AE9CDC", Offset = "0x4AE9CDC", VA = "0x4AE9CDC")]
    private void OnLoadEntity(StoryFreeQuestData entity)
    {
    }

    [Token(Token = "0x60063A3")]
    [Address(RVA = "0x4AE9EB4", Offset = "0x4AE9EB4", VA = "0x4AE9EB4", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x60063A4")]
    [Address(RVA = "0x4AE9F0C", Offset = "0x4AE9F0C", VA = "0x4AE9F0C")]
    public IReadOnlyList<StoryFreeQuestData> GetGroupList(int questGroupId)
    {
      return (IReadOnlyList<StoryFreeQuestData>) null;
    }

    [Token(Token = "0x60063A5")]
    [Address(RVA = "0x4AE9FA0", Offset = "0x4AE9FA0", VA = "0x4AE9FA0")]
    public IReadOnlyCollection<StoryFreeQuestData> GetAllItem()
    {
      return (IReadOnlyCollection<StoryFreeQuestData>) null;
    }

    [Token(Token = "0x60063A6")]
    [Address(RVA = "0x4AE9FF0", Offset = "0x4AE9FF0", VA = "0x4AE9FF0")]
    public IReadOnlyCollection<StoryFreeQuestData> GetChapterQuestList(int chapter)
    {
      return (IReadOnlyCollection<StoryFreeQuestData>) null;
    }

    [Token(Token = "0x60063A7")]
    [Address(RVA = "0x4AEA114", Offset = "0x4AEA114", VA = "0x4AEA114")]
    public IReadOnlyCollection<int> GetFreeQuestChapterIDs() => (IReadOnlyCollection<int>) null;

    [Token(Token = "0x60063A8")]
    [Address(RVA = "0x4AEA3EC", Offset = "0x4AEA3EC", VA = "0x4AEA3EC")]
    public IReadOnlyCollection<int> GetFreeQuestRouteIDs(int chapter)
    {
      return (IReadOnlyCollection<int>) null;
    }

    [Token(Token = "0x60063A9")]
    [Address(RVA = "0x4AEA774", Offset = "0x4AEA774", VA = "0x4AEA774")]
    public IReadOnlyCollection<StoryFreeQuestData> GetTargetQuestList(
      int routeId,
      QuestDifficultyTypeEnum questDifficultyType)
    {
      return (IReadOnlyCollection<StoryFreeQuestData>) null;
    }

    [Token(Token = "0x60063AA")]
    [Address(RVA = "0x4AEA96C", Offset = "0x4AEA96C", VA = "0x4AEA96C")]
    public StoryFreeQuestMaster()
    {
    }
  }
}
