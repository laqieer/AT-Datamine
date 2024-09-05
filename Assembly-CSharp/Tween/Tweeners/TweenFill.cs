// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenFill
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
  [Token(Token = "0x200050E")]
  [RequireComponent(typeof (Image))]
  [AddComponentMenu("Tween/Tweeners/Tween Fill")]
  public class TweenFill : UITweener
  {
    [Token(Token = "0x4001B03")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float from;
    [Token(Token = "0x4001B04")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float to;
    [Token(Token = "0x4001B05")]
    [FieldOffset(Offset = "0x70")]
    private bool cached;
    [Token(Token = "0x4001B06")]
    [FieldOffset(Offset = "0x78")]
    private Image sprite;

    [Token(Token = "0x170003B3")]
    public float From
    {
      [Token(Token = "0x6001D25"), Address(RVA = "0x29F8C50", Offset = "0x29F8C50", VA = "0x29F8C50")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D26"), Address(RVA = "0x29F8C58", Offset = "0x29F8C58", VA = "0x29F8C58")] set
      {
      }
    }

    [Token(Token = "0x170003B4")]
    public float To
    {
      [Token(Token = "0x6001D27"), Address(RVA = "0x29F8C60", Offset = "0x29F8C60", VA = "0x29F8C60")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D28"), Address(RVA = "0x29F8C68", Offset = "0x29F8C68", VA = "0x29F8C68")] set
      {
      }
    }

    [Token(Token = "0x6001D29")]
    [Address(RVA = "0x29F8C70", Offset = "0x29F8C70", VA = "0x29F8C70")]
    private void Cache()
    {
    }

    [Token(Token = "0x170003B5")]
    public float Value
    {
      [Token(Token = "0x6001D2A"), Address(RVA = "0x29F8CC8", Offset = "0x29F8CC8", VA = "0x29F8CC8")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D2B"), Address(RVA = "0x29F8D54", Offset = "0x29F8D54", VA = "0x29F8D54")] set
      {
      }
    }

    [Token(Token = "0x6001D2C")]
    [Address(RVA = "0x29F8DFC", Offset = "0x29F8DFC", VA = "0x29F8DFC", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D2D")]
    [Address(RVA = "0x29F8E24", Offset = "0x29F8E24", VA = "0x29F8E24")]
    public TweenFill()
    {
    }
  }
}
