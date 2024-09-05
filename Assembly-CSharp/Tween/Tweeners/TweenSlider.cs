// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenSlider
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
  [Token(Token = "0x200051B")]
  [AddComponentMenu("Tween/Tweeners/Tween Slider")]
  [RequireComponent(typeof (Slider))]
  public class TweenSlider : UITweener
  {
    [Token(Token = "0x4001B2D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float from;
    [Token(Token = "0x4001B2E")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float to;
    [Token(Token = "0x4001B2F")]
    [FieldOffset(Offset = "0x70")]
    private bool cached;
    [Token(Token = "0x4001B30")]
    [FieldOffset(Offset = "0x78")]
    private Slider slider;

    [Token(Token = "0x170003DD")]
    public float From
    {
      [Token(Token = "0x6001D8F"), Address(RVA = "0x29FA5BC", Offset = "0x29FA5BC", VA = "0x29FA5BC")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D90"), Address(RVA = "0x29FA5C4", Offset = "0x29FA5C4", VA = "0x29FA5C4")] set
      {
      }
    }

    [Token(Token = "0x170003DE")]
    public float To
    {
      [Token(Token = "0x6001D91"), Address(RVA = "0x29FA5CC", Offset = "0x29FA5CC", VA = "0x29FA5CC")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D92"), Address(RVA = "0x29FA5D4", Offset = "0x29FA5D4", VA = "0x29FA5D4")] set
      {
      }
    }

    [Token(Token = "0x6001D93")]
    [Address(RVA = "0x29FA5DC", Offset = "0x29FA5DC", VA = "0x29FA5DC")]
    private void Cache()
    {
    }

    [Token(Token = "0x170003DF")]
    public float Value
    {
      [Token(Token = "0x6001D94"), Address(RVA = "0x29FA634", Offset = "0x29FA634", VA = "0x29FA634")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D95"), Address(RVA = "0x29FA6D4", Offset = "0x29FA6D4", VA = "0x29FA6D4")] set
      {
      }
    }

    [Token(Token = "0x6001D96")]
    [Address(RVA = "0x29FA784", Offset = "0x29FA784", VA = "0x29FA784", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D97")]
    [Address(RVA = "0x29FA7AC", Offset = "0x29FA7AC", VA = "0x29FA7AC")]
    public TweenSlider()
    {
    }
  }
}
