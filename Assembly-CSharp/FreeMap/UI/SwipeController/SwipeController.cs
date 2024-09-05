// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.SwipeController.SwipeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
namespace FreeMap.UI.SwipeController
{
  [Token(Token = "0x2001614")]
  public class SwipeController : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler,
    IDragHandler
  {
    [Token(Token = "0x1400010A")]
    public event UnityAction<PointerEventData> OnStartControl
    {
      [Token(Token = "0x6007CF6"), Address(RVA = "0x21A520C", Offset = "0x21A520C", VA = "0x21A520C")] add
      {
      }
      [Token(Token = "0x6007CF7"), Address(RVA = "0x21A52BC", Offset = "0x21A52BC", VA = "0x21A52BC")] remove
      {
      }
    }

    [Token(Token = "0x1400010B")]
    public event UnityAction<PointerEventData> OnSwipe
    {
      [Token(Token = "0x6007CF8"), Address(RVA = "0x21A536C", Offset = "0x21A536C", VA = "0x21A536C")] add
      {
      }
      [Token(Token = "0x6007CF9"), Address(RVA = "0x21A541C", Offset = "0x21A541C", VA = "0x21A541C")] remove
      {
      }
    }

    [Token(Token = "0x1400010C")]
    public event UnityAction<PointerEventData> OnEndControl
    {
      [Token(Token = "0x6007CFA"), Address(RVA = "0x21A54CC", Offset = "0x21A54CC", VA = "0x21A54CC")] add
      {
      }
      [Token(Token = "0x6007CFB"), Address(RVA = "0x21A557C", Offset = "0x21A557C", VA = "0x21A557C")] remove
      {
      }
    }

    [Token(Token = "0x6007CFC")]
    [Address(RVA = "0x21A562C", Offset = "0x21A562C", VA = "0x21A562C")]
    private void Start()
    {
    }

    [Token(Token = "0x6007CFD")]
    [Address(RVA = "0x21A5650", Offset = "0x21A5650", VA = "0x21A5650")]
    public void SetEnable(bool enable)
    {
    }

    [Token(Token = "0x6007CFE")]
    [Address(RVA = "0x21A571C", Offset = "0x21A571C", VA = "0x21A571C", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007CFF")]
    [Address(RVA = "0x21A5780", Offset = "0x21A5780", VA = "0x21A5780", Slot = "6")]
    public void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007D00")]
    [Address(RVA = "0x21A57E4", Offset = "0x21A57E4", VA = "0x21A57E4", Slot = "5")]
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007D01")]
    [Address(RVA = "0x21A5848", Offset = "0x21A5848", VA = "0x21A5848")]
    public SwipeController()
    {
    }
  }
}
