// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.MotionBlurModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F9E")]
  [Serializable]
  public class MotionBlurModel : PostProcessingModel
  {
    [Token(Token = "0x40116AA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private MotionBlurModel.Settings m_Settings;

    [Token(Token = "0x17005286")]
    public MotionBlurModel.Settings settings
    {
      [Token(Token = "0x60199AC"), Address(RVA = "0x343C1FC", Offset = "0x343C1FC", VA = "0x343C1FC")] get
      {
        return new MotionBlurModel.Settings();
      }
      [Token(Token = "0x60199AD"), Address(RVA = "0x343C20C", Offset = "0x343C20C", VA = "0x343C20C")] set
      {
      }
    }

    [Token(Token = "0x60199AE")]
    [Address(RVA = "0x343C218", Offset = "0x343C218", VA = "0x343C218", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x60199AF")]
    [Address(RVA = "0x343C23C", Offset = "0x343C23C", VA = "0x343C23C")]
    public MotionBlurModel()
    {
    }

    [Token(Token = "0x2003F9F")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x40116AB")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
      [Range(0.0f, 360f)]
      public float shutterAngle;
      [Token(Token = "0x40116AC")]
      [FieldOffset(Offset = "0x4")]
      [Range(4f, 32f)]
      [Tooltip("The amount of sample points, which affects quality and performances.")]
      public int sampleCount;
      [Token(Token = "0x40116AD")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
      [Range(0.0f, 1f)]
      public float frameBlending;

      [Token(Token = "0x17005287")]
      public static MotionBlurModel.Settings defaultSettings
      {
        [Token(Token = "0x60199B0"), Address(RVA = "0x343C22C", Offset = "0x343C22C", VA = "0x343C22C")] get
        {
          return new MotionBlurModel.Settings();
        }
      }
    }
  }
}
