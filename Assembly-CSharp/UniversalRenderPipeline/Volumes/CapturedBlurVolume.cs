// Decompiled with JetBrains decompiler
// Type: UniversalRenderPipeline.Volumes.CapturedBlurVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

#nullable disable
namespace UniversalRenderPipeline.Volumes
{
  [Token(Token = "0x20003B6")]
  [VolumeComponentMenu("Staq/PostProcessing/CapturedBlur")]
  public class CapturedBlurVolume : VolumeComponent, IPostProcessComponent
  {
    [Token(Token = "0x4001608")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ClampedFloatParameter offset;
    [Token(Token = "0x4001609")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ClampedFloatParameter blur;

    [Token(Token = "0x6001594")]
    [Address(RVA = "0x2482ADC", Offset = "0x2482ADC", VA = "0x2482ADC", Slot = "8")]
    public bool IsActive() => new bool();

    [Token(Token = "0x6001595")]
    [Address(RVA = "0x2482B78", Offset = "0x2482B78", VA = "0x2482B78", Slot = "9")]
    public bool IsTileCompatible() => new bool();

    [Token(Token = "0x17000236")]
    public float Offset
    {
      [Token(Token = "0x6001596"), Address(RVA = "0x2482B38", Offset = "0x2482B38", VA = "0x2482B38")] get
      {
        return new float();
      }
      [Token(Token = "0x6001597"), Address(RVA = "0x2482B80", Offset = "0x2482B80", VA = "0x2482B80")] set
      {
      }
    }

    [Token(Token = "0x17000237")]
    public float Blur
    {
      [Token(Token = "0x6001598"), Address(RVA = "0x2482B58", Offset = "0x2482B58", VA = "0x2482B58")] get
      {
        return new float();
      }
      [Token(Token = "0x6001599"), Address(RVA = "0x2482BA4", Offset = "0x2482BA4", VA = "0x2482BA4")] set
      {
      }
    }

    [Token(Token = "0x600159A")]
    [Address(RVA = "0x2482BC8", Offset = "0x2482BC8", VA = "0x2482BC8")]
    public CapturedBlurVolume()
    {
    }
  }
}
