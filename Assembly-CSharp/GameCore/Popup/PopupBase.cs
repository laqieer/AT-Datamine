// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.PopupBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CF9")]
  public class PopupBase : MonoBehaviour
  {
    [Token(Token = "0x40039F4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Text title;
    [Token(Token = "0x40039F5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected Text text;
    [Token(Token = "0x40039F6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected CommonButton positiveButton;
    [Token(Token = "0x40039F7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UISafeAreaInsets safeArea;
    [Token(Token = "0x40039F8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected bool enableOutOfRangeClick;
    [Token(Token = "0x40039F9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PopupAnimationController controller;
    [Token(Token = "0x40039FA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x40039FB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected CanvasGroup primaryCanvasGroup;
    [Token(Token = "0x40039FF")]
    [FieldOffset(Offset = "0x70")]
    public UnityEvent OnClickOutOfRangeEvent;
    [Token(Token = "0x4003A01")]
    [FieldOffset(Offset = "0x80")]
    private CanvasGroup canvasGroup;

    [Token(Token = "0x17000AEA")]
    public UISafeAreaInsets SafeArea
    {
      [Token(Token = "0x6004A8C"), Address(RVA = "0x313F644", Offset = "0x313F644", VA = "0x313F644")] get
      {
        return (UISafeAreaInsets) null;
      }
    }

    [Token(Token = "0x17000AEB")]
    public PopupAnimationController Controller
    {
      [Token(Token = "0x6004A8D"), Address(RVA = "0x313F64C", Offset = "0x313F64C", VA = "0x313F64C")] get
      {
        return (PopupAnimationController) null;
      }
    }

    [Token(Token = "0x17000AEC")]
    public UITimelineController UITimelineController
    {
      [Token(Token = "0x6004A8E"), Address(RVA = "0x313F654", Offset = "0x313F654", VA = "0x313F654")] get
      {
        return (UITimelineController) null;
      }
    }

    [Token(Token = "0x17000AED")]
    public bool IsOpen
    {
      [Token(Token = "0x6004A8F"), Address(RVA = "0x313F65C", Offset = "0x313F65C", VA = "0x313F65C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004A90"), Address(RVA = "0x313F664", Offset = "0x313F664", VA = "0x313F664")] private set
      {
      }
    }

    [Token(Token = "0x17000AEE")]
    public string OpenGroupID
    {
      [Token(Token = "0x6004A91"), Address(RVA = "0x313F670", Offset = "0x313F670", VA = "0x313F670")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004A92"), Address(RVA = "0x313F678", Offset = "0x313F678", VA = "0x313F678")] private set
      {
      }
    }

    [Token(Token = "0x17000AEF")]
    public string CloseGroupID
    {
      [Token(Token = "0x6004A93"), Address(RVA = "0x313F680", Offset = "0x313F680", VA = "0x313F680")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004A94"), Address(RVA = "0x313F688", Offset = "0x313F688", VA = "0x313F688")] set
      {
      }
    }

    [Token(Token = "0x17000AF0")]
    public bool IsDisableBackKey
    {
      [Token(Token = "0x6004A95"), Address(RVA = "0x313F690", Offset = "0x313F690", VA = "0x313F690")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004A96"), Address(RVA = "0x313F698", Offset = "0x313F698", VA = "0x313F698")] private set
      {
      }
    }

    [Token(Token = "0x6004A97")]
    [Address(RVA = "0x313F6A4", Offset = "0x313F6A4", VA = "0x313F6A4")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x6004A98")]
    [Address(RVA = "0x313F790", Offset = "0x313F790", VA = "0x313F790")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x6004A99")]
    [Address(RVA = "0x313F798", Offset = "0x313F798", VA = "0x313F798")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x6004A9A")]
    [Address(RVA = "0x313F7A0", Offset = "0x313F7A0", VA = "0x313F7A0", Slot = "4")]
    public virtual void Destroy()
    {
    }

    [Token(Token = "0x6004A9B")]
    [Address(RVA = "0x313F9D0", Offset = "0x313F9D0", VA = "0x313F9D0")]
    public void PlayOpenAnimation(string groupID = "Open", UnityAction callback = null)
    {
    }

    [Token(Token = "0x6004A9C")]
    [Address(RVA = "0x313F800", Offset = "0x313F800", VA = "0x313F800")]
    public void PlayCloseAnimation(string groupID = "Close", UnityAction callback = null)
    {
    }

    [Token(Token = "0x6004A9D")]
    [Address(RVA = "0x313FBAC", Offset = "0x313FBAC", VA = "0x313FBAC")]
    private void PlayTimeline(
      UITimelineController.DirectionType directionType,
      UnityAction callback)
    {
    }

    [Token(Token = "0x6004A9E")]
    [Address(RVA = "0x313FF30", Offset = "0x313FF30", VA = "0x313FF30")]
    public void OnClickOutOfRange()
    {
    }

    [Token(Token = "0x6004A9F")]
    [Address(RVA = "0x313FF4C", Offset = "0x313FF4C", VA = "0x313FF4C")]
    public void SetEnableOutOfRangeEvent(bool enable)
    {
    }

    [Token(Token = "0x6004AA0")]
    [Address(RVA = "0x313FF58", Offset = "0x313FF58", VA = "0x313FF58")]
    public void ActivePositiveButton(bool active)
    {
    }

    [Token(Token = "0x6004AA1")]
    [Address(RVA = "0x313FF90", Offset = "0x313FF90", VA = "0x313FF90")]
    public void InitializeOutOfRangeEvent()
    {
    }

    [Token(Token = "0x6004AA2")]
    [Address(RVA = "0x313FFAC", Offset = "0x313FFAC", VA = "0x313FFAC", Slot = "5")]
    public virtual void OnClickClose()
    {
    }

    [Token(Token = "0x6004AA3")]
    [Address(RVA = "0x313FFB0", Offset = "0x313FFB0", VA = "0x313FFB0", Slot = "6")]
    public virtual void OnBackClosed()
    {
    }

    [Token(Token = "0x6004AA4")]
    [Address(RVA = "0x313FFB4", Offset = "0x313FFB4", VA = "0x313FFB4", Slot = "7")]
    public virtual void OnBackCurrent()
    {
    }

    [Token(Token = "0x6004AA5")]
    [Address(RVA = "0x313FFB8", Offset = "0x313FFB8", VA = "0x313FFB8", Slot = "8")]
    public virtual void Open()
    {
    }

    [Token(Token = "0x6004AA6")]
    [Address(RVA = "0x3140414", Offset = "0x3140414", VA = "0x3140414", Slot = "9")]
    public virtual void Close()
    {
    }

    [Token(Token = "0x6004AA7")]
    [Address(RVA = "0x3140580", Offset = "0x3140580", VA = "0x3140580")]
    public void DisableBackkey()
    {
    }

    [Token(Token = "0x6004AA8")]
    [Address(RVA = "0x313D5D8", Offset = "0x313D5D8", VA = "0x313D5D8")]
    public PopupBase()
    {
    }
  }
}
