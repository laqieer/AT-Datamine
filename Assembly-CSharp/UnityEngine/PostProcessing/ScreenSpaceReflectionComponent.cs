// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ScreenSpaceReflectionComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F68")]
  public sealed class ScreenSpaceReflectionComponent : 
    PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
  {
    [Token(Token = "0x40115C2")]
    [FieldOffset(Offset = "0x20")]
    private bool k_HighlightSuppression;
    [Token(Token = "0x40115C3")]
    [FieldOffset(Offset = "0x21")]
    private bool k_TraceBehindObjects;
    [Token(Token = "0x40115C4")]
    [FieldOffset(Offset = "0x22")]
    private bool k_TreatBackfaceHitAsMiss;
    [Token(Token = "0x40115C5")]
    [FieldOffset(Offset = "0x23")]
    private bool k_BilateralUpsample;
    [Token(Token = "0x40115C6")]
    [FieldOffset(Offset = "0x28")]
    private readonly int[] m_ReflectionTextures;

    [Token(Token = "0x601993E")]
    [Address(RVA = "0x3437E10", Offset = "0x3437E10", VA = "0x3437E10", Slot = "4")]
    public override DepthTextureMode GetCameraFlags() => new DepthTextureMode();

    [Token(Token = "0x1700525A")]
    public override bool active
    {
      [Token(Token = "0x601993F"), Address(RVA = "0x3437E18", Offset = "0x3437E18", VA = "0x3437E18", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019940")]
    [Address(RVA = "0x3437E90", Offset = "0x3437E90", VA = "0x3437E90", Slot = "6")]
    public override void OnEnable()
    {
    }

    [Token(Token = "0x6019941")]
    [Address(RVA = "0x3437FD8", Offset = "0x3437FD8", VA = "0x3437FD8", Slot = "11")]
    public override string GetName() => (string) null;

    [Token(Token = "0x6019942")]
    [Address(RVA = "0x3438018", Offset = "0x3438018", VA = "0x3438018", Slot = "10")]
    public override CameraEvent GetCameraEvent() => new CameraEvent();

    [Token(Token = "0x6019943")]
    [Address(RVA = "0x3438020", Offset = "0x3438020", VA = "0x3438020", Slot = "12")]
    public override void PopulateCommandBuffer(CommandBuffer cb)
    {
    }

    [Token(Token = "0x6019944")]
    [Address(RVA = "0x3439048", Offset = "0x3439048", VA = "0x3439048")]
    public ScreenSpaceReflectionComponent()
    {
    }

    [Token(Token = "0x2003F69")]
    private static class Uniforms
    {
      [Token(Token = "0x40115C7")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _RayStepSize;
      [Token(Token = "0x40115C8")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _AdditiveReflection;
      [Token(Token = "0x40115C9")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _BilateralUpsampling;
      [Token(Token = "0x40115CA")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _TreatBackfaceHitAsMiss;
      [Token(Token = "0x40115CB")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _AllowBackwardsRays;
      [Token(Token = "0x40115CC")]
      [FieldOffset(Offset = "0x14")]
      internal static readonly int _TraceBehindObjects;
      [Token(Token = "0x40115CD")]
      [FieldOffset(Offset = "0x18")]
      internal static readonly int _MaxSteps;
      [Token(Token = "0x40115CE")]
      [FieldOffset(Offset = "0x1C")]
      internal static readonly int _FullResolutionFiltering;
      [Token(Token = "0x40115CF")]
      [FieldOffset(Offset = "0x20")]
      internal static readonly int _HalfResolution;
      [Token(Token = "0x40115D0")]
      [FieldOffset(Offset = "0x24")]
      internal static readonly int _HighlightSuppression;
      [Token(Token = "0x40115D1")]
      [FieldOffset(Offset = "0x28")]
      internal static readonly int _PixelsPerMeterAtOneMeter;
      [Token(Token = "0x40115D2")]
      [FieldOffset(Offset = "0x2C")]
      internal static readonly int _ScreenEdgeFading;
      [Token(Token = "0x40115D3")]
      [FieldOffset(Offset = "0x30")]
      internal static readonly int _ReflectionBlur;
      [Token(Token = "0x40115D4")]
      [FieldOffset(Offset = "0x34")]
      internal static readonly int _MaxRayTraceDistance;
      [Token(Token = "0x40115D5")]
      [FieldOffset(Offset = "0x38")]
      internal static readonly int _FadeDistance;
      [Token(Token = "0x40115D6")]
      [FieldOffset(Offset = "0x3C")]
      internal static readonly int _LayerThickness;
      [Token(Token = "0x40115D7")]
      [FieldOffset(Offset = "0x40")]
      internal static readonly int _SSRMultiplier;
      [Token(Token = "0x40115D8")]
      [FieldOffset(Offset = "0x44")]
      internal static readonly int _FresnelFade;
      [Token(Token = "0x40115D9")]
      [FieldOffset(Offset = "0x48")]
      internal static readonly int _FresnelFadePower;
      [Token(Token = "0x40115DA")]
      [FieldOffset(Offset = "0x4C")]
      internal static readonly int _ReflectionBufferSize;
      [Token(Token = "0x40115DB")]
      [FieldOffset(Offset = "0x50")]
      internal static readonly int _ScreenSize;
      [Token(Token = "0x40115DC")]
      [FieldOffset(Offset = "0x54")]
      internal static readonly int _InvScreenSize;
      [Token(Token = "0x40115DD")]
      [FieldOffset(Offset = "0x58")]
      internal static readonly int _ProjInfo;
      [Token(Token = "0x40115DE")]
      [FieldOffset(Offset = "0x5C")]
      internal static readonly int _CameraClipInfo;
      [Token(Token = "0x40115DF")]
      [FieldOffset(Offset = "0x60")]
      internal static readonly int _ProjectToPixelMatrix;
      [Token(Token = "0x40115E0")]
      [FieldOffset(Offset = "0x64")]
      internal static readonly int _WorldToCameraMatrix;
      [Token(Token = "0x40115E1")]
      [FieldOffset(Offset = "0x68")]
      internal static readonly int _CameraToWorldMatrix;
      [Token(Token = "0x40115E2")]
      [FieldOffset(Offset = "0x6C")]
      internal static readonly int _Axis;
      [Token(Token = "0x40115E3")]
      [FieldOffset(Offset = "0x70")]
      internal static readonly int _CurrentMipLevel;
      [Token(Token = "0x40115E4")]
      [FieldOffset(Offset = "0x74")]
      internal static readonly int _NormalAndRoughnessTexture;
      [Token(Token = "0x40115E5")]
      [FieldOffset(Offset = "0x78")]
      internal static readonly int _HitPointTexture;
      [Token(Token = "0x40115E6")]
      [FieldOffset(Offset = "0x7C")]
      internal static readonly int _BlurTexture;
      [Token(Token = "0x40115E7")]
      [FieldOffset(Offset = "0x80")]
      internal static readonly int _FilteredReflections;
      [Token(Token = "0x40115E8")]
      [FieldOffset(Offset = "0x84")]
      internal static readonly int _FinalReflectionTexture;
      [Token(Token = "0x40115E9")]
      [FieldOffset(Offset = "0x88")]
      internal static readonly int _TempTexture;

      [Token(Token = "0x6019945")]
      [Address(RVA = "0x34390C8", Offset = "0x34390C8", VA = "0x34390C8")]
      static Uniforms()
      {
      }
    }

    [Token(Token = "0x2003F6A")]
    private enum PassIndex
    {
      [Token(Token = "0x40115EB")] RayTraceStep,
      [Token(Token = "0x40115EC")] CompositeFinal,
      [Token(Token = "0x40115ED")] Blur,
      [Token(Token = "0x40115EE")] CompositeSSR,
      [Token(Token = "0x40115EF")] MinMipGeneration,
      [Token(Token = "0x40115F0")] HitPointToReflections,
      [Token(Token = "0x40115F1")] BilateralKeyPack,
      [Token(Token = "0x40115F2")] BlitDepthAsCSZ,
      [Token(Token = "0x40115F3")] PoissonBlur,
    }
  }
}
