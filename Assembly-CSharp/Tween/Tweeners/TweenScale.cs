// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000519")]
  [AddComponentMenu("Tween/Tweeners/Tween Scale")]
  public class TweenScale : UITweener
  {
    [Token(Token = "0x4001B25")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Vector3 from;
    [Token(Token = "0x4001B26")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Vector3 to;
    [Token(Token = "0x4001B27")]
    [FieldOffset(Offset = "0x80")]
    private Transform cachedTransform;

    [Token(Token = "0x170003D5")]
    public Vector3 From
    {
      [Token(Token = "0x6001D7B"), Address(RVA = "0x29FA11C", Offset = "0x29FA11C", VA = "0x29FA11C")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6001D7C"), Address(RVA = "0x29FA128", Offset = "0x29FA128", VA = "0x29FA128")] set
      {
      }
    }

    [Token(Token = "0x170003D6")]
    public Vector3 To
    {
      [Token(Token = "0x6001D7D"), Address(RVA = "0x29FA134", Offset = "0x29FA134", VA = "0x29FA134")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6001D7E"), Address(RVA = "0x29FA140", Offset = "0x29FA140", VA = "0x29FA140")] set
      {
      }
    }

    [Token(Token = "0x170003D7")]
    public Transform CachedTransform
    {
      [Token(Token = "0x6001D7F"), Address(RVA = "0x29FA14C", Offset = "0x29FA14C", VA = "0x29FA14C")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170003D8")]
    public Vector3 Value
    {
      [Token(Token = "0x6001D80"), Address(RVA = "0x29FA1CC", Offset = "0x29FA1CC", VA = "0x29FA1CC")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6001D81"), Address(RVA = "0x29FA1E8", Offset = "0x29FA1E8", VA = "0x29FA1E8")] set
      {
      }
    }

    [Token(Token = "0x6001D82")]
    [Address(RVA = "0x29FA22C", Offset = "0x29FA22C", VA = "0x29FA22C", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D83")]
    [Address(RVA = "0x29FA264", Offset = "0x29FA264", VA = "0x29FA264")]
    public TweenScale()
    {
    }
  }
}
