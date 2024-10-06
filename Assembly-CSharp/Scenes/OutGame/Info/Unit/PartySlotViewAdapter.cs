// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Unit.PartySlotViewAdapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace Scenes.OutGame.Info.Unit
{
  [Token(Token = "0x2003546")]
  public class PartySlotViewAdapter : IUnitEquipmentView
  {
    [Token(Token = "0x400E7AD")]
    [FieldOffset(Offset = "0x10")]
    protected PartySlotView partySlotView;
    [Token(Token = "0x400E7AE")]
    [FieldOffset(Offset = "0x18")]
    protected OrganizationPartySlot partySlot;
    [Token(Token = "0x400E7AF")]
    [FieldOffset(Offset = "0x20")]
    private bool isNeedLp;

    [Token(Token = "0x6014E69")]
    [Address(RVA = "0x1B49764", Offset = "0x1B49764", VA = "0x1B49764")]
    public PartySlotViewAdapter(
      PartySlotView partySlotView,
      OrganizationPartySlot.SlotType slotType,
      bool isNeedLp)
    {
    }

    [Token(Token = "0x6014E6A")]
    [Address(RVA = "0x1B497FC", Offset = "0x1B497FC", VA = "0x1B497FC", Slot = "4")]
    public void Set(UnitModelBase unit)
    {
    }

    [Token(Token = "0x6014E6B")]
    [Address(RVA = "0x1B498A0", Offset = "0x1B498A0", VA = "0x1B498A0")]
    private void Set(
      UniqueID style,
      UniqueID mainweapon,
      UniqueID subweapon1,
      UniqueID subweapon2,
      UniqueID accessory,
      UniqueID unitTrust,
      UniqueID mindEquipment,
      List<UniqueID> customSkillIdList,
      bool isForExpendition)
    {
    }

    [Token(Token = "0x6014E6C")]
    [Address(RVA = "0x1B49A4C", Offset = "0x1B49A4C", VA = "0x1B49A4C", Slot = "5")]
    protected virtual void SelectStyle(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6014E6D")]
    [Address(RVA = "0x1B49A50", Offset = "0x1B49A50", VA = "0x1B49A50", Slot = "6")]
    protected virtual void SelectEquipment(
      OrganizationPartySlot partySlot,
      OrganizationEquipmentSlot equipmentSlot)
    {
    }
  }
}
