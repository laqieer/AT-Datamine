// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.ThumbRarityBaseUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032C9")]
  public static class ThumbRarityBaseUtility
  {
    [Token(Token = "0x400DAB7")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400DAB8")]
    [FieldOffset(Offset = "0x0")]
    private static string[] thumbBaseAssetName;
    [Token(Token = "0x400DAB9")]
    [FieldOffset(Offset = "0x8")]
    private static string[] thumbRarityTextAssetName;
    [Token(Token = "0x400DABA")]
    [FieldOffset(Offset = "0x10")]
    private static string[] largeThumbRarityTextAssetName;

    [Token(Token = "0x6013E82")]
    [Address(RVA = "0x1AEC064", Offset = "0x1AEC064", VA = "0x1AEC064")]
    public static string GetAssetBundleName() => (string) null;

    [Token(Token = "0x6013E83")]
    [Address(RVA = "0x1AEC0A4", Offset = "0x1AEC0A4", VA = "0x1AEC0A4")]
    public static string GetRarityTextAssetName(RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x6013E84")]
    [Address(RVA = "0x1AEC174", Offset = "0x1AEC174", VA = "0x1AEC174")]
    public static string GetLargeRarityTextAssetName(RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x6013E85")]
    [Address(RVA = "0x1AEC244", Offset = "0x1AEC244", VA = "0x1AEC244")]
    private static string GetAssetName(int rarity) => (string) null;

    [Token(Token = "0x6013E86")]
    [Address(RVA = "0x1AEC310", Offset = "0x1AEC310", VA = "0x1AEC310")]
    public static string GetAssetBaseName(RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x6013E87")]
    [Address(RVA = "0x1AEC364", Offset = "0x1AEC364", VA = "0x1AEC364")]
    static ThumbRarityBaseUtility()
    {
    }
  }
}
