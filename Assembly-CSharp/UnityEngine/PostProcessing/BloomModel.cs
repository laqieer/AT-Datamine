// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.BloomModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F7C")]
  [Serializable]
  public class BloomModel : PostProcessingModel
  {
    [Token(Token = "0x401162F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BloomModel.Settings m_Settings;

    [Token(Token = "0x17005265")]
    public BloomModel.Settings settings
    {
      [Token(Token = "0x601996B"), Address(RVA = "0x343B3D0", Offset = "0x343B3D0", VA = "0x343B3D0")] get
      {
        return new BloomModel.Settings();
      }
      [Token(Token = "0x601996C"), Address(RVA = "0x343B3E8", Offset = "0x343B3E8", VA = "0x343B3E8")] set
      {
      }
    }

    [Token(Token = "0x601996D")]
    [Address(RVA = "0x343B400", Offset = "0x343B400", VA = "0x343B400", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x601996E")]
    [Address(RVA = "0x343B450", Offset = "0x343B450", VA = "0x343B450")]
    public BloomModel()
    {
    }

    [Token(Token = "0x2003F7D")]
    [Serializable]
    public struct BloomSettings
    {
      [Token(Token = "0x4011630")]
      [FieldOffset(Offset = "0x0")]
      [Min(0.0f)]
      [Tooltip("Strength of the bloom filter.")]
      public float intensity;
      [Token(Token = "0x4011631")]
      [FieldOffset(Offset = "0x4")]
      [Min(0.0f)]
      [Tooltip("Filters out pixels under this level of brightness.")]
      public float threshold;
      [Token(Token = "0x4011632")]
      [FieldOffset(Offset = "0x8")]
      [Range(0.0f, 1f)]
      [Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
      public float softKnee;
      [Token(Token = "0x4011633")]
      [FieldOffset(Offset = "0xC")]
      [Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
      [Range(1f, 7f)]
      public float radius;
      [Token(Token = "0x4011634")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("Reduces flashing noise with an additional filter.")]
      public bool antiFlicker;

      [Token(Token = "0x17005266")]
      public float thresholdLinear
      {
        [Token(Token = "0x601996F"), Address(RVA = "0x343B47C", Offset = "0x343B47C", VA = "0x343B47C")] set
        {
        }
        [Token(Token = "0x6019970"), Address(RVA = "0x342EE50", Offset = "0x342EE50", VA = "0x342EE50")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x17005267")]
      public static BloomModel.BloomSettings defaultSettings
      {
        [Token(Token = "0x6019971"), Address(RVA = "0x343B498", Offset = "0x343B498", VA = "0x343B498")] get
        {
          return new BloomModel.BloomSettings();
        }
      }
    }

    [Token(Token = "0x2003F7E")]
    [Serializable]
    public struct LensDirtSettings
    {
      [Token(Token = "0x4011635")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
      public Texture texture;
      [Token(Token = "0x4011636")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Amount of lens dirtiness.")]
      [Min(0.0f)]
      public float intensity;

      [Token(Token = "0x17005268")]
      public static BloomModel.LensDirtSettings defaultSettings
      {
        [Token(Token = "0x6019972"), Address(RVA = "0x343B4B4", Offset = "0x343B4B4", VA = "0x343B4B4")] get
        {
          return new BloomModel.LensDirtSettings();
        }
      }
    }

    [Token(Token = "0x2003F7F")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x4011637")]
      [FieldOffset(Offset = "0x0")]
      public BloomModel.BloomSettings bloom;
      [Token(Token = "0x4011638")]
      [FieldOffset(Offset = "0x18")]
      public BloomModel.LensDirtSettings lensDirt;

      [Token(Token = "0x17005269")]
      public static BloomModel.Settings defaultSettings
      {
        [Token(Token = "0x6019973"), Address(RVA = "0x343B428", Offset = "0x343B428", VA = "0x343B428")] get
        {
          return new BloomModel.Settings();
        }
      }
    }
  }
}
