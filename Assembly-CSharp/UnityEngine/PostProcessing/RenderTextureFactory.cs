// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.RenderTextureFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FB7")]
  public sealed class RenderTextureFactory : IDisposable
  {
    [Token(Token = "0x4011711")]
    [FieldOffset(Offset = "0x10")]
    private HashSet<RenderTexture> m_TemporaryRTs;

    [Token(Token = "0x6019A00")]
    [Address(RVA = "0x3783850", Offset = "0x3783850", VA = "0x3783850")]
    public RenderTextureFactory()
    {
    }

    [Token(Token = "0x6019A01")]
    [Address(RVA = "0x37838D0", Offset = "0x37838D0", VA = "0x37838D0")]
    public RenderTexture Get(RenderTexture baseRenderTexture) => (RenderTexture) null;

    [Token(Token = "0x6019A02")]
    [Address(RVA = "0x37839E8", Offset = "0x37839E8", VA = "0x37839E8")]
    public RenderTexture Get(
      int width,
      int height,
      int depthBuffer = 0,
      RenderTextureFormat format = RenderTextureFormat.ARGBHalf,
      RenderTextureReadWrite rw = RenderTextureReadWrite.Default,
      FilterMode filterMode = FilterMode.Bilinear,
      TextureWrapMode wrapMode = TextureWrapMode.Clamp,
      string name = "FactoryTempTexture")
    {
      return (RenderTexture) null;
    }

    [Token(Token = "0x6019A03")]
    [Address(RVA = "0x3783ACC", Offset = "0x3783ACC", VA = "0x3783ACC")]
    public void Release(RenderTexture rt)
    {
    }

    [Token(Token = "0x6019A04")]
    [Address(RVA = "0x3783C08", Offset = "0x3783C08", VA = "0x3783C08")]
    public void ReleaseAll()
    {
    }

    [Token(Token = "0x6019A05")]
    [Address(RVA = "0x3783CD4", Offset = "0x3783CD4", VA = "0x3783CD4", Slot = "4")]
    public void Dispose()
    {
    }
  }
}
