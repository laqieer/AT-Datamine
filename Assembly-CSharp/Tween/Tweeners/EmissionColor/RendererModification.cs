// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.EmissionColor.RendererModification
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners.EmissionColor
{
  [Token(Token = "0x2000521")]
  public abstract class RendererModification : ITweenEmissionColor
  {
    [Token(Token = "0x170003F0")]
    public virtual bool IsValid
    {
      [Token(Token = "0x6001DC1"), Address(RVA = "0x29FB358", Offset = "0x29FB358", VA = "0x29FB358", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6001DC2")]
    [Address(RVA = "0x29FB360", Offset = "0x29FB360", VA = "0x29FB360", Slot = "6")]
    public virtual void OnEnable()
    {
    }

    [Token(Token = "0x6001DC3")]
    public abstract void SetColor(TweenEmissionColor entity, Color value);

    [Token(Token = "0x6001DC4")]
    [Address(RVA = "0x29FB364", Offset = "0x29FB364", VA = "0x29FB364")]
    protected RendererModification()
    {
    }
  }
}
