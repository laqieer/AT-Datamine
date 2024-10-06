// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationSlotEnchanceMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000818")]
  public class FormationSlotEnchanceMenu : MonoBehaviour
  {
    [Token(Token = "0x4002650")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002651")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] levelUpObjs;
    [Token(Token = "0x4002652")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] styleBoardObjs;
    [Token(Token = "0x4002653")]
    [FieldOffset(Offset = "0x30")]
    private Action<OrganizationPartySlot> onClickLevelUp;
    [Token(Token = "0x4002654")]
    [FieldOffset(Offset = "0x38")]
    private Action<OrganizationPartySlot> onClickStyleBoard;
    [Token(Token = "0x4002655")]
    [FieldOffset(Offset = "0x40")]
    private string OPEN_ANIM_NAME_FORMAT;
    [Token(Token = "0x4002656")]
    [FieldOffset(Offset = "0x48")]
    private string OUT_ANIM_NAME_FORMAT;
    [Token(Token = "0x4002657")]
    [FieldOffset(Offset = "0x50")]
    private OrganizationPartySlot partySlot;

    [Token(Token = "0x6002E69")]
    [Address(RVA = "0x3A947F4", Offset = "0x3A947F4", VA = "0x3A947F4")]
    public void Initialize(
      Action<OrganizationPartySlot> clickLevelUpAction,
      Action<OrganizationPartySlot> clickStyleBoardAction)
    {
    }

    [Token(Token = "0x6002E6A")]
    [Address(RVA = "0x3A947FC", Offset = "0x3A947FC", VA = "0x3A947FC")]
    public void OpenEnchanceMenu(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6002E6B")]
    [Address(RVA = "0x3A948C4", Offset = "0x3A948C4", VA = "0x3A948C4")]
    private void UpdateMaskView(int index)
    {
    }

    [Token(Token = "0x6002E6C")]
    [Address(RVA = "0x3A949D8", Offset = "0x3A949D8", VA = "0x3A949D8")]
    public void OnLevelUpButton()
    {
    }

    [Token(Token = "0x6002E6D")]
    [Address(RVA = "0x3A949F8", Offset = "0x3A949F8", VA = "0x3A949F8")]
    public void OnStyleBoardButton()
    {
    }

    [Token(Token = "0x6002E6E")]
    [Address(RVA = "0x3A94A18", Offset = "0x3A94A18", VA = "0x3A94A18")]
    public void OnCloseButton()
    {
    }

    [Token(Token = "0x6002E6F")]
    [Address(RVA = "0x3A94B14", Offset = "0x3A94B14", VA = "0x3A94B14")]
    public FormationSlotEnchanceMenu()
    {
    }
  }
}
