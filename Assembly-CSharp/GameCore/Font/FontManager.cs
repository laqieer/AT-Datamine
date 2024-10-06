// Decompiled with JetBrains decompiler
// Type: GameCore.Font.FontManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
namespace GameCore.Font
{
  [Token(Token = "0x2001462")]
  public class FontManager : Singleton<FontManager>
  {
    [Token(Token = "0x4005DE2")]
    [FieldOffset(Offset = "0x10")]
    private bool isInitialized;
    [Token(Token = "0x4005DE3")]
    private const string FONT_DLC_PREFAB_NAME = "FontAssets";
    [Token(Token = "0x4005DE4")]
    [FieldOffset(Offset = "0x18")]
    private FontAssets resources;
    [Token(Token = "0x4005DE5")]
    [FieldOffset(Offset = "0x20")]
    private string dlcName;

    [Token(Token = "0x60072E0")]
    [Address(RVA = "0x40532AC", Offset = "0x40532AC", VA = "0x40532AC")]
    public void LoadFontAssetFromLocal()
    {
    }

    [Token(Token = "0x60072E1")]
    [Address(RVA = "0x405337C", Offset = "0x405337C", VA = "0x405337C")]
    public UnityEngine.Font GetFontData(FontManager.FontLabel label) => (UnityEngine.Font) null;

    [Token(Token = "0x60072E2")]
    [Address(RVA = "0x4053458", Offset = "0x4053458", VA = "0x4053458")]
    public TMP_FontAsset GetTMPFontData(FontManager.FontLabel label) => (TMP_FontAsset) null;

    [Token(Token = "0x60072E3")]
    [Address(RVA = "0x40534E4", Offset = "0x40534E4", VA = "0x40534E4")]
    public string GetDlcName() => (string) null;

    [Token(Token = "0x60072E4")]
    [Address(RVA = "0x4053560", Offset = "0x4053560", VA = "0x4053560")]
    public Material GetMaterial(string materialName, TMP_FontAsset defaultFont) => (Material) null;

    [Token(Token = "0x60072E5")]
    [Address(RVA = "0x4053618", Offset = "0x4053618", VA = "0x4053618")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x60072E6")]
    [Address(RVA = "0x40536A8", Offset = "0x40536A8", VA = "0x40536A8")]
    public void Clear()
    {
    }

    [Token(Token = "0x60072E7")]
    [Address(RVA = "0x40538CC", Offset = "0x40538CC", VA = "0x40538CC")]
    public bool IsNormalFont(TMP_FontAsset font) => new bool();

    [Token(Token = "0x60072E8")]
    [Address(RVA = "0x40538E4", Offset = "0x40538E4", VA = "0x40538E4")]
    public FontManager()
    {
    }

    [Token(Token = "0x2001463")]
    public enum FontLabel
    {
      [Token(Token = "0x4005DE7")] TEXT_DEFAULT,
      [Token(Token = "0x4005DE8")] TEXT_STANDARD,
      [Token(Token = "0x4005DE9")] TEXT_NUMBER,
      [Token(Token = "0x4005DEA")] TMP_DEFAULT,
      [Token(Token = "0x4005DEB")] TMP_STANDARD,
      [Token(Token = "0x4005DEC")] TMP_NUMBER,
    }
  }
}
