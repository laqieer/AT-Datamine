// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.MasterBonusDataFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003514")]
  internal static class MasterBonusDataFactory
  {
    [Token(Token = "0x6014D1B")]
    [Address(RVA = "0x1B3A16C", Offset = "0x1B3A16C", VA = "0x1B3A16C")]
    private static ElementStyleMasterBonusData FindElementMasterBonusData(
      List<IMasterBonusData> masterBonusDatas,
      StyleMasterBonusConditionData conditionData)
    {
      return (ElementStyleMasterBonusData) null;
    }

    [Token(Token = "0x6014D1C")]
    [Address(RVA = "0x1B3A29C", Offset = "0x1B3A29C", VA = "0x1B3A29C")]
    private static MovementStyleMasterBonusData FindMovementMasterBonusData(
      List<IMasterBonusData> masterBonusDatas,
      StyleMasterBonusConditionData conditionData)
    {
      return (MovementStyleMasterBonusData) null;
    }

    [Token(Token = "0x6014D1D")]
    [Address(RVA = "0x1B3A3CC", Offset = "0x1B3A3CC", VA = "0x1B3A3CC")]
    private static WeaponMasterBonusData FindWeaponMasterBonusData(
      List<IMasterBonusData> masterBonusDatas,
      int bonusMasterId)
    {
      return (WeaponMasterBonusData) null;
    }

    [Token(Token = "0x6014D1E")]
    [Address(RVA = "0x1B3A4FC", Offset = "0x1B3A4FC", VA = "0x1B3A4FC")]
    public static List<IMasterBonusData> CreateStyleMasterBonusDatasAll()
    {
      return (List<IMasterBonusData>) null;
    }

    [Token(Token = "0x6014D1F")]
    [Address(RVA = "0x1B3AD10", Offset = "0x1B3AD10", VA = "0x1B3AD10")]
    public static List<IMasterBonusData> CreateStyleMasterBonusDatas(
      IEnumerable<StyleMasterBonus> styleMasterBonusExpDatas)
    {
      return (List<IMasterBonusData>) null;
    }

    [Token(Token = "0x6014D20")]
    [Address(RVA = "0x1B3B3AC", Offset = "0x1B3B3AC", VA = "0x1B3B3AC")]
    public static List<IMasterBonusData> CreateWeaponMasterBonusDatasAll()
    {
      return (List<IMasterBonusData>) null;
    }

    [Token(Token = "0x6014D21")]
    [Address(RVA = "0x1B3B9D0", Offset = "0x1B3B9D0", VA = "0x1B3B9D0")]
    public static List<IMasterBonusData> CreateWeaponMasterBonusDatas(
      IEnumerable<WeaponMasterBonus> weaponMasterBonusExpDatas)
    {
      return (List<IMasterBonusData>) null;
    }
  }
}
