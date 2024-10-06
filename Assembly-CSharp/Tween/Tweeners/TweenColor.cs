// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenColor
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
  [Token(Token = "0x200050A")]
  [AddComponentMenu("Tween/Tweeners/Tween Color")]
  public class TweenColor : UITweener
  {
    [Token(Token = "0x4001AF4")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Color from;
    [Token(Token = "0x4001AF5")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Color to;
    [Token(Token = "0x4001AF6")]
    [FieldOffset(Offset = "0x88")]
    private bool cached;
    [Token(Token = "0x4001AF7")]
    [FieldOffset(Offset = "0x90")]
    private Graphic widget;
    [Token(Token = "0x4001AF8")]
    [FieldOffset(Offset = "0x98")]
    private Material material;
    [Token(Token = "0x4001AF9")]
    [FieldOffset(Offset = "0xA0")]
    private Light targetlight;
    [Token(Token = "0x4001AFA")]
    [FieldOffset(Offset = "0xA8")]
    private SpriteRenderer spriteRenderer;

    [Token(Token = "0x170003AF")]
    public Color From
    {
      [Token(Token = "0x6001D0E"), Address(RVA = "0x29F80C4", Offset = "0x29F80C4", VA = "0x29F80C4")] get
      {
        return new Color();
      }
      [Token(Token = "0x6001D0F"), Address(RVA = "0x29F80D0", Offset = "0x29F80D0", VA = "0x29F80D0")] set
      {
      }
    }

    [Token(Token = "0x170003B0")]
    public Color To
    {
      [Token(Token = "0x6001D10"), Address(RVA = "0x29F80DC", Offset = "0x29F80DC", VA = "0x29F80DC")] get
      {
        return new Color();
      }
      [Token(Token = "0x6001D11"), Address(RVA = "0x29F80E8", Offset = "0x29F80E8", VA = "0x29F80E8")] set
      {
      }
    }

    [Token(Token = "0x6001D12")]
    [Address(RVA = "0x29F80F4", Offset = "0x29F80F4", VA = "0x29F80F4")]
    private void Cache()
    {
    }

    [Token(Token = "0x170003B1")]
    public Color Value
    {
      [Token(Token = "0x6001D13"), Address(RVA = "0x29F8268", Offset = "0x29F8268", VA = "0x29F8268")] get
      {
        return new Color();
      }
      [Token(Token = "0x6001D14"), Address(RVA = "0x29F8274", Offset = "0x29F8274", VA = "0x29F8274")] set
      {
      }
    }

    [Token(Token = "0x6001D15")]
    [Address(RVA = "0x29F8280", Offset = "0x29F8280", VA = "0x29F8280", Slot = "9")]
    protected virtual Color GetValidColor() => new Color();

    [Token(Token = "0x6001D16")]
    [Address(RVA = "0x29F83DC", Offset = "0x29F83DC", VA = "0x29F83DC", Slot = "10")]
    protected virtual void SetColor(Color value)
    {
    }

    [Token(Token = "0x6001D17")]
    [Address(RVA = "0x29F85E0", Offset = "0x29F85E0", VA = "0x29F85E0", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D18")]
    [Address(RVA = "0x29F8620", Offset = "0x29F8620", VA = "0x29F8620")]
    public TweenColor()
    {
    }
  }
}
