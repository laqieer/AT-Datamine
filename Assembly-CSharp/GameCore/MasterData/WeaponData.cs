// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F80")]
  [Serializable]
  public sealed class WeaponData : IMasterDataEntity, IEquipmentAddStatus
  {
    [Token(Token = "0x4004DFE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004DFF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004E00")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int prefabID;
    [Token(Token = "0x4004E01")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public bool isUnknownImage;
    [Token(Token = "0x4004E02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4004E03")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int equipmentClassification;
    [Token(Token = "0x4004E04")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string addFieldEffectSymbolName;
    [Token(Token = "0x4004E05")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public ElementTypeEnum element;
    [Token(Token = "0x4004E06")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public WeaponAttackTypeEnum weaponAttackType;
    [Token(Token = "0x4004E07")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int skillId;
    [Token(Token = "0x4004E08")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int skillUnLockLimitBreakCount;
    [Token(Token = "0x4004E09")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int limitBreakId;
    [Token(Token = "0x4004E0A")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public ComplementTypeEnum complement;
    [Token(Token = "0x4004E0B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int inscriptionCategory;
    [Token(Token = "0x4004E0C")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int normalAttackSkill;
    [Token(Token = "0x4004E0D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int normalAttackSkillLevel;
    [Token(Token = "0x4004E0E")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int optionLotteryGroup;
    [Token(Token = "0x4004E0F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int maxDurable;
    [Token(Token = "0x4004E10")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int initialPower;
    [Token(Token = "0x4004E11")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int limitPower;
    [Token(Token = "0x4004E12")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int initialHit;
    [Token(Token = "0x4004E13")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int limitHit;
    [Token(Token = "0x4004E14")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int initialAvoid;
    [Token(Token = "0x4004E15")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public int limitAvoid;
    [Token(Token = "0x4004E16")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public int initialCritical;
    [Token(Token = "0x4004E17")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public int limitCritical;
    [Token(Token = "0x4004E18")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    public int initialWeight;
    [Token(Token = "0x4004E19")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public int limitWeight;
    [Token(Token = "0x4004E1A")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    public int initialReinforceFire;
    [Token(Token = "0x4004E1B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public int limitReinforceFire;
    [Token(Token = "0x4004E1C")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    public int initialReinforceIce;
    [Token(Token = "0x4004E1D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public int limitReinforceIce;
    [Token(Token = "0x4004E1E")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public int initialReinforceThunder;
    [Token(Token = "0x4004E1F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public int limitReinforceThunder;
    [Token(Token = "0x4004E20")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    public int initialReinforceWind;
    [Token(Token = "0x4004E21")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public int limitReinforceWind;
    [Token(Token = "0x4004E22")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    public int initialReinforceLight;
    [Token(Token = "0x4004E23")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public int limitReinforceLight;
    [Token(Token = "0x4004E24")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    public int initialReinforceDark;
    [Token(Token = "0x4004E25")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public int limitReinforceDark;
    [Token(Token = "0x4004E26")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    public int initialReinforceSlash;
    [Token(Token = "0x4004E27")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public int limitReinforceSlash;
    [Token(Token = "0x4004E28")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    public int initialReinforceBlow;
    [Token(Token = "0x4004E29")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    public int limitReinforceBlow;
    [Token(Token = "0x4004E2A")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    public int initialReinforcePierce;
    [Token(Token = "0x4004E2B")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    public int limitReinforcePierce;
    [Token(Token = "0x4004E2C")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    public int initialReinforceShot;
    [Token(Token = "0x4004E2D")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public int limitReinforceShot;
    [Token(Token = "0x4004E2E")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    public int initialReinforceMagic;
    [Token(Token = "0x4004E2F")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public int limitReinforceMagic;
    [Token(Token = "0x4004E30")]
    [FieldOffset(Offset = "0xE4")]
    [SerializeField]
    public int initialReinforceProvocation;
    [Token(Token = "0x4004E31")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    public int limitReinforceProvocation;
    [Token(Token = "0x4004E32")]
    [FieldOffset(Offset = "0xEC")]
    [SerializeField]
    public int initialReinforceConfusion;
    [Token(Token = "0x4004E33")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    public int limitReinforceConfusion;
    [Token(Token = "0x4004E34")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    public int initialReinforceShakenUp;
    [Token(Token = "0x4004E35")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    public int limitReinforceShakenUp;
    [Token(Token = "0x4004E36")]
    [FieldOffset(Offset = "0xFC")]
    [SerializeField]
    public int initialReinforceCharmed;
    [Token(Token = "0x4004E37")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    public int limitReinforceCharmed;
    [Token(Token = "0x4004E38")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    public int initialReinforceBerserk;
    [Token(Token = "0x4004E39")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    public int limitReinforceBerserk;
    [Token(Token = "0x4004E3A")]
    [FieldOffset(Offset = "0x10C")]
    [SerializeField]
    public int initialReinforceBurned;
    [Token(Token = "0x4004E3B")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    public int limitReinforceBurned;
    [Token(Token = "0x4004E3C")]
    [FieldOffset(Offset = "0x114")]
    [SerializeField]
    public int initialReinforceSleep;
    [Token(Token = "0x4004E3D")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    public int limitReinforceSleep;
    [Token(Token = "0x4004E3E")]
    [FieldOffset(Offset = "0x11C")]
    [SerializeField]
    public int initialReinforceParalysis;
    [Token(Token = "0x4004E3F")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    public int limitReinforceParalysis;
    [Token(Token = "0x4004E40")]
    [FieldOffset(Offset = "0x124")]
    [SerializeField]
    public int initialReinforcePoison;
    [Token(Token = "0x4004E41")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    public int limitReinforcePoison;
    [Token(Token = "0x4004E42")]
    [FieldOffset(Offset = "0x12C")]
    [SerializeField]
    public int initialReinforceDeadlyPoison;
    [Token(Token = "0x4004E43")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    public int limitReinforceDeadlyPoison;
    [Token(Token = "0x4004E44")]
    [FieldOffset(Offset = "0x134")]
    [SerializeField]
    public int initialReinforceBleeding;
    [Token(Token = "0x4004E45")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    public int limitReinforceBleeding;
    [Token(Token = "0x4004E46")]
    [FieldOffset(Offset = "0x13C")]
    [SerializeField]
    public int initialReinforceDazzlement;
    [Token(Token = "0x4004E47")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    public int limitReinforceDazzlement;
    [Token(Token = "0x4004E48")]
    [FieldOffset(Offset = "0x144")]
    [SerializeField]
    public int initialReinforceDarkness;
    [Token(Token = "0x4004E49")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    public int limitReinforceDarkness;
    [Token(Token = "0x4004E4A")]
    [FieldOffset(Offset = "0x14C")]
    [SerializeField]
    public int initialReinforcePetrifaction;
    [Token(Token = "0x4004E4B")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    public int limitReinforcePetrifaction;
    [Token(Token = "0x4004E4C")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    public int initialReinforceDontAction;
    [Token(Token = "0x4004E4D")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    public int limitReinforceDontAction;
    [Token(Token = "0x4004E4E")]
    [FieldOffset(Offset = "0x15C")]
    [SerializeField]
    public int initialReinforceDontMove;
    [Token(Token = "0x4004E4F")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    public int limitReinforceDontMove;
    [Token(Token = "0x4004E50")]
    [FieldOffset(Offset = "0x164")]
    [SerializeField]
    public int initialReinforceDontUseSkill;
    [Token(Token = "0x4004E51")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    public int limitReinforceDontUseSkill;
    [Token(Token = "0x4004E52")]
    [FieldOffset(Offset = "0x16C")]
    [SerializeField]
    public int initialReinforceDoom;
    [Token(Token = "0x4004E53")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    public int limitReinforceDoom;

    [Token(Token = "0x17000D7C")]
    public int Key
    {
      [Token(Token = "0x6005B20"), Address(RVA = "0x277D69C", Offset = "0x277D69C", VA = "0x277D69C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B21")]
    [Address(RVA = "0x277D6A4", Offset = "0x277D6A4", VA = "0x277D6A4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B22")]
    [Address(RVA = "0x277F734", Offset = "0x277F734", VA = "0x277F734", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D7D")]
    public string Name
    {
      [Token(Token = "0x6005B23"), Address(RVA = "0x277FD00", Offset = "0x277FD00", VA = "0x277FD00")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D7E")]
    public string Flavor
    {
      [Token(Token = "0x6005B24"), Address(RVA = "0x277FDDC", Offset = "0x277FDDC", VA = "0x277FDDC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005B25")]
    [Address(RVA = "0x277FEB8", Offset = "0x277FEB8", VA = "0x277FEB8")]
    public int[] GetInitParameters() => (int[]) null;

    [Token(Token = "0x6005B26")]
    [Address(RVA = "0x277FF60", Offset = "0x277FF60", VA = "0x277FF60", Slot = "7")]
    public int GetElementReinforceValue(ElementTypeEnum element, int level) => new int();

    [Token(Token = "0x6005B27")]
    [Address(RVA = "0x27800B8", Offset = "0x27800B8", VA = "0x27800B8", Slot = "8")]
    public int GetAttackReinforceValue(AttackTypeEnum attackType, int level) => new int();

    [Token(Token = "0x6005B28")]
    [Address(RVA = "0x2780204", Offset = "0x2780204", VA = "0x2780204", Slot = "9")]
    public int GetBadStatusReinforceValue(BattleBadStatusTypeEnum badStatusType, int level)
    {
      return new int();
    }

    [Token(Token = "0x6005B29")]
    [Address(RVA = "0x27803E0", Offset = "0x27803E0", VA = "0x27803E0", Slot = "10")]
    public int GetElementResistValue(ElementTypeEnum element, int level) => new int();

    [Token(Token = "0x6005B2A")]
    [Address(RVA = "0x27803E8", Offset = "0x27803E8", VA = "0x27803E8", Slot = "11")]
    public int GetAttackResistValue(AttackTypeEnum attackType, int level) => new int();

    [Token(Token = "0x6005B2B")]
    [Address(RVA = "0x27803F0", Offset = "0x27803F0", VA = "0x27803F0", Slot = "12")]
    public int GetBadStatusResistValue(BattleBadStatusTypeEnum badStatusType, int level)
    {
      return new int();
    }

    [Token(Token = "0x6005B2C")]
    [Address(RVA = "0x27803F8", Offset = "0x27803F8", VA = "0x27803F8", Slot = "13")]
    public bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x6005B2D")]
    [Address(RVA = "0x278048C", Offset = "0x278048C", VA = "0x278048C", Slot = "14")]
    public bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x6005B2E")]
    [Address(RVA = "0x2780514", Offset = "0x2780514", VA = "0x2780514", Slot = "15")]
    public bool IsAddedStatusBadStatusReinforceValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x6005B2F")]
    [Address(RVA = "0x278062C", Offset = "0x278062C", VA = "0x278062C", Slot = "16")]
    public bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x6005B30")]
    [Address(RVA = "0x2780634", Offset = "0x2780634", VA = "0x2780634", Slot = "17")]
    public bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x6005B31")]
    [Address(RVA = "0x278063C", Offset = "0x278063C", VA = "0x278063C", Slot = "18")]
    public bool IsAddedStatusBadStatusResistValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x6005B32")]
    [Address(RVA = "0x2780644", Offset = "0x2780644", VA = "0x2780644")]
    public WeaponData()
    {
    }
  }
}
