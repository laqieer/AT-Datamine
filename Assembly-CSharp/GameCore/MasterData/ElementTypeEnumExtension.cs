// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ElementTypeEnumExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013F6")]
  public static class ElementTypeEnumExtension
  {
    [Token(Token = "0x4005CEC")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<int, ElementTypeEnum> advantageMap;
    [Token(Token = "0x4005CED")]
    [FieldOffset(Offset = "0x8")]
    private static readonly Dictionary<int, ElementTypeEnum> disAdvantageMap;
    [Token(Token = "0x4005CEE")]
    [FieldOffset(Offset = "0x10")]
    private static readonly Dictionary<int, string> VfxSymbolStringMap;
    [Token(Token = "0x4005CEF")]
    [FieldOffset(Offset = "0x18")]
    private static readonly Dictionary<int, string> VfxMagicSymbolStringMap;

    [Token(Token = "0x60070CF")]
    [Address(RVA = "0x421ABC4", Offset = "0x421ABC4", VA = "0x421ABC4")]
    public static string DisplayName(this ElementTypeEnum self) => (string) null;

    [Token(Token = "0x60070D0")]
    [Address(RVA = "0x421AD4C", Offset = "0x421AD4C", VA = "0x421AD4C")]
    public static bool HasAdvantage(this ElementTypeEnum self, ElementTypeEnum target)
    {
      return new bool();
    }

    [Token(Token = "0x60070D1")]
    [Address(RVA = "0x421ADF4", Offset = "0x421ADF4", VA = "0x421ADF4")]
    public static ElementTypeEnum GetAdvantageType(this ElementTypeEnum self)
    {
      return new ElementTypeEnum();
    }

    [Token(Token = "0x60070D2")]
    [Address(RVA = "0x421AF8C", Offset = "0x421AF8C", VA = "0x421AF8C")]
    public static bool HasDisAdvantage(this ElementTypeEnum self, ElementTypeEnum target)
    {
      return new bool();
    }

    [Token(Token = "0x60070D3")]
    [Address(RVA = "0x421B034", Offset = "0x421B034", VA = "0x421B034")]
    public static int GetResistValue(this ElementTypeEnum self, StyleData data) => new int();

    [Token(Token = "0x60070D4")]
    [Address(RVA = "0x421B094", Offset = "0x421B094", VA = "0x421B094")]
    public static int GetResistValueByAbilityBoard(
      this ElementTypeEnum self,
      List<PlayerUnitAbilityBoardParameterType> abilityBoardParameters)
    {
      return new int();
    }

    [Token(Token = "0x60070D5")]
    [Address(RVA = "0x421B204", Offset = "0x421B204", VA = "0x421B204")]
    public static int GetReinforceValue(this ElementTypeEnum self, StyleData data) => new int();

    [Token(Token = "0x60070D6")]
    [Address(RVA = "0x421B264", Offset = "0x421B264", VA = "0x421B264")]
    public static int GetReinforceValueByAbilityBoard(
      this ElementTypeEnum self,
      List<PlayerUnitAbilityBoardParameterType> abilityBoardParameters)
    {
      return new int();
    }

    [Token(Token = "0x60070D7")]
    [Address(RVA = "0x421B3D4", Offset = "0x421B3D4", VA = "0x421B3D4")]
    public static string GetVfxSymbolString(this ElementTypeEnum self) => (string) null;

    [Token(Token = "0x60070D8")]
    [Address(RVA = "0x421B46C", Offset = "0x421B46C", VA = "0x421B46C")]
    public static string GetMagicVfxSymbolString(this ElementTypeEnum self) => (string) null;

    [Token(Token = "0x60070D9")]
    [Address(RVA = "0x421B504", Offset = "0x421B504", VA = "0x421B504")]
    public static ElementTypeEnum GetReferenceElement(
      this ElementTypeEnum self,
      UnitParameterData unit)
    {
      return new ElementTypeEnum();
    }

    [Token(Token = "0x60070DA")]
    [Address(RVA = "0x421B564", Offset = "0x421B564", VA = "0x421B564")]
    public static List<ElementTypeEnum> GetIconDisplayList() => (List<ElementTypeEnum>) null;

    [Token(Token = "0x60070DB")]
    [Address(RVA = "0x421B84C", Offset = "0x421B84C", VA = "0x421B84C")]
    public static float GetReinforceValue(
      this ElementTypeEnum self,
      WeaponOptionEffect[] optionEffects)
    {
      return new float();
    }

    [Token(Token = "0x60070DC")]
    [Address(RVA = "0x421B8C8", Offset = "0x421B8C8", VA = "0x421B8C8")]
    public static float GetReinforceValue(
      this ElementTypeEnum self,
      AccessoryOptionEffect[] accessoryOptionEffects)
    {
      return new float();
    }

    [Token(Token = "0x60070DD")]
    [Address(RVA = "0x421B944", Offset = "0x421B944", VA = "0x421B944")]
    public static float GetResistValue(
      this ElementTypeEnum self,
      AccessoryOptionEffect[] accessoryOptionEffects)
    {
      return new float();
    }

    [Token(Token = "0x60070DE")]
    [Address(RVA = "0x421B9C0", Offset = "0x421B9C0", VA = "0x421B9C0")]
    static ElementTypeEnumExtension()
    {
    }
  }
}
