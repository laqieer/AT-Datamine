// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapUICanvasGetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015F8")]
  public class FreeMapUICanvasGetter : MonoBehaviour
  {
    [Token(Token = "0x400642D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Canvas canvas;
    [Token(Token = "0x400642E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UISafeAreaInsets safeAraeInsets;

    [Token(Token = "0x17001325")]
    public Canvas Canvas
    {
      [Token(Token = "0x6007C52"), Address(RVA = "0x21A0850", Offset = "0x21A0850", VA = "0x21A0850")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x17001326")]
    public UISafeAreaInsets SafeArea
    {
      [Token(Token = "0x6007C53"), Address(RVA = "0x21A0858", Offset = "0x21A0858", VA = "0x21A0858")] get
      {
        return (UISafeAreaInsets) null;
      }
    }

    [Token(Token = "0x17001327")]
    public RectTransform CanvasRectTransform
    {
      [Token(Token = "0x6007C54"), Address(RVA = "0x21A0860", Offset = "0x21A0860", VA = "0x21A0860")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6007C55")]
    [Address(RVA = "0x21A08C8", Offset = "0x21A08C8", VA = "0x21A08C8")]
    public void CorrectRectTransformToSafeArea()
    {
    }

    [Token(Token = "0x6007C56")]
    [Address(RVA = "0x21A094C", Offset = "0x21A094C", VA = "0x21A094C")]
    public FreeMapUICanvasGetter()
    {
    }
  }
}
