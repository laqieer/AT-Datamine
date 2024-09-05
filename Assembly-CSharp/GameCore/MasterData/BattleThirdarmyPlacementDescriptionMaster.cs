// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleThirdarmyPlacementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E6E")]
  [Serializable]
  public sealed class BattleThirdarmyPlacementDescriptionMaster : 
    BaseMaster<BattleThirdarmyPlacementDescriptionData>
  {
    [Token(Token = "0x40045C4")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleThirdarmyPlacementDescriptionData>> mapData;

    [Token(Token = "0x60057F7")]
    [Address(RVA = "0x3E44F94", Offset = "0x3E44F94", VA = "0x3E44F94")]
    public IReadOnlyDictionary<int, BattleThirdarmyPlacementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleThirdarmyPlacementDescriptionData>) null;
    }

    [Token(Token = "0x60057F8")]
    [Address(RVA = "0x3E44F9C", Offset = "0x3E44F9C", VA = "0x3E44F9C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60057F9")]
    [Address(RVA = "0x3E44FFC", Offset = "0x3E44FFC", VA = "0x3E44FFC", Slot = "5")]
    protected override BattleThirdarmyPlacementDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleThirdarmyPlacementDescriptionData) null;
    }

    [Token(Token = "0x60057FA")]
    [Address(RVA = "0x3E4506C", Offset = "0x3E4506C", VA = "0x3E4506C")]
    private void OnLoadEntity(BattleThirdarmyPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x60057FB")]
    [Address(RVA = "0x3E451C0", Offset = "0x3E451C0", VA = "0x3E451C0")]
    public IReadOnlyList<BattleThirdarmyPlacementDescriptionData> GetById(int placementId)
    {
      return (IReadOnlyList<BattleThirdarmyPlacementDescriptionData>) null;
    }

    [Token(Token = "0x60057FC")]
    [Address(RVA = "0x3E4527C", Offset = "0x3E4527C", VA = "0x3E4527C")]
    public BattleThirdarmyPlacementDescriptionMaster()
    {
    }
  }
}
