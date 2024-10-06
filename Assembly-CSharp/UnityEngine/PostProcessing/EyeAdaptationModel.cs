// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.EyeAdaptationModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F97")]
  [Serializable]
  public class EyeAdaptationModel : PostProcessingModel
  {
    [Token(Token = "0x4011694")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private EyeAdaptationModel.Settings m_Settings;

    [Token(Token = "0x17005280")]
    public EyeAdaptationModel.Settings settings
    {
      [Token(Token = "0x601999D"), Address(RVA = "0x343C070", Offset = "0x343C070", VA = "0x343C070")] get
      {
        return new EyeAdaptationModel.Settings();
      }
      [Token(Token = "0x601999E"), Address(RVA = "0x343C088", Offset = "0x343C088", VA = "0x343C088")] set
      {
      }
    }

    [Token(Token = "0x601999F")]
    [Address(RVA = "0x343C0A8", Offset = "0x343C0A8", VA = "0x343C0A8", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x60199A0")]
    [Address(RVA = "0x343C12C", Offset = "0x343C12C", VA = "0x343C12C")]
    public EyeAdaptationModel()
    {
    }

    [Token(Token = "0x2003F98")]
    public enum EyeAdaptationType
    {
      [Token(Token = "0x4011696")] Progressive,
      [Token(Token = "0x4011697")] Fixed,
    }

    [Token(Token = "0x2003F99")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x4011698")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Filters the dark part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
      [Range(1f, 99f)]
      public float lowPercent;
      [Token(Token = "0x4011699")]
      [FieldOffset(Offset = "0x4")]
      [Range(1f, 99f)]
      [Tooltip("Filters the bright part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
      public float highPercent;
      [Token(Token = "0x401169A")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Minimum average luminance to consider for auto exposure (in EV).")]
      public float minLuminance;
      [Token(Token = "0x401169B")]
      [FieldOffset(Offset = "0xC")]
      [Tooltip("Maximum average luminance to consider for auto exposure (in EV).")]
      public float maxLuminance;
      [Token(Token = "0x401169C")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("Exposure bias. Use this to offset the global exposure of the scene.")]
      [Min(0.0f)]
      public float keyValue;
      [Token(Token = "0x401169D")]
      [FieldOffset(Offset = "0x14")]
      [Tooltip("Set this to true to let Unity handle the key value automatically based on average luminance.")]
      public bool dynamicKeyValue;
      [Token(Token = "0x401169E")]
      [FieldOffset(Offset = "0x18")]
      [Tooltip("Use \"Progressive\" if you want the auto exposure to be animated. Use \"Fixed\" otherwise.")]
      public EyeAdaptationModel.EyeAdaptationType adaptationType;
      [Token(Token = "0x401169F")]
      [FieldOffset(Offset = "0x1C")]
      [Tooltip("Adaptation speed from a dark to a light environment.")]
      [Min(0.0f)]
      public float speedUp;
      [Token(Token = "0x40116A0")]
      [FieldOffset(Offset = "0x20")]
      [Min(0.0f)]
      [Tooltip("Adaptation speed from a light to a dark environment.")]
      public float speedDown;
      [Token(Token = "0x40116A1")]
      [FieldOffset(Offset = "0x24")]
      [Tooltip("Lower bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
      [Range(-16f, -1f)]
      public int logMin;
      [Token(Token = "0x40116A2")]
      [FieldOffset(Offset = "0x28")]
      [Tooltip("Upper bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
      [Range(1f, 16f)]
      public int logMax;

      [Token(Token = "0x17005281")]
      public static EyeAdaptationModel.Settings defaultSettings
      {
        [Token(Token = "0x60199A1"), Address(RVA = "0x343C0E8", Offset = "0x343C0E8", VA = "0x343C0E8")] get
        {
          return new EyeAdaptationModel.Settings();
        }
      }
    }
  }
}
