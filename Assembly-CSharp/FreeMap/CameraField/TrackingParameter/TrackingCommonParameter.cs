// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.TrackingParameter.TrackingCommonParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.TrackingParameter
{
  [Token(Token = "0x2001959")]
  [Serializable]
  public class TrackingCommonParameter
  {
    [Token(Token = "0x4006CFB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected Vector3 trackingOffset;
    [Token(Token = "0x4006CFC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    protected float cameraFieldOfView;

    [Token(Token = "0x17001741")]
    public Vector3 TrackingOffset
    {
      [Token(Token = "0x600908A"), Address(RVA = "0x4D0407C", Offset = "0x4D0407C", VA = "0x4D0407C")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17001742")]
    public float CameraFOV
    {
      [Token(Token = "0x600908B"), Address(RVA = "0x4D04088", Offset = "0x4D04088", VA = "0x4D04088")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600908C")]
    [Address(RVA = "0x4D04090", Offset = "0x4D04090", VA = "0x4D04090")]
    public TrackingCommonParameter()
    {
    }

    [Token(Token = "0x600908D")]
    [Address(RVA = "0x4D040F8", Offset = "0x4D040F8", VA = "0x4D040F8")]
    public TrackingCommonParameter(TrackingCommonParameter origin)
    {
    }

    [Token(Token = "0x600908E")]
    [Address(RVA = "0x4D04144", Offset = "0x4D04144", VA = "0x4D04144")]
    public void SetValue(Vector3 trackingOffset, float cameraFoV)
    {
    }

    [Token(Token = "0x600908F")]
    [Address(RVA = "0x4D04150", Offset = "0x4D04150", VA = "0x4D04150", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6009090")]
    [Address(RVA = "0x4D04158", Offset = "0x4D04158", VA = "0x4D04158", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6009091")]
    [Address(RVA = "0x4D0422C", Offset = "0x4D0422C", VA = "0x4D0422C", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
