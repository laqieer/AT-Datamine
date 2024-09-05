// Decompiled with JetBrains decompiler
// Type: OptionEffectIconResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000246")]
public static class OptionEffectIconResourceUtility
{
  [Token(Token = "0x4000D8B")]
  private const string AB_NAME = "content_spriteatlas_optioneffecticon";
  [Token(Token = "0x4000D8C")]
  private const string ASSET_NAME_FORMAT = "{0:D4}_OptionEffectIcon";
  [Token(Token = "0x4000D8D")]
  private const string GRADE_AB_NAME = "ui_page_equipdetail_texture";
  [Token(Token = "0x4000D8E")]
  private const string GRADE_BRONZE_ASSET_NAME = "Img_TypeIcon_Base_Bronze";
  [Token(Token = "0x4000D8F")]
  private const string GRADE_SILVER_ASSET_NAME = "Img_TypeIcon_Base_Silver";
  [Token(Token = "0x4000D90")]
  private const string GRADE_GOLD_ASSET_NAME = "Img_TypeIcon_Base_Gold";
  [Token(Token = "0x4000D91")]
  private const string GRADE_RAINBOW_ASSET_NAME = "Img_TypeIcon_Base_Rainbow";

  [Token(Token = "0x6000E66")]
  [Address(RVA = "0x1C8ECA0", Offset = "0x1C8ECA0", VA = "0x1C8ECA0")]
  public static string GetAssetbundleName() => (string) null;

  [Token(Token = "0x6000E67")]
  [Address(RVA = "0x1C8ECE0", Offset = "0x1C8ECE0", VA = "0x1C8ECE0")]
  public static string GetAssetName(int spriteId) => (string) null;

  [Token(Token = "0x6000E68")]
  [Address(RVA = "0x1C8ED60", Offset = "0x1C8ED60", VA = "0x1C8ED60")]
  public static string GetAssetNameByWeaponOptionId(int masterId) => (string) null;

  [Token(Token = "0x6000E69")]
  [Address(RVA = "0x1C8EDEC", Offset = "0x1C8EDEC", VA = "0x1C8EDEC")]
  public static string GetAssetNameByAccessoryOptionId(int masterId) => (string) null;

  [Token(Token = "0x6000E6A")]
  [Address(RVA = "0x1C8EE78", Offset = "0x1C8EE78", VA = "0x1C8EE78")]
  public static string GetGradeAssetbundleName() => (string) null;

  [Token(Token = "0x6000E6B")]
  [Address(RVA = "0x1C8EEB8", Offset = "0x1C8EEB8", VA = "0x1C8EEB8")]
  public static string GetGradeAssetName(
    OptionEffectIconResourceUtility.OptionEffectGradeEnum optionGrade)
  {
    return (string) null;
  }

  [Token(Token = "0x2000247")]
  public enum OptionEffectGradeEnum
  {
    [Token(Token = "0x4000D93")] BRONZE = 1,
    [Token(Token = "0x4000D94")] SILVER = 2,
    [Token(Token = "0x4000D95")] GOLD = 3,
    [Token(Token = "0x4000D96")] RAINBOW = 4,
  }
}
