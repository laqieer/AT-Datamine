// Decompiled with JetBrains decompiler
// Type: Battle.Data.MissionDataExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F7")]
  public static class MissionDataExtension
  {
    [Token(Token = "0x600F134")]
    [Address(RVA = "0x41AC5C4", Offset = "0x41AC5C4", VA = "0x41AC5C4")]
    public static bool TryGet(
      this IMissionData self,
      BattleMissionTypeEnum missionType,
      out (BattleMissionTypeEnum type, int param1, int param2) missionCond)
    {
      return new bool();
    }

    [Token(Token = "0x600F135")]
    [Address(RVA = "0x41AD030", Offset = "0x41AD030", VA = "0x41AD030")]
    public static bool Has(this IMissionData self, BattleMissionTypeEnum missionType) => new bool();

    [Token(Token = "0x600F136")]
    [Address(RVA = "0x41AD338", Offset = "0x41AD338", VA = "0x41AD338")]
    public static bool IsClearOnBattleWin(this IMissionData self, BoardData board, int count)
    {
      return new bool();
    }

    [Token(Token = "0x600F137")]
    [Address(RVA = "0x41AD3F0", Offset = "0x41AD3F0", VA = "0x41AD3F0")]
    public static bool IsClear(this IMissionData self, BoardData board, int count) => new bool();

    [Token(Token = "0x600F138")]
    [Address(RVA = "0x41ADACC", Offset = "0x41ADACC", VA = "0x41ADACC")]
    public static bool CheckSpecified(
      this IMissionData self,
      UnitParameterData unit1,
      UnitParameterData unit2,
      WeaponParameterData useWeapon,
      SkillParameterData useSkill,
      int turn)
    {
      return new bool();
    }

    [Token(Token = "0x600F139")]
    [Address(RVA = "0x41AE684", Offset = "0x41AE684", VA = "0x41AE684")]
    public static bool CheckSpecified(
      this IMissionData self,
      UnitParameterData unit1,
      FacilityData facility,
      int turn)
    {
      return new bool();
    }

    [Token(Token = "0x600F13A")]
    [Address(RVA = "0x41AEA78", Offset = "0x41AEA78", VA = "0x41AEA78")]
    public static bool IsAllMissionAtTheSameTime(this IMissionData self) => new bool();

    [Token(Token = "0x600F13B")]
    [Address(RVA = "0x41AC934", Offset = "0x41AC934", VA = "0x41AC934")]
    public static IEnumerable<(BattleMissionTypeEnum, int, int)> GetMissionConditions(
      this IMissionData self)
    {
      return (IEnumerable<(BattleMissionTypeEnum, int, int)>) null;
    }

    [Token(Token = "0x600F13C")]
    [Address(RVA = "0x41ADFA0", Offset = "0x41ADFA0", VA = "0x41ADFA0")]
    public static IEnumerable<(BattleMissionTypeEnum, int, int)> GetSpecifiedList(
      this IMissionData self)
    {
      return (IEnumerable<(BattleMissionTypeEnum, int, int)>) null;
    }
  }
}
