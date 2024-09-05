// Decompiled with JetBrains decompiler
// Type: TeamOrganization.WeaponProficiencyPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000832")]
  public class WeaponProficiencyPopup : PopupBase
  {
    [Token(Token = "0x400270E")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform listItemParent;
    [Token(Token = "0x400270F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4002710")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private WeaponProficiencySlotView baseItem;
    [Token(Token = "0x4002711")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4002712")]
    [FieldOffset(Offset = "0xA8")]
    private List<WeaponProficiencySlotView> slotViews;

    [Token(Token = "0x170006F2")]
    public Action OnCloseAction
    {
      [Token(Token = "0x6002F32"), Address(RVA = "0x3E6CBB8", Offset = "0x3E6CBB8", VA = "0x3E6CBB8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6002F33"), Address(RVA = "0x3E6CBC0", Offset = "0x3E6CBC0", VA = "0x3E6CBC0")] set
      {
      }
    }

    [Token(Token = "0x6002F34")]
    [Address(RVA = "0x3E6CBC8", Offset = "0x3E6CBC8", VA = "0x3E6CBC8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6002F35")]
    [Address(RVA = "0x3E6CC54", Offset = "0x3E6CC54", VA = "0x3E6CC54")]
    public void SetData(
      WeaponProficiencyPopup.WeaponProficiencyViewType viewType,
      OrganizationPartySlot[] partySlot,
      TeamView teamView)
    {
    }

    [Token(Token = "0x6002F36")]
    [Address(RVA = "0x3E6CE6C", Offset = "0x3E6CE6C", VA = "0x3E6CE6C")]
    public void SetStyleThumb()
    {
    }

    [Token(Token = "0x6002F37")]
    [Address(RVA = "0x3E6CFB8", Offset = "0x3E6CFB8", VA = "0x3E6CFB8")]
    public void OnClickToClose()
    {
    }

    [Token(Token = "0x6002F38")]
    [Address(RVA = "0x3E6CFD4", Offset = "0x3E6CFD4", VA = "0x3E6CFD4")]
    public WeaponProficiencyPopup()
    {
    }

    [Token(Token = "0x2000833")]
    public enum WeaponProficiencyViewType
    {
      [Token(Token = "0x4002715")] Party,
      [Token(Token = "0x4002716")] Support,
      [Token(Token = "0x4002717")] NotStyleImage,
    }
  }
}
