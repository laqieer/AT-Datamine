// Decompiled with JetBrains decompiler
// Type: staq.SystemUI.DebugButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace staq.SystemUI
{
  [Token(Token = "0x2003D59")]
  public class DebugButton : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
  {
    [Token(Token = "0x4010D98")]
    [FieldOffset(Offset = "0x18")]
    public RectTransform RectTransform;

    [Token(Token = "0x6018B02")]
    [Address(RVA = "0x2641780", Offset = "0x2641780", VA = "0x2641780")]
    private void Reset()
    {
    }

    [Token(Token = "0x6018B03")]
    [Address(RVA = "0x26417D0", Offset = "0x26417D0", VA = "0x26417D0", Slot = "4")]
    public void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6018B04")]
    [Address(RVA = "0x26418C0", Offset = "0x26418C0", VA = "0x26418C0", Slot = "5")]
    public void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6018B05")]
    [Address(RVA = "0x2641974", Offset = "0x2641974", VA = "0x2641974")]
    public DebugButton()
    {
    }
  }
}
