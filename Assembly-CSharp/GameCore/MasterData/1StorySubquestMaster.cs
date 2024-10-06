// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001312")]
  [Serializable]
  public sealed class StorySubquestMaster : BaseMaster<StorySubquestData>
  {
    [Token(Token = "0x4005A2F")]
    public const string TEXT_AB = "text_masterdata_story";
    [Token(Token = "0x4005A30")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StorySubquestData>> groupingTable;

    [Token(Token = "0x6006BB8")]
    [Address(RVA = "0x48E4AB8", Offset = "0x48E4AB8", VA = "0x48E4AB8")]
    public IReadOnlyDictionary<int, StorySubquestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestData>) null;
    }

    [Token(Token = "0x6006BB9")]
    [Address(RVA = "0x48E4AC0", Offset = "0x48E4AC0", VA = "0x48E4AC0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006BBA")]
    [Address(RVA = "0x48E4B84", Offset = "0x48E4B84", VA = "0x48E4B84", Slot = "5")]
    protected override StorySubquestData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestData) null;
    }

    [Token(Token = "0x6006BBB")]
    [Address(RVA = "0x48E4B28", Offset = "0x48E4B28", VA = "0x48E4B28")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006BBC")]
    [Address(RVA = "0x48E4BF4", Offset = "0x48E4BF4", VA = "0x48E4BF4")]
    private void OnLoadEntity(StorySubquestData entity)
    {
    }

    [Token(Token = "0x6006BBD")]
    [Address(RVA = "0x48E4BF8", Offset = "0x48E4BF8", VA = "0x48E4BF8")]
    private void GroupingBySubQuestLabel(StorySubquestData entity)
    {
    }

    [Token(Token = "0x6006BBE")]
    [Address(RVA = "0x48E4D74", Offset = "0x48E4D74", VA = "0x48E4D74")]
    public IEnumerable<StorySubquestData> GetList() => (IEnumerable<StorySubquestData>) null;

    [Token(Token = "0x6006BBF")]
    [Address(RVA = "0x48E4DC4", Offset = "0x48E4DC4", VA = "0x48E4DC4")]
    public IReadOnlyCollection<StorySubquestData> GetListByGroupLable(int grouplabel)
    {
      return (IReadOnlyCollection<StorySubquestData>) null;
    }

    [Token(Token = "0x6006BC0")]
    [Address(RVA = "0x48E4E80", Offset = "0x48E4E80", VA = "0x48E4E80")]
    public IEnumerable<StorySubquestData> GetNextSubquests(int subquestID)
    {
      return (IEnumerable<StorySubquestData>) null;
    }

    [Token(Token = "0x6006BC1")]
    [Address(RVA = "0x48E502C", Offset = "0x48E502C", VA = "0x48E502C")]
    public StorySubquestMaster()
    {
    }
  }
}
