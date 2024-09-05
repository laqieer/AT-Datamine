// Decompiled with JetBrains decompiler
// Type: EEClientLibraries.CameraInputBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace EEClientLibraries
{
  [Token(Token = "0x2000368")]
  public class CameraInputBase
  {
    [Token(Token = "0x4001419")]
    [FieldOffset(Offset = "0x10")]
    protected Camera currentCamera;
    [Token(Token = "0x400141A")]
    [FieldOffset(Offset = "0x18")]
    protected int touchCount;
    [Token(Token = "0x400141B")]
    [FieldOffset(Offset = "0x1C")]
    protected float swipeDistance;
    [Token(Token = "0x400141C")]
    [FieldOffset(Offset = "0x20")]
    protected float wheelDistance;
    [Token(Token = "0x400141D")]
    [FieldOffset(Offset = "0x24")]
    protected Vector3 cameraRotation;
    [Token(Token = "0x400141E")]
    [FieldOffset(Offset = "0x30")]
    protected Vector3 cameraMove;
    [Token(Token = "0x400141F")]
    [FieldOffset(Offset = "0x3C")]
    public float dumpingRatio;

    [Token(Token = "0x600139A")]
    [Address(RVA = "0x286C768", Offset = "0x286C768", VA = "0x286C768", Slot = "4")]
    protected virtual void DoInitialize()
    {
    }

    [Token(Token = "0x600139B")]
    [Address(RVA = "0x286C76C", Offset = "0x286C76C", VA = "0x286C76C", Slot = "5")]
    protected virtual void DoClearInputParameter()
    {
    }

    [Token(Token = "0x600139C")]
    [Address(RVA = "0x286C770", Offset = "0x286C770", VA = "0x286C770", Slot = "6")]
    protected virtual void DoUpdateParameter()
    {
    }

    [Token(Token = "0x600139D")]
    [Address(RVA = "0x286C774", Offset = "0x286C774", VA = "0x286C774", Slot = "7")]
    protected virtual int CountTouchPoint() => new int();

    [Token(Token = "0x600139E")]
    [Address(RVA = "0x286C77C", Offset = "0x286C77C", VA = "0x286C77C", Slot = "8")]
    protected virtual Vector3 GetTouchPosition(int index) => new Vector3();

    [Token(Token = "0x600139F")]
    [Address(RVA = "0x286C23C", Offset = "0x286C23C", VA = "0x286C23C")]
    public void Initialize(float dumpingRatio, Camera targetCamera)
    {
    }

    [Token(Token = "0x60013A0")]
    [Address(RVA = "0x286C348", Offset = "0x286C348", VA = "0x286C348")]
    public void ClearInputParameter()
    {
    }

    [Token(Token = "0x60013A1")]
    [Address(RVA = "0x286C3D4", Offset = "0x286C3D4", VA = "0x286C3D4")]
    public void UpdateParameter()
    {
    }

    [Token(Token = "0x60013A2")]
    [Address(RVA = "0x286C7C0", Offset = "0x286C7C0", VA = "0x286C7C0")]
    public bool IsTouchingDisplay() => new bool();

    [Token(Token = "0x60013A3")]
    [Address(RVA = "0x286C7E0", Offset = "0x286C7E0", VA = "0x286C7E0")]
    public Vector3 GetTouchPosition() => new Vector3();

    [Token(Token = "0x60013A4")]
    [Address(RVA = "0x286C7F0", Offset = "0x286C7F0", VA = "0x286C7F0")]
    public Vector3 GetCameraRotate() => new Vector3();

    [Token(Token = "0x60013A5")]
    [Address(RVA = "0x286C7FC", Offset = "0x286C7FC", VA = "0x286C7FC")]
    public float TargetDistance() => new float();

    [Token(Token = "0x60013A6")]
    [Address(RVA = "0x286C804", Offset = "0x286C804", VA = "0x286C804")]
    public float TargetWheelDistance() => new float();

    [Token(Token = "0x60013A7")]
    [Address(RVA = "0x286C80C", Offset = "0x286C80C", VA = "0x286C80C")]
    public Vector3 GetCameraMove() => new Vector3();

    [Token(Token = "0x60013A8")]
    [Address(RVA = "0x286C818", Offset = "0x286C818", VA = "0x286C818")]
    protected bool Neary0(float value) => new bool();

    [Token(Token = "0x60013A9")]
    [Address(RVA = "0x286C878", Offset = "0x286C878", VA = "0x286C878")]
    public CameraInputBase()
    {
    }
  }
}
