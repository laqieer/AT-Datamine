// Decompiled with JetBrains decompiler
// Type: StaqData.Equipment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200201D")]
  public abstract class Equipment : Item, IBasicParameter, IBattleParameter
  {
    [Token(Token = "0x40088B8")]
    [FieldOffset(Offset = "0x28")]
    protected string itemName;
    [Token(Token = "0x40088B9")]
    [FieldOffset(Offset = "0x30")]
    protected ItemTypeEnum equipmentItemType;
    [Token(Token = "0x40088BA")]
    [FieldOffset(Offset = "0x34")]
    protected RarityTypeEnum equipmentRarity;

    [Token(Token = "0x170027EA")]
    public override string Name
    {
      [Token(Token = "0x600BFA2"), Address(RVA = "0x2009174", Offset = "0x2009174", VA = "0x2009174", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027EB")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BFA3"), Address(RVA = "0x200917C", Offset = "0x200917C", VA = "0x200917C", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170027EC")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BFA4"), Address(RVA = "0x2009184", Offset = "0x2009184", VA = "0x2009184", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027ED")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BFA5"), Address(RVA = "0x200918C", Offset = "0x200918C", VA = "0x200918C", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BFA6")]
    [Address(RVA = "0x2009194", Offset = "0x2009194", VA = "0x2009194")]
    public bool Equipped() => new bool();

    [Token(Token = "0x170027EE")]
    public UniqueID equipCharacterID
    {
      [Token(Token = "0x600BFA7"), Address(RVA = "0x200920C", Offset = "0x200920C", VA = "0x200920C")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600BFA8"), Address(RVA = "0x2009214", Offset = "0x2009214", VA = "0x2009214")] private set
      {
      }
    }

    [Token(Token = "0x170027EF")]
    public bool IsFavorite
    {
      [Token(Token = "0x600BFA9"), Address(RVA = "0x200921C", Offset = "0x200921C", VA = "0x200921C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BFAA"), Address(RVA = "0x2009224", Offset = "0x2009224", VA = "0x2009224")] set
      {
      }
    }

    [Token(Token = "0x170027F0")]
    public DateTime CreateAt
    {
      [Token(Token = "0x600BFAB"), Address(RVA = "0x2009230", Offset = "0x2009230", VA = "0x2009230")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600BFAC"), Address(RVA = "0x2009238", Offset = "0x2009238", VA = "0x2009238")] protected set
      {
      }
    }

    [Token(Token = "0x600BFAD")]
    public abstract int GetElementReinforceValue(ElementTypeEnum type);

    [Token(Token = "0x600BFAE")]
    public abstract int GetAttackReinforceValue(AttackTypeEnum type);

    [Token(Token = "0x600BFAF")]
    public abstract int GetBadStatusReinforceValue(BattleBadStatusTypeEnum type);

    [Token(Token = "0x600BFB0")]
    public abstract int GetElementResistValue(ElementTypeEnum type);

    [Token(Token = "0x600BFB1")]
    public abstract int GetAttackResistValue(AttackTypeEnum type);

    [Token(Token = "0x600BFB2")]
    public abstract int GetBadStatusResistValue(BattleBadStatusTypeEnum type);

    [Token(Token = "0x600BFB3")]
    [Address(RVA = "0x2009240", Offset = "0x2009240", VA = "0x2009240", Slot = "35")]
    public virtual float GetOptionEffectElementReinforceValue(ElementTypeEnum type) => new float();

    [Token(Token = "0x600BFB4")]
    [Address(RVA = "0x2009248", Offset = "0x2009248", VA = "0x2009248", Slot = "36")]
    public virtual float GetOptionEffectAttackReinforceValue(AttackTypeEnum type) => new float();

    [Token(Token = "0x600BFB5")]
    [Address(RVA = "0x2009250", Offset = "0x2009250", VA = "0x2009250", Slot = "37")]
    public virtual float GetOptionEffectBadStatusReinforceValue(BattleBadStatusTypeEnum type)
    {
      return new float();
    }

    [Token(Token = "0x600BFB6")]
    [Address(RVA = "0x2009258", Offset = "0x2009258", VA = "0x2009258", Slot = "38")]
    public virtual float GetOptionEffectElementResistValue(ElementTypeEnum type) => new float();

    [Token(Token = "0x600BFB7")]
    [Address(RVA = "0x2009260", Offset = "0x2009260", VA = "0x2009260", Slot = "39")]
    public virtual float GetOptionEffectAttackResistValue(AttackTypeEnum type) => new float();

    [Token(Token = "0x600BFB8")]
    [Address(RVA = "0x2009268", Offset = "0x2009268", VA = "0x2009268", Slot = "40")]
    public virtual float GetOptionEffectBadStatusResistValue(BattleBadStatusTypeEnum type)
    {
      return new float();
    }

    [Token(Token = "0x600BFB9")]
    public abstract bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType);

    [Token(Token = "0x600BFBA")]
    public abstract bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType);

    [Token(Token = "0x600BFBB")]
    public abstract bool IsAddedStatusBadStatusReinforceValue(
      BattleBadStatusTypeEnum battleBadStatusType);

    [Token(Token = "0x600BFBC")]
    public abstract bool IsAddedStatusElementResistValue(ElementTypeEnum elementType);

    [Token(Token = "0x600BFBD")]
    public abstract bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType);

    [Token(Token = "0x600BFBE")]
    public abstract bool IsAddedStatusBadStatusResistValue(
      BattleBadStatusTypeEnum battleBadStatusType);

    [Token(Token = "0x600BFBF")]
    public abstract bool CheckEnhancedBadge();

    [Token(Token = "0x170027F1")]
    public virtual int Life
    {
      [Token(Token = "0x600BFC0"), Address(RVA = "0x2009270", Offset = "0x2009270", VA = "0x2009270", Slot = "48")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFC1"), Address(RVA = "0x2009278", Offset = "0x2009278", VA = "0x2009278", Slot = "49")] protected set
      {
      }
    }

    [Token(Token = "0x170027F2")]
    public virtual int Strength
    {
      [Token(Token = "0x600BFC2"), Address(RVA = "0x2009280", Offset = "0x2009280", VA = "0x2009280", Slot = "50")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFC3"), Address(RVA = "0x2009288", Offset = "0x2009288", VA = "0x2009288", Slot = "51")] protected set
      {
      }
    }

    [Token(Token = "0x170027F3")]
    public virtual int Intelligence
    {
      [Token(Token = "0x600BFC4"), Address(RVA = "0x2009290", Offset = "0x2009290", VA = "0x2009290", Slot = "52")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFC5"), Address(RVA = "0x2009298", Offset = "0x2009298", VA = "0x2009298", Slot = "53")] protected set
      {
      }
    }

    [Token(Token = "0x170027F4")]
    public virtual int Vitality
    {
      [Token(Token = "0x600BFC6"), Address(RVA = "0x20092A0", Offset = "0x20092A0", VA = "0x20092A0", Slot = "54")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFC7"), Address(RVA = "0x20092A8", Offset = "0x20092A8", VA = "0x20092A8", Slot = "55")] protected set
      {
      }
    }

    [Token(Token = "0x170027F5")]
    public virtual int Mind
    {
      [Token(Token = "0x600BFC8"), Address(RVA = "0x20092B0", Offset = "0x20092B0", VA = "0x20092B0", Slot = "56")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFC9"), Address(RVA = "0x20092B8", Offset = "0x20092B8", VA = "0x20092B8", Slot = "57")] protected set
      {
      }
    }

    [Token(Token = "0x170027F6")]
    public virtual int Agility
    {
      [Token(Token = "0x600BFCA"), Address(RVA = "0x20092C0", Offset = "0x20092C0", VA = "0x20092C0", Slot = "58")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFCB"), Address(RVA = "0x20092C8", Offset = "0x20092C8", VA = "0x20092C8", Slot = "59")] protected set
      {
      }
    }

    [Token(Token = "0x170027F7")]
    public virtual int Dexterity
    {
      [Token(Token = "0x600BFCC"), Address(RVA = "0x20092D0", Offset = "0x20092D0", VA = "0x20092D0", Slot = "60")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFCD"), Address(RVA = "0x20092D8", Offset = "0x20092D8", VA = "0x20092D8", Slot = "61")] protected set
      {
      }
    }

    [Token(Token = "0x170027F8")]
    public virtual int Lucky
    {
      [Token(Token = "0x600BFCE"), Address(RVA = "0x20092E0", Offset = "0x20092E0", VA = "0x20092E0", Slot = "62")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFCF"), Address(RVA = "0x20092E8", Offset = "0x20092E8", VA = "0x20092E8", Slot = "63")] protected set
      {
      }
    }

    [Token(Token = "0x170027F9")]
    public virtual int HP
    {
      [Token(Token = "0x600BFD0"), Address(RVA = "0x20092F0", Offset = "0x20092F0", VA = "0x20092F0", Slot = "64")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFD1"), Address(RVA = "0x20092F8", Offset = "0x20092F8", VA = "0x20092F8", Slot = "65")] protected set
      {
      }
    }

    [Token(Token = "0x170027FA")]
    public int PhysicalAtk
    {
      [Token(Token = "0x600BFD2"), Address(RVA = "0x2009300", Offset = "0x2009300", VA = "0x2009300", Slot = "20")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFD3"), Address(RVA = "0x2009308", Offset = "0x2009308", VA = "0x2009308")] protected set
      {
      }
    }

    [Token(Token = "0x170027FB")]
    public int PhysicalDef
    {
      [Token(Token = "0x600BFD4"), Address(RVA = "0x2009310", Offset = "0x2009310", VA = "0x2009310", Slot = "21")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFD5"), Address(RVA = "0x2009318", Offset = "0x2009318", VA = "0x2009318")] protected set
      {
      }
    }

    [Token(Token = "0x170027FC")]
    public int MagicalAtk
    {
      [Token(Token = "0x600BFD6"), Address(RVA = "0x2009320", Offset = "0x2009320", VA = "0x2009320", Slot = "22")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFD7"), Address(RVA = "0x2009328", Offset = "0x2009328", VA = "0x2009328")] protected set
      {
      }
    }

    [Token(Token = "0x170027FD")]
    public int MagicalDef
    {
      [Token(Token = "0x600BFD8"), Address(RVA = "0x2009330", Offset = "0x2009330", VA = "0x2009330", Slot = "23")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFD9"), Address(RVA = "0x2009338", Offset = "0x2009338", VA = "0x2009338")] protected set
      {
      }
    }

    [Token(Token = "0x170027FE")]
    public int Hit
    {
      [Token(Token = "0x600BFDA"), Address(RVA = "0x2009340", Offset = "0x2009340", VA = "0x2009340", Slot = "24")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFDB"), Address(RVA = "0x2009348", Offset = "0x2009348", VA = "0x2009348")] protected set
      {
      }
    }

    [Token(Token = "0x170027FF")]
    public int Avoid
    {
      [Token(Token = "0x600BFDC"), Address(RVA = "0x2009350", Offset = "0x2009350", VA = "0x2009350", Slot = "25")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFDD"), Address(RVA = "0x2009358", Offset = "0x2009358", VA = "0x2009358")] protected set
      {
      }
    }

    [Token(Token = "0x17002800")]
    public int Critical
    {
      [Token(Token = "0x600BFDE"), Address(RVA = "0x2009360", Offset = "0x2009360", VA = "0x2009360", Slot = "26")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFDF"), Address(RVA = "0x2009368", Offset = "0x2009368", VA = "0x2009368")] protected set
      {
      }
    }

    [Token(Token = "0x17002801")]
    public int CriticalAvoid
    {
      [Token(Token = "0x600BFE0"), Address(RVA = "0x2009370", Offset = "0x2009370", VA = "0x2009370", Slot = "27")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFE1"), Address(RVA = "0x2009378", Offset = "0x2009378", VA = "0x2009378")] protected set
      {
      }
    }

    [Token(Token = "0x17002802")]
    public int AtkSpeed
    {
      [Token(Token = "0x600BFE2"), Address(RVA = "0x2009380", Offset = "0x2009380", VA = "0x2009380", Slot = "28")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFE3"), Address(RVA = "0x2009388", Offset = "0x2009388", VA = "0x2009388")] protected set
      {
      }
    }

    [Token(Token = "0x17002803")]
    public int Weight
    {
      [Token(Token = "0x600BFE4"), Address(RVA = "0x2009390", Offset = "0x2009390", VA = "0x2009390")] get
      {
        return new int();
      }
      [Token(Token = "0x600BFE5"), Address(RVA = "0x2009398", Offset = "0x2009398", VA = "0x2009398")] protected set
      {
      }
    }

    [Token(Token = "0x600BFE6")]
    [Address(RVA = "0x20093A0", Offset = "0x20093A0", VA = "0x20093A0")]
    public void Equip(UniqueID uniqueID)
    {
    }

    [Token(Token = "0x600BFE7")]
    [Address(RVA = "0x20093A8", Offset = "0x20093A8", VA = "0x20093A8")]
    public void UnEquip()
    {
    }

    [Token(Token = "0x600BFE8")]
    [Address(RVA = "0x20093B0", Offset = "0x20093B0", VA = "0x20093B0", Slot = "66")]
    public virtual int GetCombatPower() => new int();

    [Token(Token = "0x600BFE9")]
    [Address(RVA = "0x20094C4", Offset = "0x20094C4", VA = "0x20094C4", Slot = "67")]
    public virtual IBattleParameter GetBattleParameterByStyle(Style style)
    {
      return (IBattleParameter) null;
    }

    [Token(Token = "0x600BFEA")]
    [Address(RVA = "0x20094C8", Offset = "0x20094C8", VA = "0x20094C8", Slot = "68")]
    public virtual int GetWeightByAptitude(Style style) => new int();

    [Token(Token = "0x600BFEB")]
    [Address(RVA = "0x2006598", Offset = "0x2006598", VA = "0x2006598")]
    protected Equipment()
    {
    }
  }
}
