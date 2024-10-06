// Decompiled with JetBrains decompiler
// Type: StaqPostProcessPass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x200033A")]
public class StaqPostProcessPass : ScriptableRenderPass
{
  [Token(Token = "0x4001336")]
  [FieldOffset(Offset = "0x0")]
  private static readonly ProfilingSampler m_ProfilingRenderPostProcessing;
  [Token(Token = "0x4001337")]
  private const int k_MaxPyramidSize = 6;
  [Token(Token = "0x4001338")]
  [FieldOffset(Offset = "0xD8")]
  private readonly GraphicsFormat m_DefaultHDRFormat;
  [Token(Token = "0x4001339")]
  [FieldOffset(Offset = "0xDC")]
  private bool m_UseRGBM;
  [Token(Token = "0x400133A")]
  [FieldOffset(Offset = "0x8")]
  private static readonly float LimitTime;
  [Token(Token = "0x400133B")]
  [FieldOffset(Offset = "0xE0")]
  private StaqPostProcessPass.MaterialLibrary m_Materials;
  [Token(Token = "0x400133C")]
  [FieldOffset(Offset = "0xE8")]
  private StaqPostProcessData m_Data;
  [Token(Token = "0x400133D")]
  [FieldOffset(Offset = "0xF0")]
  private RenderTextureDescriptor m_Descriptor;
  [Token(Token = "0x400133E")]
  [FieldOffset(Offset = "0x128")]
  private RenderTargetIdentifier m_cameraColorTarget;
  [Token(Token = "0x400133F")]
  [FieldOffset(Offset = "0x150")]
  private RenderTargetHandle m_tempRenderTargetHandle;
  [Token(Token = "0x4001340")]
  [FieldOffset(Offset = "0x180")]
  private RenderTargetHandle m_afterPostProcessTexture;
  [Token(Token = "0x4001341")]
  [FieldOffset(Offset = "0x1B0")]
  private SkyCover m_SkyCover;
  [Token(Token = "0x4001342")]
  [FieldOffset(Offset = "0x1B8")]
  private ScreenGradation m_ScreenGradation;
  [Token(Token = "0x4001343")]
  [FieldOffset(Offset = "0x1C0")]
  private Refractive m_Refractive;
  [Token(Token = "0x4001344")]
  [FieldOffset(Offset = "0x1C8")]
  private Glitch m_Glitch;
  [Token(Token = "0x4001345")]
  [FieldOffset(Offset = "0x1D0")]
  private ColorFrame m_ColorFrame;
  [Token(Token = "0x4001346")]
  [FieldOffset(Offset = "0x1D8")]
  private CustomVignette m_CustomVignette;
  [Token(Token = "0x4001347")]
  [FieldOffset(Offset = "0x1E0")]
  private Diffusion m_Diffusion;
  [Token(Token = "0x4001348")]
  [FieldOffset(Offset = "0x1E8")]
  private LinearBlur m_LinearBlur;
  [Token(Token = "0x4001349")]
  [FieldOffset(Offset = "0x1F0")]
  private Glare m_Glare;
  [Token(Token = "0x400134A")]
  [FieldOffset(Offset = "0x1F8")]
  private float time;

  [Token(Token = "0x60012E4")]
  [Address(RVA = "0x285F960", Offset = "0x285F960", VA = "0x285F960")]
  public StaqPostProcessPass(StaqPostProcessData data, StaqPostprocessTiming timing)
  {
  }

  [Token(Token = "0x60012E5")]
  [Address(RVA = "0x285FC9C", Offset = "0x285FC9C", VA = "0x285FC9C")]
  public void Cleanup()
  {
  }

  [Token(Token = "0x60012E6")]
  [Address(RVA = "0x285FD40", Offset = "0x285FD40", VA = "0x285FD40")]
  public void Setup(RenderTargetIdentifier cameraColorTarget, ref RenderingData data)
  {
  }

  [Token(Token = "0x60012E7")]
  [Address(RVA = "0x285FE18", Offset = "0x285FE18", VA = "0x285FE18")]
  private new void Blit(
    CommandBuffer cmd,
    RenderTargetIdentifier source,
    RenderTargetIdentifier destination,
    Material material,
    int passIndex = 0)
  {
  }

  [Token(Token = "0x60012E8")]
  [Address(RVA = "0x285FF18", Offset = "0x285FF18", VA = "0x285FF18")]
  private BuiltinRenderTextureType BlitDstDiscardContent(
    CommandBuffer cmd,
    RenderTargetIdentifier rt)
  {
    return new BuiltinRenderTextureType();
  }

  [Token(Token = "0x60012E9")]
  [Address(RVA = "0x285FFA4", Offset = "0x285FFA4", VA = "0x285FFA4", Slot = "9")]
  public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
  {
  }

