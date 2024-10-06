// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.DepthOfFieldModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F92")]
  [Serializable]
  public class DepthOfFieldModel : PostProcessingModel
  {
    [Token(Token = "0x4011688")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private DepthOfFieldModel.Settings m_Settings;

    [Token(Token = "0x1700527C")]
    public DepthOfFieldModel.Settings settings
    {
      [Token(Token = "0x6019993"), Address(RVA = "0x343BF94", Offset = "0x343BF94", VA = "0x343BF94")] get
      {
        return new DepthOfFieldModel.Settings();
      }
      [Token(Token = "0x6019994"), Address(RVA = "0x343BFA8", Offset = "0x343BFA8", VA = "0x343BFA8")] set
      {
      }
    }

    [Token(Token = "0x6019995")]
    [Address(RVA = "0x343BFBC", Offset = "0x343BFBC", VA = "0x343BFBC", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x6019996")]
    [Address(RVA = "0x343C014", Offset = "0x343C014", VA = "0x343C014")]
    public DepthOfFieldModel()
    {
    }

    [Token(Token = "0x2003F93")]
    public enum KernelSize
    {
      [Token(Token = "0x401168A")] Small,
      [Token(Token = "0x401168B")] Medium,
      [Token(Token = "0x401168C")] Large,
      [Token(Token = "0x401168D")] VeryLarge,
    }

    [Token(Token = "0x2003F94")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x401168E")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Distance to the point of focus.")]
      [Min(0.1f)]
      public float focusDistance;
      [Token(Token = "0x401168F")]
      [FieldOffset(Offset = "0x4")]
      [Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
      [Range(0.05f, 32f)]
      public float aperture;
      [Token(Token = "0x4011690")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
      [Range(1f, 300f)]
      public float focalLength;
      [Token(Token = "0x4011691")]
      [FieldOffset(Offset = "0xC")]
      [Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
      public bool useCameraFov;
      [Token(Token = "0x4011692")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
      public DepthOfFieldModel.KernelSize kernelSize;

      [Token(Token = "0x1700527D")]
      public static DepthOfFieldModel.Settings defaultSettings
      {
        [Token(Token = "0x6019997"), Address(RVA = "0x343BFE8", Offset = "0x343BFE8", VA = "0x343BFE8")] get
        {
          return new DepthOfFieldModel.Settings();
        }
      }
    }
  }
}
