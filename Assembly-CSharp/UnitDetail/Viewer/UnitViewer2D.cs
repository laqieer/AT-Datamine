// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.UnitViewer2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004B0")]
  [Serializable]
  public class UnitViewer2D : UnitViewerBase
  {
    [Token(Token = "0x40018C1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Canvas canvas;
    [Token(Token = "0x40018C2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x40018C3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x40018C4")]
    [FieldOffset(Offset = "0x58")]
    private Vector2 cachePinchCenter;
    [Token(Token = "0x40018C5")]
    [FieldOffset(Offset = "0x60")]
    private Vector2 dragPosition;
    [Token(Token = "0x40018C6")]
    [FieldOffset(Offset = "0x68")]
    private Vector2 startDragLocalPosition;
    [Token(Token = "0x40018C7")]
    [FieldOffset(Offset = "0x70")]
    private Vector2 startPinchCenter;
    [Token(Token = "0x40018C8")]
    [FieldOffset(Offset = "0x78")]
    private Vector2 startPinchCenterLocal;
    [Token(Token = "0x40018C9")]
    [FieldOffset(Offset = "0x80")]
    private float scale;
    [Token(Token = "0x40018CA")]
    [FieldOffset(Offset = "0x84")]
    private Vector2 xyTranslate;

    [Token(Token = "0x6001A5A")]
    [Address(RVA = "0x2C26284", Offset = "0x2C26284", VA = "0x2C26284", Slot = "15")]
    public override void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001A5B")]
    [Address(RVA = "0x2C264A4", Offset = "0x2C264A4", VA = "0x2C264A4", Slot = "16")]
    public override void OnDragStart(Vector2 position)
    {
    }

    [Token(Token = "0x6001A5C")]
    [Address(RVA = "0x2C2666C", Offset = "0x2C2666C", VA = "0x2C2666C", Slot = "17")]
    public override void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6001A5D")]
    [Address(RVA = "0x2C26670", Offset = "0x2C26670", VA = "0x2C26670", Slot = "18")]
    public override void OnDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001A5E")]
    [Address(RVA = "0x2C26818", Offset = "0x2C26818", VA = "0x2C26818", Slot = "11")]
    public override void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6001A5F")]
    [Address(RVA = "0x2C26820", Offset = "0x2C26820", VA = "0x2C26820", Slot = "12")]
    public override void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6001A60")]
    [Address(RVA = "0x2C26A34", Offset = "0x2C26A34", VA = "0x2C26A34", Slot = "13")]
    public override void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001A61")]
    [Address(RVA = "0x2C26AA8", Offset = "0x2C26AA8", VA = "0x2C26AA8", Slot = "22")]
    protected override void HideTransition()
    {
    }

    [Token(Token = "0x6001A62")]
    [Address(RVA = "0x2C26AD4", Offset = "0x2C26AD4", VA = "0x2C26AD4", Slot = "21")]
    protected override void ShowTransition()
    {
    }

    [Token(Token = "0x6001A63")]
    [Address(RVA = "0x2C26B00", Offset = "0x2C26B00", VA = "0x2C26B00", Slot = "7")]
    public override void Reset(Action callback = null)
    {
    }

    [Token(Token = "0x6001A64")]
    [Address(RVA = "0x2C26C24", Offset = "0x2C26C24", VA = "0x2C26C24", Slot = "8")]
    public override void ResetImmediate()
    {
    }

    [Token(Token = "0x6001A65")]
    [Address(RVA = "0x2C26C2C", Offset = "0x2C26C2C", VA = "0x2C26C2C")]
    public void SetUnitImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6001A66")]
    [Address(RVA = "0x2C26C48", Offset = "0x2C26C48", VA = "0x2C26C48")]
    public void DetouchUnitImage()
    {
    }

    [Token(Token = "0x6001A67")]
    [Address(RVA = "0x2C26B24", Offset = "0x2C26B24", VA = "0x2C26B24")]
    private void ResetImpl(float duration)
    {
    }

    [Token(Token = "0x6001A68")]
    [Address(RVA = "0x2C26564", Offset = "0x2C26564", VA = "0x2C26564")]
    private void TranslateFromScreenPos(Vector2 screenPos)
    {
    }

    [Token(Token = "0x6001A69")]
    [Address(RVA = "0x2C26E34", Offset = "0x2C26E34", VA = "0x2C26E34")]
    private void Translate(Vector2 position)
    {
    }

    [Token(Token = "0x6001A6A")]
    [Address(RVA = "0x2C268A4", Offset = "0x2C268A4", VA = "0x2C268A4")]
    public void AdjustScaling(Vector2 startPinchCenter, float value)
    {
    }

    [Token(Token = "0x6001A6B")]
    [Address(RVA = "0x2C26414", Offset = "0x2C26414", VA = "0x2C26414")]
    private IEnumerator AdjustScalingCoroutine(Vector2 scalingCenter, float scale, float duration)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6001A6C")]
    [Address(RVA = "0x2C2678C", Offset = "0x2C2678C", VA = "0x2C2678C")]
    private IEnumerator AdjustTranslateCoroutine(Vector2 translate, float duration)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6001A6D")]
    [Address(RVA = "0x2C26344", Offset = "0x2C26344", VA = "0x2C26344")]
    private IEnumerator ResetCoroutine(float duration) => (IEnumerator) null;

    [Token(Token = "0x6001A6E")]
    [Address(RVA = "0x2C264C8", Offset = "0x2C264C8", VA = "0x2C264C8")]
    private bool GetLocalPositionFromScreenPos(Vector2 screenPos, out Vector2 localPosition)
    {
      return new bool();
    }

    [Token(Token = "0x6001A6F")]
    [Address(RVA = "0x2C26F0C", Offset = "0x2C26F0C", VA = "0x2C26F0C")]
    public UnitViewer2D()
    {
    }
  }
}
