// Decompiled with JetBrains decompiler
// Type: StaqData.UnitUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200210F")]
  public static class UnitUtility
  {
    [Token(Token = "0x4008C67")]
    private const string AssetBundleNameFormat = "content_chr_{0}_{1}_thumb";
    [Token(Token = "0x4008C68")]
    private const string ThumbnailAssetNameFormat = "Chr_{0}_{1}_Thumb";

    [Token(Token = "0x600CA2E")]
    [Address(RVA = "0x1BA16CC", Offset = "0x1BA16CC", VA = "0x1BA16CC")]
    public static string GetUnitAssetBundleName(int characterId, int styleId) => (string) null;

    [Token(Token = "0x600CA2F")]
    [Address(RVA = "0x1BA1770", Offset = "0x1BA1770", VA = "0x1BA1770")]
    public static string GetUnitThumbnailName(int characterId, int styleId) => (string) null;
  }
}