  [Token(Token = "0x60012EA")]
  [Address(RVA = "0x28645F4", Offset = "0x28645F4", VA = "0x28645F4")]
  private float Random2d(float seed1, float seed2) => new float();

  [Token(Token = "0x60012EB")]
  [Address(RVA = "0x2864634", Offset = "0x2864634", VA = "0x2864634")]
  private float RandomRange(float seed1, float seed2, float min, float max) => new float();

  [Token(Token = "0x60012EC")]
  [Address(RVA = "0x2864690", Offset = "0x2864690", VA = "0x2864690")]
  private float CalcDepthSliderProjected(Camera camera) => new float();

  [Token(Token = "0x60012ED")]
  [Address(RVA = "0x2860BD0", Offset = "0x2860BD0", VA = "0x2860BD0")]
  private void SetupSkyCover(
    CommandBuffer cmd,
    RenderTargetIdentifier source,
    Material material,
    RenderingData data,
    Material compositeMaterial)
  {
  }

  [Token(Token = "0x60012EE")]
  [Address(RVA = "0x2861470", Offset = "0x2861470", VA = "0x2861470")]
  private void SetupDiffusion(
    CommandBuffer cmd,
    RenderTargetIdentifier source,
    RenderTargetIdentifier destination,
    Material diffutionMat,
    RenderingData data,
    Material compositeMat)
  {
  }

  [Token(Token = "0x60012EF")]
  [Address(RVA = "0x28618E8", Offset = "0x28618E8", VA = "0x28618E8")]
  private void SetupScreenGradation(Material material)
  {
  }

  [Token(Token = "0x60012F0")]
  [Address(RVA = "0x2861D2C", Offset = "0x2861D2C", VA = "0x2861D2C")]
  private void SetupGlare(
    CommandBuffer cmd,
    RenderTargetIdentifier source,
    Material material,
    Material compositeMaterial)
  {
  }

  [Token(Token = "0x60012F1")]
  [Address(RVA = "0x2862798", Offset = "0x2862798", VA = "0x2862798")]
  private void SetupLinearBlur(CommandBuffer cmd, RenderTargetIdentifier source, Material material)
  {
  }

  [Token(Token = "0x60012F2")]
  [Address(RVA = "0x2862F44", Offset = "0x2862F44", VA = "0x2862F44")]
  private void SetupRefractive(Material material)
  {
  }

  [Token(Token = "0x60012F3")]
  [Address(RVA = "0x28635C0", Offset = "0x28635C0", VA = "0x28635C0")]
  private void SetupGlitch(Material material)
  {
  }

  [Token(Token = "0x60012F4")]
  [Address(RVA = "0x286405C", Offset = "0x286405C", VA = "0x286405C")]
  private void SetupColorFrame(Material material)
  {
  }

  [Token(Token = "0x60012F5")]
  [Address(RVA = "0x28642E4", Offset = "0x28642E4", VA = "0x28642E4")]
  private void SetupCustomVignette(Material material)
  {
  }

  [Token(Token = "0x60012F6")]
  [Address(RVA = "0x2864728", Offset = "0x2864728", VA = "0x2864728")]
  static StaqPostProcessPass()
  {
  }

  [Token(Token = "0x200033B")]
  private class MaterialLibrary
  {
    [Token(Token = "0x400134B")]
    [FieldOffset(Offset = "0x10")]
    public readonly Material skycover;
    [Token(Token = "0x400134C")]
    [FieldOffset(Offset = "0x18")]
    public readonly Material glare;
    [Token(Token = "0x400134D")]
    [FieldOffset(Offset = "0x20")]
    public readonly Material composite;
    [Token(Token = "0x400134E")]
    [FieldOffset(Offset = "0x28")]
    public readonly Material linearblur;
    [Token(Token = "0x400134F")]
    [FieldOffset(Offset = "0x30")]
    public readonly Material blit;
    [Token(Token = "0x4001350")]
    [FieldOffset(Offset = "0x38")]
    public readonly Material diffution;

    [Token(Token = "0x60012F7")]
    [Address(RVA = "0x285FBF8", Offset = "0x285FBF8", VA = "0x285FBF8")]
    public MaterialLibrary(StaqPostProcessData data)
    {
    }

    [Token(Token = "0x60012F8")]
    [Address(RVA = "0x28647C8", Offset = "0x28647C8", VA = "0x28647C8")]
    private Material Load(Shader shader) => (Material) null;

    [Token(Token = "0x60012F9")]
    [Address(RVA = "0x285FCB4", Offset = "0x285FCB4", VA = "0x285FCB4")]
    internal void Cleanup()
    {
    }
  }

