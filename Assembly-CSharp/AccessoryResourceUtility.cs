// Decompiled with JetBrains decompiler
// Type: AccessoryResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200023E")]
public static class AccessoryResourceUtility
{
  [Token(Token = "0x4000D13")]
  private const string CONTENT_PREFIX = "content_accessory_";
  [Token(Token = "0x4000D14")]
  private const string THUMB_AB_NAME_FORMAT = "content_accessory_{0}";
  [Token(Token = "0x4000D15")]
  private const string THUMB_AB_NAME_FORMAT_EDITOR = "content_accessory_{0}_thumb";
  [Token(Token = "0x4000D16")]
  private const string THUMB_ASSET_NAME_FORMAT = "{0}_AccessoryThumb";
  [Token(Token = "0x4000D17")]
  private const string IMAGE_AB_NAME_FORMAT = "content_accessory_{0}";
  [Token(Token = "0x4000D18")]
  private const string IMAGE_AB_NAME_FORMAT_EDITOR = "content_accessory_{0}_image";
  [Token(Token = "0x4000D19")]
  private const string IMAGE_ASSET_NAME_FORMAT = "{0}_AccessoryImage";
  [Token(Token = "0x4000D1A")]
  public const string UNKNOWN_IMAGE_AB_NAME = "content_accessory_unknown_image";
  [Token(Token = "0x4000D1B")]
  public const string UNKNOWN_IMAGE_ASSET_NAME = "Unknown_AccessoryImage";
  [Token(Token = "0x4000D1C")]
  public const string UNKNOWN_THUMB_AB_NAME = "content_accessory_unknown_thumb";
  [Token(Token = "0x4000D1D")]
  public const string UNKNOWN_THUMB_ASSET_NAME = "Unknown_AccessoryThumb";
  [Token(Token = "0x4000D1E")]
  private const string PIECE_THUMB_AB_NAME_FORMAT = "content_accessory_{0}";
  [Token(Token = "0x4000D1F")]
  private const string PIECE_THUMB_AB_NAME_FORMAT_EDITOR = "content_accessory_{0}_piecethumb";
  [Token(Token = "0x4000D20")]
  private const string PIECE_THUMB_ASSET_NAME_FORMAT = "{0}_AccessoryPieceThumb";
  [Token(Token = "0x4000D21")]
  private const string PIECE_IMAGE_AB_NAME_FORMAT = "content_accessory_{0}";
  [Token(Token = "0x4000D22")]
  private const string PIECE_IMAGE_AB_NAME_FORMAT_EDITOR = "content_accessory_{0}_pieceimage";
  [Token(Token = "0x4000D23")]
  private const string PIECE_IMAGE_ASSET_NAME_FORMAT = "{0}_AccessoryPieceImage";

  [Token(Token = "0x6000E02")]
  [Address(RVA = "0x1C8A200", Offset = "0x1C8A200", VA = "0x1C8A200")]
  public static string GetThumbnailAssetbundleNameByAccessoryId(int accessoryId, bool isOverride = true)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E03")]
  [Address(RVA = "0x1C8A398", Offset = "0x1C8A398", VA = "0x1C8A398")]
  public static string GetThumbnailAssetNameByAccessoryId(int accessoryId, bool isOverride = true)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E04")]
  [Address(RVA = "0x1C8A43C", Offset = "0x1C8A43C", VA = "0x1C8A43C")]
  public static string GetImageAssetBundleNameByAccessoryId(int accessoryId, bool isOverride = true)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E05")]
  [Address(RVA = "0x1C8A4E0", Offset = "0x1C8A4E0", VA = "0x1C8A4E0")]
  public static string GetImageAssetNameByAccessoryId(int accessoryId, bool isOverride = true)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E06")]
  [Address(RVA = "0x1C8A584", Offset = "0x1C8A584", VA = "0x1C8A584")]
  public static string GetPieceImageAssetBundleNameByAccessoryId(int accessoryId) => (string) null;

  [Token(Token = "0x6000E07")]
  [Address(RVA = "0x1C8A604", Offset = "0x1C8A604", VA = "0x1C8A604")]
  public static string GetPieceThumbAssetBundleNameByAccessoryId(int accessoryId) => (string) null;

  [Token(Token = "0x6000E08")]
  [Address(RVA = "0x1C8A684", Offset = "0x1C8A684", VA = "0x1C8A684")]
  public static string GetPieceImageAssetNameByAccessoryId(int accessoryId) => (string) null;

  [Token(Token = "0x6000E09")]
  [Address(RVA = "0x1C8A704", Offset = "0x1C8A704", VA = "0x1C8A704")]
  public static string GetPieceThumbAssetNameByAccessoryId(int accessoryId) => (string) null;

  [Token(Token = "0x6000E0A")]
  [Address(RVA = "0x1C8A784", Offset = "0x1C8A784", VA = "0x1C8A784")]
  public static string GetTypeIconSpriteNameByAccessoryId(int accessoryId) => (string) null;

  [Token(Token = "0x6000E0B")]
  [Address(RVA = "0x1C8A814", Offset = "0x1C8A814", VA = "0x1C8A814")]
  public static string GetTypeIconSpriteNameByAccessoryId(
    AccessorieClassificationEnum classificationEnum,
    AccessorieTypeEnum accessorieType)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E0C")]
  [Address(RVA = "0x1C8A2A4", Offset = "0x1C8A2A4", VA = "0x1C8A2A4")]
  private static bool TryOverrideResourceId(int id, out int resourceId) => new bool();
}
