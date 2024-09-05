// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleThirdarmyTroopsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E72")]
  [Serializable]
  public sealed class BattleThirdarmyTroopsMaster : 
    BaseMaster<BattleThirdarmyTroopsData>,
    ITroopsMaster
  {
    [Token(Token = "0x40045E0")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleThirdarmyTroopsData>> mapData;

    [Token(Token = "0x600581D")]
    [Address(RVA = "0x3E461F4", Offset = "0x3E461F4", VA = "0x3E461F4")]
    public IReadOnlyDictionary<int, BattleThirdarmyTroopsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleThirdarmyTroopsData>) null;
    }

    [Token(Token = "0x600581E")]
    [Address(RVA = "0x3E461FC", Offset = "0x3E461FC", VA = "0x3E461FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600581F")]
    [Address(RVA = "0x3E4625C", Offset = "0x3E4625C", VA = "0x3E4625C", Slot = "5")]
    protected override BattleThirdarmyTroopsData LoadEntity(IMasterDataReader reader)
    {
      return (BattleThirdarmyTroopsData) null;
    }

    [Token(Token = "0x6005820")]
    [Address(RVA = "0x3E462CC", Offset = "0x3E462CC", VA = "0x3E462CC")]
    private void OnLoadEntity(BattleThirdarmyTroopsData entity)
    {
    }

    [Token(Token = "0x6005821")]
    [Address(RVA = "0x3E46420", Offset = "0x3E46420", VA = "0x3E46420", Slot = "6")]
    public IReadOnlyList<ITroopsData> GetTroops(int placementId)
    {
      return (IReadOnlyList<ITroopsData>) null;
    }

    [Token(Token = "0x6005822")]
    [Address(RVA = "0x3E464DC", Offset = "0x3E464DC", VA = "0x3E464DC")]
    public BattleThirdarmyTroopsMaster()
    {
    }
  }
}
