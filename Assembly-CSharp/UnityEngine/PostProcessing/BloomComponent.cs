// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.BloomComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F4C")]
  public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
  {
    [Token(Token = "0x4011525")]
    private const int k_MaxPyramidBlurLevel = 16;
    [Token(Token = "0x4011526")]
    [FieldOffset(Offset = "0x20")]
    private readonly RenderTexture[] m_BlurBuffer1;
    [Token(Token = "0x4011527")]
    [FieldOffset(Offset = "0x28")]
    private readonly RenderTexture[] m_BlurBuffer2;

    [Token(Token = "0x1700524A")]
    public override bool active
    {
      [Token(Token = "0x60198C4"), Address(RVA = "0x342E478", Offset = "0x342E478", VA = "0x342E478", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60198C5")]
    [Address(RVA = "0x342E4EC", Offset = "0x342E4EC", VA = "0x342E4EC")]
    public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure)
    {
    }

    [Token(Token = "0x60198C6")]
    [Address(RVA = "0x342EE5C", Offset = "0x342EE5C", VA = "0x342EE5C")]
    public BloomComponent()
    {
    }

    [Token(Token = "0x2003F4D")]
    private static class Uniforms
    {
      [Token(Token = "0x4011528")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _AutoExposure;
      [Token(Token = "0x4011529")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _Threshold;
      [Token(Token = "0x401152A")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _Curve;
      [Token(Token = "0x401152B")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _PrefilterOffs;
      [Token(Token = "0x401152C")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _SampleScale;
      [Token(Token = "0x401152D")]
      [FieldOffset(Offset = "0x14")]
      internal static readonly int _BaseTex;
      [Token(Token = "0x401152E")]
      [FieldOffset(Offset = "0x18")]
      internal static readonly int _BloomTex;
      [Token(Token = "0x401152F")]
      [FieldOffset(Offset = "0x1C")]
      internal static readonly int _Bloom_Settings;
      [Token(Token = "0x4011530")]
      [FieldOffset(Offset = "0x20")]
      internal static readonly int _Bloom_DirtTex;
      [Token(Token = "0x4011531")]
      [FieldOffset(Offset = "0x24")]
      internal static readonly int _Bloom_DirtIntensity;

      [Token(Token = "0x60198C7")]
      [Address(RVA = "0x342EEE0", Offset = "0x342EEE0", VA = "0x342EEE0")]
      static Uniforms()
      {
      }
    }
  }
}
