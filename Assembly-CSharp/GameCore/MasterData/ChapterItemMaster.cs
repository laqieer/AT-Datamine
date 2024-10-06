// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChapterItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001048")]
  [Serializable]
  public sealed class ChapterItemMaster : BaseMaster<ChapterItemData>
  {
    [Token(Token = "0x40050A5")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<ChapterItemData> groupedByFacilityTag;
    [Token(Token = "0x40050A6")]
    [FieldOffset(Offset = "0x20")]
    private List<ChapterItemData> books;
    [Token(Token = "0x40050A7")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005E8D")]
    [Address(RVA = "0x28C4A98", Offset = "0x28C4A98", VA = "0x28C4A98")]
    public IReadOnlyDictionary<int, ChapterItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ChapterItemData>) null;
    }

    [Token(Token = "0x6005E8E")]
    [Address(RVA = "0x28C4AA0", Offset = "0x28C4AA0", VA = "0x28C4AA0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E8F")]
    [Address(RVA = "0x28C4CE8", Offset = "0x28C4CE8", VA = "0x28C4CE8", Slot = "5")]
    protected override ChapterItemData LoadEntity(IMasterDataReader reader)
    {
      return (ChapterItemData) null;
    }

    [Token(Token = "0x6005E90")]
    [Address(RVA = "0x28C4B08", Offset = "0x28C4B08", VA = "0x28C4B08")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005E91")]
    [Address(RVA = "0x28C4D58", Offset = "0x28C4D58", VA = "0x28C4D58")]
    private void OnLoadEntity(ChapterItemData entity)
    {
    }

    [Token(Token = "0x6005E92")]
    [Address(RVA = "0x28C4E38", Offset = "0x28C4E38", VA = "0x28C4E38")]
    public List<ChapterItemData> GetTagedList(int tag) => (List<ChapterItemData>) null;

    [Token(Token = "0x6005E93")]
    [Address(RVA = "0x28C4E90", Offset = "0x28C4E90", VA = "0x28C4E90")]
    public List<ChapterItemData> GetBooks() => (List<ChapterItemData>) null;

    [Token(Token = "0x6005E94")]
    [Address(RVA = "0x28C4E98", Offset = "0x28C4E98", VA = "0x28C4E98")]
    public IReadOnlyCollection<ChapterItemData> GetList()
    {
      return (IReadOnlyCollection<ChapterItemData>) null;
    }

    [Token(Token = "0x6005E95")]
    [Address(RVA = "0x28C4EE8", Offset = "0x28C4EE8", VA = "0x28C4EE8")]
    public ChapterItemMaster()
    {
    }
  }
}
