// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SwitchFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027E3")]
  public class SwitchFacilityData : FacilityData
  {
    [Token(Token = "0x600F913")]
    [Address(RVA = "0x44BE854", Offset = "0x44BE854", VA = "0x44BE854")]
    public SwitchFacilityData(
      BattleFacilityData facilityMaster,
      IFacilityPlacementData placementMaster)
    {
    }

    [Token(Token = "0x600F914")]
    [Address(RVA = "0x44BF4A0", Offset = "0x44BF4A0", VA = "0x44BF4A0", Slot = "4")]
    public override bool IsEffectable(BoardData board, bool isLink, bool isMovable = false)
    {
      return new bool();
    }

    [Token(Token = "0x600F915")]
    [Address(RVA = "0x44BF64C", Offset = "0x44BF64C", VA = "0x44BF64C", Slot = "5")]
    public override void ExecEffect(
      BoardData board,
      UnitParameterData unit,
      bool isLink,
      ref List<FacilityData> activates)
    {
    }
  }
}
