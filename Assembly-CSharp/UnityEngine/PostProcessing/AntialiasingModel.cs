// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.AntialiasingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F74")]
  [Serializable]
  public class AntialiasingModel : PostProcessingModel
  {
    [Token(Token = "0x4011614")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private AntialiasingModel.Settings m_Settings;

    [Token(Token = "0x17005261")]
    public AntialiasingModel.Settings settings
    {
      [Token(Token = "0x6019962"), Address(RVA = "0x343B14C", Offset = "0x343B14C", VA = "0x343B14C")] get
      {
        return new AntialiasingModel.Settings();
      }
      [Token(Token = "0x6019963"), Address(RVA = "0x343B160", Offset = "0x343B160", VA = "0x343B160")] set
      {
      }
    }

    [Token(Token = "0x6019964")]
    [Address(RVA = "0x343B174", Offset = "0x343B174", VA = "0x343B174", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x6019965")]
    [Address(RVA = "0x343B1AC", Offset = "0x343B1AC", VA = "0x343B1AC")]
    public AntialiasingModel()
    {
    }

    [Token(Token = "0x2003F75")]
    public enum Method
    {
      [Token(Token = "0x4011616")] Fxaa,
      [Token(Token = "0x4011617")] Taa,
    }

    [Token(Token = "0x2003F76")]
    public enum FxaaPreset
    {
      [Token(Token = "0x4011619")] ExtremePerformance,
      [Token(Token = "0x401161A")] Performance,
      [Token(Token = "0x401161B")] Default,
      [Token(Token = "0x401161C")] Quality,
      [Token(Token = "0x401161D")] ExtremeQuality,
    }

    [Token(Token = "0x2003F77")]
    [Serializable]
    public struct FxaaQualitySettings
    {
      [Token(Token = "0x401161E")]
      [FieldOffset(Offset = "0x0")]
      [Range(0.0f, 1f)]
      [Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
      public float subpixelAliasingRemovalAmount;
      [Token(Token = "0x401161F")]
      [FieldOffset(Offset = "0x4")]
      [Range(0.063f, 0.333f)]
      [Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
      public float edgeDetectionThreshold;
      [Token(Token = "0x4011620")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
      [Range(0.0f, 0.0833f)]
      public float minimumRequiredLuminance;
      [Token(Token = "0x4011621")]
      [FieldOffset(Offset = "0x0")]
      public static AntialiasingModel.FxaaQualitySettings[] presets;

      [Token(Token = "0x6019966")]
      [Address(RVA = "0x343B1CC", Offset = "0x343B1CC", VA = "0x343B1CC")]
      static FxaaQualitySettings()
      {
      }
    }

    [Token(Token = "0x2003F78")]
    [Serializable]
    public struct FxaaConsoleSettings
    {
      [Token(Token = "0x4011622")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
      [Range(0.33f, 0.5f)]
      public float subpixelSpreadAmount;
      [Token(Token = "0x4011623")]
      [FieldOffset(Offset = "0x4")]
      [Range(2f, 8f)]
      [Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
      public float edgeSharpnessAmount;
      [Token(Token = "0x4011624")]
      [FieldOffset(Offset = "0x8")]
      [Range(0.125f, 0.25f)]
      [Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
      public float edgeDetectionThreshold;
      [Token(Token = "0x4011625")]
      [FieldOffset(Offset = "0xC")]
      [Range(0.04f, 0.06f)]
      [Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
      public float minimumRequiredLuminance;
      [Token(Token = "0x4011626")]
      [FieldOffset(Offset = "0x0")]
      public static AntialiasingModel.FxaaConsoleSettings[] presets;

      [Token(Token = "0x6019967")]
      [Address(RVA = "0x343B2D0", Offset = "0x343B2D0", VA = "0x343B2D0")]
      static FxaaConsoleSettings()
      {
      }
    }

    [Token(Token = "0x2003F79")]
    [Serializable]
    public struct FxaaSettings
    {
      [Token(Token = "0x4011627")]
      [FieldOffset(Offset = "0x0")]
      public AntialiasingModel.FxaaPreset preset;

      [Token(Token = "0x17005262")]
      public static AntialiasingModel.FxaaSettings defaultSettings
      {
        [Token(Token = "0x6019968"), Address(RVA = "0x343B3A8", Offset = "0x343B3A8", VA = "0x343B3A8")] get
        {
          return new AntialiasingModel.FxaaSettings();
        }
      }
    }

    [Token(Token = "0x2003F7A")]
    [Serializable]
    public struct TaaSettings
    {
      [Token(Token = "0x4011628")]
      [FieldOffset(Offset = "0x0")]
      [Range(0.1f, 1f)]
      [Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
      public float jitterSpread;
      [Token(Token = "0x4011629")]
      [FieldOffset(Offset = "0x4")]
      [Tooltip("Controls the amount of sharpening applied to the color buffer.")]
      [Range(0.0f, 3f)]
      public float sharpen;
      [Token(Token = "0x401162A")]
      [FieldOffset(Offset = "0x8")]
      [Range(0.0f, 0.99f)]
      [Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
      public float stationaryBlending;
      [Token(Token = "0x401162B")]
      [FieldOffset(Offset = "0xC")]
      [Range(0.0f, 0.99f)]
      [Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
      public float motionBlending;

      [Token(Token = "0x17005263")]
      public static AntialiasingModel.TaaSettings defaultSettings
      {
        [Token(Token = "0x6019969"), Address(RVA = "0x343B3B0", Offset = "0x343B3B0", VA = "0x343B3B0")] get
        {
          return new AntialiasingModel.TaaSettings();
        }
      }
    }

    [Token(Token = "0x2003F7B")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x401162C")]
      [FieldOffset(Offset = "0x0")]
      public AntialiasingModel.Method method;
      [Token(Token = "0x401162D")]
      [FieldOffset(Offset = "0x4")]
      public AntialiasingModel.FxaaSettings fxaaSettings;
      [Token(Token = "0x401162E")]
      [FieldOffset(Offset = "0x8")]
      public AntialiasingModel.TaaSettings taaSettings;

      [Token(Token = "0x17005264")]
      public static AntialiasingModel.Settings defaultSettings
      {
        [Token(Token = "0x601996A"), Address(RVA = "0x343B190", Offset = "0x343B190", VA = "0x343B190")] get
        {
          return new AntialiasingModel.Settings();
        }
      }
    }
  }
}
