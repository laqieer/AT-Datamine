// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.EyeAdaptationComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F5A")]
  public sealed class EyeAdaptationComponent : 
    PostProcessingComponentRenderTexture<EyeAdaptationModel>
  {
    [Token(Token = "0x4011573")]
    [FieldOffset(Offset = "0x20")]
    private ComputeShader m_EyeCompute;
    [Token(Token = "0x4011574")]
    [FieldOffset(Offset = "0x28")]
    private ComputeBuffer m_HistogramBuffer;
    [Token(Token = "0x4011575")]
    [FieldOffset(Offset = "0x30")]
    private readonly RenderTexture[] m_AutoExposurePool;
    [Token(Token = "0x4011576")]
    [FieldOffset(Offset = "0x38")]
    private int m_AutoExposurePingPing;
    [Token(Token = "0x4011577")]
    [FieldOffset(Offset = "0x40")]
    private RenderTexture m_CurrentAutoExposure;
    [Token(Token = "0x4011578")]
    [FieldOffset(Offset = "0x48")]
    private RenderTexture m_DebugHistogram;
    [Token(Token = "0x4011579")]
    [FieldOffset(Offset = "0x0")]
    private static uint[] s_EmptyHistogramBuffer;
    [Token(Token = "0x401157A")]
    [FieldOffset(Offset = "0x50")]
    private bool m_FirstFrame;
    [Token(Token = "0x401157B")]
    private const int k_HistogramBins = 64;
    [Token(Token = "0x401157C")]
    private const int k_HistogramThreadX = 16;
    [Token(Token = "0x401157D")]
    private const int k_HistogramThreadY = 16;

    [Token(Token = "0x17005253")]
    public override bool active
    {
      [Token(Token = "0x601990A"), Address(RVA = "0x34336A4", Offset = "0x34336A4", VA = "0x34336A4", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601990B")]
    [Address(RVA = "0x3433718", Offset = "0x3433718", VA = "0x3433718")]
    public void ResetHistory()
    {
    }

    [Token(Token = "0x601990C")]
    [Address(RVA = "0x3433724", Offset = "0x3433724", VA = "0x3433724", Slot = "6")]
    public override void OnEnable()
    {
    }

    [Token(Token = "0x601990D")]
    [Address(RVA = "0x3433730", Offset = "0x3433730", VA = "0x3433730", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x601990E")]
    [Address(RVA = "0x3433810", Offset = "0x3433810", VA = "0x3433810")]
    private Vector4 GetHistogramScaleOffsetRes() => new Vector4();

    [Token(Token = "0x601990F")]
    [Address(RVA = "0x34338E0", Offset = "0x34338E0", VA = "0x34338E0")]
    public Texture Prepare(RenderTexture source, Material uberMaterial) => (Texture) null;

    [Token(Token = "0x6019910")]
    [Address(RVA = "0x34342F0", Offset = "0x34342F0", VA = "0x34342F0")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x6019911")]
    [Address(RVA = "0x3434460", Offset = "0x3434460", VA = "0x3434460")]
    public EyeAdaptationComponent()
    {
    }

    [Token(Token = "0x2003F5B")]
    private static class Uniforms
    {
      [Token(Token = "0x401157E")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _Params;
      [Token(Token = "0x401157F")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _Speed;
      [Token(Token = "0x4011580")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _ScaleOffsetRes;
      [Token(Token = "0x4011581")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _ExposureCompensation;
      [Token(Token = "0x4011582")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _AutoExposure;
      [Token(Token = "0x4011583")]
      [FieldOffset(Offset = "0x14")]
      internal static readonly int _DebugWidth;

      [Token(Token = "0x6019912")]
      [Address(RVA = "0x34344DC", Offset = "0x34344DC", VA = "0x34344DC")]
      static Uniforms()
      {
      }
    }
  }
}
