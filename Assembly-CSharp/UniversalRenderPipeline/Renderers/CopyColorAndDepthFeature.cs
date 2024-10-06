// Decompiled with JetBrains decompiler
// Type: UniversalRenderPipeline.Renderers.CopyColorAndDepthFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

#nullable disable
namespace UniversalRenderPipeline.Renderers
{
  [Token(Token = "0x20003BC")]
  public class CopyColorAndDepthFeature : ScriptableRendererFeature
  {
    [Token(Token = "0x4001625")]
    [FieldOffset(Offset = "0x20")]
    private CopyColorAndDepthFeature.CustomRenderPass customRenderPass;

    [Token(Token = "0x60015B2")]
    [Address(RVA = "0x24839F8", Offset = "0x24839F8", VA = "0x24839F8", Slot = "5")]
    public override void Create()
    {
    }

    [Token(Token = "0x60015B3")]
    [Address(RVA = "0x2483A60", Offset = "0x2483A60", VA = "0x2483A60", Slot = "7")]
    public override void AddRenderPasses(
      ScriptableRenderer renderer,
      ref RenderingData renderingData)
    {
    }

    [Token(Token = "0x60015B4")]
    [Address(RVA = "0x2483AC0", Offset = "0x2483AC0", VA = "0x2483AC0")]
    public CopyColorAndDepthFeature()
    {
    }

    [Token(Token = "0x20003BD")]
    private class CustomRenderPass : ScriptableRenderPass
    {
      [Token(Token = "0x60015B5")]
      [Address(RVA = "0x2483AC8", Offset = "0x2483AC8", VA = "0x2483AC8", Slot = "9")]
      public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
      {
      }

      [Token(Token = "0x60015B6")]
      [Address(RVA = "0x2483AAC", Offset = "0x2483AAC", VA = "0x2483AAC")]
      public void Setup()
      {
      }

      [Token(Token = "0x60015B7")]
      [Address(RVA = "0x2483A58", Offset = "0x2483A58", VA = "0x2483A58")]
      public CustomRenderPass()
      {
      }
    }
  }
}
