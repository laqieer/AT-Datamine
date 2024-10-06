// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x200051C")]
  [AddComponentMenu("Tween/Tweeners/Tween Transform")]
  public class TweenTransform : UITweener
  {
    [Token(Token = "0x4001B31")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform from;
    [Token(Token = "0x4001B32")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Transform to;
    [Token(Token = "0x4001B33")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private bool parentWhenFinished;
    [Token(Token = "0x4001B34")]
    [FieldOffset(Offset = "0x80")]
    private Transform cachedTransform;
    [Token(Token = "0x4001B35")]
    [FieldOffset(Offset = "0x88")]
    private Vector3 position;
    [Token(Token = "0x4001B36")]
    [FieldOffset(Offset = "0x94")]
    private Quaternion rotation;
    [Token(Token = "0x4001B37")]
    [FieldOffset(Offset = "0xA4")]
    private Vector3 scale;

    [Token(Token = "0x170003E0")]
    public Transform From
    {
      [Token(Token = "0x6001D98"), Address(RVA = "0x29FA7BC", Offset = "0x29FA7BC", VA = "0x29FA7BC")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6001D99"), Address(RVA = "0x29FA7C4", Offset = "0x29FA7C4", VA = "0x29FA7C4")] set
      {
      }
    }

    [Token(Token = "0x170003E1")]
    public Transform To
    {
      [Token(Token = "0x6001D9A"), Address(RVA = "0x29FA7CC", Offset = "0x29FA7CC", VA = "0x29FA7CC")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6001D9B"), Address(RVA = "0x29FA7D4", Offset = "0x29FA7D4", VA = "0x29FA7D4")] set
      {
      }
    }

    [Token(Token = "0x170003E2")]
    public bool ParentWhenFinished
    {
      [Token(Token = "0x6001D9C"), Address(RVA = "0x29FA7DC", Offset = "0x29FA7DC", VA = "0x29FA7DC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001D9D"), Address(RVA = "0x29FA7E4", Offset = "0x29FA7E4", VA = "0x29FA7E4")] set
      {
      }
    }

    [Token(Token = "0x6001D9E")]
    [Address(RVA = "0x29FA7F0", Offset = "0x29FA7F0", VA = "0x29FA7F0", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D9F")]
    [Address(RVA = "0x29FAB94", Offset = "0x29FAB94", VA = "0x29FAB94")]
    public TweenTransform()
    {
    }
  }
}
