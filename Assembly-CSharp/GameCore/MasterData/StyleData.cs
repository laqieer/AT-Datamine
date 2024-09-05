// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013BF")]
  [Serializable]
  public sealed class StyleData : IMasterDataEntity
  {
    [Token(Token = "0x4005BD3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BD4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int characterId;
    [Token(Token = "0x4005BD5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public KillersFactorTypeEnum killersId;
    [Token(Token = "0x4005BD6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string voicePackName;
    [Token(Token = "0x4005BD7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public bool isUniqueName;
    [Token(Token = "0x4005BD8")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int vehicleStyleID;
    [Token(Token = "0x4005BD9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int overrideResourceId;
    [Token(Token = "0x4005BDA")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int illustStyleResourceId;
    [Token(Token = "0x4005BDB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int dotStyleResourceId;
    [Token(Token = "0x4005BDC")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int thumbnailStyleResourceId;
    [Token(Token = "0x4005BDD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int model3DStyleResourceId;
    [Token(Token = "0x4005BDE")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int freemapControllerStyleResourceId;
    [Token(Token = "0x4005BDF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int emblemID;
    [Token(Token = "0x4005BE0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string emeblem;
    [Token(Token = "0x4005BE1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4005BE2")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int initialRarityStar;
    [Token(Token = "0x4005BE3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005BE4")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public string birthPlace;
    [Token(Token = "0x4005BE5")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public string birthDay;
    [Token(Token = "0x4005BE6")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public string height;
    [Token(Token = "0x4005BE7")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public string weight;
    [Token(Token = "0x4005BE8")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public int sexType;
    [Token(Token = "0x4005BE9")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    public int bloodType;
    [Token(Token = "0x4005BEA")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public string gachaIntroduction;
    [Token(Token = "0x4005BEB")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public int characterVoice;
    [Token(Token = "0x4005BEC")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public int illustrator;
    [Token(Token = "0x4005BED")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public DateTime publishedDateTime;
    [Token(Token = "0x4005BEE")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public int homeSerif;
    [Token(Token = "0x4005BEF")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    public int element;
    [Token(Token = "0x4005BF0")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public string duelMotionType;
    [Token(Token = "0x4005BF1")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public string commonSkillMotionType;
    [Token(Token = "0x4005BF2")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public int unitClass;
    [Token(Token = "0x4005BF3")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    public int species;
    [Token(Token = "0x4005BF4")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    public int stockCounter;
    [Token(Token = "0x4005BF5")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    public int gridSize;
    [Token(Token = "0x4005BF6")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    public int styleGroup;
    [Token(Token = "0x4005BF7")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    public int styleMasterReward;
    [Token(Token = "0x4005BF8")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public int reincarnationBonusGroupId;
    [Token(Token = "0x4005BF9")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    public int customSkillCostInitial;
    [Token(Token = "0x4005BFA")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public bool listDisplayFlag;
    [Token(Token = "0x4005BFB")]
    [FieldOffset(Offset = "0xE4")]
    [SerializeField]
    public int aiType;
    [Token(Token = "0x4005BFC")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    public int initialLife;
    [Token(Token = "0x4005BFD")]
    [FieldOffset(Offset = "0xEC")]
    [SerializeField]
    public int initialStrength;
    [Token(Token = "0x4005BFE")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    public int initialIntelligence;
    [Token(Token = "0x4005BFF")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    public int initialVitality;
    [Token(Token = "0x4005C00")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    public int initialMind;
    [Token(Token = "0x4005C01")]
    [FieldOffset(Offset = "0xFC")]
    [SerializeField]
    public int initialAgility;
    [Token(Token = "0x4005C02")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    public int initialDexterity;
    [Token(Token = "0x4005C03")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    public int initialLucky;
    [Token(Token = "0x4005C04")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    public float growthRateLife;
    [Token(Token = "0x4005C05")]
    [FieldOffset(Offset = "0x10C")]
    [SerializeField]
    public float growthRateStrength;
    [Token(Token = "0x4005C06")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    public float growthRateIntelligence;
    [Token(Token = "0x4005C07")]
    [FieldOffset(Offset = "0x114")]
    [SerializeField]
    public float growthRateVitality;
    [Token(Token = "0x4005C08")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    public float growthRateMind;
    [Token(Token = "0x4005C09")]
    [FieldOffset(Offset = "0x11C")]
    [SerializeField]
    public float growthRateAgility;
    [Token(Token = "0x4005C0A")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    public float growthRateDexterity;
    [Token(Token = "0x4005C0B")]
    [FieldOffset(Offset = "0x124")]
    [SerializeField]
    public float growthRateLucky;
    [Token(Token = "0x4005C0C")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    public int limitLife;
    [Token(Token = "0x4005C0D")]
    [FieldOffset(Offset = "0x12C")]
    [SerializeField]
    public int limitStrength;
    [Token(Token = "0x4005C0E")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    public int limitIntelligence;
    [Token(Token = "0x4005C0F")]
    [FieldOffset(Offset = "0x134")]
    [SerializeField]
    public int limitVitality;
    [Token(Token = "0x4005C10")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    public int limitMind;
    [Token(Token = "0x4005C11")]
    [FieldOffset(Offset = "0x13C")]
    [SerializeField]
    public int limitAgility;
    [Token(Token = "0x4005C12")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    public int limitDexterity;
    [Token(Token = "0x4005C13")]
    [FieldOffset(Offset = "0x144")]
    [SerializeField]
    public int limitLucky;
    [Token(Token = "0x4005C14")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    public int reinforceFire;
    [Token(Token = "0x4005C15")]
    [FieldOffset(Offset = "0x14C")]
    [SerializeField]
    public int reinforceIce;
    [Token(Token = "0x4005C16")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    public int reinforceThunder;
    [Token(Token = "0x4005C17")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    public int reinforceWind;
    [Token(Token = "0x4005C18")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    public int reinforceLight;
    [Token(Token = "0x4005C19")]
    [FieldOffset(Offset = "0x15C")]
    [SerializeField]
    public int reinforceDark;
    [Token(Token = "0x4005C1A")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    public int reinforceSlash;
    [Token(Token = "0x4005C1B")]
    [FieldOffset(Offset = "0x164")]
    [SerializeField]
    public int reinforceBlow;
    [Token(Token = "0x4005C1C")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    public int reinforcePierce;
    [Token(Token = "0x4005C1D")]
    [FieldOffset(Offset = "0x16C")]
    [SerializeField]
    public int reinforceShot;
    [Token(Token = "0x4005C1E")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    public int reinforceMagic;
    [Token(Token = "0x4005C1F")]
    [FieldOffset(Offset = "0x174")]
    [SerializeField]
    public int reinforceProvocation;
    [Token(Token = "0x4005C20")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    public int reinforceConfusion;
    [Token(Token = "0x4005C21")]
    [FieldOffset(Offset = "0x17C")]
    [SerializeField]
    public int reinforceShakenUp;
    [Token(Token = "0x4005C22")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    public int reinforceCharmed;
    [Token(Token = "0x4005C23")]
    [FieldOffset(Offset = "0x184")]
    [SerializeField]
    public int reinforceBerserk;
    [Token(Token = "0x4005C24")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    public int reinforceBurned;
    [Token(Token = "0x4005C25")]
    [FieldOffset(Offset = "0x18C")]
    [SerializeField]
    public int reinforceSleep;
    [Token(Token = "0x4005C26")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    public int reinforceParalysis;
    [Token(Token = "0x4005C27")]
    [FieldOffset(Offset = "0x194")]
    [SerializeField]
    public int reinforcePoison;
    [Token(Token = "0x4005C28")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    public int reinforceDeadlyPoison;
    [Token(Token = "0x4005C29")]
    [FieldOffset(Offset = "0x19C")]
    [SerializeField]
    public int reinforceBleeding;
    [Token(Token = "0x4005C2A")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    public int reinforceDazzlement;
    [Token(Token = "0x4005C2B")]
    [FieldOffset(Offset = "0x1A4")]
    [SerializeField]
    public int reinforceDarkness;
    [Token(Token = "0x4005C2C")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    public int reinforcePetrifaction;
    [Token(Token = "0x4005C2D")]
    [FieldOffset(Offset = "0x1AC")]
    [SerializeField]
    public int reinforceDontAction;
    [Token(Token = "0x4005C2E")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    public int reinforceDontMove;
    [Token(Token = "0x4005C2F")]
    [FieldOffset(Offset = "0x1B4")]
    [SerializeField]
    public int reinforceDontUseSkill;
    [Token(Token = "0x4005C30")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    public int reinforceDoom;
    [Token(Token = "0x4005C31")]
    [FieldOffset(Offset = "0x1BC")]
    [SerializeField]
    public int resistFire;
    [Token(Token = "0x4005C32")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    public int resistIce;
    [Token(Token = "0x4005C33")]
    [FieldOffset(Offset = "0x1C4")]
    [SerializeField]
    public int resistThunder;
    [Token(Token = "0x4005C34")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    public int resistWind;
    [Token(Token = "0x4005C35")]
    [FieldOffset(Offset = "0x1CC")]
    [SerializeField]
    public int resistLight;
    [Token(Token = "0x4005C36")]
    [FieldOffset(Offset = "0x1D0")]
    [SerializeField]
    public int resistDark;
    [Token(Token = "0x4005C37")]
    [FieldOffset(Offset = "0x1D4")]
    [SerializeField]
    public int resistSlash;
    [Token(Token = "0x4005C38")]
    [FieldOffset(Offset = "0x1D8")]
    [SerializeField]
    public int resistBlow;
    [Token(Token = "0x4005C39")]
    [FieldOffset(Offset = "0x1DC")]
    [SerializeField]
    public int resistPierce;
    [Token(Token = "0x4005C3A")]
    [FieldOffset(Offset = "0x1E0")]
    [SerializeField]
    public int resistShot;
    [Token(Token = "0x4005C3B")]
    [FieldOffset(Offset = "0x1E4")]
    [SerializeField]
    public int resistMagic;
    [Token(Token = "0x4005C3C")]
    [FieldOffset(Offset = "0x1E8")]
    [SerializeField]
    public int resistProvocation;
    [Token(Token = "0x4005C3D")]
    [FieldOffset(Offset = "0x1EC")]
    [SerializeField]
    public int resistConfusion;
    [Token(Token = "0x4005C3E")]
    [FieldOffset(Offset = "0x1F0")]
    [SerializeField]
    public int resistShakenUp;
    [Token(Token = "0x4005C3F")]
    [FieldOffset(Offset = "0x1F4")]
    [SerializeField]
    public int resistCharmed;
    [Token(Token = "0x4005C40")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    public int resistBerserk;
    [Token(Token = "0x4005C41")]
    [FieldOffset(Offset = "0x1FC")]
    [SerializeField]
    public int resistBurned;
    [Token(Token = "0x4005C42")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    public int resistSleep;
    [Token(Token = "0x4005C43")]
    [FieldOffset(Offset = "0x204")]
    [SerializeField]
    public int resistParalysis;
    [Token(Token = "0x4005C44")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    public int resistPoison;
    [Token(Token = "0x4005C45")]
    [FieldOffset(Offset = "0x20C")]
    [SerializeField]
    public int resistDeadlyPoison;
    [Token(Token = "0x4005C46")]
    [FieldOffset(Offset = "0x210")]
    [SerializeField]
    public int resistBleeding;
    [Token(Token = "0x4005C47")]
    [FieldOffset(Offset = "0x214")]
    [SerializeField]
    public int resistDazzlement;
    [Token(Token = "0x4005C48")]
    [FieldOffset(Offset = "0x218")]
    [SerializeField]
    public int resistDarkness;
    [Token(Token = "0x4005C49")]
    [FieldOffset(Offset = "0x21C")]
    [SerializeField]
    public int resistPetrifaction;
    [Token(Token = "0x4005C4A")]
    [FieldOffset(Offset = "0x220")]
    [SerializeField]
    public int resistDontAction;
    [Token(Token = "0x4005C4B")]
    [FieldOffset(Offset = "0x224")]
    [SerializeField]
    public int resistDontMove;
    [Token(Token = "0x4005C4C")]
    [FieldOffset(Offset = "0x228")]
    [SerializeField]
    public int resistDontUseSkill;
    [Token(Token = "0x4005C4D")]
    [FieldOffset(Offset = "0x22C")]
    [SerializeField]
    public int resistDoom;
    [Token(Token = "0x4005C4E")]
    [FieldOffset(Offset = "0x230")]
    [SerializeField]
    public int offsetRatePhysicalDamage;
    [Token(Token = "0x4005C4F")]
    [FieldOffset(Offset = "0x234")]
    [SerializeField]
    public int offsetRateMagicDamage;
    [Token(Token = "0x4005C50")]
    [FieldOffset(Offset = "0x238")]
    [SerializeField]
    public int offsetRateTakenPhysicalDamage;
    [Token(Token = "0x4005C51")]
    [FieldOffset(Offset = "0x23C")]
    [SerializeField]
    public int offsetRateTakenMagicDamage;
    [Token(Token = "0x4005C52")]
    [FieldOffset(Offset = "0x240")]
    [SerializeField]
    public int offsetRateTakenHit;
    [Token(Token = "0x4005C53")]
    [FieldOffset(Offset = "0x244")]
    [SerializeField]
    public int offsetRateHit;
    [Token(Token = "0x4005C54")]
    [FieldOffset(Offset = "0x248")]
    [SerializeField]
    public int offsetRateCritical;
    [Token(Token = "0x4005C55")]
    [FieldOffset(Offset = "0x24C")]
    [SerializeField]
    public int offsetRateTakenCritical;
    [Token(Token = "0x4005C56")]
    [FieldOffset(Offset = "0x250")]
    [SerializeField]
    public int offsetRateHp;
    [Token(Token = "0x4005C57")]
    [FieldOffset(Offset = "0x254")]
    [SerializeField]
    public int pararaGrowthRateLife;
    [Token(Token = "0x4005C58")]
    [FieldOffset(Offset = "0x258")]
    [SerializeField]
    public int pararaGrowthRateStrength;
    [Token(Token = "0x4005C59")]
    [FieldOffset(Offset = "0x25C")]
    [SerializeField]
    public int pararaGrowthRateIntelligence;
    [Token(Token = "0x4005C5A")]
    [FieldOffset(Offset = "0x260")]
    [SerializeField]
    public int pararaGrowthRateVitality;
    [Token(Token = "0x4005C5B")]
    [FieldOffset(Offset = "0x264")]
    [SerializeField]
    public int pararaGrowthRateMind;
    [Token(Token = "0x4005C5C")]
    [FieldOffset(Offset = "0x268")]
    [SerializeField]
    public int pararaGrowthRateAgility;
    [Token(Token = "0x4005C5D")]
    [FieldOffset(Offset = "0x26C")]
    [SerializeField]
    public int pararaGrowthRateDexterity;
    [Token(Token = "0x4005C5E")]
    [FieldOffset(Offset = "0x270")]
    [SerializeField]
    public int pararaGrowthRateLucky;

    [Token(Token = "0x1700109E")]
    public int Key
    {
      [Token(Token = "0x6006EE1"), Address(RVA = "0x470AAF0", Offset = "0x470AAF0", VA = "0x470AAF0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006EE2")]
    [Address(RVA = "0x470AAF8", Offset = "0x470AAF8", VA = "0x470AAF8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006EE3")]
    [Address(RVA = "0x470DFCC", Offset = "0x470DFCC", VA = "0x470DFCC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700109F")]
    public AdditionalParameterList AdditionalParameterList
    {
      [Token(Token = "0x6006EE4"), Address(RVA = "0x470E94C", Offset = "0x470E94C", VA = "0x470E94C")] get
      {
        return (AdditionalParameterList) null;
      }
    }

    [Token(Token = "0x6006EE5")]
    [Address(RVA = "0x470A874", Offset = "0x470A874", VA = "0x470A874")]
    public void OnLoadEntity()
    {
    }

    [Token(Token = "0x170010A0")]
    public string Name
    {
      [Token(Token = "0x6006EE6"), Address(RVA = "0x470E954", Offset = "0x470E954", VA = "0x470E954")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A1")]
    public string BirthDay
    {
      [Token(Token = "0x6006EE7"), Address(RVA = "0x470EA30", Offset = "0x470EA30", VA = "0x470EA30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A2")]
    public string Dislike1
    {
      [Token(Token = "0x6006EE8"), Address(RVA = "0x470EB0C", Offset = "0x470EB0C", VA = "0x470EB0C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A3")]
    public string Dislike2
    {
      [Token(Token = "0x6006EE9"), Address(RVA = "0x470EBE8", Offset = "0x470EBE8", VA = "0x470EBE8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A4")]
    public string Favorite1
    {
      [Token(Token = "0x6006EEA"), Address(RVA = "0x470ECC4", Offset = "0x470ECC4", VA = "0x470ECC4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A5")]
    public string Favorite2
    {
      [Token(Token = "0x6006EEB"), Address(RVA = "0x470EDA0", Offset = "0x470EDA0", VA = "0x470EDA0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A6")]
    public string Height
    {
      [Token(Token = "0x6006EEC"), Address(RVA = "0x470EE7C", Offset = "0x470EE7C", VA = "0x470EE7C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A7")]
    public string Hobby1
    {
      [Token(Token = "0x6006EED"), Address(RVA = "0x470EF58", Offset = "0x470EF58", VA = "0x470EF58")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A8")]
    public string Hobby2
    {
      [Token(Token = "0x6006EEE"), Address(RVA = "0x470F034", Offset = "0x470F034", VA = "0x470F034")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A9")]
    public string Profile
    {
      [Token(Token = "0x6006EEF"), Address(RVA = "0x470F110", Offset = "0x470F110", VA = "0x470F110")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AA")]
    public string Weight
    {
      [Token(Token = "0x6006EF0"), Address(RVA = "0x470F1EC", Offset = "0x470F1EC", VA = "0x470F1EC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AB")]
    public string Affiliation
    {
      [Token(Token = "0x6006EF1"), Address(RVA = "0x470F2C8", Offset = "0x470F2C8", VA = "0x470F2C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AC")]
    public string Title
    {
      [Token(Token = "0x6006EF2"), Address(RVA = "0x470F3A4", Offset = "0x470F3A4", VA = "0x470F3A4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AD")]
    public string Explanation
    {
      [Token(Token = "0x6006EF3"), Address(RVA = "0x470F480", Offset = "0x470F480", VA = "0x470F480")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AE")]
    public string Englishname
    {
      [Token(Token = "0x6006EF4"), Address(RVA = "0x470F55C", Offset = "0x470F55C", VA = "0x470F55C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AF")]
    public string ShortName
    {
      [Token(Token = "0x6006EF5"), Address(RVA = "0x470F638", Offset = "0x470F638", VA = "0x470F638")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010B0")]
    public OverrideResourceData OverrideResourceData
    {
      [Token(Token = "0x6006EF6"), Address(RVA = "0x470F714", Offset = "0x470F714", VA = "0x470F714")] get
      {
        return (OverrideResourceData) null;
      }
    }

    [Token(Token = "0x170010B1")]
    public string BloodType
    {
      [Token(Token = "0x6006EF7"), Address(RVA = "0x470F7B0", Offset = "0x470F7B0", VA = "0x470F7B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010B2")]
    public string CharacterVoice
    {
      [Token(Token = "0x6006EF8"), Address(RVA = "0x470F918", Offset = "0x470F918", VA = "0x470F918")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010B3")]
    public string Illustrator
    {
      [Token(Token = "0x6006EF9"), Address(RVA = "0x470F9F4", Offset = "0x470F9F4", VA = "0x470F9F4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010B4")]
    public List<string> StyleGroupName
    {
      [Token(Token = "0x6006EFA"), Address(RVA = "0x470FAD0", Offset = "0x470FAD0", VA = "0x470FAD0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x6006EFB")]
    [Address(RVA = "0x470FF48", Offset = "0x470FF48", VA = "0x470FF48")]
    public AdditionalParameterType GetReinforce() => (AdditionalParameterType) null;

    [Token(Token = "0x6006EFC")]
    [Address(RVA = "0x470FF64", Offset = "0x470FF64", VA = "0x470FF64")]
    public AdditionalParameterType GetResist() => (AdditionalParameterType) null;

    [Token(Token = "0x6006EFD")]
    [Address(RVA = "0x470FF80", Offset = "0x470FF80", VA = "0x470FF80")]
    public AdditionalParameterType GetSlay() => (AdditionalParameterType) null;

    [Token(Token = "0x6006EFE")]
    [Address(RVA = "0x470FF9C", Offset = "0x470FF9C", VA = "0x470FF9C")]
    public AdditionalParameterType GetResistSlay() => (AdditionalParameterType) null;

    [Token(Token = "0x6006EFF")]
    [Address(RVA = "0x470FFB8", Offset = "0x470FFB8", VA = "0x470FFB8")]
    public bool DotWeaponAssetSwitchable() => new bool();

    [Token(Token = "0x170010B5")]
    public BasicParameter LimitBasicParam
    {
      [Token(Token = "0x6006F00"), Address(RVA = "0x47100CC", Offset = "0x47100CC", VA = "0x47100CC")] get
      {
        return (BasicParameter) null;
      }
    }

    [Token(Token = "0x6006F01")]
    [Address(RVA = "0x4710194", Offset = "0x4710194", VA = "0x4710194")]
    public string GetVoicePackId() => (string) null;

    [Token(Token = "0x6006F02")]
    [Address(RVA = "0x47101C8", Offset = "0x47101C8", VA = "0x47101C8")]
    public StyleData()
    {
    }
  }
}
