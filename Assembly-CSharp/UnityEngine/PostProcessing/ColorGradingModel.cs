// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ColorGradingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F87")]
  [Serializable]
  public class ColorGradingModel : PostProcessingModel
  {
    [Token(Token = "0x4011652")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ColorGradingModel.Settings m_Settings;

    [Token(Token = "0x17005271")]
    public ColorGradingModel.Settings settings
    {
      [Token(Token = "0x6019982"), Address(RVA = "0x343B5EC", Offset = "0x343B5EC", VA = "0x343B5EC")] get
      {
        return new ColorGradingModel.Settings();
      }
      [Token(Token = "0x6019983"), Address(RVA = "0x343B5FC", Offset = "0x343B5FC", VA = "0x343B5FC")] set
      {
      }
    }

    [Token(Token = "0x17005272")]
    public bool isDirty
    {
      [Token(Token = "0x6019984"), Address(RVA = "0x343B624", Offset = "0x343B624", VA = "0x343B624")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019985"), Address(RVA = "0x343B62C", Offset = "0x343B62C", VA = "0x343B62C")] internal set
      {
      }
    }

    [Token(Token = "0x17005273")]
    public RenderTexture bakedLut
    {
      [Token(Token = "0x6019986"), Address(RVA = "0x343B638", Offset = "0x343B638", VA = "0x343B638")] get
      {
        return (RenderTexture) null;
      }
      [Token(Token = "0x6019987"), Address(RVA = "0x343B640", Offset = "0x343B640", VA = "0x343B640")] internal set
      {
      }
    }

    [Token(Token = "0x6019988")]
    [Address(RVA = "0x343B648", Offset = "0x343B648", VA = "0x343B648", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x6019989")]
    [Address(RVA = "0x343B7C8", Offset = "0x343B7C8", VA = "0x343B7C8", Slot = "5")]
    public override void OnValidate()
    {
    }

    [Token(Token = "0x601998A")]
    [Address(RVA = "0x343B7D4", Offset = "0x343B7D4", VA = "0x343B7D4")]
    public ColorGradingModel()
    {
    }

    [Token(Token = "0x2003F88")]
    public enum Tonemapper
    {
      [Token(Token = "0x4011656")] None,
      [Token(Token = "0x4011657")] ACES,
      [Token(Token = "0x4011658")] Neutral,
    }

    [Token(Token = "0x2003F89")]
    [Serializable]
    public struct TonemappingSettings
    {
      [Token(Token = "0x4011659")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
      public ColorGradingModel.Tonemapper tonemapper;
      [Token(Token = "0x401165A")]
      [FieldOffset(Offset = "0x4")]
      [Range(-0.1f, 0.1f)]
      public float neutralBlackIn;
      [Token(Token = "0x401165B")]
      [FieldOffset(Offset = "0x8")]
      [Range(1f, 20f)]
      public float neutralWhiteIn;
      [Token(Token = "0x401165C")]
      [FieldOffset(Offset = "0xC")]
      [Range(-0.09f, 0.1f)]
      public float neutralBlackOut;
      [Token(Token = "0x401165D")]
      [FieldOffset(Offset = "0x10")]
      [Range(1f, 19f)]
      public float neutralWhiteOut;
      [Token(Token = "0x401165E")]
      [FieldOffset(Offset = "0x14")]
      [Range(0.1f, 20f)]
      public float neutralWhiteLevel;
      [Token(Token = "0x401165F")]
      [FieldOffset(Offset = "0x18")]
      [Range(1f, 10f)]
      public float neutralWhiteClip;

      [Token(Token = "0x17005274")]
      public static ColorGradingModel.TonemappingSettings defaultSettings
      {
        [Token(Token = "0x601998B"), Address(RVA = "0x343B8A4", Offset = "0x343B8A4", VA = "0x343B8A4")] get
        {
          return new ColorGradingModel.TonemappingSettings();
        }
      }
    }

    [Token(Token = "0x2003F8A")]
    [Serializable]
    public struct BasicSettings
    {
      [Token(Token = "0x4011660")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
      public float postExposure;
      [Token(Token = "0x4011661")]
      [FieldOffset(Offset = "0x4")]
      [Range(-100f, 100f)]
      [Tooltip("Sets the white balance to a custom color temperature.")]
      public float temperature;
      [Token(Token = "0x4011662")]
      [FieldOffset(Offset = "0x8")]
      [Range(-100f, 100f)]
      [Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
      public float tint;
      [Token(Token = "0x4011663")]
      [FieldOffset(Offset = "0xC")]
      [Tooltip("Shift the hue of all colors.")]
      [Range(-180f, 180f)]
      public float hueShift;
      [Token(Token = "0x4011664")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("Pushes the intensity of all colors.")]
      [Range(0.0f, 2f)]
      public float saturation;
      [Token(Token = "0x4011665")]
      [FieldOffset(Offset = "0x14")]
      [Tooltip("Expands or shrinks the overall range of tonal values.")]
      [Range(0.0f, 2f)]
      public float contrast;

      [Token(Token = "0x17005275")]
      public static ColorGradingModel.BasicSettings defaultSettings
      {
        [Token(Token = "0x601998C"), Address(RVA = "0x343B8CC", Offset = "0x343B8CC", VA = "0x343B8CC")] get
        {
          return new ColorGradingModel.BasicSettings();
        }
      }
    }

    [Token(Token = "0x2003F8B")]
    [Serializable]
    public struct ChannelMixerSettings
    {
      [Token(Token = "0x4011666")]
      [FieldOffset(Offset = "0x0")]
      public Vector3 red;
      [Token(Token = "0x4011667")]
      [FieldOffset(Offset = "0xC")]
      public Vector3 green;
      [Token(Token = "0x4011668")]
      [FieldOffset(Offset = "0x18")]
      public Vector3 blue;
      [Token(Token = "0x4011669")]
      [FieldOffset(Offset = "0x24")]
      [HideInInspector]
      public int currentEditingChannel;

      [Token(Token = "0x17005276")]
      public static ColorGradingModel.ChannelMixerSettings defaultSettings
      {
        [Token(Token = "0x601998D"), Address(RVA = "0x343B8DC", Offset = "0x343B8DC", VA = "0x343B8DC")] get
        {
          return new ColorGradingModel.ChannelMixerSettings();
        }
      }
    }

    [Token(Token = "0x2003F8C")]
    [Serializable]
    public struct LogWheelsSettings
    {
      [Token(Token = "0x401166A")]
      [FieldOffset(Offset = "0x0")]
      [Trackball("GetSlopeValue")]
      public Color slope;
      [Token(Token = "0x401166B")]
      [FieldOffset(Offset = "0x10")]
      [Trackball("GetPowerValue")]
      public Color power;
      [Token(Token = "0x401166C")]
      [FieldOffset(Offset = "0x20")]
      [Trackball("GetOffsetValue")]
      public Color offset;

      [Token(Token = "0x17005277")]
      public static ColorGradingModel.LogWheelsSettings defaultSettings
      {
        [Token(Token = "0x601998E"), Address(RVA = "0x343B8F4", Offset = "0x343B8F4", VA = "0x343B8F4")] get
        {
          return new ColorGradingModel.LogWheelsSettings();
        }
      }
    }

    [Token(Token = "0x2003F8D")]
    [Serializable]
    public struct LinearWheelsSettings
    {
      [Token(Token = "0x401166D")]
      [FieldOffset(Offset = "0x0")]
      [Trackball("GetLiftValue")]
      public Color lift;
      [Token(Token = "0x401166E")]
      [FieldOffset(Offset = "0x10")]
      [Trackball("GetGammaValue")]
      public Color gamma;
      [Token(Token = "0x401166F")]
      [FieldOffset(Offset = "0x20")]
      [Trackball("GetGainValue")]
      public Color gain;

      [Token(Token = "0x17005278")]
      public static ColorGradingModel.LinearWheelsSettings defaultSettings
      {
        [Token(Token = "0x601998F"), Address(RVA = "0x343B904", Offset = "0x343B904", VA = "0x343B904")] get
        {
          return new ColorGradingModel.LinearWheelsSettings();
        }
      }
    }

    [Token(Token = "0x2003F8E")]
    public enum ColorWheelMode
    {
      [Token(Token = "0x4011671")] Linear,
      [Token(Token = "0x4011672")] Log,
    }

    [Token(Token = "0x2003F8F")]
    [Serializable]
    public struct ColorWheelsSettings
    {
      [Token(Token = "0x4011673")]
      [FieldOffset(Offset = "0x0")]
      public ColorGradingModel.ColorWheelMode mode;
      [Token(Token = "0x4011674")]
      [FieldOffset(Offset = "0x4")]
      [TrackballGroup]
      public ColorGradingModel.LogWheelsSettings log;
      [Token(Token = "0x4011675")]
      [FieldOffset(Offset = "0x34")]
      [TrackballGroup]
      public ColorGradingModel.LinearWheelsSettings linear;

      [Token(Token = "0x17005279")]
      public static ColorGradingModel.ColorWheelsSettings defaultSettings
      {
        [Token(Token = "0x6019990"), Address(RVA = "0x343B914", Offset = "0x343B914", VA = "0x343B914")] get
        {
          return new ColorGradingModel.ColorWheelsSettings();
        }
      }
    }

    [Token(Token = "0x2003F90")]
    [Serializable]
    public struct CurvesSettings
    {
      [Token(Token = "0x4011676")]
      [FieldOffset(Offset = "0x0")]
      public ColorGradingCurve master;
      [Token(Token = "0x4011677")]
      [FieldOffset(Offset = "0x8")]
      public ColorGradingCurve red;
      [Token(Token = "0x4011678")]
      [FieldOffset(Offset = "0x10")]
      public ColorGradingCurve green;
      [Token(Token = "0x4011679")]
      [FieldOffset(Offset = "0x18")]
      public ColorGradingCurve blue;
      [Token(Token = "0x401167A")]
      [FieldOffset(Offset = "0x20")]
      public ColorGradingCurve hueVShue;
      [Token(Token = "0x401167B")]
      [FieldOffset(Offset = "0x28")]
      public ColorGradingCurve hueVSsat;
      [Token(Token = "0x401167C")]
      [FieldOffset(Offset = "0x30")]
      public ColorGradingCurve satVSsat;
      [Token(Token = "0x401167D")]
      [FieldOffset(Offset = "0x38")]
      public ColorGradingCurve lumVSsat;
      [Token(Token = "0x401167E")]
      [FieldOffset(Offset = "0x40")]
      [HideInInspector]
      public int e_CurrentEditingCurve;
      [Token(Token = "0x401167F")]
      [FieldOffset(Offset = "0x44")]
      [HideInInspector]
      public bool e_CurveY;
      [Token(Token = "0x4011680")]
      [FieldOffset(Offset = "0x45")]
      [HideInInspector]
      public bool e_CurveR;
      [Token(Token = "0x4011681")]
      [FieldOffset(Offset = "0x46")]
      [HideInInspector]
      public bool e_CurveG;
      [Token(Token = "0x4011682")]
      [FieldOffset(Offset = "0x47")]
      [HideInInspector]
      public bool e_CurveB;

      [Token(Token = "0x1700527A")]
      public static ColorGradingModel.CurvesSettings defaultSettings
      {
        [Token(Token = "0x6019991"), Address(RVA = "0x343B93C", Offset = "0x343B93C", VA = "0x343B93C")] get
        {
          return new ColorGradingModel.CurvesSettings();
        }
      }
    }

    [Token(Token = "0x2003F91")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x4011683")]
      [FieldOffset(Offset = "0x0")]
      public ColorGradingModel.TonemappingSettings tonemapping;
      [Token(Token = "0x4011684")]
      [FieldOffset(Offset = "0x1C")]
      public ColorGradingModel.BasicSettings basic;
      [Token(Token = "0x4011685")]
      [FieldOffset(Offset = "0x34")]
      public ColorGradingModel.ChannelMixerSettings channelMixer;
      [Token(Token = "0x4011686")]
      [FieldOffset(Offset = "0x5C")]
      public ColorGradingModel.ColorWheelsSettings colorWheels;
      [Token(Token = "0x4011687")]
      [FieldOffset(Offset = "0xC0")]
      public ColorGradingModel.CurvesSettings curves;

      [Token(Token = "0x1700527B")]
      public static ColorGradingModel.Settings defaultSettings
      {
        [Token(Token = "0x6019992"), Address(RVA = "0x343B71C", Offset = "0x343B71C", VA = "0x343B71C")] get
        {
          return new ColorGradingModel.Settings();
        }
      }
    }
  }
}
