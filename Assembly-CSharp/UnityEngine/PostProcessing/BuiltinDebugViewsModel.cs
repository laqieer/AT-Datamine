// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.BuiltinDebugViewsModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F80")]
  [Serializable]
  public class BuiltinDebugViewsModel : PostProcessingModel
  {
    [Token(Token = "0x4011639")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private BuiltinDebugViewsModel.Settings m_Settings;

    [Token(Token = "0x1700526A")]
    public BuiltinDebugViewsModel.Settings settings
    {
      [Token(Token = "0x6019974"), Address(RVA = "0x343B4C0", Offset = "0x343B4C0", VA = "0x343B4C0")] get
      {
        return new BuiltinDebugViewsModel.Settings();
      }
      [Token(Token = "0x6019975"), Address(RVA = "0x343B4D0", Offset = "0x343B4D0", VA = "0x343B4D0")] set
      {
      }
    }

    [Token(Token = "0x1700526B")]
    public bool willInterrupt
    {
      [Token(Token = "0x6019976"), Address(RVA = "0x343B4E0", Offset = "0x343B4E0", VA = "0x343B4E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019977")]
    [Address(RVA = "0x343B504", Offset = "0x343B504", VA = "0x343B504", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x6019978")]
    [Address(RVA = "0x342F158", Offset = "0x342F158", VA = "0x342F158")]
    public bool IsModeActive(BuiltinDebugViewsModel.Mode mode) => new bool();

    [Token(Token = "0x6019979")]
    [Address(RVA = "0x343B554", Offset = "0x343B554", VA = "0x343B554")]
    public BuiltinDebugViewsModel()
    {
    }

    [Token(Token = "0x2003F81")]
    [Serializable]
    public struct DepthSettings
    {
      [Token(Token = "0x401163A")]
      [FieldOffset(Offset = "0x0")]
      [Range(0.0f, 1f)]
      [Tooltip("Scales the camera far plane before displaying the depth map.")]
      public float scale;

      [Token(Token = "0x1700526C")]
      public static BuiltinDebugViewsModel.DepthSettings defaultSettings
      {
        [Token(Token = "0x601997A"), Address(RVA = "0x343B580", Offset = "0x343B580", VA = "0x343B580")] get
        {
          return new BuiltinDebugViewsModel.DepthSettings();
        }
      }
    }

    [Token(Token = "0x2003F82")]
    [Serializable]
    public struct MotionVectorsSettings
    {
      [Token(Token = "0x401163B")]
      [FieldOffset(Offset = "0x0")]
      [Range(0.0f, 1f)]
      [Tooltip("Opacity of the source render.")]
      public float sourceOpacity;
      [Token(Token = "0x401163C")]
      [FieldOffset(Offset = "0x4")]
      [Range(0.0f, 1f)]
      [Tooltip("Opacity of the per-pixel motion vector colors.")]
      public float motionImageOpacity;
      [Token(Token = "0x401163D")]
      [FieldOffset(Offset = "0x8")]
      [Min(0.0f)]
      [Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
      public float motionImageAmplitude;
      [Token(Token = "0x401163E")]
      [FieldOffset(Offset = "0xC")]
      [Range(0.0f, 1f)]
      [Tooltip("Opacity for the motion vector arrows.")]
      public float motionVectorsOpacity;
      [Token(Token = "0x401163F")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("The arrow density on screen.")]
      [Range(8f, 64f)]
      public int motionVectorsResolution;
      [Token(Token = "0x4011640")]
      [FieldOffset(Offset = "0x14")]
      [Tooltip("Tweaks the arrows length.")]
      [Min(0.0f)]
      public float motionVectorsAmplitude;

      [Token(Token = "0x1700526D")]
      public static BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings
      {
        [Token(Token = "0x601997B"), Address(RVA = "0x343B588", Offset = "0x343B588", VA = "0x343B588")] get
        {
          return new BuiltinDebugViewsModel.MotionVectorsSettings();
        }
      }
    }

    [Token(Token = "0x2003F83")]
    public enum Mode
    {
      [Token(Token = "0x4011642")] None,
      [Token(Token = "0x4011643")] Depth,
      [Token(Token = "0x4011644")] Normals,
      [Token(Token = "0x4011645")] MotionVectors,
      [Token(Token = "0x4011646")] AmbientOcclusion,
      [Token(Token = "0x4011647")] EyeAdaptation,
      [Token(Token = "0x4011648")] FocusPlane,
      [Token(Token = "0x4011649")] PreGradingLog,
      [Token(Token = "0x401164A")] LogLut,
      [Token(Token = "0x401164B")] UserLut,
    }

    [Token(Token = "0x2003F84")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x401164C")]
      [FieldOffset(Offset = "0x0")]
      public BuiltinDebugViewsModel.Mode mode;
      [Token(Token = "0x401164D")]
      [FieldOffset(Offset = "0x4")]
      public BuiltinDebugViewsModel.DepthSettings depth;
      [Token(Token = "0x401164E")]
      [FieldOffset(Offset = "0x8")]
      public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;

      [Token(Token = "0x1700526E")]
      public static BuiltinDebugViewsModel.Settings defaultSettings
      {
        [Token(Token = "0x601997C"), Address(RVA = "0x343B52C", Offset = "0x343B52C", VA = "0x343B52C")] get
        {
          return new BuiltinDebugViewsModel.Settings();
        }
      }
    }
  }
}
