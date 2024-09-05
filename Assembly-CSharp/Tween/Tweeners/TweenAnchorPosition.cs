// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenAnchorPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000509")]
  [RequireComponent(typeof (RectTransform))]
  [AddComponentMenu("Tween/Tweeners/Tween AnchorPosition")]
  public class TweenAnchorPosition : UITweener
  {
    [Token(Token = "0x4001AF1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Vector2 from;
    [Token(Token = "0x4001AF2")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Vector2 to;
    [Token(Token = "0x4001AF3")]
    [FieldOffset(Offset = "0x78")]
    private RectTransform rectTransform;

    [Token(Token = "0x170003AB")]
    public Vector2 From
    {
      [Token(Token = "0x6001D05"), Address(RVA = "0x29F7F98", Offset = "0x29F7F98", VA = "0x29F7F98")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001D06"), Address(RVA = "0x29F7FA0", Offset = "0x29F7FA0", VA = "0x29F7FA0")] set
      {
      }
    }

    [Token(Token = "0x170003AC")]
    public Vector2 To
    {
      [Token(Token = "0x6001D07"), Address(RVA = "0x29F7FA8", Offset = "0x29F7FA8", VA = "0x29F7FA8")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001D08"), Address(RVA = "0x29F7FB0", Offset = "0x29F7FB0", VA = "0x29F7FB0")] set
      {
      }
    }

    [Token(Token = "0x170003AD")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6001D09"), Address(RVA = "0x29F7FB8", Offset = "0x29F7FB8", VA = "0x29F7FB8")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170003AE")]
    public Vector2 Value
    {
      [Token(Token = "0x6001D0A"), Address(RVA = "0x29F804C", Offset = "0x29F804C", VA = "0x29F804C")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001D0B"), Address(RVA = "0x29F8068", Offset = "0x29F8068", VA = "0x29F8068")] set
      {
      }
    }

    [Token(Token = "0x6001D0C")]
    [Address(RVA = "0x29F809C", Offset = "0x29F809C", VA = "0x29F809C", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D0D")]
    [Address(RVA = "0x29F80BC", Offset = "0x29F80BC", VA = "0x29F80BC")]
    public TweenAnchorPosition()
    {
    }
  }
}
