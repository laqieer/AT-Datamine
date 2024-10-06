// Decompiled with JetBrains decompiler
// Type: staq.Camera.InertiaPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D81")]
  public class InertiaPosition : Vector3Base
  {
    [Token(Token = "0x4010E1E")]
    [FieldOffset(Offset = "0x20")]
    private Vector3Base Source;
    [Token(Token = "0x4010E1F")]
    [FieldOffset(Offset = "0x28")]
    private float AccelValue;
    [Token(Token = "0x4010E20")]
    [FieldOffset(Offset = "0x2C")]
    private Vector3 Velocity;
    [Token(Token = "0x4010E21")]
    private const float VelocityEpsilon = 0.0001f;

    [Token(Token = "0x6018BE2")]
    [Address(RVA = "0x2648D08", Offset = "0x2648D08", VA = "0x2648D08")]
    public InertiaPosition(Vector3Base source, float accelValue)
    {
    }

    [Token(Token = "0x6018BE3")]
    [Address(RVA = "0x2648DC0", Offset = "0x2648DC0", VA = "0x2648DC0", Slot = "7")]
    public override void GetValue(out Vector3 value)
    {
    }

    [Token(Token = "0x6018BE4")]
    [Address(RVA = "0x2648E4C", Offset = "0x2648E4C", VA = "0x2648E4C", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018BE5")]
    [Address(RVA = "0x2648EA4", Offset = "0x2648EA4", VA = "0x2648EA4", Slot = "5")]
    public override void SetDirty(bool value)
    {
    }

    [Token(Token = "0x6018BE6")]
    [Address(RVA = "0x2648F04", Offset = "0x2648F04", VA = "0x2648F04", Slot = "4")]
    public override void TimeUpdate(float deltaTime)
    {
    }

    [Token(Token = "0x6018BE7")]
    [Address(RVA = "0x2649150", Offset = "0x2649150", VA = "0x2649150", Slot = "11")]
    public override bool GetWaitIdle() => new bool();

    [Token(Token = "0x6018BE8")]
    [Address(RVA = "0x2649170", Offset = "0x2649170", VA = "0x2649170", Slot = "6")]
    public override void RegistContainer(GeometryContainer geometryContainer)
    {
    }

    [Token(Token = "0x6018BE9")]
    [Address(RVA = "0x26491B0", Offset = "0x26491B0", VA = "0x26491B0")]
    public void OnMoveFinish(Vector3 velocity)
    {
    }
  }
}
