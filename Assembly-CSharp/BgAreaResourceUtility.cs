// Decompiled with JetBrains decompiler
// Type: BgAreaResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200023F")]
public static class BgAreaResourceUtility
{
  [Token(Token = "0x4000D24")]
  private const string BG_AREA_ASSET_BUNDLE_LABEL = "content_bg_area_{0}";
  [Token(Token = "0x4000D25")]
  private const string BG_AREA_PLACE_ASSET_BUNDLE_LABEL = "content_bg_area_{0}_place";
  [Token(Token = "0x4000D26")]
  private const string BG_AREA_MINIMAP_ASSET_BUNDLE_LABEL = "content_bg_area_{0}_minimap";
  [Token(Token = "0x4000D27")]
  private const string BG_AREA_MOVABLE_ASSET_BUNDLE_LABEL = "content_bg_area_{0}_movable";
  [Token(Token = "0x4000D28")]
  private const string BG_AREA_ENVIROMENTAL_SOUND_ASSET_BUNDLE_LABEL = "content_bg_area_{0}_envse{1}";
  [Token(Token = "0x4000D29")]
  private const string BG_AREA_INTRODUCTION_ASSET_BUNDLE_LABEL = "content_bg_area_{0}_introduction";
  [Token(Token = "0x4000D2A")]
  private const string BG_AREA_INTRODUCTION_ASSET_NAME = "Introduction{0}";

  [Token(Token = "0x6000E0D")]
  [Address(RVA = "0x1C8A8CC", Offset = "0x1C8A8CC", VA = "0x1C8A8CC")]
  public static string GetBgAreaAssetbundleName(string backGroundID) => (string) null;

  [Token(Token = "0x6000E0E")]
  [Address(RVA = "0x1C8A918", Offset = "0x1C8A918", VA = "0x1C8A918")]
  public static string GetPlaceAssetbundleName(string backGroundID) => (string) null;

  [Token(Token = "0x6000E0F")]
  [Address(RVA = "0x1C8A964", Offset = "0x1C8A964", VA = "0x1C8A964")]
  public static string GetMiniMapAssetbundleName(int backGroundID) => (string) null;

  [Token(Token = "0x6000E10")]
  [Address(RVA = "0x1C8A9E4", Offset = "0x1C8A9E4", VA = "0x1C8A9E4")]
  public static string GetMovableAssetbundleName(string backGroundID) => (string) null;

  [Token(Token = "0x6000E11")]
  [Address(RVA = "0x1C8AA30", Offset = "0x1C8AA30", VA = "0x1C8AA30")]
  public static string GetEnviromentalSoundAssetbundleName(
    string backGroundID,
    string environmentalSoundID)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E12")]
  [Address(RVA = "0x1C8AA8C", Offset = "0x1C8AA8C", VA = "0x1C8AA8C")]
  public static string GetIntroductionAssetbundleName(int productionID) => (string) null;

  [Token(Token = "0x6000E13")]
  [Address(RVA = "0x1C8AB0C", Offset = "0x1C8AB0C", VA = "0x1C8AB0C")]
  public static string GetIntroductionAssetName(int productionID) => (string) null;
}
