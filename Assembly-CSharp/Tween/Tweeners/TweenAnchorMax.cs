// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenAnchorMax
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000507")]
  [RequireComponent(typeof (RectTransform))]
  [AddComponentMenu("Tween/Tweeners/Tween Anchor Max")]
  public class TweenAnchorMax : UITweener
  {
    [Token(Token = "0x4001AEB")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Vector2 from;
    [Token(Token = "0x4001AEC")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Vector2 to;
    [Token(Token = "0x4001AED")]
    [FieldOffset(Offset = "0x78")]
    private RectTransform rectTransform;

    [Token(Token = "0x170003A3")]
    public Vector2 From
    {
      [Token(Token = "0x6001CF3"), Address(RVA = "0x29F7D40", Offset = "0x29F7D40", VA = "0x29F7D40")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001CF4"), Address(RVA = "0x29F7D48", Offset = "0x29F7D48", VA = "0x29F7D48")] set
      {
      }
    }

    [Token(Token = "0x170003A4")]
    public Vector2 To
    {
      [Token(Token = "0x6001CF5"), Address(RVA = "0x29F7D50", Offset = "0x29F7D50", VA = "0x29F7D50")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001CF6"), Address(RVA = "0x29F7D58", Offset = "0x29F7D58", VA = "0x29F7D58")] set
      {
      }
    }

    [Token(Token = "0x170003A5")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6001CF7"), Address(RVA = "0x29F7D60", Offset = "0x29F7D60", VA = "0x29F7D60")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170003A6")]
    public Vector2 Value
    {
      [Token(Token = "0x6001CF8"), Address(RVA = "0x29F7DF4", Offset = "0x29F7DF4", VA = "0x29F7DF4")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001CF9"), Address(RVA = "0x29F7E10", Offset = "0x29F7E10", VA = "0x29F7E10")] set
      {
      }
    }

    [Token(Token = "0x6001CFA")]
    [Address(RVA = "0x29F7E44", Offset = "0x29F7E44", VA = "0x29F7E44", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001CFB")]
    [Address(RVA = "0x29F7E64", Offset = "0x29F7E64", VA = "0x29F7E64")]
    public TweenAnchorMax()
    {
    }
  }
}
