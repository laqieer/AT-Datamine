// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.DoorFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027DF")]
  public class DoorFacilityData : FacilityData
  {
    [Token(Token = "0x600F8E3")]
    [Address(RVA = "0x44BDC68", Offset = "0x44BDC68", VA = "0x44BDC68")]
    public DoorFacilityData(
      BattleFacilityData facilityMaster,
      IFacilityPlacementData placementMaster)
    {
    }

    [Token(Token = "0x600F8E4")]
    [Address(RVA = "0x44BDC6C", Offset = "0x44BDC6C", VA = "0x44BDC6C", Slot = "4")]
    public override bool IsEffectable(BoardData board, bool isLink, bool isMovable = false)
    {
      return new bool();
    }

    [Token(Token = "0x600F8E5")]
    [Address(RVA = "0x44BE09C", Offset = "0x44BE09C", VA = "0x44BE09C", Slot = "5")]
    public override void ExecEffect(
      BoardData board,
      UnitParameterData unit,
      bool isLink,
      ref List<FacilityData> activates)
    {
    }

    [Token(Token = "0x600F8E6")]
    [Address(RVA = "0x44BDE50", Offset = "0x44BDE50", VA = "0x44BDE50")]
    private List<GridData> GetLinkDoors(BoardData board) => (List<GridData>) null;
  }
}
