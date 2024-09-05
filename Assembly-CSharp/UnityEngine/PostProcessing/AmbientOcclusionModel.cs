// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.AmbientOcclusionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F71")]
  [Serializable]
  public class AmbientOcclusionModel : PostProcessingModel
  {
    [Token(Token = "0x4011607")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private AmbientOcclusionModel.Settings m_Settings;

    [Token(Token = "0x1700525F")]
    public AmbientOcclusionModel.Settings settings
    {
      [Token(Token = "0x601995D"), Address(RVA = "0x343B0EC", Offset = "0x343B0EC", VA = "0x343B0EC")] get
      {
        return new AmbientOcclusionModel.Settings();
      }
      [Token(Token = "0x601995E"), Address(RVA = "0x343B0FC", Offset = "0x343B0FC", VA = "0x343B0FC")] set
      {
      }
    }

    [Token(Token = "0x601995F")]
    [Address(RVA = "0x343B108", Offset = "0x343B108", VA = "0x343B108", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x6019960")]
    [Address(RVA = "0x343B130", Offset = "0x343B130", VA = "0x343B130")]
    public AmbientOcclusionModel()
    {
    }

    [Token(Token = "0x2003F72")]
    public enum SampleCount
    {
      [Token(Token = "0x4011609")] Lowest = 3,
      [Token(Token = "0x401160A")] Low = 6,
      [Token(Token = "0x401160B")] Medium = 10, // 0x0000000A
      [Token(Token = "0x401160C")] High = 16, // 0x00000010
    }

    [Token(Token = "0x2003F73")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x401160D")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Degree of darkness produced by the effect.")]
      [Range(0.0f, 4f)]
      public float intensity;
      [Token(Token = "0x401160E")]
      [FieldOffset(Offset = "0x4")]
      [Tooltip("Radius of sample points, which affects extent of darkened areas.")]
      [Min(0.0001f)]
      public float radius;
      [Token(Token = "0x401160F")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Number of sample points, which affects quality and performance.")]
      public AmbientOcclusionModel.SampleCount sampleCount;
      [Token(Token = "0x4011610")]
      [FieldOffset(Offset = "0xC")]
      [Tooltip("Halves the resolution of the effect to increase performance at the cost of visual quality.")]
      public bool downsampling;
      [Token(Token = "0x4011611")]
      [FieldOffset(Offset = "0xD")]
      [Tooltip("Forces compatibility with Forward rendered objects when working with the Deferred rendering path.")]
      public bool forceForwardCompatibility;
      [Token(Token = "0x4011612")]
      [FieldOffset(Offset = "0xE")]
      [Tooltip("Enables the ambient-only mode in that the effect only affects ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering.")]
      public bool ambientOnly;
      [Token(Token = "0x4011613")]
      [FieldOffset(Offset = "0xF")]
      [Tooltip("Toggles the use of a higher precision depth texture with the forward rendering path (may impact performances). Has no effect with the deferred rendering path.")]
      public bool highPrecision;

      [Token(Token = "0x17005260")]
      public static AmbientOcclusionModel.Settings defaultSettings
      {
        [Token(Token = "0x6019961"), Address(RVA = "0x343B118", Offset = "0x343B118", VA = "0x343B118")] get
        {
          return new AmbientOcclusionModel.Settings();
        }
      }
    }
  }
}
