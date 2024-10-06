// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MaxLimitBreakMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F6E")]
  [Serializable]
  public sealed class MaxLimitBreakMaster : BaseMaster<MaxLimitBreakData>
  {
    [Token(Token = "0x4004DD5")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<ItemTypeEnum, int> dic;

    [Token(Token = "0x6005AD2")]
    [Address(RVA = "0x277B1A4", Offset = "0x277B1A4", VA = "0x277B1A4")]
    public IReadOnlyDictionary<int, MaxLimitBreakData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MaxLimitBreakData>) null;
    }

    [Token(Token = "0x6005AD3")]
    [Address(RVA = "0x277B1AC", Offset = "0x277B1AC", VA = "0x277B1AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005AD4")]
    [Address(RVA = "0x277B20C", Offset = "0x277B20C", VA = "0x277B20C", Slot = "5")]
    protected override MaxLimitBreakData LoadEntity(IMasterDataReader reader)
    {
      return (MaxLimitBreakData) null;
    }

    [Token(Token = "0x6005AD5")]
    [Address(RVA = "0x277B27C", Offset = "0x277B27C", VA = "0x277B27C")]
    private void OnLoadEntity(MaxLimitBreakData entity)
    {
    }

    [Token(Token = "0x6005AD6")]
    [Address(RVA = "0x277B280", Offset = "0x277B280", VA = "0x277B280")]
    private void MapByItem(MaxLimitBreakData entity)
    {
    }

    [Token(Token = "0x6005AD7")]
    [Address(RVA = "0x277B31C", Offset = "0x277B31C", VA = "0x277B31C")]
    public int GetMaxLimitBreak(ItemTypeEnum itemType) => new int();

    [Token(Token = "0x6005AD8")]
    [Address(RVA = "0x277B38C", Offset = "0x277B38C", VA = "0x277B38C")]
    public MaxLimitBreakMaster()
    {
    }
  }
}
