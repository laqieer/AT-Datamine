// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.TurretFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027E4")]
  public class TurretFacilityData : FacilityData
  {
    [Token(Token = "0x600F916")]
    [Address(RVA = "0x44BE860", Offset = "0x44BE860", VA = "0x44BE860")]
    public TurretFacilityData(
      BattleFacilityData facilityMaster,
      IFacilityPlacementData placementMaster)
    {
    }

    [Token(Token = "0x600F917")]
    [Address(RVA = "0x44BF7FC", Offset = "0x44BF7FC", VA = "0x44BF7FC", Slot = "4")]
    public override bool IsEffectable(BoardData board, bool isLink, bool isMovable = false)
    {
      return new bool();
    }
  }
}
