// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenFOV
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x200050F")]
  [RequireComponent(typeof (Camera))]
  [AddComponentMenu("Tween/Tweeners/Tween Field of View")]
  public class TweenFOV : UITweener
  {
    [Token(Token = "0x4001B07")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private float from;
    [Token(Token = "0x4001B08")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private float to;
    [Token(Token = "0x4001B09")]
    [FieldOffset(Offset = "0x70")]
    private Camera targetCamera;

    [Token(Token = "0x170003B6")]
    public float From
    {
      [Token(Token = "0x6001D2E"), Address(RVA = "0x29F8E34", Offset = "0x29F8E34", VA = "0x29F8E34")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D2F"), Address(RVA = "0x29F8E3C", Offset = "0x29F8E3C", VA = "0x29F8E3C")] set
      {
      }
    }

    [Token(Token = "0x170003B7")]
    public float To
    {
      [Token(Token = "0x6001D30"), Address(RVA = "0x29F8E44", Offset = "0x29F8E44", VA = "0x29F8E44")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D31"), Address(RVA = "0x29F8E4C", Offset = "0x29F8E4C", VA = "0x29F8E4C")] set
      {
      }
    }

    [Token(Token = "0x170003B8")]
    public Camera CachedCamera
    {
      [Token(Token = "0x6001D32"), Address(RVA = "0x29F8E54", Offset = "0x29F8E54", VA = "0x29F8E54")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x170003B9")]
    public float Value
    {
      [Token(Token = "0x6001D33"), Address(RVA = "0x29F8EE8", Offset = "0x29F8EE8", VA = "0x29F8EE8")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D34"), Address(RVA = "0x29F8F04", Offset = "0x29F8F04", VA = "0x29F8F04")] set
      {
      }
    }

    [Token(Token = "0x6001D35")]
    [Address(RVA = "0x29F8F30", Offset = "0x29F8F30", VA = "0x29F8F30", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D36")]
    [Address(RVA = "0x29F8F4C", Offset = "0x29F8F4C", VA = "0x29F8F4C")]
    public TweenFOV()
    {
    }
  }
}
