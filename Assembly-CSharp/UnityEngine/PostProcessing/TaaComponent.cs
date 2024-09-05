// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.TaaComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F6B")]
  public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
  {
    [Token(Token = "0x40115F4")]
    private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing";
    [Token(Token = "0x40115F5")]
    private const int k_SampleCount = 8;
    [Token(Token = "0x40115F6")]
    [FieldOffset(Offset = "0x20")]
    private readonly RenderBuffer[] m_MRT;
    [Token(Token = "0x40115F7")]
    [FieldOffset(Offset = "0x28")]
    private int m_SampleIndex;
    [Token(Token = "0x40115F8")]
    [FieldOffset(Offset = "0x2C")]
    private bool m_ResetHistory;
    [Token(Token = "0x40115F9")]
    [FieldOffset(Offset = "0x30")]
    private RenderTexture m_HistoryTexture;

    [Token(Token = "0x1700525B")]
    public override bool active
    {
      [Token(Token = "0x6019946"), Address(RVA = "0x3439728", Offset = "0x3439728", VA = "0x3439728", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019947")]
    [Address(RVA = "0x34397B8", Offset = "0x34397B8", VA = "0x34397B8", Slot = "4")]
    public override DepthTextureMode GetCameraFlags() => new DepthTextureMode();

    [Token(Token = "0x1700525C")]
    public Vector2 jitterVector
    {
      [Token(Token = "0x6019948"), Address(RVA = "0x34397C0", Offset = "0x34397C0", VA = "0x34397C0")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6019949"), Address(RVA = "0x34397C8", Offset = "0x34397C8", VA = "0x34397C8")] private set
      {
      }
    }

    [Token(Token = "0x601994A")]
    [Address(RVA = "0x34397D0", Offset = "0x34397D0", VA = "0x34397D0")]
    public void ResetHistory()
    {
    }

    [Token(Token = "0x601994B")]
    [Address(RVA = "0x34397DC", Offset = "0x34397DC", VA = "0x34397DC")]
    public void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc)
    {
    }

    [Token(Token = "0x601994C")]
    [Address(RVA = "0x343A09C", Offset = "0x343A09C", VA = "0x343A09C")]
    public void Render(RenderTexture source, RenderTexture destination)
    {
    }

    [Token(Token = "0x601994D")]
    [Address(RVA = "0x343A5BC", Offset = "0x343A5BC", VA = "0x343A5BC")]
    private float GetHaltonValue(int index, int radix) => new float();

    [Token(Token = "0x601994E")]
    [Address(RVA = "0x3439A78", Offset = "0x3439A78", VA = "0x3439A78")]
    private Vector2 GenerateRandomOffset() => new Vector2();

    [Token(Token = "0x601994F")]
    [Address(RVA = "0x3439B0C", Offset = "0x3439B0C", VA = "0x3439B0C")]
    private Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset) => new Matrix4x4();

    [Token(Token = "0x6019950")]
    [Address(RVA = "0x3439F40", Offset = "0x3439F40", VA = "0x3439F40")]
    private Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset) => new Matrix4x4();

    [Token(Token = "0x6019951")]
    [Address(RVA = "0x343A600", Offset = "0x343A600", VA = "0x343A600", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x6019952")]
    [Address(RVA = "0x343A684", Offset = "0x343A684", VA = "0x343A684")]
    public TaaComponent()
    {
    }

    [Token(Token = "0x2003F6C")]
    private static class Uniforms
    {
      [Token(Token = "0x40115FB")]
      [FieldOffset(Offset = "0x0")]
      internal static int _Jitter;
      [Token(Token = "0x40115FC")]
      [FieldOffset(Offset = "0x4")]
      internal static int _SharpenParameters;
      [Token(Token = "0x40115FD")]
      [FieldOffset(Offset = "0x8")]
      internal static int _FinalBlendParameters;
      [Token(Token = "0x40115FE")]
      [FieldOffset(Offset = "0xC")]
      internal static int _HistoryTex;
      [Token(Token = "0x40115FF")]
      [FieldOffset(Offset = "0x10")]
      internal static int _MainTex;

      [Token(Token = "0x6019953")]
      [Address(RVA = "0x343A700", Offset = "0x343A700", VA = "0x343A700")]
      static Uniforms()
      {
      }
    }
  }
}
