// Decompiled with JetBrains decompiler
// Type: UniversalRenderPipeline.Renderers.CapturedBlurFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UniversalRenderPipeline.Volumes;

#nullable disable
namespace UniversalRenderPipeline.Renderers
{
  [Token(Token = "0x20003B8")]
  public class CapturedBlurFeature : ScriptableRendererFeature
  {
    [Token(Token = "0x400160B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Material material;
    [Token(Token = "0x400160C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RenderPassEvent renderPassEvent;
    [Token(Token = "0x400160D")]
    [FieldOffset(Offset = "0x30")]
    private CapturedBlurFeature.CustomRenderPass renderPass;

    [Token(Token = "0x60015A0")]
    [Address(RVA = "0x2482D74", Offset = "0x2482D74", VA = "0x2482D74")]
    public void SetRenderTexture(RenderTexture renderTexture)
    {
    }

    [Token(Token = "0x60015A1")]
    [Address(RVA = "0x2482D90", Offset = "0x2482D90", VA = "0x2482D90", Slot = "5")]
    public override void Create()
    {
    }

    [Token(Token = "0x60015A2")]
    [Address(RVA = "0x2482F7C", Offset = "0x2482F7C", VA = "0x2482F7C", Slot = "7")]
    public override void AddRenderPasses(
      ScriptableRenderer renderer,
      ref RenderingData renderingData)
    {
    }

    [Token(Token = "0x60015A3")]
    [Address(RVA = "0x2483040", Offset = "0x2483040", VA = "0x2483040")]
    public CapturedBlurFeature()
    {
    }

    [Token(Token = "0x20003B9")]
    private class CustomRenderPass : ScriptableRenderPass
    {
      [Token(Token = "0x400160E")]
      private const string Name = "[Custom Pass] CapturedBlurFeature";
      [Token(Token = "0x400160F")]
      [FieldOffset(Offset = "0xD8")]
      private Material material;
      [Token(Token = "0x4001610")]
      [FieldOffset(Offset = "0xE0")]
      private float offset;
      [Token(Token = "0x4001611")]
      [FieldOffset(Offset = "0xE4")]
      private float blur;
      [Token(Token = "0x4001612")]
      [FieldOffset(Offset = "0xE8")]
      private int weightsID;
      [Token(Token = "0x4001613")]
      [FieldOffset(Offset = "0xEC")]
      private int offsetsID;
      [Token(Token = "0x4001614")]
      [FieldOffset(Offset = "0xF0")]
      private float[] weights;
      [Token(Token = "0x4001615")]
      [FieldOffset(Offset = "0xF8")]
      private int tempTextureID1;
      [Token(Token = "0x4001616")]
      [FieldOffset(Offset = "0xFC")]
      private int tempTextureID2;
      [Token(Token = "0x4001617")]
      [FieldOffset(Offset = "0x100")]
      private RenderTargetIdentifier tempTexture1;
      [Token(Token = "0x4001618")]
      [FieldOffset(Offset = "0x128")]
      private RenderTargetIdentifier tempTexture2;
      [Token(Token = "0x4001619")]
      [FieldOffset(Offset = "0x150")]
      private CapturedBlurVolume blurVolume;
      [Token(Token = "0x400161A")]
      [FieldOffset(Offset = "0x158")]
      private RenderTexture targetTexture;

      [Token(Token = "0x60015A4")]
      [Address(RVA = "0x2482E04", Offset = "0x2482E04", VA = "0x2482E04")]
      public CustomRenderPass(Material material, RenderPassEvent passEvent)
      {
      }

      [Token(Token = "0x60015A5")]
      [Address(RVA = "0x2483050", Offset = "0x2483050", VA = "0x2483050")]
      public void UpdateWeights()
      {
      }

      [Token(Token = "0x60015A6")]
      [Address(RVA = "0x2483134", Offset = "0x2483134", VA = "0x2483134")]
      public void SetParams(float offset, float blur)
      {
      }

      [Token(Token = "0x60015A7")]
      [Address(RVA = "0x2483154", Offset = "0x2483154", VA = "0x2483154")]
      public void SetRenderTexture(RenderTexture renderTexture)
      {
      }

      [Token(Token = "0x60015A8")]
      [Address(RVA = "0x2482FB8", Offset = "0x2482FB8", VA = "0x2482FB8")]
      public void Setup()
      {
      }

      [Token(Token = "0x60015A9")]
      [Address(RVA = "0x248315C", Offset = "0x248315C", VA = "0x248315C", Slot = "9")]
      public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
      {
      }

      [Token(Token = "0x60015AA")]
      [Address(RVA = "0x248334C", Offset = "0x248334C", VA = "0x248334C")]
      private void Render(CommandBuffer cmd, ref RenderingData renderingData)
      {
      }
    }
  }
}
