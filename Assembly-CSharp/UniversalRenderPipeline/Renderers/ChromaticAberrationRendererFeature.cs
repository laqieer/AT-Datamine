// Decompiled with JetBrains decompiler
// Type: UniversalRenderPipeline.Renderers.ChromaticAberrationRendererFeature
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
  [Token(Token = "0x20003BA")]
  public class ChromaticAberrationRendererFeature : ScriptableRendererFeature
  {
    [Token(Token = "0x400161B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Material material;
    [Token(Token = "0x400161C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RenderPassEvent renderPassEvent;
    [Token(Token = "0x400161D")]
    [FieldOffset(Offset = "0x30")]
    private ChromaticAberrationRendererFeature.CustomRenderPass renderPass;

    [Token(Token = "0x60015AB")]
    [Address(RVA = "0x2483574", Offset = "0x2483574", VA = "0x2483574", Slot = "5")]
    public override void Create()
    {
    }

    [Token(Token = "0x60015AC")]
    [Address(RVA = "0x24836BC", Offset = "0x24836BC", VA = "0x24836BC", Slot = "7")]
    public override void AddRenderPasses(
      ScriptableRenderer renderer,
      ref RenderingData renderingData)
    {
    }

    [Token(Token = "0x60015AD")]
    [Address(RVA = "0x2483780", Offset = "0x2483780", VA = "0x2483780")]
    public ChromaticAberrationRendererFeature()
    {
    }

    [Token(Token = "0x20003BB")]
    private class CustomRenderPass : ScriptableRenderPass
    {
      [Token(Token = "0x400161E")]
      private const string Name = "[Custom Pass] ChromaticAberrationRendererFeature";
      [Token(Token = "0x400161F")]
      [FieldOffset(Offset = "0xD8")]
      private Material material;
      [Token(Token = "0x4001620")]
      [FieldOffset(Offset = "0xE0")]
      private float size;
      [Token(Token = "0x4001621")]
      [FieldOffset(Offset = "0xE4")]
      private int offsetID;
      [Token(Token = "0x4001622")]
      [FieldOffset(Offset = "0xE8")]
      private int screenCopyTextureID;
      [Token(Token = "0x4001623")]
      [FieldOffset(Offset = "0xF0")]
      private RenderTargetIdentifier screenCopyTexture;
      [Token(Token = "0x4001624")]
      [FieldOffset(Offset = "0x118")]
      private ChromaticAberrationVolume chromaticAberrationVolume;

      [Token(Token = "0x60015AE")]
      [Address(RVA = "0x24835E8", Offset = "0x24835E8", VA = "0x24835E8")]
      public CustomRenderPass(Material material, RenderPassEvent passEvent)
      {
      }

      [Token(Token = "0x60015AF")]
      [Address(RVA = "0x24836F8", Offset = "0x24836F8", VA = "0x24836F8")]
      public void Setup()
      {
      }

      [Token(Token = "0x60015B0")]
      [Address(RVA = "0x2483790", Offset = "0x2483790", VA = "0x2483790", Slot = "9")]
      public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
      {
      }

      [Token(Token = "0x60015B1")]
      [Address(RVA = "0x24838B0", Offset = "0x24838B0", VA = "0x24838B0")]
      private void Render(CommandBuffer cmd, ref RenderingData renderingData)
      {
      }
    }
  }
}
