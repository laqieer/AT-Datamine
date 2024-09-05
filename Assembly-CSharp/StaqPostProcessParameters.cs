// Decompiled with JetBrains decompiler
// Type: StaqPostProcessParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000330")]
[RequireComponent(typeof (Volume))]
[DisallowMultipleComponent]
public class StaqPostProcessParameters : MonoBehaviour
{
  [Token(Token = "0x40012EE")]
  [FieldOffset(Offset = "0x18")]
  public StaqPostProcessParameters.SkyCoverParameters skyCoverParams;
  [Token(Token = "0x40012EF")]
  [FieldOffset(Offset = "0x28")]
  public StaqPostProcessParameters.ScreenGradationParameters screenGradationParams;
  [Token(Token = "0x40012F0")]
  [FieldOffset(Offset = "0x58")]
  public StaqPostProcessParameters.RefractiveParameters refractiveParams;
  [Token(Token = "0x40012F1")]
  [FieldOffset(Offset = "0x88")]
  public StaqPostProcessParameters.GlitchParameters glitchParams;
  [Token(Token = "0x40012F2")]
  [FieldOffset(Offset = "0xA4")]
  public StaqPostProcessParameters.ColorFrameParameters colorFrameParams;
  [Token(Token = "0x40012F3")]
  [FieldOffset(Offset = "0xD4")]
  public StaqPostProcessParameters.CustomVignetteParameters customVignetteParameters;
  [Token(Token = "0x40012F4")]
  [FieldOffset(Offset = "0x10C")]
  public StaqPostProcessParameters.LinearBlurParameters linearBlurParams;
  [Token(Token = "0x40012F5")]
  [FieldOffset(Offset = "0x11C")]
  public StaqPostProcessParameters.GlareParameters glareParams;
  [Token(Token = "0x40012F6")]
  [FieldOffset(Offset = "0x138")]
  private VolumeProfile _profile;
  [Token(Token = "0x40012F7")]
  [FieldOffset(Offset = "0x140")]
  private VolumeProfile _sharedProfile;
  [Token(Token = "0x40012F8")]
  [FieldOffset(Offset = "0x148")]
  private SkyCover _SkyCover;
  [Token(Token = "0x40012F9")]
  [FieldOffset(Offset = "0x150")]
  private ScreenGradation _ScreenGradation;
  [Token(Token = "0x40012FA")]
  [FieldOffset(Offset = "0x158")]
  private Refractive _Refractive;
  [Token(Token = "0x40012FB")]
  [FieldOffset(Offset = "0x160")]
  private Glitch _Glitch;
  [Token(Token = "0x40012FC")]
  [FieldOffset(Offset = "0x168")]
  private ColorFrame _ColorFrame;
  [Token(Token = "0x40012FD")]
  [FieldOffset(Offset = "0x170")]
  private CustomVignette _CustomVignette;
  [Token(Token = "0x40012FE")]
  [FieldOffset(Offset = "0x178")]
  private LinearBlur _LinearBlur;
  [Token(Token = "0x40012FF")]
  [FieldOffset(Offset = "0x180")]
  private Glare _Glare;

  [Token(Token = "0x60012D8")]
  [Address(RVA = "0x285EC44", Offset = "0x285EC44", VA = "0x285EC44")]
  private void GetSkyCover()
  {
  }

  [Token(Token = "0x60012D9")]
  [Address(RVA = "0x285EC98", Offset = "0x285EC98", VA = "0x285EC98")]
  private void GetScreenGradation()
  {
  }

  [Token(Token = "0x60012DA")]
  [Address(RVA = "0x285ECEC", Offset = "0x285ECEC", VA = "0x285ECEC")]
  private void GetRefractive()
  {
  }

  [Token(Token = "0x60012DB")]
  [Address(RVA = "0x285ED40", Offset = "0x285ED40", VA = "0x285ED40")]
  private void GetGlitch()
  {
  }

  [Token(Token = "0x60012DC")]
  [Address(RVA = "0x285ED94", Offset = "0x285ED94", VA = "0x285ED94")]
  private void GetColorFrame()
  {
  }

  [Token(Token = "0x60012DD")]
  [Address(RVA = "0x285EDE8", Offset = "0x285EDE8", VA = "0x285EDE8")]
  private void GetCustomVignette()
  {
  }

