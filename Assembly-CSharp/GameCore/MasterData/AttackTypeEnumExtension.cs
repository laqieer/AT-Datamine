// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AttackTypeEnumExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013F1")]
  public static class AttackTypeEnumExtension
  {
    [Token(Token = "0x4005CE4")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<int, string> VfxSymbolStringMap;

    [Token(Token = "0x6006FE8")]
    [Address(RVA = "0x4206A1C", Offset = "0x4206A1C", VA = "0x4206A1C")]
    public static string DisplayName(this AttackTypeEnum self) => (string) null;

    [Token(Token = "0x6006FE9")]
    [Address(RVA = "0x4206B80", Offset = "0x4206B80", VA = "0x4206B80")]
    public static int GetResistValue(this AttackTypeEnum self, StyleData data) => new int();

    [Token(Token = "0x6006FEA")]
    [Address(RVA = "0x4206BD8", Offset = "0x4206BD8", VA = "0x4206BD8")]
    public static int GettResistValueByAbilityBoard(
      this AttackTypeEnum self,
      List<PlayerUnitAbilityBoardParameterType> abilityBoardParameters)
    {
      return new int();
    }

    [Token(Token = "0x6006FEB")]
    [Address(RVA = "0x4206D60", Offset = "0x4206D60", VA = "0x4206D60")]
    public static int GetReinforceValue(this AttackTypeEnum self, StyleData data) => new int();

    [Token(Token = "0x6006FEC")]
    [Address(RVA = "0x4206DB8", Offset = "0x4206DB8", VA = "0x4206DB8")]
    public static int GetReinforceValueByAbilityBoard(
      this AttackTypeEnum self,
      List<PlayerUnitAbilityBoardParameterType> abilityBoardParameters)
    {
      return new int();
    }

    [Token(Token = "0x6006FED")]
    [Address(RVA = "0x4206F40", Offset = "0x4206F40", VA = "0x4206F40")]
    public static string GetVfxSymbolString(this AttackTypeEnum self) => (string) null;

    [Token(Token = "0x6006FEE")]
    [Address(RVA = "0x4206FF8", Offset = "0x4206FF8", VA = "0x4206FF8")]
    public static List<AttackTypeEnum> GetIconDisplayList() => (List<AttackTypeEnum>) null;

    [Token(Token = "0x6006FEF")]
    [Address(RVA = "0x4207278", Offset = "0x4207278", VA = "0x4207278")]
    public static float GetReinforceValue(
      this AttackTypeEnum self,
      WeaponOptionEffect[] optionEffects)
    {
      return new float();
    }

    [Token(Token = "0x6006FF0")]
    [Address(RVA = "0x42072FC", Offset = "0x42072FC", VA = "0x42072FC")]
    public static float GetReinforceValue(
      this AttackTypeEnum self,
      AccessoryOptionEffect[] optionEffects)
    {
      return new float();
    }

    [Token(Token = "0x6006FF1")]
    [Address(RVA = "0x4207380", Offset = "0x4207380", VA = "0x4207380")]
    public static float GetResistValue(
      this AttackTypeEnum self,
      AccessoryOptionEffect[] optionEffects)
    {
      return new float();
    }

    [Token(Token = "0x6006FF2")]
    [Address(RVA = "0x4207404", Offset = "0x4207404", VA = "0x4207404")]
    static AttackTypeEnumExtension()
    {
    }
  }
}
