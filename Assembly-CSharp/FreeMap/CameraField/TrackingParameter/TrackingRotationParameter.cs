// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.TrackingParameter.TrackingRotationParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField.CameraController;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.TrackingParameter
{
  [Token(Token = "0x200195E")]
  [Serializable]
  public class TrackingRotationParameter
  {
    [Token(Token = "0x4006D0F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private TrackingRotationParameter.TrackingRotType trackingType;
    [Token(Token = "0x4006D10")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private float trackingRotateSpeed;
    [Token(Token = "0x4006D11")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float rotateEasingDuration;
    [Token(Token = "0x4006D12")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private EasingCalc.EaseType rotateEasingType;

    [Token(Token = "0x1700174E")]
    public TrackingRotationParameter.TrackingRotType TrakingType
    {
      [Token(Token = "0x60090B4"), Address(RVA = "0x4D052BC", Offset = "0x4D052BC", VA = "0x4D052BC")] get
      {
        return new TrackingRotationParameter.TrackingRotType();
      }
    }

    [Token(Token = "0x1700174F")]
    public float TrackingRotateSpeed
    {
      [Token(Token = "0x60090B5"), Address(RVA = "0x4D052C4", Offset = "0x4D052C4", VA = "0x4D052C4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001750")]
    public float RotateEasingDuration
    {
      [Token(Token = "0x60090B6"), Address(RVA = "0x4D052CC", Offset = "0x4D052CC", VA = "0x4D052CC")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001751")]
    public EasingCalc.EaseType RotateEasingType
    {
      [Token(Token = "0x60090B7"), Address(RVA = "0x4D052D4", Offset = "0x4D052D4", VA = "0x4D052D4")] get
      {
        return new EasingCalc.EaseType();
      }
    }

    [Token(Token = "0x60090B8")]
    [Address(RVA = "0x4D052DC", Offset = "0x4D052DC", VA = "0x4D052DC")]
    public TrackingRotationParameter()
    {
    }

    [Token(Token = "0x200195F")]
    public enum TrackingRotType
    {
      [Token(Token = "0x4006D14")] SpeedComplement,
      [Token(Token = "0x4006D15")] Easing,
    }
  }
}
