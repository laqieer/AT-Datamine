// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.DepthOfFieldComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F56")]
  public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
  {
    [Token(Token = "0x4011560")]
    private const string k_ShaderString = "Hidden/Post FX/Depth Of Field";
    [Token(Token = "0x4011561")]
    [FieldOffset(Offset = "0x20")]
    private RenderTexture m_CoCHistory;
    [Token(Token = "0x4011562")]
    private const float k_FilmHeight = 0.024f;

    [Token(Token = "0x17005251")]
    public override bool active
    {
      [Token(Token = "0x60198FA"), Address(RVA = "0x34324F0", Offset = "0x34324F0", VA = "0x34324F0", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60198FB")]
    [Address(RVA = "0x3432558", Offset = "0x3432558", VA = "0x3432558", Slot = "4")]
    public override DepthTextureMode GetCameraFlags() => new DepthTextureMode();

    [Token(Token = "0x60198FC")]
    [Address(RVA = "0x3432560", Offset = "0x3432560", VA = "0x3432560")]
    private float CalculateFocalLength() => new float();

    [Token(Token = "0x60198FD")]
    [Address(RVA = "0x34325FC", Offset = "0x34325FC", VA = "0x34325FC")]
    private float CalculateMaxCoCRadius(int screenHeight) => new float();

    [Token(Token = "0x60198FE")]
    [Address(RVA = "0x3432670", Offset = "0x3432670", VA = "0x3432670")]
    private bool CheckHistory(int width, int height) => new bool();

    [Token(Token = "0x60198FF")]
    [Address(RVA = "0x3432740", Offset = "0x3432740", VA = "0x3432740")]
    private RenderTextureFormat SelectFormat(
      RenderTextureFormat primary,
      RenderTextureFormat secondary)
    {
      return new RenderTextureFormat();
    }

    [Token(Token = "0x6019900")]
    [Address(RVA = "0x343278C", Offset = "0x343278C", VA = "0x343278C")]
    public void Prepare(
      RenderTexture source,
      Material uberMaterial,
      bool antialiasCoC,
      Vector2 taaJitter,
      float taaBlending)
    {
    }

    [Token(Token = "0x6019901")]
    [Address(RVA = "0x3432F58", Offset = "0x3432F58", VA = "0x3432F58", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x6019902")]
    [Address(RVA = "0x3432FD0", Offset = "0x3432FD0", VA = "0x3432FD0")]
    public DepthOfFieldComponent()
    {
    }

    [Token(Token = "0x2003F57")]
    private static class Uniforms
    {
      [Token(Token = "0x4011563")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _DepthOfFieldTex;
      [Token(Token = "0x4011564")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _DepthOfFieldCoCTex;
      [Token(Token = "0x4011565")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _Distance;
      [Token(Token = "0x4011566")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _LensCoeff;
      [Token(Token = "0x4011567")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _MaxCoC;
      [Token(Token = "0x4011568")]
      [FieldOffset(Offset = "0x14")]
      internal static readonly int _RcpMaxCoC;
      [Token(Token = "0x4011569")]
      [FieldOffset(Offset = "0x18")]
      internal static readonly int _RcpAspect;
      [Token(Token = "0x401156A")]
      [FieldOffset(Offset = "0x1C")]
      internal static readonly int _MainTex;
      [Token(Token = "0x401156B")]
      [FieldOffset(Offset = "0x20")]
      internal static readonly int _CoCTex;
      [Token(Token = "0x401156C")]
      [FieldOffset(Offset = "0x24")]
      internal static readonly int _TaaParams;
      [Token(Token = "0x401156D")]
      [FieldOffset(Offset = "0x28")]
      internal static readonly int _DepthOfFieldParams;

      [Token(Token = "0x6019903")]
      [Address(RVA = "0x3433018", Offset = "0x3433018", VA = "0x3433018")]
      static Uniforms()
      {
      }
    }
  }
}
