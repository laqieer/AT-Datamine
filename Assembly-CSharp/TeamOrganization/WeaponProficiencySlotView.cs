// Decompiled with JetBrains decompiler
// Type: TeamOrganization.WeaponProficiencySlotView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200080E")]
  public class WeaponProficiencySlotView : PartySlotView
  {
    [Token(Token = "0x4002627")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x4002628")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private WeaponProficiencyView weaponProficiencyView;
    [Token(Token = "0x400262A")]
    [FieldOffset(Offset = "0x8C")]
    private WeaponProficiencyPopup.WeaponProficiencyViewType viewType;

    [Token(Token = "0x170006E0")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6002E35"), Address(RVA = "0x3A91E24", Offset = "0x3A91E24", VA = "0x3A91E24")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170006E1")]
    public bool IsStyleView
    {
      [Token(Token = "0x6002E36"), Address(RVA = "0x3A91E2C", Offset = "0x3A91E2C", VA = "0x3A91E2C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002E37"), Address(RVA = "0x3A91E34", Offset = "0x3A91E34", VA = "0x3A91E34")] set
      {
      }
    }

    [Token(Token = "0x6002E38")]
    [Address(RVA = "0x3A91E40", Offset = "0x3A91E40", VA = "0x3A91E40")]
    public void SetOneData(
      WeaponProficiencyPopup.WeaponProficiencyViewType viewType,
      TeamView teamView)
    {
    }

    [Token(Token = "0x6002E39")]
    [Address(RVA = "0x3A91E58", Offset = "0x3A91E58", VA = "0x3A91E58", Slot = "4")]
    public override void Initialize(
      UnitNodeDotCell unitNodeDotCell,
      TeamView teamView,
      bool isNeedLp)
    {
    }

    [Token(Token = "0x6002E3A")]
    [Address(RVA = "0x3A91EA4", Offset = "0x3A91EA4", VA = "0x3A91EA4", Slot = "5")]
    public override void UpdateView(
      OrganizationPartySlot organizationPartySlot,
      bool checkAttention)
    {
    }

    [Token(Token = "0x6002E3B")]
    [Address(RVA = "0x3A924A8", Offset = "0x3A924A8", VA = "0x3A924A8")]
    public void SetStyleThumb()
    {
    }

    [Token(Token = "0x6002E3C")]
    [Address(RVA = "0x3A92580", Offset = "0x3A92580", VA = "0x3A92580")]
    public WeaponProficiencySlotView()
    {
    }
  }
}
