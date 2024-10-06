// Decompiled with JetBrains decompiler
// Type: CommonGesturePanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000211")]
[RequireComponent(typeof (Image))]
[AddComponentMenu("UI/Common Gesture Panel", 33)]
public class CommonGesturePanel : 
  MonoBehaviour,
  IPointerDownHandler,
  IEventSystemHandler,
  IPointerUpHandler
{
  [Token(Token = "0x4000C52")]
  [FieldOffset(Offset = "0x18")]
  public float doubleClickFUSDTimeLimit;
  [Token(Token = "0x4000C53")]
  [FieldOffset(Offset = "0x1C")]
  public float doubleClickTotalTimeLimit;
  [Token(Token = "0x4000C54")]
  [FieldOffset(Offset = "0x20")]
  public float doubleClickDistanceLimit;
  [Token(Token = "0x4000C55")]
  [FieldOffset(Offset = "0x24")]
  public float longPressTimeThreshold;
  [Token(Token = "0x4000C56")]
  [FieldOffset(Offset = "0x28")]
  public float pointerMoveThreshold;
  [Token(Token = "0x4000C57")]
  [FieldOffset(Offset = "0x2C")]
  public float flickSpeedThreshold;
  [Token(Token = "0x4000C58")]
  [FieldOffset(Offset = "0x30")]
  public float flickTimeLimit;
  [Token(Token = "0x4000C59")]
  [FieldOffset(Offset = "0x34")]
  public float pinchDegreeThreshold;
  [Token(Token = "0x4000C5A")]
  [FieldOffset(Offset = "0x38")]
  public Action<PointerEventData> OnPointerDownAction;
  [Token(Token = "0x4000C5B")]
  [FieldOffset(Offset = "0x40")]
  public Action<PointerEventData> OnPointerUpAction;
  [Token(Token = "0x4000C5C")]
  [FieldOffset(Offset = "0x48")]
  public Action<Vector2> OnSingleClick;
  [Token(Token = "0x4000C5D")]
  [FieldOffset(Offset = "0x50")]
  public Action<Vector2> OnDoubleClick;
  [Token(Token = "0x4000C5E")]
  [FieldOffset(Offset = "0x58")]
  public Action<Vector2> OnLongPress;
  [Token(Token = "0x4000C5F")]
  [FieldOffset(Offset = "0x60")]
  public Action<Vector2> OnSinglePointerMoveStart;
  [Token(Token = "0x4000C60")]
  [FieldOffset(Offset = "0x68")]
  public Action<Vector2, Vector2> OnSinglePointerMove;
  [Token(Token = "0x4000C61")]
  [FieldOffset(Offset = "0x70")]
  public Action<Vector2> OnSinglePointerMoveEnd;
  [Token(Token = "0x4000C62")]
  [FieldOffset(Offset = "0x78")]
  public Action<CommonGesturePanel.Direction, Vector2> OnFlick;
  [Token(Token = "0x4000C63")]
  [FieldOffset(Offset = "0x80")]
  public Action<Vector2> OnPinchStart;
  [Token(Token = "0x4000C64")]
  [FieldOffset(Offset = "0x88")]
  public Action<float> OnPinch;
  [Token(Token = "0x4000C65")]
  [FieldOffset(Offset = "0x90")]
  public Action<Vector2> OnPinchEnd;
  [Token(Token = "0x4000C66")]
  [FieldOffset(Offset = "0x98")]
  public Action<Vector2> OnDoublePointerMoveStart;
  [Token(Token = "0x4000C67")]
  [FieldOffset(Offset = "0xA0")]
  public Action<Vector2, Vector2> OnDoublePointerMove;
  [Token(Token = "0x4000C68")]
  [FieldOffset(Offset = "0xA8")]
  public Action<Vector2> OnDoublePointerMoveEnd;
  [Token(Token = "0x4000C69")]
  [FieldOffset(Offset = "0xB0")]
  public CommonGesturePanel.GesturePanelStatus currentStatus;
  [Token(Token = "0x4000C6A")]
  [FieldOffset(Offset = "0xB8")]
  private List<PointerEventData> eventDataList;
  [Token(Token = "0x4000C6B")]
  [FieldOffset(Offset = "0xC0")]
  private float singlePointerDownTime;
  [Token(Token = "0x4000C6C")]
  [FieldOffset(Offset = "0xC4")]
  private Vector2 singlePointerDownPosition;
  [Token(Token = "0x4000C6D")]
  [FieldOffset(Offset = "0xCC")]
  private float singlePointerUpTime;

  [Token(Token = "0x1700010F")]
  protected ScrollRect parentScrollRect
  {
    [Token(Token = "0x6000D0D"), Address(RVA = "0x4C7FCDC", Offset = "0x4C7FCDC", VA = "0x4C7FCDC")] get
    {
      return (ScrollRect) null;
    }
    [Token(Token = "0x6000D0E"), Address(RVA = "0x4C7FCE4", Offset = "0x4C7FCE4", VA = "0x4C7FCE4")] private set
    {
    }
  }

  [Token(Token = "0x6000D0F")]
  [Address(RVA = "0x4C7FCEC", Offset = "0x4C7FCEC", VA = "0x4C7FCEC")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D10")]
  [Address(RVA = "0x4C7FD60", Offset = "0x4C7FD60", VA = "0x4C7FD60")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D11")]
  [Address(RVA = "0x4C8046C", Offset = "0x4C8046C", VA = "0x4C8046C")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000D12")]
  [Address(RVA = "0x4C80470", Offset = "0x4C80470", VA = "0x4C80470")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000D13")]
  [Address(RVA = "0x4C80474", Offset = "0x4C80474", VA = "0x4C80474")]
  private void RegisterScrollCallback()
  {
  }

  [Token(Token = "0x6000D14")]
  [Address(RVA = "0x4C80538", Offset = "0x4C80538", VA = "0x4C80538")]
  private void UnRegisterScrollCallback()
  {
  }

  [Token(Token = "0x6000D15")]
  [Address(RVA = "0x4C805D8", Offset = "0x4C805D8", VA = "0x4C805D8", Slot = "6")]
  protected virtual void OnScrollViewValueChange(Vector2 vector)
  {
  }

  [Token(Token = "0x6000D16")]
  [Address(RVA = "0x4C7FD64", Offset = "0x4C7FD64", VA = "0x4C7FD64")]
  private void UpdateStatus()
  {
  }

  [Token(Token = "0x6000D17")]
  [Address(RVA = "0x4C7FCF0", Offset = "0x4C7FCF0", VA = "0x4C7FCF0")]
  private void ResetStatus()
  {
  }

  [Token(Token = "0x6000D18")]
  [Address(RVA = "0x4C805DC", Offset = "0x4C805DC", VA = "0x4C805DC", Slot = "4")]
  public void OnPointerDown(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D19")]
  [Address(RVA = "0x4C80854", Offset = "0x4C80854", VA = "0x4C80854", Slot = "5")]
  public void OnPointerUp(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D1A")]
  [Address(RVA = "0x4C80B9C", Offset = "0x4C80B9C", VA = "0x4C80B9C")]
  public GameObject GetHitObject(Vector2 screenPosition) => (GameObject) null;

  [Token(Token = "0x6000D1B")]
  [Address(RVA = "0x4C80AF8", Offset = "0x4C80AF8", VA = "0x4C80AF8")]
  private CommonGesturePanel.Direction GetDirection(Vector2 src)
  {
    return new CommonGesturePanel.Direction();
  }

  [Token(Token = "0x6000D1C")]
  [Address(RVA = "0x4C80C38", Offset = "0x4C80C38", VA = "0x4C80C38")]
  public CommonGesturePanel()
  {
  }

  [Token(Token = "0x2000212")]
  public enum GesturePanelStatus
  {
    [Token(Token = "0x4000C70")] Idle,
    [Token(Token = "0x4000C71")] SinglePointerDown,
    [Token(Token = "0x4000C72")] SinglePointerUp,
    [Token(Token = "0x4000C73")] SinglePointerMove,
    [Token(Token = "0x4000C74")] DoublePointer,
    [Token(Token = "0x4000C75")] DoublePointerMove,
    [Token(Token = "0x4000C76")] Pinch,
  }

  [Token(Token = "0x2000213")]
  public enum Direction
  {
    [Token(Token = "0x4000C78")] None,
    [Token(Token = "0x4000C79")] Left,
    [Token(Token = "0x4000C7A")] Up,
    [Token(Token = "0x4000C7B")] Right,
    [Token(Token = "0x4000C7C")] Down,
  }
}
