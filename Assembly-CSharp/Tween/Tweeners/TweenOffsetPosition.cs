// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenOffsetPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000511")]
  [AddComponentMenu("Tween/Tweeners/Tween Offset Position")]
  public class TweenOffsetPosition : TweenPosition
  {
    [Token(Token = "0x4001B0D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private bool fixedPosition;
    [Token(Token = "0x4001B0E")]
    [FieldOffset(Offset = "0x99")]
    private bool isInitialize;

    [Token(Token = "0x170003BE")]
    public bool FixedPosition
    {
      [Token(Token = "0x6001D40"), Address(RVA = "0x29F91B0", Offset = "0x29F91B0", VA = "0x29F91B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001D41"), Address(RVA = "0x29F91B8", Offset = "0x29F91B8", VA = "0x29F91B8")] set
      {
      }
    }

    [Token(Token = "0x6001D42")]
    [Address(RVA = "0x29F91C4", Offset = "0x29F91C4", VA = "0x29F91C4", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001D43")]
    [Address(RVA = "0x29F91C8", Offset = "0x29F91C8", VA = "0x29F91C8", Slot = "5")]
    protected override void Startup()
    {
    }

    [Token(Token = "0x6001D44")]
    [Address(RVA = "0x29F92D4", Offset = "0x29F92D4", VA = "0x29F92D4", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D45")]
    [Address(RVA = "0x29F9494", Offset = "0x29F9494", VA = "0x29F9494")]
    public TweenOffsetPosition()
    {
    }
  }
}
