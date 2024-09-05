// Decompiled with JetBrains decompiler
// Type: MnemnographResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000245")]
public static class MnemnographResourceUtility
{
  [Token(Token = "0x4000D7B")]
  private const string CONTENT_PREFIX = "content_mnemnograph_";
  [Token(Token = "0x4000D7C")]
  private const string THUMB_AB_NAME_FORMAT = "content_mnemnograph_{0}";
  [Token(Token = "0x4000D7D")]
  private const string THUMB_AB_NAME_FORMAT_EDITOR = "content_mnemnograph_{0}_thumb";
  [Token(Token = "0x4000D7E")]
  private const string THUMB_ASSET_NAME_FORMAT = "{0}_MnemnographThumb";
  [Token(Token = "0x4000D7F")]
  private const string IMAGE_AB_NAME_FORMAT = "content_mnemnograph_{0}";
  [Token(Token = "0x4000D80")]
  private const string IMAGE_AB_NAME_FORMAT_EDITOR = "content_mnemnograph_{0}_image";
  [Token(Token = "0x4000D81")]
  private const string IMAGE_ASSET_NAME_FORMAT = "{0}_MnemnographImage";
  [Token(Token = "0x4000D82")]
  private const string IMAGE_STRIP_AB_NAME_FORMAT = "content_mnemnograph_{0}";
  [Token(Token = "0x4000D83")]
  private const string IMAGE_STRIP_AB_NAME_FORMAT_EDITOR = "content_mnemnograph_{0}_image_strip";
  [Token(Token = "0x4000D84")]
  private const string IMAGE_STRIP_ASSET_NAME_FORMAT = "{0}_MnemnographImage_Strip";
  [Token(Token = "0x4000D85")]
  private const string IMAGE_LAYOUT_AB_NAME_FORMAT = "content_mnemnograph_{0}";
  [Token(Token = "0x4000D86")]
  private const string IMAGE_LAYOUT_AB_NAME_FORMAT_EDITOR = "content_mnemnograph_{0}_image";
  [Token(Token = "0x4000D87")]
  private const string IMAGE_LAYOUT_ASSET_NAME_FORMAT = "{0}_MnemnographImage_pos";
  [Token(Token = "0x4000D88")]
  private const string LONGTHUMB_AB_NAME_FORMAT = "content_mnemnograph_{0}";
  [Token(Token = "0x4000D89")]
  private const string LONGTHUMB_AB_NAME_FORMAT_EDITOR = "content_mnemnograph_{0}_longthumb";
  [Token(Token = "0x4000D8A")]
  private const string LONGTHUMB_ASSET_NAME_FORMAT = "{0}_MnemnographLongThumb";

  [Token(Token = "0x6000E5B")]
  [Address(RVA = "0x1C8E68C", Offset = "0x1C8E68C", VA = "0x1C8E68C")]
  public static string GetThumbnailAssetbundleNameById(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E5C")]
  [Address(RVA = "0x1C8E70C", Offset = "0x1C8E70C", VA = "0x1C8E70C")]
  public static string GetThumbnailAssetNameById(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E5D")]
  [Address(RVA = "0x1C8E78C", Offset = "0x1C8E78C", VA = "0x1C8E78C")]
  public static string GetImageAssetBundleNameById(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E5E")]
  [Address(RVA = "0x1C8E80C", Offset = "0x1C8E80C", VA = "0x1C8E80C")]
  public static string GetImageLayoutAssetBundleNameById(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E5F")]
  [Address(RVA = "0x1C8E88C", Offset = "0x1C8E88C", VA = "0x1C8E88C")]
  public static string GetImageAssetNameById(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E60")]
  [Address(RVA = "0x1C8E90C", Offset = "0x1C8E90C", VA = "0x1C8E90C")]
  public static string GetImageLayoutAssetNameById(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E61")]
  [Address(RVA = "0x1C8E98C", Offset = "0x1C8E98C", VA = "0x1C8E98C")]
  public static string GetImageStripAssetBundleNameByStyleId(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E62")]
  [Address(RVA = "0x1C8EA0C", Offset = "0x1C8EA0C", VA = "0x1C8EA0C")]
  public static string GetImageStripAssetNameByStyleId(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E63")]
  [Address(RVA = "0x1C8EA8C", Offset = "0x1C8EA8C", VA = "0x1C8EA8C")]
  public static string GetLongThumbnailAssetbundleNameById(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E64")]
  [Address(RVA = "0x1C8EB0C", Offset = "0x1C8EB0C", VA = "0x1C8EB0C")]
  public static string GetLongThumbnailAssetNameById(int mindEquipmentId) => (string) null;

  [Token(Token = "0x6000E65")]
  [Address(RVA = "0x1C8EB8C", Offset = "0x1C8EB8C", VA = "0x1C8EB8C")]
  public static (string, string) GetVirtualRectangleThumbnailAssetBundleNameAndAssetName(
    int mindEquipmentId)
  {
    return ();
  }
}
