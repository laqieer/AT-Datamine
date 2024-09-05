// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.TrackingParameter.TrackingMoveOffsetParameter
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
  [Token(Token = "0x200195C")]
  [Serializable]
  public class TrackingMoveOffsetParameter
  {
    [Token(Token = "0x4006D08")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected float positionOffsetChangeTime;
    [Token(Token = "0x4006D09")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    protected float positionOffsetZPlus;
    [Token(Token = "0x4006D0A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public EasingCalc.EaseType easyingPositionOffsetZPlus;
    [Token(Token = "0x4006D0B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    protected float positionOffsetZMinus;
    [Token(Token = "0x4006D0C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public EasingCalc.EaseType easyingPositionOffsetZMinus;

    [Token(Token = "0x17001749")]
    public float PositionOffsetChangeTime
    {
      [Token(Token = "0x60090A8"), Address(RVA = "0x4D050D4", Offset = "0x4D050D4", VA = "0x4D050D4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700174A")]
    public float PositionOffsetZPlus
    {
      [Token(Token = "0x60090A9"), Address(RVA = "0x4D050DC", Offset = "0x4D050DC", VA = "0x4D050DC")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700174B")]
    public float PositionOffsetZMinus
    {
      [Token(Token = "0x60090AA"), Address(RVA = "0x4D050E4", Offset = "0x4D050E4", VA = "0x4D050E4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60090AB")]
    [Address(RVA = "0x4D050EC", Offset = "0x4D050EC", VA = "0x4D050EC")]
    public TrackingMoveOffsetParameter()
    {
    }
  }
}
