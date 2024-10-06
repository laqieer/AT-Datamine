// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.FreeMapOverrideCameraTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField.CameraController;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField
{
  [Token(Token = "0x2001955")]
  public class FreeMapOverrideCameraTransform : OverrideCameraBase
  {
    [Token(Token = "0x4006CE1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private FreeMapOverrideCameraTransform.FreeMapTransformCameraParameter overrideTransformParam;
    [Token(Token = "0x4006CE2")]
    [FieldOffset(Offset = "0x30")]
    private FreeMapOverrideCameraTransform.FreeMapTransformCameraParameter backupParameter;

    [Token(Token = "0x600906D")]
    [Address(RVA = "0x4AFFBAC", Offset = "0x4AFFBAC", VA = "0x4AFFBAC")]
    public void Initialize(
      Vector3 position,
      Vector3 angle,
      float fov,
      bool absoluteFOV,
      Transform target,
      CameraViewPositionReferenceEnum reference)
    {
    }

    [Token(Token = "0x600906E")]
    [Address(RVA = "0x4B1902C", Offset = "0x4B1902C", VA = "0x4B1902C", Slot = "4")]
    public override void SetTargetTransform(Transform target)
    {
    }

    [Token(Token = "0x600906F")]
    [Address(RVA = "0x4B1903C", Offset = "0x4B1903C", VA = "0x4B1903C", Slot = "5")]
    public override void ChangeCamera(FreeMapCameraControllerBase target)
    {
    }

    [Token(Token = "0x6009070")]
    [Address(RVA = "0x4B1924C", Offset = "0x4B1924C", VA = "0x4B1924C", Slot = "6")]
    public override void RevertCamera(FreeMapCameraControllerBase target)
    {
    }

    [Token(Token = "0x6009071")]
    [Address(RVA = "0x4B191C4", Offset = "0x4B191C4", VA = "0x4B191C4")]
    private IEnumerator ChangeTransformCoroutine(
      FreeMapCameraControllerBase target,
      FreeMapOverrideCameraTransform.FreeMapTransformCameraParameter start,
      FreeMapOverrideCameraTransform.FreeMapTransformCameraParameter end)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6009072")]
    [Address(RVA = "0x4B193E4", Offset = "0x4B193E4", VA = "0x4B193E4")]
    private IEnumerator RevertCoroutine(
      FreeMapCameraControllerBase target,
      FreeMapOverrideCameraTransform.FreeMapTransformCameraParameter start,
      FreeMapOverrideCameraTransform.FreeMapTransformCameraParameter end)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6009073")]
    [Address(RVA = "0x4B19494", Offset = "0x4B19494", VA = "0x4B19494")]
    public FreeMapOverrideCameraTransform()
    {
    }

    [Token(Token = "0x2001956")]
    [Serializable]
    public class FreeMapTransformCameraParameter
    {
      [Token(Token = "0x4006CE3")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Transform targetTransform;
      [Token(Token = "0x4006CE4")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private Vector3 overridePosition;
      [Token(Token = "0x4006CE5")]
      [FieldOffset(Offset = "0x24")]
      [SerializeField]
      private Vector3 overrideAngle;
      [Token(Token = "0x4006CE6")]
      [FieldOffset(Offset = "0x30")]
      [SerializeField]
      private float overrideFOV;
      [Token(Token = "0x4006CE7")]
      [FieldOffset(Offset = "0x34")]
      [SerializeField]
      private bool absoluteFOV;
      [Token(Token = "0x4006CE8")]
      [FieldOffset(Offset = "0x38")]
      [SerializeField]
      private CameraViewPositionReferenceEnum referencePosition;

      [Token(Token = "0x17001737")]
      public Vector3 OverridePosition
      {
        [Token(Token = "0x6009074"), Address(RVA = "0x4B194A4", Offset = "0x4B194A4", VA = "0x4B194A4")] get
        {
          return new Vector3();
        }
      }

      [Token(Token = "0x17001738")]
      public Vector3 OverrideAngle
      {
        [Token(Token = "0x6009075"), Address(RVA = "0x4B195BC", Offset = "0x4B195BC", VA = "0x4B195BC")] get
        {
          return new Vector3();
        }
      }

      [Token(Token = "0x17001739")]
      public Quaternion OverrideQuaternion
      {
        [Token(Token = "0x6009076"), Address(RVA = "0x4B19668", Offset = "0x4B19668", VA = "0x4B19668")] get
        {
          return new Quaternion();
        }
      }

      [Token(Token = "0x1700173A")]
      public float OverrideFOV
      {
        [Token(Token = "0x6009077"), Address(RVA = "0x4B19690", Offset = "0x4B19690", VA = "0x4B19690")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x1700173B")]
      public bool AbsoluteFOV
      {
        [Token(Token = "0x6009078"), Address(RVA = "0x4B19698", Offset = "0x4B19698", VA = "0x4B19698")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700173C")]
      public CameraViewPositionReferenceEnum ReferencePosition
      {
        [Token(Token = "0x6009079"), Address(RVA = "0x4B196A0", Offset = "0x4B196A0", VA = "0x4B196A0")] get
        {
          return new CameraViewPositionReferenceEnum();
        }
      }

      [Token(Token = "0x600907A")]
      [Address(RVA = "0x4B19008", Offset = "0x4B19008", VA = "0x4B19008")]
      public void SetParameter(
        Vector3 position,
        Vector3 angle,
        float fov,
        bool absoluteFOV,
        Transform target = null,
        CameraViewPositionReferenceEnum reference = CameraViewPositionReferenceEnum.Default)
      {
      }

      [Token(Token = "0x600907B")]
      [Address(RVA = "0x4B196A8", Offset = "0x4B196A8", VA = "0x4B196A8")]
      public void UpdateParameter(
        Vector3 position,
        Vector3 angle,
        float fov,
        bool absoluteFOV,
        CameraViewPositionReferenceEnum reference = CameraViewPositionReferenceEnum.Default)
      {
      }

      [Token(Token = "0x600907C")]
      [Address(RVA = "0x4B196C8", Offset = "0x4B196C8", VA = "0x4B196C8")]
      public void SetTargetTransform(Transform target)
      {
      }

      [Token(Token = "0x600907D")]
      [Address(RVA = "0x4B19000", Offset = "0x4B19000", VA = "0x4B19000")]
      public FreeMapTransformCameraParameter()
      {
      }
    }
  }
}
