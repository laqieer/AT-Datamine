// Decompiled with JetBrains decompiler
// Type: Battle.UI.StyleModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Style;
using System;
using TeamOrganization;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200239B")]
  public class StyleModel : StyleModelBase
  {
    [Token(Token = "0x4009787")]
    [FieldOffset(Offset = "0x78")]
    private CharacterModel character;
    [Token(Token = "0x4009788")]
    [FieldOffset(Offset = "0x80")]
    private AdditionalParameterModel additionalParameterModel;
    [Token(Token = "0x4009789")]
    [FieldOffset(Offset = "0x88")]
    private SkillModelList styleSkills;
    [Token(Token = "0x400978A")]
    [FieldOffset(Offset = "0x90")]
    private SkillModelList unlockedStyleSkills;
    [Token(Token = "0x400978B")]
    [FieldOffset(Offset = "0x98")]
    private SkillModelList commuSkills;
    [Token(Token = "0x400978C")]
    [FieldOffset(Offset = "0xA0")]
    private SkillModelList unlockedCommuSkills;

    [Token(Token = "0x17002ED8")]
    public override AdditionalParameterModelBase AdditionalParameter
    {
      [Token(Token = "0x600D99A"), Address(RVA = "0x22CFF6C", Offset = "0x22CFF6C", VA = "0x22CFF6C", Slot = "4")] get
      {
        return (AdditionalParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002ED9")]
    public override SkillModelListBase StyleSkills
    {
      [Token(Token = "0x600D99B"), Address(RVA = "0x22CFF74", Offset = "0x22CFF74", VA = "0x22CFF74", Slot = "5")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17002EDA")]
    public override SkillModelListBase UnlockedStyleSkills
    {
      [Token(Token = "0x600D99C"), Address(RVA = "0x22CFF7C", Offset = "0x22CFF7C", VA = "0x22CFF7C", Slot = "6")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17002EDB")]
    public override SkillModelListBase CommuSkills
    {
      [Token(Token = "0x600D99D"), Address(RVA = "0x22CFF84", Offset = "0x22CFF84", VA = "0x22CFF84", Slot = "7")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17002EDC")]
    public override SkillModelListBase UnlockedCommuSkills
    {
      [Token(Token = "0x600D99E"), Address(RVA = "0x22CFF8C", Offset = "0x22CFF8C", VA = "0x22CFF8C", Slot = "8")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x14000138")]
    public override event Action OnChange
    {
      [Token(Token = "0x600D99F"), Address(RVA = "0x22CFF94", Offset = "0x22CFF94", VA = "0x22CFF94", Slot = "9")] add
      {
      }
      [Token(Token = "0x600D9A0"), Address(RVA = "0x22D0030", Offset = "0x22D0030", VA = "0x22D0030", Slot = "10")] remove
      {
      }
    }

    [Token(Token = "0x600D9A1")]
    [Address(RVA = "0x22D00CC", Offset = "0x22D00CC", VA = "0x22D00CC")]
    public void Set(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D9A2")]
    [Address(RVA = "0x22D0808", Offset = "0x22D0808", VA = "0x22D0808")]
    public void Set(StyleModel model)
    {
    }

    [Token(Token = "0x600D9A3")]
    [Address(RVA = "0x22D0610", Offset = "0x22D0610", VA = "0x22D0610")]
    private void SetUnlocked(
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      int value)
    {
    }

    [Token(Token = "0x600D9A4")]
    [Address(RVA = "0x22D0990", Offset = "0x22D0990", VA = "0x22D0990")]
    public StyleModel()
    {
    }
  }
}
