// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.TrackingParameter.TrackingPositionParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.TrackingParameter
{
  [Token(Token = "0x200195D")]
  [Serializable]
  public class TrackingPositionParameter
  {
    [Token(Token = "0x4006D0D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected Vector3 trackingAngles;
    [Token(Token = "0x4006D0E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    protected float trackingDistance;

    [Token(Token = "0x1700174C")]
    public Vector3 TrackingAngles
    {
      [Token(Token = "0x60090AC"), Address(RVA = "0x4D05108", Offset = "0x4D05108", VA = "0x4D05108")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x1700174D")]
    public float TrackingDistance
    {
      [Token(Token = "0x60090AD"), Address(RVA = "0x4D05114", Offset = "0x4D05114", VA = "0x4D05114")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60090AE")]
    [Address(RVA = "0x4D04BC0", Offset = "0x4D04BC0", VA = "0x4D04BC0")]
    public TrackingPositionParameter()
    {
    }

    [Token(Token = "0x60090AF")]
    [Address(RVA = "0x4D04DDC", Offset = "0x4D04DDC", VA = "0x4D04DDC")]
    public TrackingPositionParameter(TrackingPositionParameter param)
    {
    }

    [Token(Token = "0x60090B0")]
    [Address(RVA = "0x4D04E58", Offset = "0x4D04E58", VA = "0x4D04E58")]
    public void SetValue(Vector3 trackingAngles, float trackingDistance)
    {
    }

    [Token(Token = "0x60090B1")]
    [Address(RVA = "0x4D0511C", Offset = "0x4D0511C", VA = "0x4D0511C", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x60090B2")]
    [Address(RVA = "0x4D051F0", Offset = "0x4D051F0", VA = "0x4D051F0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x60090B3")]
    [Address(RVA = "0x4D051F8", Offset = "0x4D051F8", VA = "0x4D051F8", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
