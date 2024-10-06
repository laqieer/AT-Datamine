// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TrustData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F6D")]
  [Serializable]
  public sealed class TrustData : IMasterDataEntity, IEquipmentAddStatus
  {
    [Token(Token = "0x4004D8E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D8F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004D90")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int skill;
    [Token(Token = "0x4004D91")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int hp;
    [Token(Token = "0x4004D92")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int physicsAttack;
    [Token(Token = "0x4004D93")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int magicAttack;
    [Token(Token = "0x4004D94")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int physicsDefence;
    [Token(Token = "0x4004D95")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int magicDefence;
    [Token(Token = "0x4004D96")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int hit;
    [Token(Token = "0x4004D97")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int avoid;
    [Token(Token = "0x4004D98")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int critical;
    [Token(Token = "0x4004D99")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int criticalAvoid;
    [Token(Token = "0x4004D9A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int weight;
    [Token(Token = "0x4004D9B")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int initialReinforceFire;
    [Token(Token = "0x4004D9C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int initialReinforceIce;
    [Token(Token = "0x4004D9D")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int initialReinforceThunder;
    [Token(Token = "0x4004D9E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int initialReinforceWind;
    [Token(Token = "0x4004D9F")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int initialReinforceLight;
    [Token(Token = "0x4004DA0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int initialReinforceDark;
    [Token(Token = "0x4004DA1")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int initialReinforceSlash;
    [Token(Token = "0x4004DA2")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int initialReinforceBlow;
    [Token(Token = "0x4004DA3")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int initialReinforcePierce;
    [Token(Token = "0x4004DA4")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int initialReinforceShot;
    [Token(Token = "0x4004DA5")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int initialReinforceMagic;
    [Token(Token = "0x4004DA6")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int initialReinforceProvocation;
    [Token(Token = "0x4004DA7")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int initialReinforceConfusion;
    [Token(Token = "0x4004DA8")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public int initialReinforceShakenUp;
    [Token(Token = "0x4004DA9")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public int initialReinforceCharmed;
    [Token(Token = "0x4004DAA")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public int initialReinforceBerserk;
    [Token(Token = "0x4004DAB")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    public int initialReinforceBurned;
    [Token(Token = "0x4004DAC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public int initialReinforceSleep;
    [Token(Token = "0x4004DAD")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    public int initialReinforceParalysis;
    [Token(Token = "0x4004DAE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public int initialReinforcePoison;
    [Token(Token = "0x4004DAF")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    public int initialReinforceDeadlyPoison;
    [Token(Token = "0x4004DB0")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public int initialReinforceBleeding;
    [Token(Token = "0x4004DB1")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public int initialReinforceDazzlement;
    [Token(Token = "0x4004DB2")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public int initialReinforceDarkness;
    [Token(Token = "0x4004DB3")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    public int initialReinforcePetrifaction;
    [Token(Token = "0x4004DB4")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public int initialReinforceDontAction;
    [Token(Token = "0x4004DB5")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    public int initialReinforceDontMove;
    [Token(Token = "0x4004DB6")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public int initialReinforceDontUseSkill;
    [Token(Token = "0x4004DB7")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    public int initialReinforceDoom;
    [Token(Token = "0x4004DB8")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public int initialResistFire;
    [Token(Token = "0x4004DB9")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    public int initialResistIce;
    [Token(Token = "0x4004DBA")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public int initialResistThunder;
    [Token(Token = "0x4004DBB")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    public int initialResistWind;
    [Token(Token = "0x4004DBC")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    public int initialResistLight;
    [Token(Token = "0x4004DBD")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    public int initialResistDark;
    [Token(Token = "0x4004DBE")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    public int initialResistSlash;
    [Token(Token = "0x4004DBF")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    public int initialResistBlow;
    [Token(Token = "0x4004DC0")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public int initialResistPierce;
    [Token(Token = "0x4004DC1")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    public int initialResistShot;
    [Token(Token = "0x4004DC2")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public int initialResistMagic;
    [Token(Token = "0x4004DC3")]
    [FieldOffset(Offset = "0xE4")]
    [SerializeField]
    public int initialResistProvocation;
    [Token(Token = "0x4004DC4")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    public int initialResistConfusion;
    [Token(Token = "0x4004DC5")]
    [FieldOffset(Offset = "0xEC")]
    [SerializeField]
    public int initialResistShakenUp;
    [Token(Token = "0x4004DC6")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    public int initialResistCharmed;
    [Token(Token = "0x4004DC7")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    public int initialResistBerserk;
    [Token(Token = "0x4004DC8")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    public int initialResistBurned;
    [Token(Token = "0x4004DC9")]
    [FieldOffset(Offset = "0xFC")]
    [SerializeField]
    public int initialResistSleep;
    [Token(Token = "0x4004DCA")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    public int initialResistParalysis;
    [Token(Token = "0x4004DCB")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    public int initialResistPoison;
    [Token(Token = "0x4004DCC")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    public int initialResistDeadlyPoison;
    [Token(Token = "0x4004DCD")]
    [FieldOffset(Offset = "0x10C")]
    [SerializeField]
    public int initialResistBleeding;
    [Token(Token = "0x4004DCE")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    public int initialResistDazzlement;
    [Token(Token = "0x4004DCF")]
    [FieldOffset(Offset = "0x114")]
    [SerializeField]
    public int initialResistDarkness;
    [Token(Token = "0x4004DD0")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    public int initialResistPetrifaction;
    [Token(Token = "0x4004DD1")]
    [FieldOffset(Offset = "0x11C")]
    [SerializeField]
    public int initialResistDontAction;
    [Token(Token = "0x4004DD2")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    public int initialResistDontMove;
    [Token(Token = "0x4004DD3")]
    [FieldOffset(Offset = "0x124")]
    [SerializeField]
    public int initialResistDontUseSkill;
    [Token(Token = "0x4004DD4")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    public int initialResistDoom;

    [Token(Token = "0x17000D72")]
    public int Key
    {
      [Token(Token = "0x6005ABF"), Address(RVA = "0x3C42C90", Offset = "0x3C42C90", VA = "0x3C42C90", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005AC0")]
    [Address(RVA = "0x3C42C98", Offset = "0x3C42C98", VA = "0x3C42C98", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005AC1")]
    [Address(RVA = "0x3C44784", Offset = "0x3C44784", VA = "0x3C44784", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D73")]
    public string Name
    {
      [Token(Token = "0x6005AC2"), Address(RVA = "0x3C44C58", Offset = "0x3C44C58", VA = "0x3C44C58")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D74")]
    public string Flavor
    {
      [Token(Token = "0x6005AC3"), Address(RVA = "0x3C44D34", Offset = "0x3C44D34", VA = "0x3C44D34")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005AC4")]
    [Address(RVA = "0x3C44E10", Offset = "0x3C44E10", VA = "0x3C44E10")]
    public int[] GetParameters() => (int[]) null;

    [Token(Token = "0x6005AC5")]
    [Address(RVA = "0x3C44F08", Offset = "0x3C44F08", VA = "0x3C44F08", Slot = "7")]
    public int GetElementReinforceValue(ElementTypeEnum element, int level = 1) => new int();

    [Token(Token = "0x6005AC6")]
    [Address(RVA = "0x3C44F64", Offset = "0x3C44F64", VA = "0x3C44F64", Slot = "8")]
    public int GetAttackReinforceValue(AttackTypeEnum attackType, int level = 1) => new int();

    [Token(Token = "0x6005AC7")]
    [Address(RVA = "0x3C44FB8", Offset = "0x3C44FB8", VA = "0x3C44FB8", Slot = "9")]
    public int GetBadStatusReinforceValue(BattleBadStatusTypeEnum badStatusType, int level = 1)
    {
      return new int();
    }

    [Token(Token = "0x6005AC8")]
    [Address(RVA = "0x3C4506C", Offset = "0x3C4506C", VA = "0x3C4506C", Slot = "10")]
    public int GetElementResistValue(ElementTypeEnum element, int level = 1) => new int();

    [Token(Token = "0x6005AC9")]
    [Address(RVA = "0x3C450C8", Offset = "0x3C450C8", VA = "0x3C450C8", Slot = "11")]
    public int GetAttackResistValue(AttackTypeEnum attackType, int level = 1) => new int();

    [Token(Token = "0x6005ACA")]
    [Address(RVA = "0x3C4511C", Offset = "0x3C4511C", VA = "0x3C4511C", Slot = "12")]
    public int GetBadStatusResistValue(BattleBadStatusTypeEnum badStatusType, int level = 1)
    {
      return new int();
    }

    [Token(Token = "0x6005ACB")]
    [Address(RVA = "0x3C451D0", Offset = "0x3C451D0", VA = "0x3C451D0", Slot = "13")]
    public bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x6005ACC")]
    [Address(RVA = "0x3C45234", Offset = "0x3C45234", VA = "0x3C45234", Slot = "14")]
    public bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x6005ACD")]
    [Address(RVA = "0x3C45290", Offset = "0x3C45290", VA = "0x3C45290", Slot = "15")]
    public bool IsAddedStatusBadStatusReinforceValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x6005ACE")]
    [Address(RVA = "0x3C4534C", Offset = "0x3C4534C", VA = "0x3C4534C", Slot = "16")]
    public bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x6005ACF")]
    [Address(RVA = "0x3C453B0", Offset = "0x3C453B0", VA = "0x3C453B0", Slot = "17")]
    public bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x6005AD0")]
    [Address(RVA = "0x3C4540C", Offset = "0x3C4540C", VA = "0x3C4540C", Slot = "18")]
    public bool IsAddedStatusBadStatusResistValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x6005AD1")]
    [Address(RVA = "0x3C454C8", Offset = "0x3C454C8", VA = "0x3C454C8")]
    public TrustData()
    {
    }
  }
}
