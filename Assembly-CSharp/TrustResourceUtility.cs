// Decompiled with JetBrains decompiler
// Type: TrustResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200024C")]
public static class TrustResourceUtility
{
  [Token(Token = "0x4000DAD")]
  private const string TRUST_AB_NAME_FORMAT = "content_trust_{0}_thumb";
  [Token(Token = "0x4000DAE")]
  private const string TRUST_ASSET_NAME_FORMAT = "{0}_TrustThumb";
  [Token(Token = "0x4000DAF")]
  private const string TRUSTIMAGE_AB_NAME_FORMAT = "content_trust_{0}_image";
  [Token(Token = "0x4000DB0")]
  private const string TRUSTIMAGE_ASSET_NAME_FORMAT = "{0}_TrustImage";

  [Token(Token = "0x6000E86")]
  [Address(RVA = "0x1C8FD1C", Offset = "0x1C8FD1C", VA = "0x1C8FD1C")]
  public static string GetThumbnailAssetbundleNameByTrustId(int trustId) => (string) null;

  [Token(Token = "0x6000E87")]
  [Address(RVA = "0x1C8FD9C", Offset = "0x1C8FD9C", VA = "0x1C8FD9C")]
  public static string GetThumbnailAssetNameByTrustId(int trustId) => (string) null;

  [Token(Token = "0x6000E88")]
  [Address(RVA = "0x1C8FE1C", Offset = "0x1C8FE1C", VA = "0x1C8FE1C")]
  public static string GetImageAssetbundleNameByTrustId(int trustId) => (string) null;

  [Token(Token = "0x6000E89")]
  [Address(RVA = "0x1C8FE9C", Offset = "0x1C8FE9C", VA = "0x1C8FE9C")]
  public static string GetImageAssetNameByTrustId(int trustId) => (string) null;
}
