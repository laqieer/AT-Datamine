// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E01")]
  [Serializable]
  public sealed class BattleBadStatusGroupMaster : BaseMaster<BattleBadStatusGroupData>
  {
    [Token(Token = "0x40042E5")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<int>> idsMapByGroup;

    [Token(Token = "0x600556D")]
    [Address(RVA = "0x3AB07FC", Offset = "0x3AB07FC", VA = "0x3AB07FC")]
    public IReadOnlyDictionary<int, BattleBadStatusGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleBadStatusGroupData>) null;
    }

    [Token(Token = "0x600556E")]
    [Address(RVA = "0x3AB0804", Offset = "0x3AB0804", VA = "0x3AB0804", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600556F")]
    [Address(RVA = "0x3AB0864", Offset = "0x3AB0864", VA = "0x3AB0864", Slot = "5")]
    protected override BattleBadStatusGroupData LoadEntity(IMasterDataReader reader)
    {
      return (BattleBadStatusGroupData) null;
    }

    [Token(Token = "0x6005570")]
    [Address(RVA = "0x3AB08D4", Offset = "0x3AB08D4", VA = "0x3AB08D4")]
    private void OnLoadEntity(BattleBadStatusGroupData entity)
    {
    }

    [Token(Token = "0x6005571")]
    [Address(RVA = "0x3AB0A54", Offset = "0x3AB0A54", VA = "0x3AB0A54")]
    public IReadOnlyList<int> GetByGroup(int group) => (IReadOnlyList<int>) null;

    [Token(Token = "0x6005572")]
    [Address(RVA = "0x3AB0ACC", Offset = "0x3AB0ACC", VA = "0x3AB0ACC")]
    public BattleBadStatusGroupMaster()
    {
    }
  }
}
