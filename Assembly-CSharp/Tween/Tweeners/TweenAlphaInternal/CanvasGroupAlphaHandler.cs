// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenAlphaInternal.CanvasGroupAlphaHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners.TweenAlphaInternal
{
  [Token(Token = "0x2000525")]
  public class CanvasGroupAlphaHandler : IAlphaHandler
  {
    [Token(Token = "0x4001B48")]
    [FieldOffset(Offset = "0x10")]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4001B49")]
    [FieldOffset(Offset = "0x18")]
    private TweenAlphaOptionRaycast optionRaycast;

    [Token(Token = "0x6001DD3")]
    [Address(RVA = "0x29F7C64", Offset = "0x29F7C64", VA = "0x29F7C64")]
    public CanvasGroupAlphaHandler(CanvasGroup canvasGroup, TweenAlphaOptionRaycast optionRaycast)
    {
    }

    [Token(Token = "0x170003F5")]
    public float Alpha
    {
      [Token(Token = "0x6001DD4"), Address(RVA = "0x29FB604", Offset = "0x29FB604", VA = "0x29FB604", Slot = "4")] get
      {
        return new float();
      }
      [Token(Token = "0x6001DD5"), Address(RVA = "0x29FB620", Offset = "0x29FB620", VA = "0x29FB620", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x6001DD6")]
    [Address(RVA = "0x29FB658", Offset = "0x29FB658", VA = "0x29FB658")]
    private void ModifyRaycast(float alpha)
    {
    }
  }
}
