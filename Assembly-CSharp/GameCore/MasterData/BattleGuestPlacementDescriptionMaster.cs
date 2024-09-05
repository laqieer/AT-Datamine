// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleGuestPlacementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E4D")]
  [Serializable]
  public sealed class BattleGuestPlacementDescriptionMaster : 
    BaseMaster<BattleGuestPlacementDescriptionData>
  {
    [Token(Token = "0x40044F0")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleGuestPlacementDescriptionData>> mapData;

    [Token(Token = "0x60056FA")]
    [Address(RVA = "0x3E3B12C", Offset = "0x3E3B12C", VA = "0x3E3B12C")]
    public IReadOnlyDictionary<int, BattleGuestPlacementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleGuestPlacementDescriptionData>) null;
    }

    [Token(Token = "0x60056FB")]
    [Address(RVA = "0x3E3B134", Offset = "0x3E3B134", VA = "0x3E3B134", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60056FC")]
    [Address(RVA = "0x3E3B194", Offset = "0x3E3B194", VA = "0x3E3B194", Slot = "5")]
    protected override BattleGuestPlacementDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleGuestPlacementDescriptionData) null;
    }

    [Token(Token = "0x60056FD")]
    [Address(RVA = "0x3E3B204", Offset = "0x3E3B204", VA = "0x3E3B204")]
    private void OnLoadEntity(BattleGuestPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x60056FE")]
    [Address(RVA = "0x3E3B358", Offset = "0x3E3B358", VA = "0x3E3B358")]
    public IReadOnlyList<BattleGuestPlacementDescriptionData> GetById(int placementId)
    {
      return (IReadOnlyList<BattleGuestPlacementDescriptionData>) null;
    }

    [Token(Token = "0x60056FF")]
    [Address(RVA = "0x3E3B414", Offset = "0x3E3B414", VA = "0x3E3B414")]
    public BattleGuestPlacementDescriptionMaster()
    {
    }
  }
}
