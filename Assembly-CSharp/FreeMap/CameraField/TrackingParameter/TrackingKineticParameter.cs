// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.TrackingParameter.TrackingKineticParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.TrackingParameter
{
  [Token(Token = "0x200195B")]
  [Serializable]
  public class TrackingKineticParameter
  {
    [Token(Token = "0x4006D04")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private BoxCollider kineticCollider;
    [Token(Token = "0x4006D05")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TrackingCommonParameter commonParameter;
    [Token(Token = "0x4006D06")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TrackingPositionParameter positionParameter;
    [Token(Token = "0x4006D07")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private float changeTime;

    [Token(Token = "0x17001745")]
    public BoxCollider KineticCollider
    {
      [Token(Token = "0x600909B"), Address(RVA = "0x4D04AC8", Offset = "0x4D04AC8", VA = "0x4D04AC8")] get
      {
        return (BoxCollider) null;
      }
    }

    [Token(Token = "0x17001746")]
    public TrackingCommonParameter CommonParam
    {
      [Token(Token = "0x600909C"), Address(RVA = "0x4D04AD0", Offset = "0x4D04AD0", VA = "0x4D04AD0")] get
      {
        return (TrackingCommonParameter) null;
      }
    }

    [Token(Token = "0x17001747")]
    public TrackingPositionParameter PositionParam
    {
      [Token(Token = "0x600909D"), Address(RVA = "0x4D04AD8", Offset = "0x4D04AD8", VA = "0x4D04AD8")] get
      {
        return (TrackingPositionParameter) null;
      }
    }

    [Token(Token = "0x17001748")]
    public float ChangeTime
    {
      [Token(Token = "0x600909E"), Address(RVA = "0x4D04AE0", Offset = "0x4D04AE0", VA = "0x4D04AE0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600909F")]
    [Address(RVA = "0x4D04AE8", Offset = "0x4D04AE8", VA = "0x4D04AE8")]
    public TrackingKineticParameter()
    {
    }

    [Token(Token = "0x60090A0")]
    [Address(RVA = "0x4D04C28", Offset = "0x4D04C28", VA = "0x4D04C28")]
    public TrackingKineticParameter(
      TrackingCommonParameter commonParameter,
      TrackingPositionParameter positionParameter,
      float changeTime)
    {
    }

    [Token(Token = "0x60090A1")]
    [Address(RVA = "0x4D04CF0", Offset = "0x4D04CF0", VA = "0x4D04CF0")]
    public TrackingKineticParameter(TrackingKineticParameter origin)
    {
    }

    [Token(Token = "0x60090A2")]
    [Address(RVA = "0x4D04E28", Offset = "0x4D04E28", VA = "0x4D04E28")]
    public void SetValue(
      Vector3 trackingOffset,
      float cameraFoV,
      Vector3 trackingAngles,
      float trackingDistance)
    {
    }

    [Token(Token = "0x60090A3")]
    [Address(RVA = "0x4D04E64", Offset = "0x4D04E64", VA = "0x4D04E64")]
    public void SetChangeTime(float changeTime)
    {
    }

    [Token(Token = "0x60090A4")]
    [Address(RVA = "0x4D04E74", Offset = "0x4D04E74", VA = "0x4D04E74")]
    public bool Contains(Vector3 target) => new bool();

    [Token(Token = "0x60090A5")]
    [Address(RVA = "0x4D04F54", Offset = "0x4D04F54", VA = "0x4D04F54")]
    public float NearDistance(Vector3 target) => new float();

    [Token(Token = "0x60090A6")]
    [Address(RVA = "0x4D04FD0", Offset = "0x4D04FD0", VA = "0x4D04FD0")]
    public bool IsEqualValue(TrackingKineticParameter param) => new bool();

    [Token(Token = "0x60090A7")]
    [Address(RVA = "0x4D05034", Offset = "0x4D05034", VA = "0x4D05034", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
