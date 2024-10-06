// Decompiled with JetBrains decompiler
// Type: RadialBlurPostProcessRenderFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x2000195")]
public class RadialBlurPostProcessRenderFeature : ScriptableRendererFeature
{
  [Token(Token = "0x4000A42")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Shader shader;
  [Token(Token = "0x4000A43")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private bool applyToSceneView;
  [Token(Token = "0x4000A44")]
  [FieldOffset(Offset = "0x30")]
  private RadialBlurPostProcessRenderPass postProcessPass;

  [Token(Token = "0x6000ACE")]
  [Address(RVA = "0x4BBB630", Offset = "0x4BBB630", VA = "0x4BBB630", Slot = "5")]
  public override void Create()
  {
  }

  [Token(Token = "0x6000ACF")]
  [Address(RVA = "0x4BBB844", Offset = "0x4BBB844", VA = "0x4BBB844", Slot = "7")]
  public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
  {
  }

  [Token(Token = "0x6000AD0")]
  [Address(RVA = "0x4BBB998", Offset = "0x4BBB998", VA = "0x4BBB998")]
  public RadialBlurPostProcessRenderFeature()
  {
  }
}
