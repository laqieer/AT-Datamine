// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.CameraController.RotationCameraController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField.TrackingParameter;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.CameraController
{
  [Token(Token = "0x2001970")]
  public class RotationCameraController : FreeMapCameraControllerBase
  {
    [Token(Token = "0x4006D60")]
    [FieldOffset(Offset = "0x80")]
    private float cameraRotateEaseTime;
    [Token(Token = "0x4006D61")]
    [FieldOffset(Offset = "0x84")]
    private Quaternion cameraRotateFrom;
    [Token(Token = "0x4006D62")]
    [FieldOffset(Offset = "0x94")]
    private Quaternion cameraRotateTo;
    [Token(Token = "0x4006D63")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TrackingRotationParameter rotationParam;

    [Token(Token = "0x600910F")]
    [Address(RVA = "0x4D07CF8", Offset = "0x4D07CF8", VA = "0x4D07CF8", Slot = "4")]
    protected override void InternalInitialize()
    {
    }

    [Token(Token = "0x6009110")]
    [Address(RVA = "0x4D07D4C", Offset = "0x4D07D4C", VA = "0x4D07D4C", Slot = "6")]
    protected override void OnInitTrackingParam()
    {
    }

    [Token(Token = "0x6009111")]
    [Address(RVA = "0x4D07D58", Offset = "0x4D07D58", VA = "0x4D07D58", Slot = "5")]
    protected override void OnBeginInternal()
    {
    }

    [Token(Token = "0x6009112")]
    [Address(RVA = "0x4D07E14", Offset = "0x4D07E14", VA = "0x4D07E14", Slot = "7")]
    protected override void SetCartPositionAndRotation(bool isClip)
    {
    }

    [Token(Token = "0x6009113")]
    [Address(RVA = "0x4D080F0", Offset = "0x4D080F0", VA = "0x4D080F0", Slot = "8")]
    public override CameraControlType GetControlType() => new CameraControlType();

    [Token(Token = "0x6009114")]
    [Address(RVA = "0x4D080F8", Offset = "0x4D080F8", VA = "0x4D080F8")]
    public RotationCameraController()
    {
    }
  }
}
