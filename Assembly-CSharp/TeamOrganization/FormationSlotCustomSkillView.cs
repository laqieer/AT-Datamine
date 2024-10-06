// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationSlotCustomSkillView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000817")]
  public class FormationSlotCustomSkillView : MonoBehaviour
  {
    [Token(Token = "0x400264B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton customSkillButton;
    [Token(Token = "0x400264C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FormationSlotCustomSkillCell[] customSkillCells;
    [Token(Token = "0x400264D")]
    [FieldOffset(Offset = "0x28")]
    private Action<OrganizationPartySlot> onClickCustomSkillSlotButton;
    [Token(Token = "0x400264E")]
    [FieldOffset(Offset = "0x30")]
    protected OrganizationPartySlot partySlot;
    [Token(Token = "0x400264F")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6002E64")]
    [Address(RVA = "0x3A94430", Offset = "0x3A94430", VA = "0x3A94430")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E65")]
    [Address(RVA = "0x3A944E4", Offset = "0x3A944E4", VA = "0x3A944E4")]
    public void UpdateView(OrganizationPartySlot organizationPartySlot)
    {
    }

    [Token(Token = "0x6002E66")]
    [Address(RVA = "0x3A946BC", Offset = "0x3A946BC", VA = "0x3A946BC")]
    private void OnClickCustomSkillButton()
    {
    }

    [Token(Token = "0x6002E67")]
    [Address(RVA = "0x3A947E4", Offset = "0x3A947E4", VA = "0x3A947E4")]
    public void SetCustomSkillSlotAction(
      Action<OrganizationPartySlot> onClickCustomSkillSlotButton)
    {
    }

    [Token(Token = "0x6002E68")]
    [Address(RVA = "0x3A947EC", Offset = "0x3A947EC", VA = "0x3A947EC")]
    public FormationSlotCustomSkillView()
    {
    }
  }
}
