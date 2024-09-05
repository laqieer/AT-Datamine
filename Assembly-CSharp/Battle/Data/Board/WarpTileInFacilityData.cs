// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.WarpTileInFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027E5")]
  public class WarpTileInFacilityData : FacilityData
  {
    [Token(Token = "0x600F918")]
    [Address(RVA = "0x44BE858", Offset = "0x44BE858", VA = "0x44BE858")]
    public WarpTileInFacilityData(
      BattleFacilityData facilityMaster,
      IFacilityPlacementData placementMaster)
    {
    }

    [Token(Token = "0x600F919")]
    [Address(RVA = "0x44BF81C", Offset = "0x44BF81C", VA = "0x44BF81C", Slot = "4")]
    public override bool IsEffectable(BoardData board, bool isLink, bool isMovable = false)
    {
      return new bool();
    }

    [Token(Token = "0x600F91A")]
    [Address(RVA = "0x44BFA1C", Offset = "0x44BFA1C", VA = "0x44BFA1C", Slot = "5")]
    public override void ExecEffect(
      BoardData board,
      UnitParameterData controller,
      bool isLink,
      ref List<FacilityData> activates)
    {
    }

    [Token(Token = "0x600F91B")]
    [Address(RVA = "0x44BF890", Offset = "0x44BF890", VA = "0x44BF890")]
    public GridData GetPair(BoardData board) => (GridData) null;
  }
}
