// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.EmissionColor.RendererGroupModification
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Graphics.Utility;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners.EmissionColor
{
  [Token(Token = "0x2000523")]
  public class RendererGroupModification : RendererModification
  {
    [Token(Token = "0x4001B47")]
    [FieldOffset(Offset = "0x18")]
    private RendererGroup rendererGroup;

    [Token(Token = "0x170003F3")]
    public override bool IsValid
    {
      [Token(Token = "0x6001DCB"), Address(RVA = "0x29FB4E4", Offset = "0x29FB4E4", VA = "0x29FB4E4", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6001DCC")]
    [Address(RVA = "0x29FB544", Offset = "0x29FB544", VA = "0x29FB544")]
    public RendererGroupModification(RendererGroup rendererGroup)
    {
    }

    [Token(Token = "0x6001DCD")]
    [Address(RVA = "0x29F8790", Offset = "0x29F8790", VA = "0x29F8790")]
    public RendererGroupModification(MonoBehaviour monoBehaviour)
    {
    }

    [Token(Token = "0x6001DCE")]
    [Address(RVA = "0x29FB57C", Offset = "0x29FB57C", VA = "0x29FB57C", Slot = "7")]
    public override void SetColor(TweenEmissionColor entity, Color value)
    {
    }

    [Token(Token = "0x6001DCF")]
    [Address(RVA = "0x29FB578", Offset = "0x29FB578", VA = "0x29FB578")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6001DD0")]
    [Address(RVA = "0x29FB5A8", Offset = "0x29FB5A8", VA = "0x29FB5A8")]
    private void EnableEmissionColor()
    {
    }
  }
}
