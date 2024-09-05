// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.EquipmentStatusUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032BE")]
  public static class EquipmentStatusUtility
  {
    [Token(Token = "0x400DA84")]
    public const string maxLevelExpText = "---";
    [Token(Token = "0x400DA85")]
    [FieldOffset(Offset = "0x0")]
    private static readonly EquipmentStatusUtility.BaseParamCalculator[] BaseParamCalculatorMap;
    [Token(Token = "0x400DA86")]
    public const int DefaultSmallNumberOfDigits = 2;
    [Token(Token = "0x400DA87")]
    [FieldOffset(Offset = "0x8")]
    private static readonly int[] powerOf10s;

    [Token(Token = "0x6013DB9")]
    [Address(RVA = "0x1AE5CF8", Offset = "0x1AE5CF8", VA = "0x1AE5CF8")]
    public static WeaponStandardStatus GetWeaponStandardStatus(Weapon weapon)
    {
      return (WeaponStandardStatus) null;
    }

    [Token(Token = "0x6013DBA")]
    [Address(RVA = "0x1AE5EB8", Offset = "0x1AE5EB8", VA = "0x1AE5EB8")]
    public static WeaponStandardStatus GetWeaponStandardStatusNextLevel(Weapon weapon)
    {
      return (WeaponStandardStatus) null;
    }

    [Token(Token = "0x6013DBB")]
    [Address(RVA = "0x1AE5F54", Offset = "0x1AE5F54", VA = "0x1AE5F54")]
    public static WeaponStandardStatus GetWeaponStandardStatusByLevel(Weapon weapon, int level)
    {
      return (WeaponStandardStatus) null;
    }

    [Token(Token = "0x6013DBC")]
    [Address(RVA = "0x1AE5D94", Offset = "0x1AE5D94", VA = "0x1AE5D94")]
    public static WeaponStandardStatus GetWeaponStandardStatus(
      WeaponData weaponMaster,
      int weaponLevel,
      IEnumerable<WeaponOptionEffect> options,
      InscriptionData inscription,
      int limitBreakCount = 0,
      bool addMasterBonus = true)
    {
      return (WeaponStandardStatus) null;
    }

    [Token(Token = "0x6013DBD")]
    [Address(RVA = "0x1AE6C4C", Offset = "0x1AE6C4C", VA = "0x1AE6C4C")]
    public static AccessoryStandardStatus GetAccessoryStandardStatus(AccessoriesData acc, int level)
    {
      return (AccessoryStandardStatus) null;
    }

    [Token(Token = "0x6013DBE")]
    [Address(RVA = "0x1AE7570", Offset = "0x1AE7570", VA = "0x1AE7570")]
    public static AccessoryStandardStatus GetAccessoryStandardStatus(Accessory acc)
    {
      return (AccessoryStandardStatus) null;
    }

    [Token(Token = "0x6013DBF")]
    [Address(RVA = "0x1AE7630", Offset = "0x1AE7630", VA = "0x1AE7630")]
    public static AccessoryStandardStatus GetAccessoryStandardStatusByLevel(
      Accessory acc,
      int level)
    {
      return (AccessoryStandardStatus) null;
    }

    [Token(Token = "0x6013DC0")]
    [Address(RVA = "0x1AE76E0", Offset = "0x1AE76E0", VA = "0x1AE76E0")]
    public static AccessoryStandardStatus GetAccessoryStandardStatus(
      AccessoriesData weaponMaster,
      int weaponLevel,
      IEnumerable<AccessoryOptionEffect> options,
      InscriptionData inscription,
      int limitBreakCount = 0,
      bool addMasterBonus = true)
    {
      return (AccessoryStandardStatus) null;
    }

    [Token(Token = "0x6013DC1")]
    [Address(RVA = "0x1AE8404", Offset = "0x1AE8404", VA = "0x1AE8404")]
    public static MindStandardStatus GetMindStandardStatus(MindEquipment mind)
    {
      return (MindStandardStatus) null;
    }

    [Token(Token = "0x6013DC2")]
    [Address(RVA = "0x1AE852C", Offset = "0x1AE852C", VA = "0x1AE852C")]
    public static MindStandardStatus GetMindStandardStatusByLevel(MindEquipment mind, int level)
    {
      return (MindStandardStatus) null;
    }

    [Token(Token = "0x6013DC3")]
    [Address(RVA = "0x1AE8484", Offset = "0x1AE8484", VA = "0x1AE8484")]
    public static MindStandardStatus GetMindStandardStatus(
      MindEquipmentData mindMaster,
      int mindLevel,
      int limitBreakCount = 0)
    {
      return (MindStandardStatus) null;
    }

    [Token(Token = "0x6013DC4")]
    [Address(RVA = "0x1AE8AA0", Offset = "0x1AE8AA0", VA = "0x1AE8AA0")]
    public static int Lerp(int min, int max, int cap, int now) => new int();

    [Token(Token = "0x6013DC5")]
    [Address(RVA = "0x1AE8B84", Offset = "0x1AE8B84", VA = "0x1AE8B84")]
    public static float CalculateBaseParam(
      int initParamValue,
      int maxParamValue,
      int currentLevel,
      int maxLevelCap,
      ComplementTypeEnum complementType)
    {
      return new float();
    }

    [Token(Token = "0x6013DC6")]
    [Address(RVA = "0x1AE5FE8", Offset = "0x1AE5FE8", VA = "0x1AE5FE8")]
    private static void CalculateBaseStandardStatus(
      WeaponStandardStatus status,
      WeaponData weaponMaster,
      int weaponLevel,
      int limitBreakCount)
    {
    }

    [Token(Token = "0x6013DC7")]
    [Address(RVA = "0x1AE8D18", Offset = "0x1AE8D18", VA = "0x1AE8D18")]
    private static int GetFiringRangeID(WeaponData weaponMaster) => new int();

    [Token(Token = "0x6013DC8")]
    [Address(RVA = "0x1AE8C58", Offset = "0x1AE8C58", VA = "0x1AE8C58")]
    private static RangeData GetRangeShapeDetailData(WeaponData weaponMaster) => (RangeData) null;

    [Token(Token = "0x6013DC9")]
    [Address(RVA = "0x1AE8E38", Offset = "0x1AE8E38", VA = "0x1AE8E38")]
    public static RangeShapeData GetRangeShapeData(WeaponData weaponMaster)
    {
      return (RangeShapeData) null;
    }

    [Token(Token = "0x6013DCA")]
    [Address(RVA = "0x1AE85A4", Offset = "0x1AE85A4", VA = "0x1AE85A4")]
    private static void CalculateBaseStandardStatus(
      MindStandardStatus status,
      MindEquipmentData mindMaster,
      int mindLevel,
      int limitBreakCount)
    {
    }

    [Token(Token = "0x6013DCB")]
    [Address(RVA = "0x1AE6CF0", Offset = "0x1AE6CF0", VA = "0x1AE6CF0")]
    private static void CalculateBaseStandardStatus(
      AccessoryStandardStatus status,
      AccessoriesData accMaster,
      int level,
      int limitBreakCount)
    {
    }

    [Token(Token = "0x6013DCC")]
    [Address(RVA = "0x1AE8F0C", Offset = "0x1AE8F0C", VA = "0x1AE8F0C")]
    private static float DefaultBaseParam(
      int initParamValue,
      int maxParamValue,
      int currentLevel,
      int maxLevelCap)
    {
      return new float();
    }

    [Token(Token = "0x6013DCD")]
    [Address(RVA = "0x1AE8F14", Offset = "0x1AE8F14", VA = "0x1AE8F14")]
    public static float CalculateBaseParamLinear(
      int initParamValue,
      int maxParamValue,
      int currentLevel,
      int maxLevelCap)
    {
      return new float();
    }

    [Token(Token = "0x6013DCE")]
    [Address(RVA = "0x1AE6BA8", Offset = "0x1AE6BA8", VA = "0x1AE6BA8")]
    private static void OffsetStatusWithInscription(
      WeaponStandardStatus status,
      int inscriptionMasterId)
    {
    }

    [Token(Token = "0x6013DCF")]
    [Address(RVA = "0x1AE8360", Offset = "0x1AE8360", VA = "0x1AE8360")]
    private static void OffsetStatusWithInscription(
      AccessoryStandardStatus status,
      int inscriptionMasterId)
    {
    }

    [Token(Token = "0x6013DD0")]
    [Address(RVA = "0x1AE77FC", Offset = "0x1AE77FC", VA = "0x1AE77FC")]
    private static void OffsetStatusWithOptions(
      AccessoryStandardStatus status,
      IEnumerable<AccessoryOptionEffect> options)
    {
    }

    [Token(Token = "0x6013DD1")]
    [Address(RVA = "0x1AE6484", Offset = "0x1AE6484", VA = "0x1AE6484")]
    private static void OffsetStatusWithOptions(
      WeaponStandardStatus status,
      IEnumerable<WeaponOptionEffect> options)
    {
    }

    [Token(Token = "0x6013DD2")]
    [Address(RVA = "0x1AE6BA4", Offset = "0x1AE6BA4", VA = "0x1AE6BA4")]
    private static void OffsetStatusWithMasterBonus(WeaponStandardStatus status)
    {
    }

    [Token(Token = "0x6013DD3")]
    [Address(RVA = "0x1AE835C", Offset = "0x1AE835C", VA = "0x1AE835C")]
    private static void OffsetStatusWithMasterBonus(AccessoryStandardStatus status)
    {
    }

    [Token(Token = "0x6013DD4")]
    [Address(RVA = "0x1AE6480", Offset = "0x1AE6480", VA = "0x1AE6480")]
    private static void OffsetStatusWithType(WeaponStandardStatus status)
    {
    }

    [Token(Token = "0x6013DD5")]
    [Address(RVA = "0x1AE77F8", Offset = "0x1AE77F8", VA = "0x1AE77F8")]
    private static void OffsetStatusWithType(AccessoryStandardStatus status)
    {
    }

    [Token(Token = "0x6013DD6")]
    [Address(RVA = "0x1AE8FC0", Offset = "0x1AE8FC0", VA = "0x1AE8FC0")]
    public static float ToFixed(float value, int digits = 2) => new float();

    [Token(Token = "0x6013DD7")]
    [Address(RVA = "0x1AE3210", Offset = "0x1AE3210", VA = "0x1AE3210")]
    public static int ToInt(float value) => new int();

    [Token(Token = "0x6013DD8")]
    [Address(RVA = "0x1AE90AC", Offset = "0x1AE90AC", VA = "0x1AE90AC")]
    static EquipmentStatusUtility()
    {
    }

    [Token(Token = "0x20032BF")]
    private delegate float BaseParamCalculator(
      int initParamValue,
      int maxParamValue,
      int currentLevel,
      int maxLevelCap);
  }
}
