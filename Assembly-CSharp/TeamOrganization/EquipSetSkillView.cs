// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetSkillView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007D0")]
  public class EquipSetSkillView : MonoBehaviour
  {
    [Token(Token = "0x4002478")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EquipSetSkillCell styleSkill;
    [Token(Token = "0x4002479")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipSetSkillCell equipmentSkill;
    [Token(Token = "0x400247A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EquipSetSkillCell customSkill;
    [Token(Token = "0x400247B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private EquipSetSkillCell commuSkill;

    [Token(Token = "0x6002C2A")]
    [Address(RVA = "0x3878C18", Offset = "0x3878C18", VA = "0x3878C18")]
    private void Awake()
    {
    }

    [Token(Token = "0x6002C2B")]
    [Address(RVA = "0x3878C88", Offset = "0x3878C88", VA = "0x3878C88")]
    public void UpdateUnitSkillView(Style style, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C2C")]
    [Address(RVA = "0x3879A18", Offset = "0x3879A18", VA = "0x3879A18")]
    public void UpdateCommuSkillView(
      int characterId,
      List<CommunicationSkill> communicationSkills,
      IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C2D")]
    [Address(RVA = "0x387AB78", Offset = "0x387AB78", VA = "0x387AB78")]
    public void UpdateEquipSkillView(OrganizationPartySlot partySlot, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C2E")]
    [Address(RVA = "0x387B460", Offset = "0x387B460", VA = "0x387B460")]
    public void UpdateCustomSkillView(CustomSkill[] customSkills, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C2F")]
    [Address(RVA = "0x387B5FC", Offset = "0x387B5FC", VA = "0x387B5FC")]
    public void UpdateSkillView(OrganizationPartySlot partySlot, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C30")]
    [Address(RVA = "0x387B804", Offset = "0x387B804", VA = "0x387B804")]
    public EquipSetSkillView()
    {
    }
  }
}
