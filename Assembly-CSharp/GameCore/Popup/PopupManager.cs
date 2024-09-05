// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.PopupManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CFF")]
  public class PopupManager : SingletonMonoBehaviour<PopupManager>
  {
    [Token(Token = "0x4003A0D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject objSystemPopupRoot;
    [Token(Token = "0x4003A0E")]
    private const string CONST_POPUP_ANIM_OPEN = "Open";
    [Token(Token = "0x4003A0F")]
    private const string CONST_POPUP_ANIM_CLOSE = "Close";
    [Token(Token = "0x4003A10")]
    [FieldOffset(Offset = "0x28")]
    private GameObject popupAttachObject;
    [Token(Token = "0x4003A11")]
    [FieldOffset(Offset = "0x30")]
    private List<PopupBase> popupList;
    [Token(Token = "0x4003A12")]
    [FieldOffset(Offset = "0x38")]
    private bool isAnimation;
    [Token(Token = "0x4003A13")]
    [FieldOffset(Offset = "0x40")]
    private GameObject systemPopupObject;
    [Token(Token = "0x4003A14")]
    [FieldOffset(Offset = "0x48")]
    private CommonPopup systemSmallPopupAsset;
    [Token(Token = "0x4003A15")]
    [FieldOffset(Offset = "0x50")]
    private CommonPopup systemSmallNarrowPopupAsset;
    [Token(Token = "0x4003A16")]
    [FieldOffset(Offset = "0x58")]
    private CommonPopup systemMediumPopupAsset;
    [Token(Token = "0x4003A17")]
    [FieldOffset(Offset = "0x60")]
    private CommonPopup systemLargePopupAsset;

    [Token(Token = "0x17000AF3")]
    public bool IsProcessing
    {
      [Token(Token = "0x6004AB8"), Address(RVA = "0x3140850", Offset = "0x3140850", VA = "0x3140850")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004AB9"), Address(RVA = "0x3140858", Offset = "0x3140858", VA = "0x3140858")] private set
      {
      }
    }

    [Token(Token = "0x6004ABA")]
    [Address(RVA = "0x3140864", Offset = "0x3140864", VA = "0x3140864", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6004ABB")]
    [Address(RVA = "0x31409A0", Offset = "0x31409A0", VA = "0x31409A0")]
    public GameObject GetSystemPopupRoot() => (GameObject) null;

    [Token(Token = "0x6004ABC")]
    [Address(RVA = "0x31409A8", Offset = "0x31409A8", VA = "0x31409A8")]
    public PopupBase Current() => (PopupBase) null;

    [Token(Token = "0x6004ABD")]
    [Address(RVA = "0x3140A1C", Offset = "0x3140A1C", VA = "0x3140A1C")]
    public void ConfirmSystemPopupOpen(
      string title,
      string message,
      Action confirmAction,
      Action outOfRangeAction,
      string groupID = "Open")
    {
    }

    [Token(Token = "0x6004ABE")]
    [Address(RVA = "0x3140BB4", Offset = "0x3140BB4", VA = "0x3140BB4")]
    public void CancelSystemPopupOpen(
      string title,
      string message,
      Action cancelAction,
      Action outOfRangeAction,
      string groupID = "Open")
    {
    }

    [Token(Token = "0x6004ABF")]
    [Address(RVA = "0x3140D4C", Offset = "0x3140D4C", VA = "0x3140D4C")]
    public void CloseSystemPopupOpen(
      string title,
      string message,
      Action closeAction,
      Action outOfRangeAction,
      string groupID = "Open")
    {
    }

    [Token(Token = "0x6004AC0")]
    [Address(RVA = "0x3140EE4", Offset = "0x3140EE4", VA = "0x3140EE4")]
    public void ConfirmWitCancelSystemPopupOpen(
      string title,
      string message,
      Action confirmAction,
      Action cancelAction,
      Action outOfRangeAction,
      string groupID = "Open")
    {
    }

    [Token(Token = "0x6004AC1")]
    [Address(RVA = "0x314108C", Offset = "0x314108C", VA = "0x314108C")]
    public PopupHandle SystemPopupOpenSmall(
      CommonPopupContent popupContent,
      Action outOfRangeAction,
      params CommonButtonContent[] contents)
    {
      return (PopupHandle) null;
    }

    [Token(Token = "0x6004AC2")]
    [Address(RVA = "0x31412C0", Offset = "0x31412C0", VA = "0x31412C0")]
    public PopupHandle PopupOpenSmall(
      CommonPopupContent popupContent,
      Action outOfRangeAction,
      params CommonButtonContent[] contents)
    {
      return (PopupHandle) null;
    }

    [Token(Token = "0x6004AC3")]
    [Address(RVA = "0x31414F4", Offset = "0x31414F4", VA = "0x31414F4")]
    public PopupHandle SystemPopupOpenSmallNarrow(
      CommonPopupContentNoTitle popupContent,
      Action outOfRangeAction,
      params CommonButtonContent[] contents)
    {
      return (PopupHandle) null;
    }

    [Token(Token = "0x6004AC4")]
    [Address(RVA = "0x314150C", Offset = "0x314150C", VA = "0x314150C")]
    public PopupHandle SystemPopupOpenMedium(
      CommonPopupContent popupContent,
      Action outOfRangeAction,
      params CommonButtonContent[] contents)
    {
      return (PopupHandle) null;
    }

    [Token(Token = "0x6004AC5")]
    [Address(RVA = "0x3141524", Offset = "0x3141524", VA = "0x3141524")]
    public PopupHandle SystemPopupOpenLarge(
      CommonPopupContent popupContent,
      Action outOfRangeAction,
      params CommonButtonContent[] contents)
    {
      return (PopupHandle) null;
    }

    [Token(Token = "0x6004AC6")]
    [Address(RVA = "0x31410A4", Offset = "0x31410A4", VA = "0x31410A4")]
    public PopupHandle SystemPopupOpen(
      CommonPopup popupObject,
      CommonPopupContent popupContent,
      Action outOfRangeAction,
      params CommonButtonContent[] contents)
    {
      return (PopupHandle) null;
    }

    [Token(Token = "0x6004AC7")]
    [Address(RVA = "0x31412D8", Offset = "0x31412D8", VA = "0x31412D8")]
    public PopupHandle PopupOpen(
      CommonPopup popupObject,
      CommonPopupContent popupContent,
      Action outOfRangeAction,
      params CommonButtonContent[] contents)
    {
      return (PopupHandle) null;
    }

    [Token(Token = "0x6004AC8")]
    [Address(RVA = "0x3140058", Offset = "0x3140058", VA = "0x3140058")]
    public void Open(
      PopupBase popup,
      string groupID = "Open",
      bool isPrevPopupClose = false,
      Func<bool> waitStartAnimation = null,
      bool front = false)
    {
    }

    [Token(Token = "0x6004AC9")]
    [Address(RVA = "0x314174C", Offset = "0x314174C", VA = "0x314174C")]
    private IEnumerator WaitCallExecute(Func<bool> wait, Action execute) => (IEnumerator) null;

    [Token(Token = "0x6004ACA")]
    [Address(RVA = "0x31417E8", Offset = "0x31417E8", VA = "0x31417E8")]
    public void Close(string groupID = "Close")
    {
    }

    [Token(Token = "0x6004ACB")]
    [Address(RVA = "0x3141B94", Offset = "0x3141B94", VA = "0x3141B94")]
    public void Close(Action onPopupAnimationFinished, string groupID = "Close")
    {
    }

    [Token(Token = "0x6004ACC")]
    [Address(RVA = "0x31404A8", Offset = "0x31404A8", VA = "0x31404A8")]
    public void Close(PopupBase popup, string groupID = "Close")
    {
    }

    [Token(Token = "0x6004ACD")]
    [Address(RVA = "0x3141C90", Offset = "0x3141C90", VA = "0x3141C90")]
    public void CloseAll()
    {
    }

    [Token(Token = "0x6004ACE")]
    [Address(RVA = "0x3141554", Offset = "0x3141554", VA = "0x3141554")]
    private void ClosePopupChain(List<PopupBase> popups, int index, UnityAction callback = null)
    {
    }

    [Token(Token = "0x6004ACF")]
    [Address(RVA = "0x3141D60", Offset = "0x3141D60", VA = "0x3141D60")]
    public void Clear(PopupBase popup)
    {
    }

    [Token(Token = "0x6004AD0")]
    [Address(RVA = "0x3141E10", Offset = "0x3141E10", VA = "0x3141E10")]
    public void ClearAll()
    {
    }

    [Token(Token = "0x6004AD1")]
    [Address(RVA = "0x314201C", Offset = "0x314201C", VA = "0x314201C")]
    public void ClearAllExcept(Component component)
    {
    }

    [Token(Token = "0x6004AD2")]
    [Address(RVA = "0x3142324", Offset = "0x3142324", VA = "0x3142324")]
    public void ClearAllExcept(List<Component> component)
    {
    }

    [Token(Token = "0x6004AD3")]
    [Address(RVA = "0x3142634", Offset = "0x3142634", VA = "0x3142634")]
    public void Back(UnityAction completeEvent = null)
    {
    }

    [Token(Token = "0x6004AD4")]
    [Address(RVA = "0x31418D4", Offset = "0x31418D4", VA = "0x31418D4")]
    private void PlayPopupAnimation(
      PopupBase popup,
      bool isOpenAnimation,
      string groupID = "",
      UnityAction callback = null)
    {
    }

    [Token(Token = "0x6004AD5")]
    [Address(RVA = "0x31427A8", Offset = "0x31427A8", VA = "0x31427A8")]
    public PopupManager()
    {
    }
  }
}
