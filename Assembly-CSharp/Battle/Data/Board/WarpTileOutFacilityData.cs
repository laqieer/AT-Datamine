// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.WarpTileOutFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027E6")]
  public class WarpTileOutFacilityData : FacilityData
  {
    [Token(Token = "0x600F91C")]
    [Address(RVA = "0x44BE85C", Offset = "0x44BE85C", VA = "0x44BE85C")]
    public WarpTileOutFacilityData(
      BattleFacilityData facilityMaster,
      IFacilityPlacementData placementMaster)
    {
    }

    [Token(Token = "0x600F91D")]
    [Address(RVA = "0x44BFAE8", Offset = "0x44BFAE8", VA = "0x44BFAE8", Slot = "4")]
    public override bool IsEffectable(BoardData board, bool isLink, bool isMovable = false)
    {
      return new bool();
    }
  }
}
