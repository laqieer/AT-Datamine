// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenWidth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x200051F")]
  [RequireComponent(typeof (RectTransform))]
  [AddComponentMenu("Tween/Tweeners/Tween Width")]
  public class TweenWidth : UITweener
  {
    [Token(Token = "0x4001B42")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private int from;
    [Token(Token = "0x4001B43")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private int to;
    [Token(Token = "0x4001B44")]
    [FieldOffset(Offset = "0x70")]
    private RectTransform widget;

    [Token(Token = "0x170003EC")]
    public int From
    {
      [Token(Token = "0x6001DB7"), Address(RVA = "0x29FB108", Offset = "0x29FB108", VA = "0x29FB108")] get
      {
        return new int();
      }
      [Token(Token = "0x6001DB8"), Address(RVA = "0x29FB110", Offset = "0x29FB110", VA = "0x29FB110")] set
      {
      }
    }

    [Token(Token = "0x170003ED")]
    public int To
    {
      [Token(Token = "0x6001DB9"), Address(RVA = "0x29FB118", Offset = "0x29FB118", VA = "0x29FB118")] get
      {
        return new int();
      }
      [Token(Token = "0x6001DBA"), Address(RVA = "0x29FB120", Offset = "0x29FB120", VA = "0x29FB120")] set
      {
      }
    }

    [Token(Token = "0x170003EE")]
    public RectTransform CachedWidget
    {
      [Token(Token = "0x6001DBB"), Address(RVA = "0x29FB128", Offset = "0x29FB128", VA = "0x29FB128")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170003EF")]
    public int Value
    {
      [Token(Token = "0x6001DBC"), Address(RVA = "0x29FB1BC", Offset = "0x29FB1BC", VA = "0x29FB1BC")] get
      {
        return new int();
      }
      [Token(Token = "0x6001DBD"), Address(RVA = "0x29FB1F4", Offset = "0x29FB1F4", VA = "0x29FB1F4")] set
      {
      }
    }

    [Token(Token = "0x6001DBE")]
    [Address(RVA = "0x29FB248", Offset = "0x29FB248", VA = "0x29FB248", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001DBF")]
    [Address(RVA = "0x29FB348", Offset = "0x29FB348", VA = "0x29FB348")]
    public TweenWidth()
    {
    }
  }
}
