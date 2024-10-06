// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.AmbientOcclusionComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F49")]
  public sealed class AmbientOcclusionComponent : 
    PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
  {
    [Token(Token = "0x4011514")]
    private const string k_BlitShaderString = "Hidden/Post FX/Blit";
    [Token(Token = "0x4011515")]
    private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion";
    [Token(Token = "0x4011516")]
    [FieldOffset(Offset = "0x20")]
    private readonly RenderTargetIdentifier[] m_MRT;

    [Token(Token = "0x17005247")]
    private AmbientOcclusionComponent.OcclusionSource occlusionSource
    {
      [Token(Token = "0x60198BB"), Address(RVA = "0x3748F60", Offset = "0x3748F60", VA = "0x3748F60")] get
      {
        return new AmbientOcclusionComponent.OcclusionSource();
      }
    }

    [Token(Token = "0x17005248")]
    private bool ambientOnlySupported
    {
      [Token(Token = "0x60198BC"), Address(RVA = "0x3749004", Offset = "0x3749004", VA = "0x3749004")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005249")]
    public override bool active
    {
      [Token(Token = "0x60198BD"), Address(RVA = "0x3749094", Offset = "0x3749094", VA = "0x3749094", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60198BE")]
    [Address(RVA = "0x3749108", Offset = "0x3749108", VA = "0x3749108", Slot = "4")]
    public override DepthTextureMode GetCameraFlags() => new DepthTextureMode();

    [Token(Token = "0x60198BF")]
    [Address(RVA = "0x3749140", Offset = "0x3749140", VA = "0x3749140", Slot = "11")]
    public override string GetName() => (string) null;

    [Token(Token = "0x60198C0")]
    [Address(RVA = "0x3749180", Offset = "0x3749180", VA = "0x3749180", Slot = "10")]
    public override CameraEvent GetCameraEvent() => new CameraEvent();

    [Token(Token = "0x60198C1")]
    [Address(RVA = "0x37491D8", Offset = "0x37491D8", VA = "0x37491D8", Slot = "12")]
    public override void PopulateCommandBuffer(CommandBuffer cb)
    {
    }

    [Token(Token = "0x60198C2")]
    [Address(RVA = "0x3749B9C", Offset = "0x3749B9C", VA = "0x3749B9C")]
    public AmbientOcclusionComponent()
    {
    }

    [Token(Token = "0x2003F4A")]
    private static class Uniforms
    {
      [Token(Token = "0x4011517")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _Intensity;
      [Token(Token = "0x4011518")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _Radius;
      [Token(Token = "0x4011519")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _FogParams;
      [Token(Token = "0x401151A")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _Downsample;
      [Token(Token = "0x401151B")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _SampleCount;
      [Token(Token = "0x401151C")]
      [FieldOffset(Offset = "0x14")]
      internal static readonly int _OcclusionTexture1;
      [Token(Token = "0x401151D")]
      [FieldOffset(Offset = "0x18")]
      internal static readonly int _OcclusionTexture2;
      [Token(Token = "0x401151E")]
      [FieldOffset(Offset = "0x1C")]
      internal static readonly int _OcclusionTexture;
      [Token(Token = "0x401151F")]
      [FieldOffset(Offset = "0x20")]
      internal static readonly int _MainTex;
      [Token(Token = "0x4011520")]
      [FieldOffset(Offset = "0x24")]
      internal static readonly int _TempRT;

      [Token(Token = "0x60198C3")]
      [Address(RVA = "0x342E264", Offset = "0x342E264", VA = "0x342E264")]
      static Uniforms()
      {
      }
    }

    [Token(Token = "0x2003F4B")]
    private enum OcclusionSource
    {
      [Token(Token = "0x4011522")] DepthTexture,
      [Token(Token = "0x4011523")] DepthNormalsTexture,
      [Token(Token = "0x4011524")] GBuffer,
    }
  }
}
