// Decompiled with JetBrains decompiler
// Type: TypeIconResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200024D")]
public static class TypeIconResourceUtility
{
  [Token(Token = "0x4000DB1")]
  private const string AB_NAME = "content_spriteatlas_typeicon";
  [Token(Token = "0x4000DB2")]
  private const string ASSET_NAME_SPRITE_ATLAS = "TypeIcon";
  [Token(Token = "0x4000DB3")]
  private const string ASSET_NAME_FORMAT_ELEMENT = "101{0:D4}_TypeIcon";
  [Token(Token = "0x4000DB4")]
  private const string ASSET_NAME_FORMAT_UNIT_CLASS = "102{0:D4}_TypeIcon";
  [Token(Token = "0x4000DB5")]
  private const string ASSET_NAME_FORMAT_MOVE = "103001{0:D1}_TypeIcon";
  [Token(Token = "0x4000DB6")]
  private const string ASSET_NAME_FORMAT_ARMOR = "103002{0:D1}_TypeIcon";
  [Token(Token = "0x4000DB7")]
  private const string ASSET_NAME_FORMAT_RIDE = "103003{0:D1}_TypeIcon";
  [Token(Token = "0x4000DB8")]
  private const string ASSET_NAME_FORMAT_SPECIES = "104{0:D4}_TypeIcon";
  [Token(Token = "0x4000DB9")]
  private const string ASSET_NAME_FORMAT_KILLERS = "106{0:D4}_TypeIcon";
  [Token(Token = "0x4000DBA")]
  private const string ASSET_NAME_FORMAT_ATTACK = "107{0:D4}_TypeIcon";

  [Token(Token = "0x6000E8A")]
  [Address(RVA = "0x1C8FF1C", Offset = "0x1C8FF1C", VA = "0x1C8FF1C")]
  public static string GetAssetbundleName() => (string) null;

  [Token(Token = "0x6000E8B")]
  [Address(RVA = "0x1C8FF5C", Offset = "0x1C8FF5C", VA = "0x1C8FF5C")]
  public static string GetAtlasName() => (string) null;

  [Token(Token = "0x6000E8C")]
  [Address(RVA = "0x1C8FF9C", Offset = "0x1C8FF9C", VA = "0x1C8FF9C")]
  public static string GetAssetName(ElementTypeEnum element) => (string) null;

  [Token(Token = "0x6000E8D")]
  [Address(RVA = "0x1C9001C", Offset = "0x1C9001C", VA = "0x1C9001C")]
  public static string GetAssetNameByUnitClass(int unitClass) => (string) null;

  [Token(Token = "0x6000E8E")]
  [Address(RVA = "0x1C9009C", Offset = "0x1C9009C", VA = "0x1C9009C")]
  public static string GetAssetName(MoveTypeEnum move) => (string) null;

  [Token(Token = "0x6000E8F")]
  [Address(RVA = "0x1C9011C", Offset = "0x1C9011C", VA = "0x1C9011C")]
  public static string GetAssetName(ArmorTypeEnum armor) => (string) null;

  [Token(Token = "0x6000E90")]
  [Address(RVA = "0x1C9019C", Offset = "0x1C9019C", VA = "0x1C9019C")]
  public static string GetAssetName(RideTypeEnum ride) => (string) null;

  [Token(Token = "0x6000E91")]
  [Address(RVA = "0x1C9021C", Offset = "0x1C9021C", VA = "0x1C9021C")]
  public static string GetAssetName(SpeciesTypeEnum species) => (string) null;

  [Token(Token = "0x6000E92")]
  [Address(RVA = "0x1C9029C", Offset = "0x1C9029C", VA = "0x1C9029C")]
  public static string GetAssetName(KillersFactorTypeEnum killers) => (string) null;

  [Token(Token = "0x6000E93")]
  [Address(RVA = "0x1C9031C", Offset = "0x1C9031C", VA = "0x1C9031C")]
  public static string GetAssetName(AttackTypeEnum attack) => (string) null;
}
