// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenPreferredHeight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000515")]
  [RequireComponent(typeof (LayoutElement))]
  [AddComponentMenu("Tween/Tweeners/Tween Preferred Height")]
  public class TweenPreferredHeight : UITweener
  {
    [Token(Token = "0x4001B1B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private int from;
    [Token(Token = "0x4001B1C")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private int to;
    [Token(Token = "0x4001B1D")]
    [FieldOffset(Offset = "0x70")]
    private LayoutElement widget;

    [Token(Token = "0x170003CA")]
    public int From
    {
      [Token(Token = "0x6001D5F"), Address(RVA = "0x29F9958", Offset = "0x29F9958", VA = "0x29F9958")] get
      {
        return new int();
      }
      [Token(Token = "0x6001D60"), Address(RVA = "0x29F9960", Offset = "0x29F9960", VA = "0x29F9960")] set
      {
      }
    }

    [Token(Token = "0x170003CB")]
    public int To
    {
      [Token(Token = "0x6001D61"), Address(RVA = "0x29F9968", Offset = "0x29F9968", VA = "0x29F9968")] get
      {
        return new int();
      }
      [Token(Token = "0x6001D62"), Address(RVA = "0x29F9970", Offset = "0x29F9970", VA = "0x29F9970")] set
      {
      }
    }

    [Token(Token = "0x170003CC")]
    public LayoutElement CachedWidget
    {
      [Token(Token = "0x6001D63"), Address(RVA = "0x29F9978", Offset = "0x29F9978", VA = "0x29F9978")] get
      {
        return (LayoutElement) null;
      }
    }

    [Token(Token = "0x170003CD")]
    public int Value
    {
      [Token(Token = "0x6001D64"), Address(RVA = "0x29F9A0C", Offset = "0x29F9A0C", VA = "0x29F9A0C")] get
      {
        return new int();
      }
      [Token(Token = "0x6001D65"), Address(RVA = "0x29F9A4C", Offset = "0x29F9A4C", VA = "0x29F9A4C")] set
      {
      }
    }

    [Token(Token = "0x6001D66")]
    [Address(RVA = "0x29F9A78", Offset = "0x29F9A78", VA = "0x29F9A78", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D67")]
    [Address(RVA = "0x29F9B78", Offset = "0x29F9B78", VA = "0x29F9B78")]
    public TweenPreferredHeight()
    {
    }
  }
}
