// Decompiled with JetBrains decompiler
// Type: GameCore.Font.FontSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Font
{
  [Token(Token = "0x2001465")]
  public class FontSetter : MonoBehaviour
  {
    [Token(Token = "0x4005DF0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("差し替えるフォント")]
    private FontManager.FontLabel fontType;
    [Token(Token = "0x4005DF1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("マテリアル名(TMPro用)")]
    private string materialName;

    [Token(Token = "0x60072F0")]
    [Address(RVA = "0x4053DF4", Offset = "0x4053DF4", VA = "0x4053DF4")]
    public void Awake()
    {
    }

    [Token(Token = "0x60072F1")]
    [Address(RVA = "0x4053DF8", Offset = "0x4053DF8", VA = "0x4053DF8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60072F2")]
    [Address(RVA = "0x4054144", Offset = "0x4054144", VA = "0x4054144")]
    public FontSetter()
    {
    }
  }
}
