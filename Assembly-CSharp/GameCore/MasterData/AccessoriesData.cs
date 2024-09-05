// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoriesData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F3E")]
  [Serializable]
  public sealed class AccessoriesData : IMasterDataEntity, IEquipmentAddStatus
  {
    [Token(Token = "0x4004C49")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004C4A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004C4B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4004C4C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool isUnknownImage;
    [Token(Token = "0x4004C4D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public AccessorieTypeEnum accessorieType;
    [Token(Token = "0x4004C4E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public AccessorieClassificationEnum accessorieClassification;
    [Token(Token = "0x4004C4F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int skillId;
    [Token(Token = "0x4004C50")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int skillUnLockLimitBreakCount;
    [Token(Token = "0x4004C51")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public ComplementTypeEnum complement;
    [Token(Token = "0x4004C52")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int limitBreakId;
    [Token(Token = "0x4004C53")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int optionLotteryGroup;
    [Token(Token = "0x4004C54")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int initialLife;
    [Token(Token = "0x4004C55")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int limitLife;
    [Token(Token = "0x4004C56")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int initialStrength;
    [Token(Token = "0x4004C57")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int limitStrength;
    [Token(Token = "0x4004C58")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int initialIntelligence;
    [Token(Token = "0x4004C59")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int limitIntelligence;
    [Token(Token = "0x4004C5A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int initialVitality;
    [Token(Token = "0x4004C5B")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int limitVitality;
    [Token(Token = "0x4004C5C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int initialMind;
    [Token(Token = "0x4004C5D")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int limitMind;
    [Token(Token = "0x4004C5E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int initialAgility;
    [Token(Token = "0x4004C5F")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int limitAgility;
    [Token(Token = "0x4004C60")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int initialDexterity;
    [Token(Token = "0x4004C61")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int limitDexterity;
    [Token(Token = "0x4004C62")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public int initialLucky;
    [Token(Token = "0x4004C63")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public int limitLucky;
    [Token(Token = "0x4004C64")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public int initialPhysicsDefence;
    [Token(Token = "0x4004C65")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    public int limitPhysicsDefence;
    [Token(Token = "0x4004C66")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public int initialMagicDefence;
    [Token(Token = "0x4004C67")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    public int limitMagicDefence;
    [Token(Token = "0x4004C68")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public int initialCriticalAvoid;
    [Token(Token = "0x4004C69")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    public int limitCriticalAvoid;
    [Token(Token = "0x4004C6A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public int initialWeight;
    [Token(Token = "0x4004C6B")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public int limitWeight;
    [Token(Token = "0x4004C6C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public int initialReinforceFire;
    [Token(Token = "0x4004C6D")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    public int limitReinforceFire;
    [Token(Token = "0x4004C6E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public int initialReinforceIce;
    [Token(Token = "0x4004C6F")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    public int limitReinforceIce;
    [Token(Token = "0x4004C70")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public int initialReinforceThunder;
    [Token(Token = "0x4004C71")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    public int limitReinforceThunder;
    [Token(Token = "0x4004C72")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public int initialReinforceWind;
    [Token(Token = "0x4004C73")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    public int limitReinforceWind;
    [Token(Token = "0x4004C74")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public int initialReinforceLight;
    [Token(Token = "0x4004C75")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    public int limitReinforceLight;
    [Token(Token = "0x4004C76")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    public int initialReinforceDark;
    [Token(Token = "0x4004C77")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    public int limitReinforceDark;
    [Token(Token = "0x4004C78")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    public int initialReinforceSlash;
    [Token(Token = "0x4004C79")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    public int limitReinforceSlash;
    [Token(Token = "0x4004C7A")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public int initialReinforceBlow;
    [Token(Token = "0x4004C7B")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    public int limitReinforceBlow;
    [Token(Token = "0x4004C7C")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public int initialReinforcePierce;
    [Token(Token = "0x4004C7D")]
    [FieldOffset(Offset = "0xE4")]
    [SerializeField]
    public int limitReinforcePierce;
    [Token(Token = "0x4004C7E")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    public int initialReinforceShot;
    [Token(Token = "0x4004C7F")]
    [FieldOffset(Offset = "0xEC")]
    [SerializeField]
    public int limitReinforceShot;
    [Token(Token = "0x4004C80")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    public int initialReinforceMagic;
    [Token(Token = "0x4004C81")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    public int limitReinforceMagic;
    [Token(Token = "0x4004C82")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    public int initialReinforceProvocation;
    [Token(Token = "0x4004C83")]
    [FieldOffset(Offset = "0xFC")]
    [SerializeField]
    public int limitReinforceProvocation;
    [Token(Token = "0x4004C84")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    public int initialReinforceConfusion;
    [Token(Token = "0x4004C85")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    public int limitReinforceConfusion;
    [Token(Token = "0x4004C86")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    public int initialReinforceShakenUp;
    [Token(Token = "0x4004C87")]
    [FieldOffset(Offset = "0x10C")]
    [SerializeField]
    public int limitReinforceShakenUp;
    [Token(Token = "0x4004C88")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    public int initialReinforceCharmed;
    [Token(Token = "0x4004C89")]
    [FieldOffset(Offset = "0x114")]
    [SerializeField]
    public int limitReinforceCharmed;
    [Token(Token = "0x4004C8A")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    public int initialReinforceBerserk;
    [Token(Token = "0x4004C8B")]
    [FieldOffset(Offset = "0x11C")]
    [SerializeField]
    public int limitReinforceBerserk;
    [Token(Token = "0x4004C8C")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    public int initialReinforceBurned;
    [Token(Token = "0x4004C8D")]
    [FieldOffset(Offset = "0x124")]
    [SerializeField]
    public int limitReinforceBurned;
    [Token(Token = "0x4004C8E")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    public int initialReinforceSleep;
    [Token(Token = "0x4004C8F")]
    [FieldOffset(Offset = "0x12C")]
    [SerializeField]
    public int limitReinforceSleep;
    [Token(Token = "0x4004C90")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    public int initialReinforceParalysis;
    [Token(Token = "0x4004C91")]
    [FieldOffset(Offset = "0x134")]
    [SerializeField]
    public int limitReinforceParalysis;
    [Token(Token = "0x4004C92")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    public int initialReinforcePoison;
    [Token(Token = "0x4004C93")]
    [FieldOffset(Offset = "0x13C")]
    [SerializeField]
    public int limitReinforcePoison;
    [Token(Token = "0x4004C94")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    public int initialReinforceDeadlyPoison;
    [Token(Token = "0x4004C95")]
    [FieldOffset(Offset = "0x144")]
    [SerializeField]
    public int limitReinforceDeadlyPoison;
    [Token(Token = "0x4004C96")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    public int initialReinforceBleeding;
    [Token(Token = "0x4004C97")]
    [FieldOffset(Offset = "0x14C")]
    [SerializeField]
    public int limitReinforceBleeding;
    [Token(Token = "0x4004C98")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    public int initialReinforceDazzlement;
    [Token(Token = "0x4004C99")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    public int limitReinforceDazzlement;
    [Token(Token = "0x4004C9A")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    public int initialReinforceDarkness;
    [Token(Token = "0x4004C9B")]
    [FieldOffset(Offset = "0x15C")]
    [SerializeField]
    public int limitReinforceDarkness;
    [Token(Token = "0x4004C9C")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    public int initialReinforcePetrifaction;
    [Token(Token = "0x4004C9D")]
    [FieldOffset(Offset = "0x164")]
    [SerializeField]
    public int limitReinforcePetrifaction;
    [Token(Token = "0x4004C9E")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    public int initialReinforceDontAction;
    [Token(Token = "0x4004C9F")]
    [FieldOffset(Offset = "0x16C")]
    [SerializeField]
    public int limitReinforceDontAction;
    [Token(Token = "0x4004CA0")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    public int initialReinforceDontMove;
    [Token(Token = "0x4004CA1")]
    [FieldOffset(Offset = "0x174")]
    [SerializeField]
    public int limitReinforceDontMove;
    [Token(Token = "0x4004CA2")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    public int initialReinforceDontUseSkill;
    [Token(Token = "0x4004CA3")]
    [FieldOffset(Offset = "0x17C")]
    [SerializeField]
    public int limitReinforceDontUseSkill;
    [Token(Token = "0x4004CA4")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    public int initialReinforceDoom;
    [Token(Token = "0x4004CA5")]
    [FieldOffset(Offset = "0x184")]
    [SerializeField]
    public int limitReinforceDoom;
    [Token(Token = "0x4004CA6")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    public int initialResistFire;
    [Token(Token = "0x4004CA7")]
    [FieldOffset(Offset = "0x18C")]
    [SerializeField]
    public int limitResistFire;
    [Token(Token = "0x4004CA8")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    public int initialResistIce;
    [Token(Token = "0x4004CA9")]
    [FieldOffset(Offset = "0x194")]
    [SerializeField]
    public int limitResistIce;
    [Token(Token = "0x4004CAA")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    public int initialResistThunder;
    [Token(Token = "0x4004CAB")]
    [FieldOffset(Offset = "0x19C")]
    [SerializeField]
    public int limitResistThunder;
    [Token(Token = "0x4004CAC")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    public int initialResistWind;
    [Token(Token = "0x4004CAD")]
    [FieldOffset(Offset = "0x1A4")]
    [SerializeField]
    public int limitResistWind;
    [Token(Token = "0x4004CAE")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    public int initialResistLight;
    [Token(Token = "0x4004CAF")]
    [FieldOffset(Offset = "0x1AC")]
    [SerializeField]
    public int limitResistLight;
    [Token(Token = "0x4004CB0")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    public int initialResistDark;
    [Token(Token = "0x4004CB1")]
    [FieldOffset(Offset = "0x1B4")]
    [SerializeField]
    public int limitResistDark;
    [Token(Token = "0x4004CB2")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    public int initialResistSlash;
    [Token(Token = "0x4004CB3")]
    [FieldOffset(Offset = "0x1BC")]
    [SerializeField]
    public int limitResistSlash;
    [Token(Token = "0x4004CB4")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    public int initialResistBlow;
    [Token(Token = "0x4004CB5")]
    [FieldOffset(Offset = "0x1C4")]
    [SerializeField]
    public int limitResistBlow;
    [Token(Token = "0x4004CB6")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    public int initialResistPierce;
    [Token(Token = "0x4004CB7")]
    [FieldOffset(Offset = "0x1CC")]
    [SerializeField]
    public int limitResistPierce;
    [Token(Token = "0x4004CB8")]
    [FieldOffset(Offset = "0x1D0")]
    [SerializeField]
    public int initialResistShot;
    [Token(Token = "0x4004CB9")]
    [FieldOffset(Offset = "0x1D4")]
    [SerializeField]
    public int limitResistShot;
    [Token(Token = "0x4004CBA")]
    [FieldOffset(Offset = "0x1D8")]
    [SerializeField]
    public int initialResistMagic;
    [Token(Token = "0x4004CBB")]
    [FieldOffset(Offset = "0x1DC")]
    [SerializeField]
    public int limitResistMagic;
    [Token(Token = "0x4004CBC")]
    [FieldOffset(Offset = "0x1E0")]
    [SerializeField]
    public int initialResistProvocation;
    [Token(Token = "0x4004CBD")]
    [FieldOffset(Offset = "0x1E4")]
    [SerializeField]
    public int limitResistProvocation;
    [Token(Token = "0x4004CBE")]
    [FieldOffset(Offset = "0x1E8")]
    [SerializeField]
    public int initialResistConfusion;
    [Token(Token = "0x4004CBF")]
    [FieldOffset(Offset = "0x1EC")]
    [SerializeField]
    public int limitResistConfusion;
    [Token(Token = "0x4004CC0")]
    [FieldOffset(Offset = "0x1F0")]
    [SerializeField]
    public int initialResistShakenUp;
    [Token(Token = "0x4004CC1")]
    [FieldOffset(Offset = "0x1F4")]
    [SerializeField]
    public int limitResistShakenUp;
    [Token(Token = "0x4004CC2")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    public int initialResistCharmed;
    [Token(Token = "0x4004CC3")]
    [FieldOffset(Offset = "0x1FC")]
    [SerializeField]
    public int limitResistCharmed;
    [Token(Token = "0x4004CC4")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    public int initialResistBerserk;
    [Token(Token = "0x4004CC5")]
    [FieldOffset(Offset = "0x204")]
    [SerializeField]
    public int limitResistBerserk;
    [Token(Token = "0x4004CC6")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    public int initialResistBurned;
    [Token(Token = "0x4004CC7")]
    [FieldOffset(Offset = "0x20C")]
    [SerializeField]
    public int limitResistBurned;
    [Token(Token = "0x4004CC8")]
    [FieldOffset(Offset = "0x210")]
    [SerializeField]
    public int initialResistSleep;
    [Token(Token = "0x4004CC9")]
    [FieldOffset(Offset = "0x214")]
    [SerializeField]
    public int limitResistSleep;
    [Token(Token = "0x4004CCA")]
    [FieldOffset(Offset = "0x218")]
    [SerializeField]
    public int initialResistParalysis;
    [Token(Token = "0x4004CCB")]
    [FieldOffset(Offset = "0x21C")]
    [SerializeField]
    public int limitResistParalysis;
    [Token(Token = "0x4004CCC")]
    [FieldOffset(Offset = "0x220")]
    [SerializeField]
    public int initialResistPoison;
    [Token(Token = "0x4004CCD")]
    [FieldOffset(Offset = "0x224")]
    [SerializeField]
    public int limitResistPoison;
    [Token(Token = "0x4004CCE")]
    [FieldOffset(Offset = "0x228")]
    [SerializeField]
    public int initialResistDeadlyPoison;
    [Token(Token = "0x4004CCF")]
    [FieldOffset(Offset = "0x22C")]
    [SerializeField]
    public int limitResistDeadlyPoison;
    [Token(Token = "0x4004CD0")]
    [FieldOffset(Offset = "0x230")]
    [SerializeField]
    public int initialResistBleeding;
    [Token(Token = "0x4004CD1")]
    [FieldOffset(Offset = "0x234")]
    [SerializeField]
    public int limitResistBleeding;
    [Token(Token = "0x4004CD2")]
    [FieldOffset(Offset = "0x238")]
    [SerializeField]
    public int initialResistDazzlement;
    [Token(Token = "0x4004CD3")]
    [FieldOffset(Offset = "0x23C")]
    [SerializeField]
    public int limitResistDazzlement;
    [Token(Token = "0x4004CD4")]
    [FieldOffset(Offset = "0x240")]
    [SerializeField]
    public int initialResistDarkness;
    [Token(Token = "0x4004CD5")]
    [FieldOffset(Offset = "0x244")]
    [SerializeField]
    public int limitResistDarkness;
    [Token(Token = "0x4004CD6")]
    [FieldOffset(Offset = "0x248")]
    [SerializeField]
    public int initialResistPetrifaction;
    [Token(Token = "0x4004CD7")]
    [FieldOffset(Offset = "0x24C")]
    [SerializeField]
    public int limitResistPetrifaction;
    [Token(Token = "0x4004CD8")]
    [FieldOffset(Offset = "0x250")]
    [SerializeField]
    public int initialResistDontAction;
    [Token(Token = "0x4004CD9")]
    [FieldOffset(Offset = "0x254")]
    [SerializeField]
    public int limitResistDontAction;
    [Token(Token = "0x4004CDA")]
    [FieldOffset(Offset = "0x258")]
    [SerializeField]
    public int initialResistDontMove;
    [Token(Token = "0x4004CDB")]
    [FieldOffset(Offset = "0x25C")]
    [SerializeField]
    public int limitResistDontMove;
    [Token(Token = "0x4004CDC")]
    [FieldOffset(Offset = "0x260")]
    [SerializeField]
    public int initialResistDontUseSkill;
    [Token(Token = "0x4004CDD")]
    [FieldOffset(Offset = "0x264")]
    [SerializeField]
    public int limitResistDontUseSkill;
    [Token(Token = "0x4004CDE")]
    [FieldOffset(Offset = "0x268")]
    [SerializeField]
    public int initialResistDoom;
    [Token(Token = "0x4004CDF")]
    [FieldOffset(Offset = "0x26C")]
    [SerializeField]
    public int limitResistDoom;

    [Token(Token = "0x17000D56")]
    public int Key
    {
      [Token(Token = "0x60059D1"), Address(RVA = "0x3C349B8", Offset = "0x3C349B8", VA = "0x3C349B8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60059D2")]
    [Address(RVA = "0x3C349C0", Offset = "0x3C349C0", VA = "0x3C349C0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60059D3")]
    [Address(RVA = "0x3C382B0", Offset = "0x3C382B0", VA = "0x3C382B0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D57")]
    public string Name
    {
      [Token(Token = "0x60059D4"), Address(RVA = "0x3C38C88", Offset = "0x3C38C88", VA = "0x3C38C88")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D58")]
    public string Flavor
    {
      [Token(Token = "0x60059D5"), Address(RVA = "0x3C38D64", Offset = "0x3C38D64", VA = "0x3C38D64")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60059D6")]
    [Address(RVA = "0x3C38E40", Offset = "0x3C38E40", VA = "0x3C38E40")]
    public int[] GetInitParameters() => (int[]) null;

    [Token(Token = "0x60059D7")]
    [Address(RVA = "0x3C38FA4", Offset = "0x3C38FA4", VA = "0x3C38FA4", Slot = "7")]
    public int GetElementReinforceValue(ElementTypeEnum element, int level) => new int();

    [Token(Token = "0x60059D8")]
    [Address(RVA = "0x3C391E8", Offset = "0x3C391E8", VA = "0x3C391E8", Slot = "8")]
    public int GetAttackReinforceValue(AttackTypeEnum attackType, int level) => new int();

    [Token(Token = "0x60059D9")]
    [Address(RVA = "0x3C39330", Offset = "0x3C39330", VA = "0x3C39330", Slot = "9")]
    public int GetBadStatusReinforceValue(BattleBadStatusTypeEnum badStatusType, int level)
    {
      return new int();
    }

    [Token(Token = "0x60059DA")]
    [Address(RVA = "0x3C39508", Offset = "0x3C39508", VA = "0x3C39508", Slot = "10")]
    public int GetElementResistValue(ElementTypeEnum element, int level) => new int();

    [Token(Token = "0x60059DB")]
    [Address(RVA = "0x3C3965C", Offset = "0x3C3965C", VA = "0x3C3965C", Slot = "11")]
    public int GetAttackResistValue(AttackTypeEnum attackType, int level) => new int();

    [Token(Token = "0x60059DC")]
    [Address(RVA = "0x3C397A4", Offset = "0x3C397A4", VA = "0x3C397A4", Slot = "12")]
    public int GetBadStatusResistValue(BattleBadStatusTypeEnum badStatusType, int level)
    {
      return new int();
    }

    [Token(Token = "0x60059DD")]
    [Address(RVA = "0x3C3997C", Offset = "0x3C3997C", VA = "0x3C3997C", Slot = "13")]
    public bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x60059DE")]
    [Address(RVA = "0x3C39A10", Offset = "0x3C39A10", VA = "0x3C39A10", Slot = "14")]
    public bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x60059DF")]
    [Address(RVA = "0x3C39A98", Offset = "0x3C39A98", VA = "0x3C39A98", Slot = "15")]
    public bool IsAddedStatusBadStatusReinforceValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x60059E0")]
    [Address(RVA = "0x3C39BB0", Offset = "0x3C39BB0", VA = "0x3C39BB0", Slot = "16")]
    public bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x60059E1")]
    [Address(RVA = "0x3C39C44", Offset = "0x3C39C44", VA = "0x3C39C44", Slot = "17")]
    public bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x60059E2")]
    [Address(RVA = "0x3C39CCC", Offset = "0x3C39CCC", VA = "0x3C39CCC", Slot = "18")]
    public bool IsAddedStatusBadStatusResistValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x60059E3")]
    [Address(RVA = "0x3C39DE4", Offset = "0x3C39DE4", VA = "0x3C39DE4")]
    public AccessoriesData()
    {
    }
  }
}
