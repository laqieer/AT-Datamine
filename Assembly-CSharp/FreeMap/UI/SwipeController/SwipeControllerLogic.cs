// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.SwipeController.SwipeControllerLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace FreeMap.UI.SwipeController
{
  [Token(Token = "0x2001615")]
  public class SwipeControllerLogic : IPlayerInputProvider
  {
    [Token(Token = "0x400647C")]
    private const float MoveAnimationDistance = 60f;
    [Token(Token = "0x4006481")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 forwardDirection;
    [Token(Token = "0x4006482")]
    [FieldOffset(Offset = "0x34")]
    private Vector3 rightDirection;
    [Token(Token = "0x4006483")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform swipeRectTransform;

    [Token(Token = "0x17001349")]
    public bool IsValid
    {
      [Token(Token = "0x6007D02"), Address(RVA = "0x21A5850", Offset = "0x21A5850", VA = "0x21A5850")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700134A")]
    public bool IsEnabled
    {
      [Token(Token = "0x6007D03"), Address(RVA = "0x21A58B0", Offset = "0x21A58B0", VA = "0x21A58B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007D04"), Address(RVA = "0x21A58B8", Offset = "0x21A58B8", VA = "0x21A58B8")] private set
      {
      }
    }

    [Token(Token = "0x1700134B")]
    public Vector2 StartPosition
    {
      [Token(Token = "0x6007D05"), Address(RVA = "0x21A58C4", Offset = "0x21A58C4", VA = "0x21A58C4")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6007D06"), Address(RVA = "0x21A58CC", Offset = "0x21A58CC", VA = "0x21A58CC")] private set
      {
      }
    }

    [Token(Token = "0x1700134C")]
    public Vector2 SwipeValue
    {
      [Token(Token = "0x6007D07"), Address(RVA = "0x21A58D4", Offset = "0x21A58D4", VA = "0x21A58D4")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6007D08"), Address(RVA = "0x21A58DC", Offset = "0x21A58DC", VA = "0x21A58DC")] private set
      {
      }
    }

    [Token(Token = "0x1700134D")]
    public SwipeControllerLogic.ControllType ControlType
    {
      [Token(Token = "0x6007D09"), Address(RVA = "0x21A58E4", Offset = "0x21A58E4", VA = "0x21A58E4")] set
      {
      }
      [Token(Token = "0x6007D0A"), Address(RVA = "0x21A58EC", Offset = "0x21A58EC", VA = "0x21A58EC")] get
      {
        return new SwipeControllerLogic.ControllType();
      }
    }

    [Token(Token = "0x1400010D")]
    public event MoveUpdateFunc OnMoveUpdate
    {
      [Token(Token = "0x6007D0B"), Address(RVA = "0x21A58F4", Offset = "0x21A58F4", VA = "0x21A58F4", Slot = "4")] add
      {
      }
      [Token(Token = "0x6007D0C"), Address(RVA = "0x21A5990", Offset = "0x21A5990", VA = "0x21A5990", Slot = "5")] remove
      {
      }
    }

    [Token(Token = "0x1400010E")]
    public event SetMoveSpeedFunc SetMoveSpeed
    {
      [Token(Token = "0x6007D0D"), Address(RVA = "0x21A5A2C", Offset = "0x21A5A2C", VA = "0x21A5A2C", Slot = "6")] add
      {
      }
      [Token(Token = "0x6007D0E"), Address(RVA = "0x21A5AC8", Offset = "0x21A5AC8", VA = "0x21A5AC8", Slot = "7")] remove
      {
      }
    }

    [Token(Token = "0x1400010F")]
    public event SetAnimationRateFunc SetAnimationRate
    {
      [Token(Token = "0x6007D0F"), Address(RVA = "0x21A5B64", Offset = "0x21A5B64", VA = "0x21A5B64", Slot = "8")] add
      {
      }
      [Token(Token = "0x6007D10"), Address(RVA = "0x21A5C00", Offset = "0x21A5C00", VA = "0x21A5C00", Slot = "9")] remove
      {
      }
    }

    [Token(Token = "0x1700134E")]
    private FreeMap.UI.SwipeController.SwipeController component
    {
      [Token(Token = "0x6007D11"), Address(RVA = "0x21A5C9C", Offset = "0x21A5C9C", VA = "0x21A5C9C")] set
      {
      }
      [Token(Token = "0x6007D12"), Address(RVA = "0x21A5CA4", Offset = "0x21A5CA4", VA = "0x21A5CA4")] get
      {
        return (FreeMap.UI.SwipeController.SwipeController) null;
      }
    }

    [Token(Token = "0x1700134F")]
    private ITrackedCamera trackedCamera
    {
      [Token(Token = "0x6007D13"), Address(RVA = "0x21A5CAC", Offset = "0x21A5CAC", VA = "0x21A5CAC")] set
      {
      }
      [Token(Token = "0x6007D14"), Address(RVA = "0x21A5CB4", Offset = "0x21A5CB4", VA = "0x21A5CB4")] get
      {
        return (ITrackedCamera) null;
      }
    }

    [Token(Token = "0x17001350")]
    private Transform targetPlayer
    {
      [Token(Token = "0x6007D15"), Address(RVA = "0x21A5CBC", Offset = "0x21A5CBC", VA = "0x21A5CBC")] set
      {
      }
      [Token(Token = "0x6007D16"), Address(RVA = "0x21A5CC4", Offset = "0x21A5CC4", VA = "0x21A5CC4")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17001351")]
    public bool IsSwipping
    {
      [Token(Token = "0x6007D17"), Address(RVA = "0x21A5CCC", Offset = "0x21A5CCC", VA = "0x21A5CCC")] set
      {
      }
      [Token(Token = "0x6007D18"), Address(RVA = "0x21A5CD8", Offset = "0x21A5CD8", VA = "0x21A5CD8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007D19")]
    [Address(RVA = "0x21A5CE0", Offset = "0x21A5CE0", VA = "0x21A5CE0")]
    public SwipeControllerLogic()
    {
    }

    [Token(Token = "0x6007D1A")]
    [Address(RVA = "0x21A5CE8", Offset = "0x21A5CE8", VA = "0x21A5CE8")]
    public SwipeControllerLogic(
      FreeMap.UI.SwipeController.SwipeController component,
      ITrackedCamera trackedCamera,
      Transform targetPlayer)
    {
    }

    [Token(Token = "0x6007D1B")]
    [Address(RVA = "0x21A5D2C", Offset = "0x21A5D2C", VA = "0x21A5D2C")]
    public void Setup(
      FreeMap.UI.SwipeController.SwipeController component,
      ITrackedCamera trackedCamera,
      Transform targetPlayer)
    {
    }

    [Token(Token = "0x6007D1C")]
    [Address(RVA = "0x21A5E7C", Offset = "0x21A5E7C", VA = "0x21A5E7C")]
    public void SetPlayer(ITrackedCamera trackedCamera, Transform targetPlayer)
    {
    }

    [Token(Token = "0x6007D1D")]
    [Address(RVA = "0x21A5E84", Offset = "0x21A5E84", VA = "0x21A5E84")]
    public void SetEnabled(bool enabled)
    {
    }

    [Token(Token = "0x6007D1E")]
    [Address(RVA = "0x21A5FDC", Offset = "0x21A5FDC", VA = "0x21A5FDC")]
    public void Release()
    {
    }

    [Token(Token = "0x6007D1F")]
    [Address(RVA = "0x21A5FE8", Offset = "0x21A5FE8", VA = "0x21A5FE8")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6007D20")]
    [Address(RVA = "0x21A61C8", Offset = "0x21A61C8", VA = "0x21A61C8")]
    private void BeginControl(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007D21")]
    [Address(RVA = "0x21A5F30", Offset = "0x21A5F30", VA = "0x21A5F30")]
    private void EndControl(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007D22")]
    [Address(RVA = "0x21A6478", Offset = "0x21A6478", VA = "0x21A6478")]
    private void Swipe(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007D23")]
    [Address(RVA = "0x21A6324", Offset = "0x21A6324", VA = "0x21A6324")]
    private void SetStartPosition(Camera camera, Vector2 pointerPosition)
    {
    }

    [Token(Token = "0x6007D24")]
    [Address(RVA = "0x21A6660", Offset = "0x21A6660", VA = "0x21A6660")]
    private void SetDesiredPosition(Camera camera, Vector2 pointerPosition)
    {
    }

    [Token(Token = "0x6007D25")]
    [Address(RVA = "0x21A6B3C", Offset = "0x21A6B3C", VA = "0x21A6B3C")]
    protected Quaternion CalcRotationTrackingTarget(Transform cameraTransform, Transform target)
    {
      return new Quaternion();
    }

    [Token(Token = "0x6007D26")]
    [Address(RVA = "0x21A6810", Offset = "0x21A6810", VA = "0x21A6810")]
    protected Vector3 GetDirMove(Vector2 swipeSize) => new Vector3();

    [Token(Token = "0x6007D27")]
    [Address(RVA = "0x21A63B8", Offset = "0x21A63B8", VA = "0x21A63B8")]
    private void UpdateDirMove(Transform transform)
    {
    }

    [Token(Token = "0x2001616")]
    public enum ControllType
    {
      [Token(Token = "0x400648C")] CameraFixed,
      [Token(Token = "0x400648D")] SwipeFixed,
    }
  }
}
