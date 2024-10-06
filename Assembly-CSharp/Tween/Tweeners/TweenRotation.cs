// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenRotation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000518")]
  [AddComponentMenu("Tween/Tweeners/Tween Rotation")]
  public class TweenRotation : UITweener
  {
    [Token(Token = "0x4001B21")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Vector3 from;
    [Token(Token = "0x4001B22")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Vector3 to;
    [Token(Token = "0x4001B23")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private bool quaternionLerp;
    [Token(Token = "0x4001B24")]
    [FieldOffset(Offset = "0x88")]
    private Transform cachedTransform;

    [Token(Token = "0x170003D0")]
    public Vector3 From
    {
      [Token(Token = "0x6001D70"), Address(RVA = "0x29F9EC4", Offset = "0x29F9EC4", VA = "0x29F9EC4")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6001D71"), Address(RVA = "0x29F9ED0", Offset = "0x29F9ED0", VA = "0x29F9ED0")] set
      {
      }
    }

    [Token(Token = "0x170003D1")]
    public Vector3 To
    {
      [Token(Token = "0x6001D72"), Address(RVA = "0x29F9EDC", Offset = "0x29F9EDC", VA = "0x29F9EDC")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6001D73"), Address(RVA = "0x29F9EE8", Offset = "0x29F9EE8", VA = "0x29F9EE8")] set
      {
      }
    }

    [Token(Token = "0x170003D2")]
    public bool QuaternionLerp
    {
      [Token(Token = "0x6001D74"), Address(RVA = "0x29F9EF4", Offset = "0x29F9EF4", VA = "0x29F9EF4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001D75"), Address(RVA = "0x29F9EFC", Offset = "0x29F9EFC", VA = "0x29F9EFC")] set
      {
      }
    }

    [Token(Token = "0x170003D3")]
    public Transform CachedTransform
    {
      [Token(Token = "0x6001D76"), Address(RVA = "0x29F9F08", Offset = "0x29F9F08", VA = "0x29F9F08")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170003D4")]
    public Quaternion Value
    {
      [Token(Token = "0x6001D77"), Address(RVA = "0x29F9F88", Offset = "0x29F9F88", VA = "0x29F9F88")] get
      {
        return new Quaternion();
      }
      [Token(Token = "0x6001D78"), Address(RVA = "0x29F9FA4", Offset = "0x29F9FA4", VA = "0x29F9FA4")] set
      {
      }
    }

    [Token(Token = "0x6001D79")]
    [Address(RVA = "0x29F9FF0", Offset = "0x29F9FF0", VA = "0x29F9FF0", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D7A")]
    [Address(RVA = "0x29FA114", Offset = "0x29FA114", VA = "0x29FA114")]
    public TweenRotation()
    {
    }
  }
}
