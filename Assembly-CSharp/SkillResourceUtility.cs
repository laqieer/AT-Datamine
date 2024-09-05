// Decompiled with JetBrains decompiler
// Type: SkillResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
[Token(Token = "0x200024A")]
public static class SkillResourceUtility
{
  [Token(Token = "0x4000D9D")]
  private const string DEFAULT_ICON_NAME = "120101";
  [Token(Token = "0x4000D9E")]
  private const string SKILL_AB_THUMB_NAME_FORMAT = "content_skill_{0}_thumb";
  [Token(Token = "0x4000D9F")]
  private const string SKILL_ASSET_THUMB_NAME_FORMAT = "{0}_SkillThumb";
  [Token(Token = "0x4000DA0")]
  private const string SKILL_AB_MAIN_ICON_NAME = "content_spriteatlas_mainskillicon";
  [Token(Token = "0x4000DA1")]
  private const string SKILL_AB_SUB_ICON_NAME = "content_spriteatlas_subskillicon";
  [Token(Token = "0x4000DA2")]
  private const string SKILL_ASSET_MAIN_ICON_NAME_FORMAT = "{0}_MainSkillIcon";
  [Token(Token = "0x4000DA3")]
  private const string SKILL_ASSET_SUB_ICON_NAME_FORMAT = "{0}_SubSkillIcon";
  [Token(Token = "0x4000DA4")]
  private const string SKILL_AB_RARITY_BASE_NAME = "ui_common_thumb";
  [Token(Token = "0x4000DA5")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string[] SKILL_ASSET_RARITY_BASE_NAME_FORMAT;
  [Token(Token = "0x4000DA6")]
  public const string BADSTATUS_EFFECT_ICON_ASSET_BUNDLE_NAME = "content_spriteatlas_statuseffecticon";
  [Token(Token = "0x4000DA7")]
  public const string BADSTATUS_EFFECT_ICON_NAME_FORMAT = "1{0:D2}_StatusEffectIcon";
  [Token(Token = "0x4000DA8")]
  private const string SKILL_TYPE_ICON_ASSET_BUNDLE_NAME = "content_spriteatlas_skilltypeicon";
  [Token(Token = "0x4000DA9")]
  private const string SKILL_TYPE_ICON_ASSET_NAME = "SkillTypeIcon";
  [Token(Token = "0x4000DAA")]
  private const string SKILL_TYPE_ICON_SPRITE_NAME_FORMAT = "{0}_SkillTypeIcon";

  [Token(Token = "0x6000E75")]
  [Address(RVA = "0x1C8F40C", Offset = "0x1C8F40C", VA = "0x1C8F40C")]
  public static string GetThumbnailAssetbundleNameBySkillId(int skillId) => (string) null;

  [Token(Token = "0x6000E76")]
  [Address(RVA = "0x1C8F48C", Offset = "0x1C8F48C", VA = "0x1C8F48C")]
  public static string GetThumbnailAssetNameBySkillId(int skillId) => (string) null;

  [Token(Token = "0x6000E77")]
  [Address(RVA = "0x1C8F50C", Offset = "0x1C8F50C", VA = "0x1C8F50C")]
  public static string GetIconAssetbundleName(SkillUtility.IconSize iconSize) => (string) null;

  [Token(Token = "0x6000E78")]
  [Address(RVA = "0x1C8F590", Offset = "0x1C8F590", VA = "0x1C8F590")]
  public static string GetMainIconAssetbundleName() => (string) null;

  [Token(Token = "0x6000E79")]
  [Address(RVA = "0x1C8F5E0", Offset = "0x1C8F5E0", VA = "0x1C8F5E0")]
  public static string GetSubIconAssetbundleName() => (string) null;

  [Token(Token = "0x6000E7A")]
  [Address(RVA = "0x1C8F630", Offset = "0x1C8F630", VA = "0x1C8F630")]
  public static string GetIconAssetName(SkillUtility.IconSize iconSize, string iconName)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E7B")]
  [Address(RVA = "0x1C8F6FC", Offset = "0x1C8F6FC", VA = "0x1C8F6FC")]
  public static string GetMainIconAssetName(string iconName) => (string) null;

  [Token(Token = "0x6000E7C")]
  [Address(RVA = "0x1C8F754", Offset = "0x1C8F754", VA = "0x1C8F754")]
  public static string GetSubIconAssetName(string iconName) => (string) null;

  [Token(Token = "0x6000E7D")]
  [Address(RVA = "0x1C8F7AC", Offset = "0x1C8F7AC", VA = "0x1C8F7AC")]
  public static string GetRarityBaseAssetbundleName() => (string) null;

  [Token(Token = "0x6000E7E")]
  [Address(RVA = "0x1C8F7EC", Offset = "0x1C8F7EC", VA = "0x1C8F7EC")]
  public static string GetRarityBaseAssetName(int rarityTypeEnum) => (string) null;

  [Token(Token = "0x6000E7F")]
  [Address(RVA = "0x1C8F8BC", Offset = "0x1C8F8BC", VA = "0x1C8F8BC")]
  public static string GetRarityBaseAssetName(RarityTypeEnum rarityTypeEnum) => (string) null;

  [Token(Token = "0x6000E80")]
  [Address(RVA = "0x1C8F910", Offset = "0x1C8F910", VA = "0x1C8F910")]
  public static string GetTypeIconAssetBundleName() => (string) null;

  [Token(Token = "0x6000E81")]
  [Address(RVA = "0x1C8F950", Offset = "0x1C8F950", VA = "0x1C8F950")]
  public static string GetTypeIconAssetName() => (string) null;

  [Token(Token = "0x6000E82")]
  [Address(RVA = "0x1C8F990", Offset = "0x1C8F990", VA = "0x1C8F990")]
  public static string GetTypeIconSpriteName(SkillTypeEnum skillType) => (string) null;

  [Token(Token = "0x6000E83")]
  [Address(RVA = "0x1C8FA14", Offset = "0x1C8FA14", VA = "0x1C8FA14")]
  static SkillResourceUtility()
  {
  }
}
