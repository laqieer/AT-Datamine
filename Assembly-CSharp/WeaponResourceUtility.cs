// Decompiled with JetBrains decompiler
// Type: WeaponResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200024F")]
public static class WeaponResourceUtility
{
  [Token(Token = "0x4000DBE")]
  private const string CONTENT_PREFIX = "content_weapon_";
  [Token(Token = "0x4000DBF")]
  private const string THUMB_AB_NAME_FORMAT = "content_weapon_{0}";
  [Token(Token = "0x4000DC0")]
  private const string THUMB_AB_NAME_FORMAT_EDITOR = "content_weapon_{0}_thumb";
  [Token(Token = "0x4000DC1")]
  private const string THUMB_ASSET_NAME_FORMAT = "{0}_WeaponThumb";
  [Token(Token = "0x4000DC2")]
  private const string IMAGE_AB_NAME_FORMAT = "content_weapon_{0}";
  [Token(Token = "0x4000DC3")]
  private const string IMAGE_AB_NAME_FORMAT_EDITOR = "content_weapon_{0}_image";
  [Token(Token = "0x4000DC4")]
  private const string IMAGE_ASSET_NAME_FORMAT = "{0}_WeaponImage";
  [Token(Token = "0x4000DC5")]
  public const string UNKNOWN_IMAGE_AB_NAME = "content_weapon_unknown_image";
  [Token(Token = "0x4000DC6")]
  public const string UNKNOWN_IMAGE_ASSET_NAME = "Unkown_WeaponImage";
  [Token(Token = "0x4000DC7")]
  public const string UNKNOWN_THUMB_AB_NAME = "content_weapon_unknown_thumb";
  [Token(Token = "0x4000DC8")]
  public const string UNKNOWN_THUMB_ASSET_NAME = "Unknown_WeaponThumb";
  [Token(Token = "0x4000DC9")]
  private const string PIECE_THUMB_AB_NAME_FORMAT = "content_weapon_{0}";
  [Token(Token = "0x4000DCA")]
  private const string PIECE_THUMB_AB_NAME_FORMAT_EDITOR = "content_weapon_{0}_piecethumb";
  [Token(Token = "0x4000DCB")]
  private const string PIECE_THUMB_ASSET_NAME_FORMAT = "{0}_WeaponPieceThumb";
  [Token(Token = "0x4000DCC")]
  private const string PIECE_IMAGE_AB_NAME_FORMAT = "content_weapon_{0}";
  [Token(Token = "0x4000DCD")]
  private const string PIECE_IMAGE_AB_NAME_FORMAT_EDITOR = "content_weapon_{0}_pieceimage";
  [Token(Token = "0x4000DCE")]
  private const string PIECE_IMAGE_ASSET_NAME_FORMAT = "{0}_WeaponPieceImage";

  [Token(Token = "0x6000E97")]
  [Address(RVA = "0x1C904DC", Offset = "0x1C904DC", VA = "0x1C904DC")]
  public static string GetThumbnailAssetbundleNameByWeaponId(int weaponId, bool isOverride = true)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E98")]
  [Address(RVA = "0x1C90674", Offset = "0x1C90674", VA = "0x1C90674")]
  public static string GetThumbnailAssetbundleNameByUnknownWeapon() => (string) null;

  [Token(Token = "0x6000E99")]
  [Address(RVA = "0x1C906D0", Offset = "0x1C906D0", VA = "0x1C906D0")]
  public static string GetThumbnailAssetNameByWeaponId(int weaponId, bool isOverride = true)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E9A")]
  [Address(RVA = "0x1C90774", Offset = "0x1C90774", VA = "0x1C90774")]
  public static string GetThumbnailAssetNameByUnknownWeapon() => (string) null;

  [Token(Token = "0x6000E9B")]
  [Address(RVA = "0x1C907D0", Offset = "0x1C907D0", VA = "0x1C907D0")]
  public static string GetImageAssetBundleNameByWeaponId(int weaponId, bool isOverride = true)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E9C")]
  [Address(RVA = "0x1C90874", Offset = "0x1C90874", VA = "0x1C90874")]
  public static string GetImageAssetNameByWeaponId(int weaponId, bool isOverride = true)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E9D")]
  [Address(RVA = "0x1C90918", Offset = "0x1C90918", VA = "0x1C90918")]
  public static string GetPieceImageAssetBundleNameByWeaponId(int weaponId) => (string) null;

  [Token(Token = "0x6000E9E")]
  [Address(RVA = "0x1C90998", Offset = "0x1C90998", VA = "0x1C90998")]
  public static string GetPieceThumbAssetBundleNameByWeaponId(int weaponId) => (string) null;

  [Token(Token = "0x6000E9F")]
  [Address(RVA = "0x1C90A18", Offset = "0x1C90A18", VA = "0x1C90A18")]
  public static string GetPieceImageAssetNameByWeaponId(int weaponId) => (string) null;

  [Token(Token = "0x6000EA0")]
  [Address(RVA = "0x1C90A98", Offset = "0x1C90A98", VA = "0x1C90A98")]
  public static string GetPieceThumbAssetNameByWeaponId(int weaponId) => (string) null;

  [Token(Token = "0x6000EA1")]
  [Address(RVA = "0x1C90580", Offset = "0x1C90580", VA = "0x1C90580")]
  private static bool TryOverrideResourceId(int id, out int resourceId) => new bool();
}
