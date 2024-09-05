// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.CameraController.FreeMapCameraControllerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.CameraController
{
  [Token(Token = "0x2001963")]
  public abstract class FreeMapCameraControllerBase : MonoBehaviour
  {
    [Token(Token = "0x4006D20")]
    [FieldOffset(Offset = "0x18")]
    protected FreeMapCameraField ownerCameraField;
    [Token(Token = "0x4006D21")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected Camera linkCamera;
    [Token(Token = "0x4006D22")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected Transform trackingTarget;
    [Token(Token = "0x4006D23")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected Vector3 trackingOffset;
    [Token(Token = "0x4006D24")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    protected float cameraFieldOfView;
    [Token(Token = "0x4006D25")]
    [FieldOffset(Offset = "0x40")]
    protected float cameraFieldOfViewInRuntimeInternal;
    [Token(Token = "0x4006D26")]
    [FieldOffset(Offset = "0x48")]
    protected FreeMapCameraControllerBase.VectorAjustMentHandler ajustMentHandler;
    [Token(Token = "0x4006D27")]
    [FieldOffset(Offset = "0x50")]
    protected FreeMapCameraControllerBase.RaycastHitHandler raycastHandler;
    [Token(Token = "0x4006D28")]
    [FieldOffset(Offset = "0x58")]
    protected bool isMoveTransform;
    [Token(Token = "0x4006D29")]
    [FieldOffset(Offset = "0x60")]
    protected CinemachineVirtualCamera virtualCamera;
    [Token(Token = "0x4006D2A")]
    [FieldOffset(Offset = "0x68")]
    protected bool isStopTracking;
    [Token(Token = "0x4006D2B")]
    [FieldOffset(Offset = "0x6C")]
    protected Vector3 clipPosition;
    [Token(Token = "0x4006D2C")]
    [FieldOffset(Offset = "0x78")]
    protected float recoveryTime;
    [Token(Token = "0x4006D2D")]
    [FieldOffset(Offset = "0x7C")]
    protected float currentRecoveryTime;

    [Token(Token = "0x17001752")]
    public Camera LinkCamera
    {
      [Token(Token = "0x60090BE"), Address(RVA = "0x4D053E8", Offset = "0x4D053E8", VA = "0x4D053E8")] get
      {
        return (Camera) null;
      }
      [Token(Token = "0x60090BF"), Address(RVA = "0x4D053F0", Offset = "0x4D053F0", VA = "0x4D053F0")] set
      {
      }
    }

    [Token(Token = "0x17001753")]
    public Transform TrackingTarget
    {
      [Token(Token = "0x60090C0"), Address(RVA = "0x4D053F8", Offset = "0x4D053F8", VA = "0x4D053F8")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x60090C1"), Address(RVA = "0x4D05400", Offset = "0x4D05400", VA = "0x4D05400")] set
      {
      }
    }

    [Token(Token = "0x17001754")]
    public Vector3 TrackingOffset
    {
      [Token(Token = "0x60090C2"), Address(RVA = "0x4D05408", Offset = "0x4D05408", VA = "0x4D05408")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17001755")]
    public float CameraFieldOfViewInRuntime
    {
      [Token(Token = "0x60090C3"), Address(RVA = "0x4D05414", Offset = "0x4D05414", VA = "0x4D05414")] get
      {
        return new float();
      }
      [Token(Token = "0x60090C4"), Address(RVA = "0x4D05438", Offset = "0x4D05438", VA = "0x4D05438")] set
      {
      }
    }

    [Token(Token = "0x60090C5")]
    [Address(RVA = "0x4D05440", Offset = "0x4D05440", VA = "0x4D05440")]
    public void Initialize(
      FreeMapCameraField owner,
      Camera linkCamera,
      Transform trackingTarget,
      FreeMapCameraControllerBase.VectorAjustMentHandler vectorHandler,
      FreeMapCameraControllerBase.RaycastHitHandler raycastHandler)
    {
    }

    [Token(Token = "0x60090C6")]
    [Address(RVA = "0x4D05688", Offset = "0x4D05688", VA = "0x4D05688")]
    public void Initialize(FreeMapCameraField owner)
    {
    }

    [Token(Token = "0x60090C7")]
    [Address(RVA = "0x4D057F0", Offset = "0x4D057F0", VA = "0x4D057F0")]
    public void RegistCamera(Camera linkCamera)
    {
    }

    [Token(Token = "0x60090C8")]
    [Address(RVA = "0x4D057F8", Offset = "0x4D057F8", VA = "0x4D057F8")]
    public void UnRegisterCamera()
    {
    }

    [Token(Token = "0x60090C9")]
    [Address(RVA = "0x4D05800", Offset = "0x4D05800", VA = "0x4D05800", Slot = "4")]
    protected virtual void InternalInitialize()
    {
    }

    [Token(Token = "0x60090CA")]
    [Address(RVA = "0x4D05804", Offset = "0x4D05804", VA = "0x4D05804")]
    public void Begin()
    {
    }

    [Token(Token = "0x60090CB")]
    [Address(RVA = "0x4D058CC", Offset = "0x4D058CC", VA = "0x4D058CC", Slot = "5")]
    protected virtual void OnBeginInternal()
    {
    }

    [Token(Token = "0x60090CC")]
    [Address(RVA = "0x4D058D0", Offset = "0x4D058D0", VA = "0x4D058D0")]
    public void InitTrackingParam()
    {
    }

    [Token(Token = "0x60090CD")]
    [Address(RVA = "0x4D058E4", Offset = "0x4D058E4", VA = "0x4D058E4", Slot = "6")]
    protected virtual void OnInitTrackingParam()
    {
    }

    [Token(Token = "0x60090CE")]
    [Address(RVA = "0x4D058E8", Offset = "0x4D058E8", VA = "0x4D058E8")]
    public void ActiveVirtualCamera()
    {
    }

    [Token(Token = "0x60090CF")]
    [Address(RVA = "0x4D05828", Offset = "0x4D05828", VA = "0x4D05828")]
    public void CameraUpdate(bool isClip)
    {
    }

    [Token(Token = "0x60090D0")]
    [Address(RVA = "0x4D05B60", Offset = "0x4D05B60", VA = "0x4D05B60")]
    public void DeactiveVirtualCamera()
    {
    }

    [Token(Token = "0x60090D1")]
    [Address(RVA = "0x4D05B8C", Offset = "0x4D05B8C", VA = "0x4D05B8C")]
    public void SetActiveMoveTransform(bool enabled)
    {
    }

    [Token(Token = "0x60090D2")]
    [Address(RVA = "0x4D05B98", Offset = "0x4D05B98", VA = "0x4D05B98")]
    public void SetFieldOfView(float fieldOfView)
    {
    }

    [Token(Token = "0x60090D3")]
    [Address(RVA = "0x4D05C20", Offset = "0x4D05C20", VA = "0x4D05C20")]
    public float GetFieldOfView() => new float();

    [Token(Token = "0x60090D4")]
    protected abstract void SetCartPositionAndRotation(bool isClip);

    [Token(Token = "0x60090D5")]
    [Address(RVA = "0x4D05914", Offset = "0x4D05914", VA = "0x4D05914")]
    private void RayCastUpdate()
    {
    }

    [Token(Token = "0x60090D6")]
    [Address(RVA = "0x4D05CA4", Offset = "0x4D05CA4", VA = "0x4D05CA4")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60090D7")]
    public abstract CameraControlType GetControlType();

    [Token(Token = "0x60090D8")]
    [Address(RVA = "0x4D05D70", Offset = "0x4D05D70", VA = "0x4D05D70")]
    protected void SetClipPosition(Vector3 ajustmentPosition)
    {
    }

    [Token(Token = "0x60090D9")]
    [Address(RVA = "0x4D05DF0", Offset = "0x4D05DF0", VA = "0x4D05DF0")]
    protected Vector3 CalcClippingPosition(Vector3 newPosition) => new Vector3();

    [Token(Token = "0x60090DA")]
    [Address(RVA = "0x4D05E9C", Offset = "0x4D05E9C", VA = "0x4D05E9C")]
    protected FreeMapCameraControllerBase()
    {
    }

    [Token(Token = "0x2001964")]
    public delegate bool VectorAjustMentHandler(
      Vector3 oldPosition,
      Vector3 newPosition,
      out Vector3 correctedPosition);

    [Token(Token = "0x2001965")]
    public delegate void RaycastHitHandler(RaycastHit[] hits);
  }
}