  [Token(Token = "0x60012DE")]
  [Address(RVA = "0x285EE3C", Offset = "0x285EE3C", VA = "0x285EE3C")]
  private void GetLinearBlur()
  {
  }

  [Token(Token = "0x60012DF")]
  [Address(RVA = "0x285EE90", Offset = "0x285EE90", VA = "0x285EE90")]
  private void GetGlare()
  {
  }

  [Token(Token = "0x60012E0")]
  [Address(RVA = "0x285EEE4", Offset = "0x285EEE4", VA = "0x285EEE4")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60012E1")]
  [Address(RVA = "0x285EFE0", Offset = "0x285EFE0", VA = "0x285EFE0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60012E2")]
  [Address(RVA = "0x285F084", Offset = "0x285F084", VA = "0x285F084")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x60012E3")]
  [Address(RVA = "0x285F958", Offset = "0x285F958", VA = "0x285F958")]
  public StaqPostProcessParameters()
  {
  }

  [Token(Token = "0x2000331")]
  [Serializable]
  public struct SkyCoverParameters
  {
    [Token(Token = "0x4001300")]
    [FieldOffset(Offset = "0x0")]
    public bool add;
    [Token(Token = "0x4001301")]
    [FieldOffset(Offset = "0x4")]
    [Range(0.0f, 2f)]
    public float boost;
    [Token(Token = "0x4001302")]
    [FieldOffset(Offset = "0x8")]
    [Range(0.0f, 1f)]
    public float blurSize;
    [Token(Token = "0x4001303")]
    [FieldOffset(Offset = "0xC")]
    [Range(0.0f, 1f)]
    public float depthSlider;
  }

  [Token(Token = "0x2000332")]
  [Serializable]
  public struct ScreenGradationParameters
  {
    [Token(Token = "0x4001304")]
    [FieldOffset(Offset = "0x0")]
    [Range(0.0f, 360f)]
    public float angle;
    [Token(Token = "0x4001305")]
    [FieldOffset(Offset = "0x4")]
    [Range(-1f, 1f)]
    public float offset;
    [Token(Token = "0x4001306")]
    [FieldOffset(Offset = "0x8")]
    [Range(0.0f, 2f)]
    public float threshold;
    [Token(Token = "0x4001307")]
    [FieldOffset(Offset = "0xC")]
    [Range(0.0f, 1f)]
    public float intensity;
    [Token(Token = "0x4001308")]
    [FieldOffset(Offset = "0x10")]
    [ColorUsage(false, false)]
    public Color colorA;
    [Token(Token = "0x4001309")]
    [FieldOffset(Offset = "0x20")]
    [ColorUsage(false, false)]
    public Color colorB;
  }

  [Token(Token = "0x2000333")]
  [Serializable]
  public struct RefractiveParameters
  {
    [Token(Token = "0x400130A")]
    [FieldOffset(Offset = "0x0")]
    public Texture mainTex;
    [Token(Token = "0x400130B")]
    [FieldOffset(Offset = "0x8")]
    public Vector2 tiling;
    [Token(Token = "0x400130C")]
    [FieldOffset(Offset = "0x10")]
    public Vector2 offset;
    [Token(Token = "0x400130D")]
    [FieldOffset(Offset = "0x18")]
    public float bumpScale;
    [Token(Token = "0x400130E")]
    [FieldOffset(Offset = "0x1C")]
    public bool useUVScroll;
    [Token(Token = "0x400130F")]
    [FieldOffset(Offset = "0x1D")]
    public bool useUVRotation;
    [Token(Token = "0x4001310")]
    [FieldOffset(Offset = "0x1E")]
    public bool useAgePercent;
    [Token(Token = "0x4001311")]
    [FieldOffset(Offset = "0x20")]
    public float agePercent;
    [Token(Token = "0x4001312")]
    [FieldOffset(Offset = "0x24")]
    public Vector3 uvSpeed;
  }

  [Token(Token = "0x2000334")]
  [Serializable]
  public struct GlitchParameters
  {
    [Token(Token = "0x4001313")]
    [FieldOffset(Offset = "0x0")]
    [Range(1f, 4f)]
    public int lines;
    [Token(Token = "0x4001314")]
    [FieldOffset(Offset = "0x4")]
    [Range(0.0f, 360f)]
    public float rotation;
    [Token(Token = "0x4001315")]
    [FieldOffset(Offset = "0x8")]
    [Range(0.0f, 1f)]
    public float offset;
    [Token(Token = "0x4001316")]
    [FieldOffset(Offset = "0xC")]
    [Range(0.0f, 1f)]
    public float thickness;
    [Token(Token = "0x4001317")]
    [FieldOffset(Offset = "0x10")]
    public bool useColor;
    [Token(Token = "0x4001318")]
    [FieldOffset(Offset = "0x11")]
    public bool useAgePercent;
    [Token(Token = "0x4001319")]
    [FieldOffset(Offset = "0x14")]
    public float agePercent;
    [Token(Token = "0x400131A")]
    [FieldOffset(Offset = "0x18")]
    public float speed;
  }

  [Token(Token = "0x2000335")]
  [Serializable]
  public struct ColorFrameParameters
  {
    [Token(Token = "0x400131B")]
    [FieldOffset(Offset = "0x0")]
    public Color frameColor;
    [Token(Token = "0x400131C")]
    [FieldOffset(Offset = "0x10")]
    public Vector4 drawEdge;
    [Token(Token = "0x400131D")]
    [FieldOffset(Offset = "0x20")]
    [Range(0.0f, 1334f)]
    public float width;
    [Token(Token = "0x400131E")]
    [FieldOffset(Offset = "0x24")]
    [Range(0.0f, 750f)]
    public float height;
    [Token(Token = "0x400131F")]
    [FieldOffset(Offset = "0x28")]
    [Range(0.001f, 1f)]
    public float smoothness;
    [Token(Token = "0x4001320")]
    [FieldOffset(Offset = "0x2C")]
    public int blendMode;
  }

  [Token(Token = "0x2000336")]
  [Serializable]
  public struct CustomVignetteParameters
  {
    [Token(Token = "0x4001321")]
    [FieldOffset(Offset = "0x0")]
    public Color color;
    [Token(Token = "0x4001322")]
    [FieldOffset(Offset = "0x10")]
    public Vector4 drawCorner;
    [Token(Token = "0x4001323")]
    [FieldOffset(Offset = "0x20")]
    public Vector2 center;
    [Token(Token = "0x4001324")]
    [FieldOffset(Offset = "0x28")]
    [Min(0.0f)]
    public float intensity;
    [Token(Token = "0x4001325")]
    [FieldOffset(Offset = "0x2C")]
    [Range(0.001f, 1f)]
    public float smoothness;
    [Token(Token = "0x4001326")]
    [FieldOffset(Offset = "0x30")]
    public bool roundness;
    [Token(Token = "0x4001327")]
    [FieldOffset(Offset = "0x34")]
    public int blendMode;
  }

  [Token(Token = "0x2000337")]
  public struct LinearBlurParameters
  {
    [Token(Token = "0x4001328")]
    [FieldOffset(Offset = "0x0")]
    [Range(0.0f, 10f)]
    public float intensity;
    [Token(Token = "0x4001329")]
    [FieldOffset(Offset = "0x4")]
    [Range(0.0f, 360f)]
    public float direction;
    [Token(Token = "0x400132A")]
    [FieldOffset(Offset = "0x8")]
    [Range(0.0f, 100f)]
    public float frequency;
    [Token(Token = "0x400132B")]
    [FieldOffset(Offset = "0xC")]
    [Range(0.0f, 1f)]
    public float density;
  }

  [Token(Token = "0x2000338")]
  [Serializable]
  public struct GlareParameters
  {
    [Token(Token = "0x400132C")]
    [FieldOffset(Offset = "0x0")]
    public bool crossing;
    [Token(Token = "0x400132D")]
    [FieldOffset(Offset = "0x4")]
    [Range(0.0f, 180f)]
    public float angle1;
    [Token(Token = "0x400132E")]
    [FieldOffset(Offset = "0x8")]
    [Range(0.0f, 180f)]
    public float angle2;
    [Token(Token = "0x400132F")]
    [FieldOffset(Offset = "0xC")]
    [Min(0.0f)]
    public float threshold;
    [Token(Token = "0x4001330")]
    [FieldOffset(Offset = "0x10")]
    [Min(0.0f)]
    public float intensity;
    [Token(Token = "0x4001331")]
    [FieldOffset(Offset = "0x14")]
    [Range(0.0f, 1f)]
    public float scatter;
    [Token(Token = "0x4001332")]
    [FieldOffset(Offset = "0x18")]
    [Min(0.0f)]
    public float clamp;
  }
}
