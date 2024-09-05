// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvProcessOneMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DBF")]
  [Serializable]
  public sealed class AdvProcessOneMaster : BaseMaster<AdvProcessOneData>
  {
    [Token(Token = "0x40041C5")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AdvProcessOneData>> processTable;

    [Token(Token = "0x600540D")]
    [Address(RVA = "0x3AA09EC", Offset = "0x3AA09EC", VA = "0x3AA09EC")]
    public IReadOnlyDictionary<int, AdvProcessOneData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvProcessOneData>) null;
    }

    [Token(Token = "0x600540E")]
    [Address(RVA = "0x3AA09F4", Offset = "0x3AA09F4", VA = "0x3AA09F4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600540F")]
    [Address(RVA = "0x3AA0AAC", Offset = "0x3AA0AAC", VA = "0x3AA0AAC", Slot = "5")]
    protected override AdvProcessOneData LoadEntity(IMasterDataReader reader)
    {
      return (AdvProcessOneData) null;
    }

    [Token(Token = "0x6005410")]
    [Address(RVA = "0x3AA0A5C", Offset = "0x3AA0A5C", VA = "0x3AA0A5C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005411")]
    [Address(RVA = "0x3AA0B1C", Offset = "0x3AA0B1C", VA = "0x3AA0B1C")]
    private void OnLoadEntity(AdvProcessOneData entity)
    {
    }

    [Token(Token = "0x6005412")]
    [Address(RVA = "0x3AA0C98", Offset = "0x3AA0C98", VA = "0x3AA0C98")]
    public List<AdvProcessOneData> GetProcessOrderTable(int processID)
    {
      return (List<AdvProcessOneData>) null;
    }

    [Token(Token = "0x6005413")]
    [Address(RVA = "0x3AA0D54", Offset = "0x3AA0D54", VA = "0x3AA0D54")]
    public AdvProcessOneMaster()
    {
    }
  }
}
