// Decompiled with JetBrains decompiler
// Type: RadialBlurPostProcessRenderPass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x2000196")]
public class RadialBlurPostProcessRenderPass : ScriptableRenderPass
{
  [Token(Token = "0x4000A45")]
  private const string PROFILING_SAMPLER_NAME = "Radial Blur Post Process";
  [Token(Token = "0x4000A46")]
  [FieldOffset(Offset = "0xD8")]
  private readonly ProfilingSampler profilingSampler;
  [Token(Token = "0x4000A47")]
  private const string RENDER_PASS_NAME = "RadialBlurPostProcessVolume";
  [Token(Token = "0x4000A48")]
  [FieldOffset(Offset = "0xE0")]
  private readonly Material material;
  [Token(Token = "0x4000A49")]
  [FieldOffset(Offset = "0xE8")]
  private readonly int centerPropertyId;
  [Token(Token = "0x4000A4A")]
  [FieldOffset(Offset = "0xEC")]
  private readonly int radiusPropertyId;
  [Token(Token = "0x4000A4B")]
  [FieldOffset(Offset = "0xF0")]
  private readonly int iterationCountPropertyId;
  [Token(Token = "0x4000A4C")]
  [FieldOffset(Offset = "0xF4")]
  private readonly int mainTexPropertyId;
  [Token(Token = "0x4000A4D")]
  [FieldOffset(Offset = "0xF8")]
  private RenderTargetHandle tempRenderTargetHandle;
  [Token(Token = "0x4000A4E")]
  [FieldOffset(Offset = "0x128")]
  private RenderTargetIdentifier sourceIdentifier;
  [Token(Token = "0x4000A4F")]
  [FieldOffset(Offset = "0x150")]
  private RadialBlurPostProcessVolume volume;

  [Token(Token = "0x6000AD1")]
  [Address(RVA = "0x4BBB694", Offset = "0x4BBB694", VA = "0x4BBB694")]
  public RadialBlurPostProcessRenderPass(Shader shader)
  {
  }

  [Token(Token = "0x6000AD2")]
  [Address(RVA = "0x4BBB8E8", Offset = "0x4BBB8E8", VA = "0x4BBB8E8")]
  public void Setup(RenderTargetIdentifier sourceIdentifier, RenderPassEvent renderEvent)
  {
  }

  [Token(Token = "0x6000AD3")]
  [Address(RVA = "0x4BBB9A8", Offset = "0x4BBB9A8", VA = "0x4BBB9A8", Slot = "9")]
  public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
  {
  }
}
