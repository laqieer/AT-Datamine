// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleGuestTroopsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E4F")]
  [Serializable]
  public sealed class BattleGuestTroopsMaster : BaseMaster<BattleGuestTroopsData>, ITroopsMaster
  {
    [Token(Token = "0x4004504")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleGuestTroopsData>> mapData;

    [Token(Token = "0x6005718")]
    [Address(RVA = "0x3E3BE3C", Offset = "0x3E3BE3C", VA = "0x3E3BE3C")]
    public IReadOnlyDictionary<int, BattleGuestTroopsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleGuestTroopsData>) null;
    }

    [Token(Token = "0x6005719")]
    [Address(RVA = "0x3E3BE44", Offset = "0x3E3BE44", VA = "0x3E3BE44", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600571A")]
    [Address(RVA = "0x3E3BEA4", Offset = "0x3E3BEA4", VA = "0x3E3BEA4", Slot = "5")]
    protected override BattleGuestTroopsData LoadEntity(IMasterDataReader reader)
    {
      return (BattleGuestTroopsData) null;
    }

    [Token(Token = "0x600571B")]
    [Address(RVA = "0x3E3BF14", Offset = "0x3E3BF14", VA = "0x3E3BF14")]
    private void OnLoadEntity(BattleGuestTroopsData entity)
    {
    }

    [Token(Token = "0x600571C")]
    [Address(RVA = "0x3E3C068", Offset = "0x3E3C068", VA = "0x3E3C068", Slot = "6")]
    public IReadOnlyList<ITroopsData> GetTroops(int placementId)
    {
      return (IReadOnlyList<ITroopsData>) null;
    }

    [Token(Token = "0x600571D")]
    [Address(RVA = "0x3E3C124", Offset = "0x3E3C124", VA = "0x3E3C124")]
    public BattleGuestTroopsMaster()
    {
    }
  }
}
