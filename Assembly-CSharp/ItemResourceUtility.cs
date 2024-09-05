// Decompiled with JetBrains decompiler
// Type: ItemResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000242")]
public static class ItemResourceUtility
{
  [Token(Token = "0x4000D70")]
  private const string ITEM_AB_NAME_FORMAT = "content_item_{0}_thumb";
  [Token(Token = "0x4000D71")]
  private const string ITEM_ASSET_NAME_FORMAT = "{0}_ItemThumb";
  [Token(Token = "0x4000D72")]
  private const string ITEM_IMAGE_AB_NAME_FORMAT = "content_item_{0}_image";
  [Token(Token = "0x4000D73")]
  private const string ITEM_IMAGE_ASSET_NAME_FORMAT = "{0}_ItemImage";
  [Token(Token = "0x4000D74")]
  private const int STANDARD_SET_ITEM_ID = 301010001;
  [Token(Token = "0x4000D75")]
  private const int FEATURED_SET_ITEM_ID = 301010002;

  [Token(Token = "0x6000E51")]
  [Address(RVA = "0x1C8E2EC", Offset = "0x1C8E2EC", VA = "0x1C8E2EC")]
  public static string GetThumbnailAssetbundleNameByItemId(int itemId) => (string) null;

  [Token(Token = "0x6000E52")]
  [Address(RVA = "0x1C8E36C", Offset = "0x1C8E36C", VA = "0x1C8E36C")]
  public static string GetThumbnailAssetNameByItemId(int itemId) => (string) null;

  [Token(Token = "0x6000E53")]
  [Address(RVA = "0x1C8E3EC", Offset = "0x1C8E3EC", VA = "0x1C8E3EC")]
  public static string GetSetItemThumbnailAssetbundleNameByItemId(
    ItemResourceUtility.SetItemTypeEnum setItemType)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E54")]
  [Address(RVA = "0x1C8E414", Offset = "0x1C8E414", VA = "0x1C8E414")]
  public static string GetSetItemThumbnailAssetName(ItemResourceUtility.SetItemTypeEnum setItemType)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E55")]
  [Address(RVA = "0x1C8E43C", Offset = "0x1C8E43C", VA = "0x1C8E43C")]
  public static string GetImageAssetbundleNameByItemId(int itemId) => (string) null;

  [Token(Token = "0x6000E56")]
  [Address(RVA = "0x1C8E4BC", Offset = "0x1C8E4BC", VA = "0x1C8E4BC")]
  public static string GetImageAssetNameByItemId(int itemId) => (string) null;

  [Token(Token = "0x6000E57")]
  [Address(RVA = "0x1C8E53C", Offset = "0x1C8E53C", VA = "0x1C8E53C")]
  public static string GetSetItemImageAssetbundleNameByItemId(
    ItemResourceUtility.SetItemTypeEnum setItemType)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E58")]
  [Address(RVA = "0x1C8E564", Offset = "0x1C8E564", VA = "0x1C8E564")]
  public static string GetSetItemImageAssetName(ItemResourceUtility.SetItemTypeEnum setItemType)
  {
    return (string) null;
  }

  [Token(Token = "0x2000243")]
  public enum SetItemTypeEnum
  {
    [Token(Token = "0x4000D77")] Standard,
    [Token(Token = "0x4000D78")] Featured,
  }
}
