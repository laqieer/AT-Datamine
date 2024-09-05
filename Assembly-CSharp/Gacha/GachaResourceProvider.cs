// Decompiled with JetBrains decompiler
// Type: Gacha.GachaResourceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200151B")]
  internal class GachaResourceProvider : 
    IGachaResourceProvider,
    IGachaBGMovieProvider,
    IGachaBGTextureProvider,
    IGachaLogoTextureProvider,
    IGachaTopTextureProvider
  {
    [Token(Token = "0x40060FA")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, BGTextureResource> textureResources;
    [Token(Token = "0x40060FB")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, BGMovieResource> movieResources;

    [Token(Token = "0x6007769")]
    [Address(RVA = "0x44F19E0", Offset = "0x44F19E0", VA = "0x44F19E0", Slot = "5")]
    public void FindBGTextureResource(string url, Action<BGTextureResource> onFound)
    {
    }

    [Token(Token = "0x600776A")]
    [Address(RVA = "0x44F1B40", Offset = "0x44F1B40", VA = "0x44F1B40", Slot = "6")]
    public void FindLogoTextureResource(int gachaId, Action<BGTextureResource> onFound)
    {
    }

    [Token(Token = "0x600776B")]
    [Address(RVA = "0x44F1C48", Offset = "0x44F1C48", VA = "0x44F1C48", Slot = "7")]
    public void FindTopTextureResource(int gachaId, Action<BGTextureResource> onFound)
    {
    }

    [Token(Token = "0x600776C")]
    [Address(RVA = "0x44F1D50", Offset = "0x44F1D50", VA = "0x44F1D50", Slot = "8")]
    public void FindStoryBGTextureResource(int gachaId, Action<BGTextureResource> onFound)
    {
    }

    [Token(Token = "0x600776D")]
    [Address(RVA = "0x44ECE78", Offset = "0x44ECE78", VA = "0x44ECE78")]
    public void FindGachaBannerTextureResource(int gachaId, Action<BGTextureResource> onFound)
    {
    }

    [Token(Token = "0x600776E")]
    [Address(RVA = "0x44F1E58", Offset = "0x44F1E58", VA = "0x44F1E58", Slot = "4")]
    public void FindBGMovieResource(string url, Action<BGMovieResource> onFound)
    {
    }

    [Token(Token = "0x600776F")]
    [Address(RVA = "0x44F19E4", Offset = "0x44F19E4", VA = "0x44F19E4")]
    private void FindTextureResourceImple(string url, Action<BGTextureResource> onFound)
    {
    }

    [Token(Token = "0x6007770")]
    [Address(RVA = "0x44F1FEC", Offset = "0x44F1FEC", VA = "0x44F1FEC")]
    public GachaResourceProvider()
    {
    }
  }
}
