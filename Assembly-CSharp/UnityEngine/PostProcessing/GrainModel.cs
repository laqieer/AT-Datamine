// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GrainModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F9C")]
  [Serializable]
  public class GrainModel : PostProcessingModel
  {
    [Token(Token = "0x40116A5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GrainModel.Settings m_Settings;

    [Token(Token = "0x17005284")]
    public GrainModel.Settings settings
    {
      [Token(Token = "0x60199A7"), Address(RVA = "0x343C1A4", Offset = "0x343C1A4", VA = "0x343C1A4")] get
      {
        return new GrainModel.Settings();
      }
      [Token(Token = "0x60199A8"), Address(RVA = "0x343C1B4", Offset = "0x343C1B4", VA = "0x343C1B4")] set
      {
      }
    }

    [Token(Token = "0x60199A9")]
    [Address(RVA = "0x343C1C0", Offset = "0x343C1C0", VA = "0x343C1C0", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x60199AA")]
    [Address(RVA = "0x343C1E8", Offset = "0x343C1E8", VA = "0x343C1E8")]
    public GrainModel()
    {
    }

    [Token(Token = "0x2003F9D")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x40116A6")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Enable the use of colored grain.")]
      public bool colored;
      [Token(Token = "0x40116A7")]
      [FieldOffset(Offset = "0x4")]
      [Range(0.0f, 1f)]
      [Tooltip("Grain strength. Higher means more visible grain.")]
      public float intensity;
      [Token(Token = "0x40116A8")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Grain particle size.")]
      [Range(0.3f, 3f)]
      public float size;
      [Token(Token = "0x40116A9")]
      [FieldOffset(Offset = "0xC")]
      [Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
      [Range(0.0f, 1f)]
      public float luminanceContribution;

      [Token(Token = "0x17005285")]
      public static GrainModel.Settings defaultSettings
      {
        [Token(Token = "0x60199AB"), Address(RVA = "0x343C1D0", Offset = "0x343C1D0", VA = "0x343C1D0")] get
        {
          return new GrainModel.Settings();
        }
      }
    }
  }
}
