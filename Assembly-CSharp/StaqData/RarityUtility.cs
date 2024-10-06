// Decompiled with JetBrains decompiler
// Type: StaqData.RarityUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200207E")]
  public static class RarityUtility
  {
    [Token(Token = "0x4008A3B")]
    public const string IconCommonImageAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x4008A3C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string[] IconBaseImageAssetFormat;
    [Token(Token = "0x4008A3D")]
    public const string RarityImageAssetbundleName = "ui_common_thumb_texture_spriteatlas";
    [Token(Token = "0x4008A3E")]
    private const string RarityImageAssetFormat = "Img_Rarelity_{0}_S";
    [Token(Token = "0x4008A3F")]
    private const string RarityImageAssetFormatSizeM = "Img_Rarelity_{0}";
    [Token(Token = "0x4008A40")]
    public const string MnemnographBaseAssetbundleName = "ui_common_thumb_texture_spriteatlas";
    [Token(Token = "0x4008A41")]
    public const string RarityBaseImageAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x4008A42")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string VirtualRectangleRarityFrameAssetBundleName;

    [Token(Token = "0x600C46C")]
    [Address(RVA = "0x19F7B18", Offset = "0x19F7B18", VA = "0x19F7B18")]
    public static string GetItemBaseAssetName(this RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x600C46D")]
    [Address(RVA = "0x19F7B94", Offset = "0x19F7B94", VA = "0x19F7B94")]
    public static string GetMnemnographBaseAssetName(this RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x600C46E")]
    [Address(RVA = "0x19F7C18", Offset = "0x19F7C18", VA = "0x19F7C18")]
    public static string GetLongMnemnographBaseAssetName(this RarityTypeEnum rarity)
    {
      return (string) null;
    }

    [Token(Token = "0x600C46F")]
    [Address(RVA = "0x19F7C9C", Offset = "0x19F7C9C", VA = "0x19F7C9C")]
    public static string GetRarityImageAssetName(this RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x600C470")]
    [Address(RVA = "0x19F7DA8", Offset = "0x19F7DA8", VA = "0x19F7DA8")]
    public static string GetRarityImageAssetNameSizeM(this RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x600C471")]
    [Address(RVA = "0x19F7D18", Offset = "0x19F7D18", VA = "0x19F7D18")]
    public static string ToRarityImageAssetNameSuffix(this RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x600C472")]
    [Address(RVA = "0x19F7E24", Offset = "0x19F7E24", VA = "0x19F7E24")]
    public static string GetRarityBaseImageAssetName(this RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x600C473")]
    [Address(RVA = "0x19F7EA4", Offset = "0x19F7EA4", VA = "0x19F7EA4")]
    public static string GetVirtualRectangleRarityFrameAssetName(this RarityTypeEnum rarity)
    {
      return (string) null;
    }

    [Token(Token = "0x600C474")]
    [Address(RVA = "0x19F7F98", Offset = "0x19F7F98", VA = "0x19F7F98")]
    public static (string, string) GetArmourySquareItemFrame(this RarityTypeEnum rarity) => ();

    [Token(Token = "0x600C475")]
    [Address(RVA = "0x19F80EC", Offset = "0x19F80EC", VA = "0x19F80EC")]
    static RarityUtility()
    {
    }
  }
}