  [Token(Token = "0x200033C")]
  private static class ShaderConstants
  {
    [Token(Token = "0x4001351")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int _SourceTex;
    [Token(Token = "0x4001352")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int _CameraTargetSize;
    [Token(Token = "0x4001353")]
    [FieldOffset(Offset = "0x8")]
    public static readonly int _SourceTexLowMip;
    [Token(Token = "0x4001354")]
    [FieldOffset(Offset = "0xC")]
    public static readonly int _MaskedSkyTex;
    [Token(Token = "0x4001355")]
    [FieldOffset(Offset = "0x10")]
    public static readonly int _DepthSlider;
    [Token(Token = "0x4001356")]
    [FieldOffset(Offset = "0x14")]
    public static readonly int _Scatter;
    [Token(Token = "0x4001357")]
    [FieldOffset(Offset = "0x18")]
    public static readonly int _Add;
    [Token(Token = "0x4001358")]
    [FieldOffset(Offset = "0x1C")]
    public static readonly int _Boost;
    [Token(Token = "0x4001359")]
    [FieldOffset(Offset = "0x20")]
    public static readonly int PrefilterdTexID;
    [Token(Token = "0x400135A")]
    [FieldOffset(Offset = "0x24")]
    public static readonly int VerticalGlareTexID;
    [Token(Token = "0x400135B")]
    [FieldOffset(Offset = "0x28")]
    public static readonly int HorizontalGlareTexID;
    [Token(Token = "0x400135C")]
    [FieldOffset(Offset = "0x2C")]
    public static readonly int PongTexID;
    [Token(Token = "0x400135D")]
    [FieldOffset(Offset = "0x30")]
    public static readonly int PingTexID;
    [Token(Token = "0x400135E")]
    [FieldOffset(Offset = "0x34")]
    public static readonly int _Params;
    [Token(Token = "0x400135F")]
    [FieldOffset(Offset = "0x38")]
    public static readonly int _GlareRGBM;
    [Token(Token = "0x4001360")]
    [FieldOffset(Offset = "0x3C")]
    public static readonly int _GlareOffset;
    [Token(Token = "0x4001361")]
    [FieldOffset(Offset = "0x40")]
    public static readonly int _VerticalGlareTex;
    [Token(Token = "0x4001362")]
    [FieldOffset(Offset = "0x44")]
    public static readonly int _HorizontalGlareTex;
    [Token(Token = "0x4001363")]
    [FieldOffset(Offset = "0x48")]
    public static readonly int _GlareIntencity;
    [Token(Token = "0x4001364")]
    [FieldOffset(Offset = "0x4C")]
    public static readonly int _Threshold;
    [Token(Token = "0x4001365")]
    [FieldOffset(Offset = "0x50")]
    public static readonly int _Intencity;
    [Token(Token = "0x4001366")]
    [FieldOffset(Offset = "0x54")]
    public static readonly int _GradationColA;
    [Token(Token = "0x4001367")]
    [FieldOffset(Offset = "0x58")]
    public static readonly int _GradationColB;
    [Token(Token = "0x4001368")]
    [FieldOffset(Offset = "0x5C")]
    public static readonly int _MatrixOffsetRotate;
    [Token(Token = "0x4001369")]
    [FieldOffset(Offset = "0x60")]
    public static readonly int _LinearBlurTexID;
    [Token(Token = "0x400136A")]
    [FieldOffset(Offset = "0x64")]
    public static readonly int _Velocity;
    [Token(Token = "0x400136B")]
    [FieldOffset(Offset = "0x68")]
    public static readonly int _Frequency;
    [Token(Token = "0x400136C")]
    [FieldOffset(Offset = "0x6C")]
    public static readonly int _Amplitude;
    [Token(Token = "0x400136D")]
    [FieldOffset(Offset = "0x70")]
    public static readonly int _MatrixBlur;
    [Token(Token = "0x400136E")]
    [FieldOffset(Offset = "0x74")]
    public static readonly int _NormalMap;
    [Token(Token = "0x400136F")]
    [FieldOffset(Offset = "0x78")]
    public static readonly int _MatrixNormalMap;
    [Token(Token = "0x4001370")]
    [FieldOffset(Offset = "0x7C")]
    public static readonly int _BumpScale;
    [Token(Token = "0x4001371")]
    [FieldOffset(Offset = "0x80")]
    public static readonly int _MatrixGlitch;
    [Token(Token = "0x4001372")]
    [FieldOffset(Offset = "0x84")]
    public static readonly int _SliceY;
    [Token(Token = "0x4001373")]
    [FieldOffset(Offset = "0x88")]
    public static readonly int _SliceH;
    [Token(Token = "0x4001374")]
    [FieldOffset(Offset = "0x8C")]
    public static readonly int _EnableLine;
    [Token(Token = "0x4001375")]
    [FieldOffset(Offset = "0x90")]
    public static readonly int _XAxisG;
    [Token(Token = "0x4001376")]
    [FieldOffset(Offset = "0x94")]
    public static readonly int _OffsetGlitch;
    [Token(Token = "0x4001377")]
    [FieldOffset(Offset = "0x98")]
    public static readonly int _OffsetColor;
    [Token(Token = "0x4001378")]
    [FieldOffset(Offset = "0x9C")]
    public static readonly int _OffsetColorRGB;
    [Token(Token = "0x4001379")]
    [FieldOffset(Offset = "0xA0")]
    public static readonly int _ColorFrameColor;
    [Token(Token = "0x400137A")]
    [FieldOffset(Offset = "0xA4")]
    public static readonly int _ColorFrameDrawEdge;
    [Token(Token = "0x400137B")]
    [FieldOffset(Offset = "0xA8")]
    public static readonly int _ColorFrameParams1;
    [Token(Token = "0x400137C")]
    [FieldOffset(Offset = "0xAC")]
    public static readonly int _CustomVignetteColor;
    [Token(Token = "0x400137D")]
    [FieldOffset(Offset = "0xB0")]
    public static readonly int _CustomVignetteDrawCorner;
    [Token(Token = "0x400137E")]
    [FieldOffset(Offset = "0xB4")]
    public static readonly int _CustomVignetteParams1;
    [Token(Token = "0x400137F")]
    [FieldOffset(Offset = "0xB8")]
    public static readonly int _CustomVignetteParams2;
    [Token(Token = "0x4001380")]
    [FieldOffset(Offset = "0xBC")]
    public static readonly int _DiffusionTarget1;
    [Token(Token = "0x4001381")]
    [FieldOffset(Offset = "0xC0")]
    public static readonly int _DiffusionTarget2;
    [Token(Token = "0x4001382")]
    [FieldOffset(Offset = "0xC4")]
    public static readonly int _Contrast;
    [Token(Token = "0x4001383")]
    [FieldOffset(Offset = "0xC8")]
    public static readonly int _Offsets;
    [Token(Token = "0x4001384")]
    [FieldOffset(Offset = "0xCC")]
    public static readonly int _Weights;
    [Token(Token = "0x4001385")]
    [FieldOffset(Offset = "0xD0")]
    public static readonly int _DiffusionFactor;
    [Token(Token = "0x4001386")]
    [FieldOffset(Offset = "0xD4")]
    public static readonly int _DiffusionTex;
    [Token(Token = "0x4001387")]
    [FieldOffset(Offset = "0xD8")]
    public static readonly int _DiffusionMask;
    [Token(Token = "0x4001388")]
    [FieldOffset(Offset = "0xE0")]
    public static readonly string _ScreenGradationKeyword;
    [Token(Token = "0x4001389")]
    [FieldOffset(Offset = "0xE8")]
    public static readonly string _SkyCoverKeyword;
    [Token(Token = "0x400138A")]
    [FieldOffset(Offset = "0xF0")]
    public static readonly string _Glare1Keyword;
    [Token(Token = "0x400138B")]
    [FieldOffset(Offset = "0xF8")]
    public static readonly string _Glare2Keyword;
    [Token(Token = "0x400138C")]
    [FieldOffset(Offset = "0x100")]
    public static readonly string _DiffusionKeyword;
    [Token(Token = "0x400138D")]
    [FieldOffset(Offset = "0x108")]
    public static readonly string _GlitchUseColorKeyword;
    [Token(Token = "0x400138E")]
    [FieldOffset(Offset = "0x110")]
    public static readonly int _CheckSkymaskPass;
    [Token(Token = "0x400138F")]
    [FieldOffset(Offset = "0x114")]
    public static readonly int _CheckGradationPass;
    [Token(Token = "0x4001390")]
    [FieldOffset(Offset = "0x118")]
    public static readonly int _RefractivePass;
    [Token(Token = "0x4001391")]
    [FieldOffset(Offset = "0x11C")]
    public static readonly int _GlitchPass;
    [Token(Token = "0x4001392")]
    [FieldOffset(Offset = "0x120")]
    public static readonly int _ColorFramePass;
    [Token(Token = "0x4001393")]
    [FieldOffset(Offset = "0x124")]
    public static readonly int _CustomVignettePass;
    [Token(Token = "0x4001394")]
    [FieldOffset(Offset = "0x128")]
    public static int[] _BloomMipUp;
    [Token(Token = "0x4001395")]
    [FieldOffset(Offset = "0x130")]
    public static int[] _BloomMipDown;

    [Token(Token = "0x60012FA")]
    [Address(RVA = "0x2864880", Offset = "0x2864880", VA = "0x2864880")]
    static ShaderConstants()
    {
    }
  }
}
