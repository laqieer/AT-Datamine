// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MindEquipmentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F65")]
  [Serializable]
  public sealed class MindEquipmentData : IMasterDataEntity, IEquipmentAddStatus
  {
    [Token(Token = "0x4004D2F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D30")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004D31")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int medalExchangeId;
    [Token(Token = "0x4004D32")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int medalExchangeValue;
    [Token(Token = "0x4004D33")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int partySkill;
    [Token(Token = "0x4004D34")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int trustMaster;
    [Token(Token = "0x4004D35")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ComplementTypeEnum complement;
    [Token(Token = "0x4004D36")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int limitBreakId;
    [Token(Token = "0x4004D37")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int initialHp;
    [Token(Token = "0x4004D38")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int limitHp;
    [Token(Token = "0x4004D39")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int initialPhysicsAttack;
    [Token(Token = "0x4004D3A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int limitPhysicsAttack;
    [Token(Token = "0x4004D3B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int initialMagicAttack;
    [Token(Token = "0x4004D3C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int limitMagicAttack;
    [Token(Token = "0x4004D3D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int initialPhysicsDefence;
    [Token(Token = "0x4004D3E")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int limitPhysicsDefence;
    [Token(Token = "0x4004D3F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int initialMagicDefence;
    [Token(Token = "0x4004D40")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int limitMagicDefence;
    [Token(Token = "0x4004D41")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int initialHit;
    [Token(Token = "0x4004D42")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int limitHit;
    [Token(Token = "0x4004D43")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int initialAvoid;
    [Token(Token = "0x4004D44")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int limitAvoid;
    [Token(Token = "0x4004D45")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int initialCritical;
    [Token(Token = "0x4004D46")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int limitCritical;
    [Token(Token = "0x4004D47")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int initialCriticalAvoid;
    [Token(Token = "0x4004D48")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int limitCriticalAvoid;
    [Token(Token = "0x4004D49")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public int initialReinforceFire;
    [Token(Token = "0x4004D4A")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public int limitReinforceFire;
    [Token(Token = "0x4004D4B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public int initialReinforceIce;
    [Token(Token = "0x4004D4C")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    public int limitReinforceIce;
    [Token(Token = "0x4004D4D")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public int initialReinforceThunder;
    [Token(Token = "0x4004D4E")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    public int limitReinforceThunder;
    [Token(Token = "0x4004D4F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public int initialReinforceWind;
    [Token(Token = "0x4004D50")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    public int limitReinforceWind;
    [Token(Token = "0x4004D51")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public int initialReinforceLight;
    [Token(Token = "0x4004D52")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public int limitReinforceLight;
    [Token(Token = "0x4004D53")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public int initialReinforceDark;
    [Token(Token = "0x4004D54")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    public int limitReinforceDark;
    [Token(Token = "0x4004D55")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public int initialReinforceSlash;
    [Token(Token = "0x4004D56")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    public int limitReinforceSlash;
    [Token(Token = "0x4004D57")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public int initialReinforceBlow;
    [Token(Token = "0x4004D58")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    public int limitReinforceBlow;
    [Token(Token = "0x4004D59")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public int initialReinforcePierce;
    [Token(Token = "0x4004D5A")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    public int limitReinforcePierce;
    [Token(Token = "0x4004D5B")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public int initialReinforceShot;
    [Token(Token = "0x4004D5C")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    public int limitReinforceShot;
    [Token(Token = "0x4004D5D")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    public int initialReinforceMagic;
    [Token(Token = "0x4004D5E")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    public int limitReinforceMagic;
    [Token(Token = "0x4004D5F")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    public int initialReinforceProvocation;
    [Token(Token = "0x4004D60")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    public int limitReinforceProvocation;
    [Token(Token = "0x4004D61")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public int initialReinforceConfusion;
    [Token(Token = "0x4004D62")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    public int limitReinforceConfusion;
    [Token(Token = "0x4004D63")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public int initialReinforceShakenUp;
    [Token(Token = "0x4004D64")]
    [FieldOffset(Offset = "0xE4")]
    [SerializeField]
    public int limitReinforceShakenUp;
    [Token(Token = "0x4004D65")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    public int initialReinforceCharmed;
    [Token(Token = "0x4004D66")]
    [FieldOffset(Offset = "0xEC")]
    [SerializeField]
    public int limitReinforceCharmed;
    [Token(Token = "0x4004D67")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    public int initialReinforceBerserk;
    [Token(Token = "0x4004D68")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    public int limitReinforceBerserk;
    [Token(Token = "0x4004D69")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    public int initialReinforceBurned;
    [Token(Token = "0x4004D6A")]
    [FieldOffset(Offset = "0xFC")]
    [SerializeField]
    public int limitReinforceBurned;
    [Token(Token = "0x4004D6B")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    public int initialReinforceSleep;
    [Token(Token = "0x4004D6C")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    public int limitReinforceSleep;
    [Token(Token = "0x4004D6D")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    public int initialReinforceParalysis;
    [Token(Token = "0x4004D6E")]
    [FieldOffset(Offset = "0x10C")]
    [SerializeField]
    public int limitReinforceParalysis;
    [Token(Token = "0x4004D6F")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    public int initialReinforcePoison;
    [Token(Token = "0x4004D70")]
    [FieldOffset(Offset = "0x114")]
    [SerializeField]
    public int limitReinforcePoison;
    [Token(Token = "0x4004D71")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    public int initialReinforceDeadlyPoison;
    [Token(Token = "0x4004D72")]
    [FieldOffset(Offset = "0x11C")]
    [SerializeField]
    public int limitReinforceDeadlyPoison;
    [Token(Token = "0x4004D73")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    public int initialReinforceBleeding;
    [Token(Token = "0x4004D74")]
    [FieldOffset(Offset = "0x124")]
    [SerializeField]
    public int limitReinforceBleeding;
    [Token(Token = "0x4004D75")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    public int initialReinforceDazzlement;
    [Token(Token = "0x4004D76")]
    [FieldOffset(Offset = "0x12C")]
    [SerializeField]
    public int limitReinforceDazzlement;
    [Token(Token = "0x4004D77")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    public int initialReinforceDarkness;
    [Token(Token = "0x4004D78")]
    [FieldOffset(Offset = "0x134")]
    [SerializeField]
    public int limitReinforceDarkness;
    [Token(Token = "0x4004D79")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    public int initialReinforcePetrifaction;
    [Token(Token = "0x4004D7A")]
    [FieldOffset(Offset = "0x13C")]
    [SerializeField]
    public int limitReinforcePetrifaction;
    [Token(Token = "0x4004D7B")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    public int initialReinforceDontAction;
    [Token(Token = "0x4004D7C")]
    [FieldOffset(Offset = "0x144")]
    [SerializeField]
    public int limitReinforceDontAction;
    [Token(Token = "0x4004D7D")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    public int initialReinforceDontMove;
    [Token(Token = "0x4004D7E")]
    [FieldOffset(Offset = "0x14C")]
    [SerializeField]
    public int limitReinforceDontMove;
    [Token(Token = "0x4004D7F")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    public int initialReinforceDontUseSkill;
    [Token(Token = "0x4004D80")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    public int limitReinforceDontUseSkill;
    [Token(Token = "0x4004D81")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    public int initialReinforceDoom;
    [Token(Token = "0x4004D82")]
    [FieldOffset(Offset = "0x15C")]
    [SerializeField]
    public int limitReinforceDoom;
    [Token(Token = "0x4004D83")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    public bool listDisplayFlag;

    [Token(Token = "0x17000D6B")]
    public int Key
    {
      [Token(Token = "0x6005A8D"), Address(RVA = "0x3C3F108", Offset = "0x3C3F108", VA = "0x3C3F108", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A8E")]
    [Address(RVA = "0x3C3F110", Offset = "0x3C3F110", VA = "0x3C3F110", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A8F")]
    [Address(RVA = "0x3C41140", Offset = "0x3C41140", VA = "0x3C41140", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D6C")]
    public string Name
    {
      [Token(Token = "0x6005A90"), Address(RVA = "0x3C416F4", Offset = "0x3C416F4", VA = "0x3C416F4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D6D")]
    public string Flavor
    {
      [Token(Token = "0x6005A91"), Address(RVA = "0x3C417D0", Offset = "0x3C417D0", VA = "0x3C417D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D6E")]
    public string GachaFlavor
    {
      [Token(Token = "0x6005A92"), Address(RVA = "0x3C418AC", Offset = "0x3C418AC", VA = "0x3C418AC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005A93")]
    [Address(RVA = "0x3C41988", Offset = "0x3C41988", VA = "0x3C41988")]
    public SkillData GetCustomSkill() => (SkillData) null;

    [Token(Token = "0x6005A94")]
    [Address(RVA = "0x3C41A60", Offset = "0x3C41A60", VA = "0x3C41A60", Slot = "7")]
    public int GetElementReinforceValue(ElementTypeEnum element, int level) => new int();

    [Token(Token = "0x6005A95")]
    [Address(RVA = "0x3C41BB4", Offset = "0x3C41BB4", VA = "0x3C41BB4", Slot = "8")]
    public int GetAttackReinforceValue(AttackTypeEnum attackType, int level) => new int();

    [Token(Token = "0x6005A96")]
    [Address(RVA = "0x3C41CFC", Offset = "0x3C41CFC", VA = "0x3C41CFC", Slot = "9")]
    public int GetBadStatusReinforceValue(BattleBadStatusTypeEnum badStatusType, int level)
    {
      return new int();
    }

    [Token(Token = "0x6005A97")]
    [Address(RVA = "0x3C41E9C", Offset = "0x3C41E9C", VA = "0x3C41E9C", Slot = "10")]
    public int GetElementResistValue(ElementTypeEnum element, int level) => new int();

    [Token(Token = "0x6005A98")]
    [Address(RVA = "0x3C41EA4", Offset = "0x3C41EA4", VA = "0x3C41EA4", Slot = "11")]
    public int GetAttackResistValue(AttackTypeEnum attackType, int level) => new int();

    [Token(Token = "0x6005A99")]
    [Address(RVA = "0x3C41EAC", Offset = "0x3C41EAC", VA = "0x3C41EAC", Slot = "12")]
    public int GetBadStatusResistValue(BattleBadStatusTypeEnum badStatusType, int level)
    {
      return new int();
    }

    [Token(Token = "0x6005A9A")]
    [Address(RVA = "0x3C41EB4", Offset = "0x3C41EB4", VA = "0x3C41EB4", Slot = "13")]
    public bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x6005A9B")]
    [Address(RVA = "0x3C41F48", Offset = "0x3C41F48", VA = "0x3C41F48", Slot = "14")]
    public bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x6005A9C")]
    [Address(RVA = "0x3C41FD0", Offset = "0x3C41FD0", VA = "0x3C41FD0", Slot = "15")]
    public bool IsAddedStatusBadStatusReinforceValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x6005A9D")]
    [Address(RVA = "0x3C420E8", Offset = "0x3C420E8", VA = "0x3C420E8", Slot = "16")]
    public bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x6005A9E")]
    [Address(RVA = "0x3C420F0", Offset = "0x3C420F0", VA = "0x3C420F0", Slot = "17")]
    public bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x6005A9F")]
    [Address(RVA = "0x3C420F8", Offset = "0x3C420F8", VA = "0x3C420F8", Slot = "18")]
    public bool IsAddedStatusBadStatusResistValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x6005AA0")]
    [Address(RVA = "0x3C42100", Offset = "0x3C42100", VA = "0x3C42100")]
    public int[] GetInitParameters() => (int[]) null;

    [Token(Token = "0x6005AA1")]
    [Address(RVA = "0x3C421E8", Offset = "0x3C421E8", VA = "0x3C421E8")]
    public MindEquipmentData()
    {
    }
  }
}
