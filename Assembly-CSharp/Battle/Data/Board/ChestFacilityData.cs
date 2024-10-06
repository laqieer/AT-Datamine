// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ChestFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027DE")]
  public class ChestFacilityData : FacilityData
  {
    [Token(Token = "0x600F8E1")]
    [Address(RVA = "0x44BD2E0", Offset = "0x44BD2E0", VA = "0x44BD2E0")]
    public ChestFacilityData(
      BattleFacilityData facilityMaster,
      IFacilityPlacementData placementMaster)
    {
    }

    [Token(Token = "0x600F8E2")]
    [Address(RVA = "0x44BDAD8", Offset = "0x44BDAD8", VA = "0x44BDAD8", Slot = "5")]
    public override void ExecEffect(
      BoardData board,
      UnitParameterData controller,
      bool isLink,
      ref List<FacilityData> activates)
    {
    }
  }
}
