// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleInitialPlacementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E51")]
  [Serializable]
  public sealed class BattleInitialPlacementDescriptionMaster : 
    BaseMaster<BattleInitialPlacementDescriptionData>
  {
    [Token(Token = "0x400450A")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleInitialPlacementDescriptionData>> mapData;

    [Token(Token = "0x6005726")]
    [Address(RVA = "0x3E3C4CC", Offset = "0x3E3C4CC", VA = "0x3E3C4CC")]
    public IReadOnlyDictionary<int, BattleInitialPlacementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleInitialPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005727")]
    [Address(RVA = "0x3E3C4D4", Offset = "0x3E3C4D4", VA = "0x3E3C4D4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005728")]
    [Address(RVA = "0x3E3C534", Offset = "0x3E3C534", VA = "0x3E3C534", Slot = "5")]
    protected override BattleInitialPlacementDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleInitialPlacementDescriptionData) null;
    }

    [Token(Token = "0x6005729")]
    [Address(RVA = "0x3E3C5A4", Offset = "0x3E3C5A4", VA = "0x3E3C5A4")]
    private void OnLoadEntity(BattleInitialPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x600572A")]
    [Address(RVA = "0x3E3C6F8", Offset = "0x3E3C6F8", VA = "0x3E3C6F8")]
    public List<BattleInitialPlacementDescriptionData> GetById(int placementId)
    {
      return (List<BattleInitialPlacementDescriptionData>) null;
    }

    [Token(Token = "0x600572B")]
    [Address(RVA = "0x3E3C7B4", Offset = "0x3E3C7B4", VA = "0x3E3C7B4")]
    public BattleInitialPlacementDescriptionMaster()
    {
    }
  }
}
