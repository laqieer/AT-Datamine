// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenEmissionColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using Tween.Tweeners.EmissionColor;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x200050B")]
  [AddComponentMenu("Tween/Tweeners/Tween Emission Color")]
  public class TweenEmissionColor : TweenColor
  {
    [Token(Token = "0x4001AFB")]
    [FieldOffset(Offset = "0xB0")]
    private MeshRendererModification meshRendererModification;
    [Token(Token = "0x4001AFC")]
    [FieldOffset(Offset = "0xB8")]
    private RendererGroupModification rendererGroupModification;
    [Token(Token = "0x4001AFD")]
    [FieldOffset(Offset = "0xC0")]
    private List<RendererModification> validRendererModifications;

    [Token(Token = "0x170003B2")]
    public int EmissionPropertyID
    {
      [Token(Token = "0x6001D19"), Address(RVA = "0x29F8634", Offset = "0x29F8634", VA = "0x29F8634")] get
      {
        return new int();
      }
      [Token(Token = "0x6001D1A"), Address(RVA = "0x29F863C", Offset = "0x29F863C", VA = "0x29F863C")] private set
      {
      }
    }

    [Token(Token = "0x6001D1B")]
    [Address(RVA = "0x29F8644", Offset = "0x29F8644", VA = "0x29F8644", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001D1C")]
    [Address(RVA = "0x29F884C", Offset = "0x29F884C", VA = "0x29F884C")]
    private void Resister(RendererModification rendererModification)
    {
    }

    [Token(Token = "0x6001D1D")]
    [Address(RVA = "0x29F890C", Offset = "0x29F890C", VA = "0x29F890C", Slot = "7")]
    protected override void OnEnableMonoBehaviour()
    {
    }

    [Token(Token = "0x6001D1E")]
    [Address(RVA = "0x29F8A0C", Offset = "0x29F8A0C", VA = "0x29F8A0C", Slot = "10")]
    protected override void SetColor(Color value)
    {
    }

    [Token(Token = "0x6001D1F")]
    [Address(RVA = "0x29F8B0C", Offset = "0x29F8B0C", VA = "0x29F8B0C")]
    public TweenEmissionColor()
    {
    }
  }
}
