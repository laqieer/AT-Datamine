// Decompiled with JetBrains decompiler
// Type: GameCore.Font.FontAssets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace GameCore.Font
{
  [Token(Token = "0x2001461")]
  public class FontAssets : MonoBehaviour
  {
    [Token(Token = "0x4005DDF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FontInfo[] assets;
    [Token(Token = "0x4005DE0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TMPFontInfo[] tmpAssets;
    [Token(Token = "0x4005DE1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MaterialInfo[] tmpMaterialInfo;

    [Token(Token = "0x60072DB")]
    [Address(RVA = "0x4052F6C", Offset = "0x4052F6C", VA = "0x4052F6C")]
    public UnityEngine.Font GetFont(FontManager.FontLabel label) => (UnityEngine.Font) null;

    [Token(Token = "0x60072DC")]
    [Address(RVA = "0x4052FD0", Offset = "0x4052FD0", VA = "0x4052FD0")]
    public TMP_FontAsset GetTMPFont(FontManager.FontLabel label) => (TMP_FontAsset) null;

    [Token(Token = "0x60072DD")]
    [Address(RVA = "0x4053034", Offset = "0x4053034", VA = "0x4053034")]
    public Material GetMaterialByName(string materialName, TMP_FontAsset defaultFont)
    {
      return (Material) null;
    }

    [Token(Token = "0x60072DE")]
    [Address(RVA = "0x4053190", Offset = "0x4053190", VA = "0x4053190")]
    public bool IsInFontAsset(TMP_FontAsset font) => new bool();

    [Token(Token = "0x60072DF")]
    [Address(RVA = "0x40532A4", Offset = "0x40532A4", VA = "0x40532A4")]
    public FontAssets()
    {
    }
  }
}
