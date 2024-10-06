// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.TutorialPopupEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000D1E")]
  public class TutorialPopupEventSystem : 
    MonoBehaviour,
    IBeginDragHandler,
    IEventSystemHandler,
    IEndDragHandler,
    IPointerUpHandler,
    IPointerDownHandler
  {
    [Token(Token = "0x4003ACF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TutorialPopup tutorialPopup;

    [Token(Token = "0x6004B7D")]
    [Address(RVA = "0x32E63A0", Offset = "0x32E63A0", VA = "0x32E63A0", Slot = "6")]
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004B7E")]
    [Address(RVA = "0x32E63C8", Offset = "0x32E63C8", VA = "0x32E63C8", Slot = "7")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004B7F")]
    [Address(RVA = "0x32E63E8", Offset = "0x32E63E8", VA = "0x32E63E8", Slot = "4")]
    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004B80")]
    [Address(RVA = "0x32E6410", Offset = "0x32E6410", VA = "0x32E6410", Slot = "5")]
    public void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004B81")]
    [Address(RVA = "0x32E6428", Offset = "0x32E6428", VA = "0x32E6428")]
    public TutorialPopupEventSystem()
    {
    }
  }
}
