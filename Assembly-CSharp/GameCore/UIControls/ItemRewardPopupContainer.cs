// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.ItemRewardPopupContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BFA")]
  public class ItemRewardPopupContainer : MonoBehaviour
  {
    [Token(Token = "0x4003650")]
    [FieldOffset(Offset = "0x18")]
    public int DisplayLimit;
    [Token(Token = "0x4003651")]
    [FieldOffset(Offset = "0x20")]
    public GameObject touchPreventionObject;
    [Token(Token = "0x4003652")]
    [FieldOffset(Offset = "0x28")]
    public GameObject displayTitleObject;
    [Token(Token = "0x4003653")]
    [FieldOffset(Offset = "0x30")]
    public GameObject displayContentTextObject;
    [Token(Token = "0x4003654")]
    [FieldOffset(Offset = "0x38")]
    public Text displayContentText;
    [Token(Token = "0x4003655")]
    [FieldOffset(Offset = "0x40")]
    public Button closeButton;
    [Token(Token = "0x4003656")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ItemRewardPopupContent itemRewardPopupContent;
    [Token(Token = "0x4003658")]
    [FieldOffset(Offset = "0x58")]
    public QuestRewardCustomSkillUI displayCustomSkillItemObject;
    [Token(Token = "0x4003659")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private string[] InItemEffectTrackNames;
    [Token(Token = "0x400365A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform parent;
    [Token(Token = "0x400365B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<Text> displayItemNameTextObjects;
    [Token(Token = "0x400365C")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<TextMeshProUGUI> displayItemQuantityTextObjects;
    [Token(Token = "0x400365D")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400365E")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400365F")]
    [FieldOffset(Offset = "0x90")]
    private string customSkillName;
    [Token(Token = "0x4003660")]
    [FieldOffset(Offset = "0x98")]
    private int customSkillId;

    [Token(Token = "0x170009F1")]
    public List<ItemRewardPopupContent> contentList
    {
      [Token(Token = "0x600449F"), Address(RVA = "0x364B4BC", Offset = "0x364B4BC", VA = "0x364B4BC")] get
      {
        return (List<ItemRewardPopupContent>) null;
      }
      [Token(Token = "0x60044A0"), Address(RVA = "0x364B4C4", Offset = "0x364B4C4", VA = "0x364B4C4")] private set
      {
      }
    }

    [Token(Token = "0x60044A1")]
    [Address(RVA = "0x364B4CC", Offset = "0x364B4CC", VA = "0x364B4CC")]
    public void DisplayTitle(bool active)
    {
    }

    [Token(Token = "0x60044A2")]
    [Address(RVA = "0x364A9F0", Offset = "0x364A9F0", VA = "0x364A9F0")]
    public void SetEnableByButtonComponent(bool enable)
    {
    }

    [Token(Token = "0x60044A3")]
    [Address(RVA = "0x364B4EC", Offset = "0x364B4EC", VA = "0x364B4EC")]
    public void SetCloseBtn(bool state)
    {
    }

    [Token(Token = "0x60044A4")]
    [Address(RVA = "0x364ABB0", Offset = "0x364ABB0", VA = "0x364ABB0")]
    public void AddCloseButtonCallback(UnityAction closeAction)
    {
    }

    [Token(Token = "0x60044A5")]
    [Address(RVA = "0x364AB8C", Offset = "0x364AB8C", VA = "0x364AB8C")]
    public void RemoveCloseButtonCallback(UnityAction closeAction)
    {
    }

    [Token(Token = "0x60044A6")]
    [Address(RVA = "0x364AC60", Offset = "0x364AC60", VA = "0x364AC60")]
    public void AddBackKeyCallback(Action action)
    {
    }

    [Token(Token = "0x60044A7")]
    [Address(RVA = "0x364ABD4", Offset = "0x364ABD4", VA = "0x364ABD4")]
    public void RemoveBackKeyCallback(Action action)
    {
    }

    [Token(Token = "0x60044A8")]
    [Address(RVA = "0x364B50C", Offset = "0x364B50C", VA = "0x364B50C")]
    public void DisplayTextContent(bool active)
    {
    }

    [Token(Token = "0x60044A9")]
    [Address(RVA = "0x3649B9C", Offset = "0x3649B9C", VA = "0x3649B9C")]
    public void SetTextContent(string text)
    {
    }

    [Token(Token = "0x60044AA")]
    [Address(RVA = "0x364AA10", Offset = "0x364AA10", VA = "0x364AA10")]
    public void SetTouchPreventionObjectActive(bool active)
    {
    }

    [Token(Token = "0x60044AB")]
    [Address(RVA = "0x364B52C", Offset = "0x364B52C", VA = "0x364B52C")]
    public void SetBGAlpha(int value)
    {
    }

    [Token(Token = "0x60044AC")]
    [Address(RVA = "0x364B5D0", Offset = "0x364B5D0", VA = "0x364B5D0")]
    public UITimelineController GetUITimelineController() => (UITimelineController) null;

    [Token(Token = "0x60044AD")]
    [Address(RVA = "0x364B5D8", Offset = "0x364B5D8", VA = "0x364B5D8")]
    public void SetActivingTimelieMute(int num)
    {
    }

    [Token(Token = "0x60044AE")]
    [Address(RVA = "0x364B64C", Offset = "0x364B64C", VA = "0x364B64C", Slot = "4")]
    public virtual void SetDisplayItemNum(int num)
    {
    }

    [Token(Token = "0x60044AF")]
    [Address(RVA = "0x364A2D0", Offset = "0x364A2D0", VA = "0x364A2D0")]
    public IEnumerator TurnOnItemIcon() => (IEnumerator) null;

    [Token(Token = "0x60044B0")]
    [Address(RVA = "0x364A350", Offset = "0x364A350", VA = "0x364A350")]
    public void ShowItemIcons()
    {
    }

    [Token(Token = "0x60044B1")]
    [Address(RVA = "0x3649E70", Offset = "0x3649E70", VA = "0x3649E70")]
    public void InitializeItemText()
    {
    }

    [Token(Token = "0x60044B2")]
    [Address(RVA = "0x364A060", Offset = "0x364A060", VA = "0x364A060")]
    public void SetItemText(int index, string itemName, int quantity)
    {
    }

    [Token(Token = "0x60044B3")]
    [Address(RVA = "0x364A298", Offset = "0x364A298", VA = "0x364A298")]
    public void SetCustomSkillItem(string itemName, int customSkillId)
    {
    }

    [Token(Token = "0x60044B4")]
    [Address(RVA = "0x364B81C", Offset = "0x364B81C", VA = "0x364B81C")]
    public ItemRewardPopupContainer()
    {
    }
  }
}
