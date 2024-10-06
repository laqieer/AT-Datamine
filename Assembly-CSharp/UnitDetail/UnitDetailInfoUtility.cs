// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitDetailInfoUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x200049F")]
  public static class UnitDetailInfoUtility
  {
    [Token(Token = "0x400187C")]
    public const string SpriteAtlasAssetBundleName = "2dassets_ui_unitdetail_spriteatlases";
    [Token(Token = "0x400187D")]
    public const string SpriteAtlasName = "UnitDetail_ ReplaceImage";

    [Token(Token = "0x60019DB")]
    [Address(RVA = "0x2C240AC", Offset = "0x2C240AC", VA = "0x2C240AC")]
    public static string GetRaritySpriteName(RarityTypeEnum rarity) => (string) null;

    [Token(Token = "0x60019DC")]
    [Address(RVA = "0x2C241A0", Offset = "0x2C241A0", VA = "0x2C241A0")]
    public static string GetFavoriteSpriteName(bool favorite) => (string) null;
  }
}
