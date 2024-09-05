// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.CameraController.PositionCameraController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField.TrackingParameter;
using FreeMap.Instance;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.CameraController
{
  [Token(Token = "0x2001967")]
  public class PositionCameraController : FreeMapCameraControllerBase
  {
    [Token(Token = "0x4006D30")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TrackingPositionParameter positionParam;
    [Token(Token = "0x4006D31")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TrackingMoveOffsetParameter moveOffsetParam;
    [Token(Token = "0x4006D32")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TrackingExtendColliderParameter extendCollider;
    [Token(Token = "0x4006D33")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private bool isRotation;
    [Token(Token = "0x4006D34")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private float changeKinecticParamTime;
    [Token(Token = "0x4006D35")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TrackingRotationParameter rotationParam;
    [Token(Token = "0x4006D36")]
    [FieldOffset(Offset = "0xA8")]
    private FreeMapPlayerInstance player;
    [Token(Token = "0x4006D37")]
    [FieldOffset(Offset = "0xB0")]
    private float cameraRotateEaseTime;
    [Token(Token = "0x4006D38")]
    [FieldOffset(Offset = "0xB4")]
    private Quaternion cameraRotateFrom;
    [Token(Token = "0x4006D39")]
    [FieldOffset(Offset = "0xC4")]
    private Quaternion cameraRotateTo;
    [Token(Token = "0x4006D3A")]
    [FieldOffset(Offset = "0xD8")]
    private TrackingKineticParameter defaultKineticParam;
    [Token(Token = "0x4006D3B")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private KinecticParameterField[] kineticParameters;
    [Token(Token = "0x4006D3C")]
    [FieldOffset(Offset = "0xE8")]
    private PositionCameraController.KineticParameterHandler kineticChangeHandler;
    [Token(Token = "0x4006D3D")]
    private const float PlusOffsetAngleMin = 45f;
    [Token(Token = "0x4006D3E")]
    private const float PlusOffsetAngleMax = 315f;
    [Token(Token = "0x4006D3F")]
    private const float MinusOffsetAngleMin = 135f;
    [Token(Token = "0x4006D40")]
    private const float MinusOffsetAngleMax = 225f;
    [Token(Token = "0x4006D41")]
    [FieldOffset(Offset = "0xF0")]
    private PositionCameraController.PositionOffsetHandler zplusOffsetHandler;
    [Token(Token = "0x4006D42")]
    [FieldOffset(Offset = "0xF8")]
    private PositionCameraController.PositionOffsetHandler zMinusOffsetHandler;

    [Token(Token = "0x17001757")]
    public IReadOnlyList<BoxCollider> ExtendColliderList
    {
      [Token(Token = "0x60090E5"), Address(RVA = "0x4D06194", Offset = "0x4D06194", VA = "0x4D06194")] get
      {
        return (IReadOnlyList<BoxCollider>) null;
      }
    }

    [Token(Token = "0x17001758")]
    public bool IsRotation
    {
      [Token(Token = "0x60090E6"), Address(RVA = "0x4D061AC", Offset = "0x4D061AC", VA = "0x4D061AC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001759")]
    public IReadOnlyList<KinecticParameterField> KineticList
    {
      [Token(Token = "0x60090E7"), Address(RVA = "0x4D061B4", Offset = "0x4D061B4", VA = "0x4D061B4")] get
      {
        return (IReadOnlyList<KinecticParameterField>) null;
      }
    }

    [Token(Token = "0x60090E8")]
    [Address(RVA = "0x4D061BC", Offset = "0x4D061BC", VA = "0x4D061BC", Slot = "4")]
    protected override void InternalInitialize()
    {
    }

    [Token(Token = "0x60090E9")]
    [Address(RVA = "0x4D06328", Offset = "0x4D06328", VA = "0x4D06328", Slot = "6")]
    protected override void OnInitTrackingParam()
    {
    }

    [Token(Token = "0x60090EA")]
    [Address(RVA = "0x4D06378", Offset = "0x4D06378", VA = "0x4D06378", Slot = "5")]
    protected override void OnBeginInternal()
    {
    }

    [Token(Token = "0x60090EB")]
    [Address(RVA = "0x4D06434", Offset = "0x4D06434", VA = "0x4D06434", Slot = "7")]
    protected override void SetCartPositionAndRotation(bool isClip)
    {
    }

    [Token(Token = "0x60090EC")]
    [Address(RVA = "0x4D06664", Offset = "0x4D06664", VA = "0x4D06664")]
    private void CalcPositionAndRotation(
      TrackingPositionParameter positionParam,
      TrackingCommonParameter commonParam,
      bool isClip)
    {
    }

    [Token(Token = "0x60090ED")]
    [Address(RVA = "0x4D06DF8", Offset = "0x4D06DF8", VA = "0x4D06DF8", Slot = "8")]
    public override CameraControlType GetControlType() => new CameraControlType();

    [Token(Token = "0x60090EE")]
    [Address(RVA = "0x4D06E00", Offset = "0x4D06E00", VA = "0x4D06E00")]
    public void AddExtendBoxCollider(BoxCollider collider)
    {
    }

    [Token(Token = "0x60090EF")]
    [Address(RVA = "0x4D06E18", Offset = "0x4D06E18", VA = "0x4D06E18")]
    public PositionCameraController()
    {
    }

    [Token(Token = "0x2001968")]
    protected class KineticParameterHandler
    {
      [Token(Token = "0x4006D43")]
      [FieldOffset(Offset = "0x10")]
      private TrackingKineticParameter currentKineticParam;
      [Token(Token = "0x4006D44")]
      [FieldOffset(Offset = "0x18")]
      private TrackingKineticParameter startParam;
      [Token(Token = "0x4006D45")]
      [FieldOffset(Offset = "0x20")]
      private TrackingKineticParameter endParam;
      [Token(Token = "0x4006D46")]
      [FieldOffset(Offset = "0x28")]
      private float currentChangeValue;

      [Token(Token = "0x1700175A")]
      public TrackingKineticParameter CurrentParam
      {
        [Token(Token = "0x60090F0"), Address(RVA = "0x4D0710C", Offset = "0x4D0710C", VA = "0x4D0710C")] get
        {
          return (TrackingKineticParameter) null;
        }
      }

      [Token(Token = "0x60090F1")]
      [Address(RVA = "0x4D062BC", Offset = "0x4D062BC", VA = "0x4D062BC")]
      public void SetParameter(TrackingKineticParameter param)
      {
      }

      [Token(Token = "0x60090F2")]
      [Address(RVA = "0x4D0635C", Offset = "0x4D0635C", VA = "0x4D0635C")]
      public void SetTrakingKineticProgress(float ratio)
      {
      }

      [Token(Token = "0x60090F3")]
      [Address(RVA = "0x4D0655C", Offset = "0x4D0655C", VA = "0x4D0655C")]
      public void SetChangeParameter(TrackingKineticParameter changeParam)
      {
      }

      [Token(Token = "0x60090F4")]
      [Address(RVA = "0x4D065E0", Offset = "0x4D065E0", VA = "0x4D065E0")]
      public void ChangeUpdate()
      {
      }

      [Token(Token = "0x60090F5")]
      [Address(RVA = "0x4D07114", Offset = "0x4D07114", VA = "0x4D07114")]
      private void Lerp(float ratio)
      {
      }

      [Token(Token = "0x60090F6")]
      [Address(RVA = "0x4D070DC", Offset = "0x4D070DC", VA = "0x4D070DC")]
      public KineticParameterHandler()
      {
      }
    }

    [Token(Token = "0x2001969")]
    protected class PositionOffsetHandler
    {
      [Token(Token = "0x4006D47")]
      [FieldOffset(Offset = "0x10")]
      private float changeTime;
      [Token(Token = "0x4006D48")]
      [FieldOffset(Offset = "0x18")]
      private Func<float, bool> isActiveAngle;

      [Token(Token = "0x60090F7")]
      [Address(RVA = "0x4D070E4", Offset = "0x4D070E4", VA = "0x4D070E4")]
      public PositionOffsetHandler(Func<float, bool> offsetActiveAction)
      {
      }

      [Token(Token = "0x60090F8")]
      [Address(RVA = "0x4D06BE8", Offset = "0x4D06BE8", VA = "0x4D06BE8")]
      public Vector3 CalcOffsetPosition(
        Transform cameraCart,
        FreeMapPlayerInstance player,
        float offsetTime,
        float offsetValue,
        EasingCalc.EaseType easeType = EasingCalc.EaseType.Linear)
      {
        return new Vector3();
      }
    }
  }
}
