// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenOrthoSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000512")]
  [RequireComponent(typeof (Camera))]
  [AddComponentMenu("Tween/Tweeners/Tween Orthographic Size")]
  public class TweenOrthoSize : UITweener
  {
    [Token(Token = "0x4001B0F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private float from;
    [Token(Token = "0x4001B10")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private float to;
    [Token(Token = "0x4001B11")]
    [FieldOffset(Offset = "0x70")]
    private Camera targetCamera;

    [Token(Token = "0x170003BF")]
    public float From
    {
      [Token(Token = "0x6001D46"), Address(RVA = "0x29F94F8", Offset = "0x29F94F8", VA = "0x29F94F8")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D47"), Address(RVA = "0x29F9500", Offset = "0x29F9500", VA = "0x29F9500")] set
      {
      }
    }

    [Token(Token = "0x170003C0")]
    public float To
    {
      [Token(Token = "0x6001D48"), Address(RVA = "0x29F9508", Offset = "0x29F9508", VA = "0x29F9508")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D49"), Address(RVA = "0x29F9510", Offset = "0x29F9510", VA = "0x29F9510")] set
      {
      }
    }

    [Token(Token = "0x170003C1")]
    public Camera CachedCamera
    {
      [Token(Token = "0x6001D4A"), Address(RVA = "0x29F9518", Offset = "0x29F9518", VA = "0x29F9518")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x170003C2")]
    public float Value
    {
      [Token(Token = "0x6001D4B"), Address(RVA = "0x29F95AC", Offset = "0x29F95AC", VA = "0x29F95AC")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D4C"), Address(RVA = "0x29F95C8", Offset = "0x29F95C8", VA = "0x29F95C8")] set
      {
      }
    }

    [Token(Token = "0x6001D4D")]
    [Address(RVA = "0x29F95F4", Offset = "0x29F95F4", VA = "0x29F95F4", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D4E")]
    [Address(RVA = "0x29F9610", Offset = "0x29F9610", VA = "0x29F9610")]
    public TweenOrthoSize()
    {
    }
  }
}
