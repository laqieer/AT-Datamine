// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestTaskMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001318")]
  [Serializable]
  public sealed class StorySubquestTaskMaster : BaseMaster<StorySubquestTaskData>
  {
    [Token(Token = "0x4005A49")]
    public const string TEXT_AB = "text_masterdata_story";
    [Token(Token = "0x4005A4A")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StorySubquestTaskData>> groupingTable;

    [Token(Token = "0x6006BD7")]
    [Address(RVA = "0x48E6074", Offset = "0x48E6074", VA = "0x48E6074")]
    public IReadOnlyDictionary<int, StorySubquestTaskData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestTaskData>) null;
    }

    [Token(Token = "0x6006BD8")]
    [Address(RVA = "0x48E607C", Offset = "0x48E607C", VA = "0x48E607C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006BD9")]
    [Address(RVA = "0x48E6184", Offset = "0x48E6184", VA = "0x48E6184", Slot = "5")]
    protected override StorySubquestTaskData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestTaskData) null;
    }

    [Token(Token = "0x6006BDA")]
    [Address(RVA = "0x48E60E4", Offset = "0x48E60E4", VA = "0x48E60E4")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006BDB")]
    [Address(RVA = "0x48E61F4", Offset = "0x48E61F4", VA = "0x48E61F4")]
    private void OnLoadEntity(StorySubquestTaskData entity)
    {
    }

    [Token(Token = "0x6006BDC")]
    [Address(RVA = "0x48E61F8", Offset = "0x48E61F8", VA = "0x48E61F8")]
    private void GroupingBySubQuestID(StorySubquestTaskData entity)
    {
    }

    [Token(Token = "0x6006BDD")]
    [Address(RVA = "0x48E6374", Offset = "0x48E6374", VA = "0x48E6374")]
    public IReadOnlyCollection<StorySubquestTaskData> GetListBySubQuestID(int subquestID)
    {
      return (IReadOnlyCollection<StorySubquestTaskData>) null;
    }

    [Token(Token = "0x6006BDE")]
    [Address(RVA = "0x48E6430", Offset = "0x48E6430", VA = "0x48E6430")]
    public IReadOnlyCollection<StorySubquestTaskData> GetListBySubQuestBattleID(int subQuestBattleId)
    {
      return (IReadOnlyCollection<StorySubquestTaskData>) null;
    }

    [Token(Token = "0x6006BDF")]
    [Address(RVA = "0x48E6554", Offset = "0x48E6554", VA = "0x48E6554")]
    public IEnumerable<StorySubquestTaskData> GetList()
    {
      return (IEnumerable<StorySubquestTaskData>) null;
    }

    [Token(Token = "0x6006BE0")]
    [Address(RVA = "0x48E65A4", Offset = "0x48E65A4", VA = "0x48E65A4")]
    public StorySubquestTaskMaster()
    {
    }
  }
}
