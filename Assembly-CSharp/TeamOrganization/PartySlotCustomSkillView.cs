// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartySlotCustomSkillView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007F1")]
  public class PartySlotCustomSkillView : MonoBehaviour
  {
    [Token(Token = "0x4002526")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button customSkillButton;
    [Token(Token = "0x4002527")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CustomSkillSlot[] customSkillSlots;
    [Token(Token = "0x4002528")]
    [FieldOffset(Offset = "0x28")]
    private Action<OrganizationPartySlot> onClickCustomSkillSlotButton;
    [Token(Token = "0x4002529")]
    [FieldOffset(Offset = "0x30")]
    protected OrganizationPartySlot partySlot;

    [Token(Token = "0x6002D53")]
    [Address(RVA = "0x3A871B8", Offset = "0x3A871B8", VA = "0x3A871B8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6002D54")]
    [Address(RVA = "0x3A8724C", Offset = "0x3A8724C", VA = "0x3A8724C")]
    public void UpdateView(OrganizationPartySlot organizationPartySlot)
    {
    }

    [Token(Token = "0x6002D55")]
    [Address(RVA = "0x3A872CC", Offset = "0x3A872CC", VA = "0x3A872CC")]
    public void UpdateAttentionIcon(PartySlotAttentionData attentionData)
    {
    }

    [Token(Token = "0x6002D56")]
    [Address(RVA = "0x3A87364", Offset = "0x3A87364", VA = "0x3A87364")]
    private void OnClickCustomSkillButton()
    {
    }

    [Token(Token = "0x6002D57")]
    [Address(RVA = "0x3A87398", Offset = "0x3A87398", VA = "0x3A87398")]
    public void SetCustomSkillSlotAction(
      Action<OrganizationPartySlot> onClickCustomSkillSlotButton)
    {
    }

    [Token(Token = "0x6002D58")]
    [Address(RVA = "0x3A873A0", Offset = "0x3A873A0", VA = "0x3A873A0")]
    public PartySlotCustomSkillView()
    {
    }
  }
}
