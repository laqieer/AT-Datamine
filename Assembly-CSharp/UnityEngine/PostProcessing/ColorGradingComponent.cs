// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ColorGradingComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F54")]
  public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
  {
    [Token(Token = "0x4011547")]
    private const int k_InternalLogLutSize = 32;
    [Token(Token = "0x4011548")]
    private const int k_CurvePrecision = 128;
    [Token(Token = "0x4011549")]
    private const float k_CurveStep = 0.0078125f;
    [Token(Token = "0x401154A")]
    [FieldOffset(Offset = "0x20")]
    private Texture2D m_GradingCurves;
    [Token(Token = "0x401154B")]
    [FieldOffset(Offset = "0x28")]
    private Color[] m_pixels;

    [Token(Token = "0x17005250")]
    public override bool active
    {
      [Token(Token = "0x60198E2"), Address(RVA = "0x3430720", Offset = "0x3430720", VA = "0x3430720", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60198E3")]
    [Address(RVA = "0x3430788", Offset = "0x3430788", VA = "0x3430788")]
    private float StandardIlluminantY(float x) => new float();

    [Token(Token = "0x60198E4")]
    [Address(RVA = "0x34307B4", Offset = "0x34307B4", VA = "0x34307B4")]
    private Vector3 CIExyToLMS(float x, float y) => new Vector3();

    [Token(Token = "0x60198E5")]
    [Address(RVA = "0x3430844", Offset = "0x3430844", VA = "0x3430844")]
    private Vector3 CalculateColorBalance(float temperature, float tint) => new Vector3();

    [Token(Token = "0x60198E6")]
    [Address(RVA = "0x3430948", Offset = "0x3430948", VA = "0x3430948")]
    private static Color NormalizeColor(Color c) => new Color();

    [Token(Token = "0x60198E7")]
    [Address(RVA = "0x3430A14", Offset = "0x3430A14", VA = "0x3430A14")]
    private static Vector3 ClampVector(Vector3 v, float min, float max) => new Vector3();

    [Token(Token = "0x60198E8")]
    [Address(RVA = "0x3430A48", Offset = "0x3430A48", VA = "0x3430A48")]
    public static Vector3 GetLiftValue(Color lift) => new Vector3();

    [Token(Token = "0x60198E9")]
    [Address(RVA = "0x3430ACC", Offset = "0x3430ACC", VA = "0x3430ACC")]
    public static Vector3 GetGammaValue(Color gamma) => new Vector3();

    [Token(Token = "0x60198EA")]
    [Address(RVA = "0x3430BB0", Offset = "0x3430BB0", VA = "0x3430BB0")]
    public static Vector3 GetGainValue(Color gain) => new Vector3();

    [Token(Token = "0x60198EB")]
    [Address(RVA = "0x3430C68", Offset = "0x3430C68", VA = "0x3430C68")]
    public static void CalculateLiftGammaGain(
      Color lift,
      Color gamma,
      Color gain,
      out Vector3 outLift,
      out Vector3 outGamma,
      out Vector3 outGain)
    {
    }

    [Token(Token = "0x60198EC")]
    [Address(RVA = "0x3430D04", Offset = "0x3430D04", VA = "0x3430D04")]
    public static Vector3 GetSlopeValue(Color slope) => new Vector3();

    [Token(Token = "0x60198ED")]
    [Address(RVA = "0x3430DA0", Offset = "0x3430DA0", VA = "0x3430DA0")]
    public static Vector3 GetPowerValue(Color power) => new Vector3();

    [Token(Token = "0x60198EE")]
    [Address(RVA = "0x3430E58", Offset = "0x3430E58", VA = "0x3430E58")]
    public static Vector3 GetOffsetValue(Color offset) => new Vector3();

    [Token(Token = "0x60198EF")]
    [Address(RVA = "0x3430EEC", Offset = "0x3430EEC", VA = "0x3430EEC")]
    public static void CalculateSlopePowerOffset(
      Color slope,
      Color power,
      Color offset,
      out Vector3 outSlope,
      out Vector3 outPower,
      out Vector3 outOffset)
    {
    }

    [Token(Token = "0x60198F0")]
    [Address(RVA = "0x3430F88", Offset = "0x3430F88", VA = "0x3430F88")]
    private TextureFormat GetCurveFormat() => new TextureFormat();

    [Token(Token = "0x60198F1")]
    [Address(RVA = "0x3430FB0", Offset = "0x3430FB0", VA = "0x3430FB0")]
    private Texture2D GetCurveTexture() => (Texture2D) null;

    [Token(Token = "0x60198F2")]
    [Address(RVA = "0x34314E8", Offset = "0x34314E8", VA = "0x34314E8")]
    private bool IsLogLutValid(RenderTexture lut) => new bool();

    [Token(Token = "0x60198F3")]
    [Address(RVA = "0x3431584", Offset = "0x3431584", VA = "0x3431584")]
    private RenderTextureFormat GetLutFormat() => new RenderTextureFormat();

    [Token(Token = "0x60198F4")]
    [Address(RVA = "0x34315A8", Offset = "0x34315A8", VA = "0x34315A8")]
    private void GenerateLut()
    {
    }

    [Token(Token = "0x60198F5")]
    [Address(RVA = "0x3431D30", Offset = "0x3431D30", VA = "0x3431D30", Slot = "10")]
    public override void Prepare(Material uberMaterial)
    {
    }

    [Token(Token = "0x60198F6")]
    [Address(RVA = "0x3431F08", Offset = "0x3431F08", VA = "0x3431F08")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x60198F7")]
    [Address(RVA = "0x343204C", Offset = "0x343204C", VA = "0x343204C", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x60198F8")]
    [Address(RVA = "0x34320B0", Offset = "0x34320B0", VA = "0x34320B0")]
    public ColorGradingComponent()
    {
    }

    [Token(Token = "0x2003F55")]
    private static class Uniforms
    {
      [Token(Token = "0x401154C")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _LutParams;
      [Token(Token = "0x401154D")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _NeutralTonemapperParams1;
      [Token(Token = "0x401154E")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _NeutralTonemapperParams2;
      [Token(Token = "0x401154F")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _HueShift;
      [Token(Token = "0x4011550")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _Saturation;
      [Token(Token = "0x4011551")]
      [FieldOffset(Offset = "0x14")]
      internal static readonly int _Contrast;
      [Token(Token = "0x4011552")]
      [FieldOffset(Offset = "0x18")]
      internal static readonly int _Balance;
      [Token(Token = "0x4011553")]
      [FieldOffset(Offset = "0x1C")]
      internal static readonly int _Lift;
      [Token(Token = "0x4011554")]
      [FieldOffset(Offset = "0x20")]
      internal static readonly int _InvGamma;
      [Token(Token = "0x4011555")]
      [FieldOffset(Offset = "0x24")]
      internal static readonly int _Gain;
      [Token(Token = "0x4011556")]
      [FieldOffset(Offset = "0x28")]
      internal static readonly int _Slope;
      [Token(Token = "0x4011557")]
      [FieldOffset(Offset = "0x2C")]
      internal static readonly int _Power;
      [Token(Token = "0x4011558")]
      [FieldOffset(Offset = "0x30")]
      internal static readonly int _Offset;
      [Token(Token = "0x4011559")]
      [FieldOffset(Offset = "0x34")]
      internal static readonly int _ChannelMixerRed;
      [Token(Token = "0x401155A")]
      [FieldOffset(Offset = "0x38")]
      internal static readonly int _ChannelMixerGreen;
      [Token(Token = "0x401155B")]
      [FieldOffset(Offset = "0x3C")]
      internal static readonly int _ChannelMixerBlue;
      [Token(Token = "0x401155C")]
      [FieldOffset(Offset = "0x40")]
      internal static readonly int _Curves;
      [Token(Token = "0x401155D")]
      [FieldOffset(Offset = "0x44")]
      internal static readonly int _LogLut;
      [Token(Token = "0x401155E")]
      [FieldOffset(Offset = "0x48")]
      internal static readonly int _LogLut_Params;
      [Token(Token = "0x401155F")]
      [FieldOffset(Offset = "0x4C")]
      internal static readonly int _ExposureEV;

      [Token(Token = "0x60198F9")]
      [Address(RVA = "0x3432124", Offset = "0x3432124", VA = "0x3432124")]
      static Uniforms()
      {
      }
    }
  }
}
