// Decompiled with JetBrains decompiler
// Type: StaqData.Style
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020FF")]
  public class Style
  {
    [Token(Token = "0x4008BD1")]
    private const string ASSETBUNDLE_PATH = "content_unit_";
    [Token(Token = "0x4008BD2")]
    private const string CLASS_ASSETBUNDLE_PATH = "class_";
    [Token(Token = "0x4008BD3")]
    private const float ExpRateMax = 1f;
    [Token(Token = "0x4008BD4")]
    private const float MinDamageRateMax = 0.05f;
    [Token(Token = "0x4008BD5")]
    private const float MinDamageControl = 100f;
    [Token(Token = "0x4008BD6")]
    private const float MaxDamageRateMin = 3f;
    [Token(Token = "0x4008BD7")]
    private const float MaxDamageRateMax = 40f;
    [Token(Token = "0x4008BD8")]
    private const float MaxDamageControl = 100f;
    [Token(Token = "0x4008BF9")]
    [FieldOffset(Offset = "0xE0")]
    private List<EquipmentClassificationData> enableEquipmentClassificationList;
    [Token(Token = "0x4008BFB")]
    [FieldOffset(Offset = "0xF0")]
    public StyleEquipmentSetData equipmentSetDate;

    [Token(Token = "0x17002B65")]
    public int LabelID
    {
      [Token(Token = "0x600C890"), Address(RVA = "0x1CE3278", Offset = "0x1CE3278", VA = "0x1CE3278")] get
      {
        return new int();
      }
      [Token(Token = "0x600C891"), Address(RVA = "0x1CE3280", Offset = "0x1CE3280", VA = "0x1CE3280")] private set
      {
      }
    }

    [Token(Token = "0x17002B66")]
    public UniqueID UniqueID
    {
      [Token(Token = "0x600C892"), Address(RVA = "0x1CE3288", Offset = "0x1CE3288", VA = "0x1CE3288")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600C893"), Address(RVA = "0x1CE3290", Offset = "0x1CE3290", VA = "0x1CE3290")] private set
      {
      }
    }

    [Token(Token = "0x17002B67")]
    public StyleParameter UnitParameter
    {
      [Token(Token = "0x600C894"), Address(RVA = "0x1CE3298", Offset = "0x1CE3298", VA = "0x1CE3298")] get
      {
        return (StyleParameter) null;
      }
      [Token(Token = "0x600C895"), Address(RVA = "0x1CE32A0", Offset = "0x1CE32A0", VA = "0x1CE32A0")] private set
      {
      }
    }

    [Token(Token = "0x17002B68")]
    public StyleParameter UnitOnly
    {
      [Token(Token = "0x600C896"), Address(RVA = "0x1CE32A8", Offset = "0x1CE32A8", VA = "0x1CE32A8")] get
      {
        return (StyleParameter) null;
      }
      [Token(Token = "0x600C897"), Address(RVA = "0x1CE32B0", Offset = "0x1CE32B0", VA = "0x1CE32B0")] private set
      {
      }
    }

    [Token(Token = "0x17002B69")]
    public BasicParameter InitialParameter
    {
      [Token(Token = "0x600C898"), Address(RVA = "0x1CE32B8", Offset = "0x1CE32B8", VA = "0x1CE32B8")] get
      {
        return (BasicParameter) null;
      }
      [Token(Token = "0x600C899"), Address(RVA = "0x1CE32C0", Offset = "0x1CE32C0", VA = "0x1CE32C0")] private set
      {
      }
    }

    [Token(Token = "0x17002B6A")]
    public PlayerUnitLevelUpType LevelupType
    {
      [Token(Token = "0x600C89A"), Address(RVA = "0x1CE32C8", Offset = "0x1CE32C8", VA = "0x1CE32C8")] get
      {
        return (PlayerUnitLevelUpType) null;
      }
      [Token(Token = "0x600C89B"), Address(RVA = "0x1CE32D0", Offset = "0x1CE32D0", VA = "0x1CE32D0")] private set
      {
      }
    }

    [Token(Token = "0x17002B6B")]
    public BasicParameter LevelupParameter
    {
      [Token(Token = "0x600C89C"), Address(RVA = "0x1CE32D8", Offset = "0x1CE32D8", VA = "0x1CE32D8")] get
      {
        return (BasicParameter) null;
      }
      [Token(Token = "0x600C89D"), Address(RVA = "0x1CE32E0", Offset = "0x1CE32E0", VA = "0x1CE32E0")] private set
      {
      }
    }

    [Token(Token = "0x17002B6C")]
    public BasicParameter LimitParameter
    {
      [Token(Token = "0x600C89E"), Address(RVA = "0x1CE32E8", Offset = "0x1CE32E8", VA = "0x1CE32E8")] get
      {
        return (BasicParameter) null;
      }
    }

    [Token(Token = "0x17002B6D")]
    public BasicParameter PararaParameter
    {
      [Token(Token = "0x600C89F"), Address(RVA = "0x1CE33E8", Offset = "0x1CE33E8", VA = "0x1CE33E8")] get
      {
        return (BasicParameter) null;
      }
      [Token(Token = "0x600C8A0"), Address(RVA = "0x1CE33F0", Offset = "0x1CE33F0", VA = "0x1CE33F0")] private set
      {
      }
    }

    [Token(Token = "0x17002B6E")]
    public BasicParameter AbilityBoardParameter
    {
      [Token(Token = "0x600C8A1"), Address(RVA = "0x1CE33F8", Offset = "0x1CE33F8", VA = "0x1CE33F8")] get
      {
        return (BasicParameter) null;
      }
      [Token(Token = "0x600C8A2"), Address(RVA = "0x1CE3400", Offset = "0x1CE3400", VA = "0x1CE3400")] private set
      {
      }
    }

    [Token(Token = "0x17002B6F")]
    public float MinDamageRate
    {
      [Token(Token = "0x600C8A3"), Address(RVA = "0x1CE3408", Offset = "0x1CE3408", VA = "0x1CE3408")] get
      {
        return new float();
      }
      [Token(Token = "0x600C8A4"), Address(RVA = "0x1CE3410", Offset = "0x1CE3410", VA = "0x1CE3410")] private set
      {
      }
    }

    [Token(Token = "0x17002B70")]
    public float MaxDamageRate
    {
      [Token(Token = "0x600C8A5"), Address(RVA = "0x1CE3418", Offset = "0x1CE3418", VA = "0x1CE3418")] get
      {
        return new float();
      }
      [Token(Token = "0x600C8A6"), Address(RVA = "0x1CE3420", Offset = "0x1CE3420", VA = "0x1CE3420")] private set
      {
      }
    }

    [Token(Token = "0x17002B71")]
    public int StyleId
    {
      [Token(Token = "0x600C8A7"), Address(RVA = "0x1CE3428", Offset = "0x1CE3428", VA = "0x1CE3428")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8A8"), Address(RVA = "0x1CE3430", Offset = "0x1CE3430", VA = "0x1CE3430")] private set
      {
      }
    }

    [Token(Token = "0x17002B72")]
    public DateTime CreateAt
    {
      [Token(Token = "0x600C8A9"), Address(RVA = "0x1CE3438", Offset = "0x1CE3438", VA = "0x1CE3438")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600C8AA"), Address(RVA = "0x1CE3440", Offset = "0x1CE3440", VA = "0x1CE3440")] private set
      {
      }
    }

    [Token(Token = "0x17002B73")]
    public DateTime UpdateAt
    {
      [Token(Token = "0x600C8AB"), Address(RVA = "0x1CE3448", Offset = "0x1CE3448", VA = "0x1CE3448")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600C8AC"), Address(RVA = "0x1CE3450", Offset = "0x1CE3450", VA = "0x1CE3450")] private set
      {
      }
    }

    [Token(Token = "0x17002B74")]
    public bool IsFavorite
    {
      [Token(Token = "0x600C8AD"), Address(RVA = "0x1CE3458", Offset = "0x1CE3458", VA = "0x1CE3458")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C8AE"), Address(RVA = "0x1CE3460", Offset = "0x1CE3460", VA = "0x1CE3460")] set
      {
      }
    }

    [Token(Token = "0x17002B75")]
    public int Exp
    {
      [Token(Token = "0x600C8AF"), Address(RVA = "0x1CE346C", Offset = "0x1CE346C", VA = "0x1CE346C")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8B0"), Address(RVA = "0x1CE3474", Offset = "0x1CE3474", VA = "0x1CE3474")] private set
      {
      }
    }

    [Token(Token = "0x17002B76")]
    public int AwakeCount
    {
      [Token(Token = "0x600C8B1"), Address(RVA = "0x1CE347C", Offset = "0x1CE347C", VA = "0x1CE347C")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8B2"), Address(RVA = "0x1CE3484", Offset = "0x1CE3484", VA = "0x1CE3484")] private set
      {
      }
    }

    [Token(Token = "0x17002B77")]
    public int LimitBreak
    {
      [Token(Token = "0x600C8B3"), Address(RVA = "0x1CE348C", Offset = "0x1CE348C", VA = "0x1CE348C")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8B4"), Address(RVA = "0x1CE3494", Offset = "0x1CE3494", VA = "0x1CE3494")] private set
      {
      }
    }

    [Token(Token = "0x17002B78")]
    public int Pin
    {
      [Token(Token = "0x600C8B5"), Address(RVA = "0x1CE349C", Offset = "0x1CE349C", VA = "0x1CE349C")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8B6"), Address(RVA = "0x1CE34A4", Offset = "0x1CE34A4", VA = "0x1CE34A4")] private set
      {
      }
    }

    [Token(Token = "0x17002B79")]
    public int RarityStar
    {
      [Token(Token = "0x600C8B7"), Address(RVA = "0x1CE34AC", Offset = "0x1CE34AC", VA = "0x1CE34AC")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8B8"), Address(RVA = "0x1CE34B4", Offset = "0x1CE34B4", VA = "0x1CE34B4")] private set
      {
      }
    }

    [Token(Token = "0x17002B7A")]
    public RarityStarTypeEnum RarityStarType
    {
      [Token(Token = "0x600C8B9"), Address(RVA = "0x1CE34BC", Offset = "0x1CE34BC", VA = "0x1CE34BC")] get
      {
        return new RarityStarTypeEnum();
      }
    }

    [Token(Token = "0x17002B7B")]
    public int AiType
    {
      [Token(Token = "0x600C8BA"), Address(RVA = "0x1CE3550", Offset = "0x1CE3550", VA = "0x1CE3550")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8BB"), Address(RVA = "0x1CE3558", Offset = "0x1CE3558", VA = "0x1CE3558")] private set
      {
      }
    }

    [Token(Token = "0x17002B7C")]
    public int ReincarnationCount
    {
      [Token(Token = "0x600C8BC"), Address(RVA = "0x1CE3560", Offset = "0x1CE3560", VA = "0x1CE3560")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8BD"), Address(RVA = "0x1CE3568", Offset = "0x1CE3568", VA = "0x1CE3568")] private set
      {
      }
    }

    [Token(Token = "0x17002B7D")]
    public bool IsUnitTrustReleased
    {
      [Token(Token = "0x600C8BE"), Address(RVA = "0x1CE3570", Offset = "0x1CE3570", VA = "0x1CE3570")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C8BF"), Address(RVA = "0x1CE3578", Offset = "0x1CE3578", VA = "0x1CE3578")] private set
      {
      }
    }

    [Token(Token = "0x17002B7E")]
    public int IncraseSkillCost
    {
      [Token(Token = "0x600C8C0"), Address(RVA = "0x1CE3584", Offset = "0x1CE3584", VA = "0x1CE3584")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8C1"), Address(RVA = "0x1CE358C", Offset = "0x1CE358C", VA = "0x1CE358C")] private set
      {
      }
    }

    [Token(Token = "0x17002B7F")]
    public List<UnitSkill> UnitSkills
    {
      [Token(Token = "0x600C8C2"), Address(RVA = "0x1CE3594", Offset = "0x1CE3594", VA = "0x1CE3594")] get
      {
        return (List<UnitSkill>) null;
      }
      [Token(Token = "0x600C8C3"), Address(RVA = "0x1CE359C", Offset = "0x1CE359C", VA = "0x1CE359C")] private set
      {
      }
    }

    [Token(Token = "0x17002B80")]
    public int[] LearningAbilityBoardNodeIds
    {
      [Token(Token = "0x600C8C4"), Address(RVA = "0x1CE35A4", Offset = "0x1CE35A4", VA = "0x1CE35A4")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x600C8C5"), Address(RVA = "0x1CE35AC", Offset = "0x1CE35AC", VA = "0x1CE35AC")] private set
      {
      }
    }

    [Token(Token = "0x17002B81")]
    public AbilityBoard[] AbilityBoards
    {
      [Token(Token = "0x600C8C6"), Address(RVA = "0x1CE35B4", Offset = "0x1CE35B4", VA = "0x1CE35B4")] get
      {
        return (AbilityBoard[]) null;
      }
      [Token(Token = "0x600C8C7"), Address(RVA = "0x1CE35BC", Offset = "0x1CE35BC", VA = "0x1CE35BC")] private set
      {
      }
    }

    [Token(Token = "0x17002B82")]
    public int AbilityBoardNodeReleaseCount
    {
      [Token(Token = "0x600C8C8"), Address(RVA = "0x1CE35C4", Offset = "0x1CE35C4", VA = "0x1CE35C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C8C9"), Address(RVA = "0x1CE35CC", Offset = "0x1CE35CC", VA = "0x1CE35CC")] private set
      {
      }
    }

    [Token(Token = "0x17002B83")]
    public CharacterData CharacterData
    {
      [Token(Token = "0x600C8CA"), Address(RVA = "0x1CE35D4", Offset = "0x1CE35D4", VA = "0x1CE35D4")] get
      {
        return (CharacterData) null;
      }
      [Token(Token = "0x600C8CB"), Address(RVA = "0x1CE35DC", Offset = "0x1CE35DC", VA = "0x1CE35DC")] private set
      {
      }
    }

    [Token(Token = "0x17002B84")]
    public StyleData StyleData
    {
      [Token(Token = "0x600C8CC"), Address(RVA = "0x1CE35E4", Offset = "0x1CE35E4", VA = "0x1CE35E4")] get
      {
        return (StyleData) null;
      }
      [Token(Token = "0x600C8CD"), Address(RVA = "0x1CE35EC", Offset = "0x1CE35EC", VA = "0x1CE35EC")] private set
      {
      }
    }

    [Token(Token = "0x17002B85")]
    public ClassData ClassData
    {
      [Token(Token = "0x600C8CE"), Address(RVA = "0x1CE35F4", Offset = "0x1CE35F4", VA = "0x1CE35F4")] get
      {
        return (ClassData) null;
      }
      [Token(Token = "0x600C8CF"), Address(RVA = "0x1CE35FC", Offset = "0x1CE35FC", VA = "0x1CE35FC")] private set
      {
      }
    }

    [Token(Token = "0x17002B86")]
    public WeaponProficiency WeaponProficiency
    {
      [Token(Token = "0x600C8D0"), Address(RVA = "0x1CE3604", Offset = "0x1CE3604", VA = "0x1CE3604")] get
      {
        return (WeaponProficiency) null;
      }
      [Token(Token = "0x600C8D1"), Address(RVA = "0x1CE360C", Offset = "0x1CE360C", VA = "0x1CE360C")] private set
      {
      }
    }

    [Token(Token = "0x17002B87")]
    public IReadOnlyList<EquipmentClassificationData> EnableEquipmentClassificationList
    {
      [Token(Token = "0x600C8D2"), Address(RVA = "0x1CE3614", Offset = "0x1CE3614", VA = "0x1CE3614")] get
      {
        return (IReadOnlyList<EquipmentClassificationData>) null;
      }
    }

    [Token(Token = "0x17002B88")]
    public Dictionary<SpeciesTypeEnum, int> SpeciesMaxDamegeDec
    {
      [Token(Token = "0x600C8D3"), Address(RVA = "0x1CE361C", Offset = "0x1CE361C", VA = "0x1CE361C")] get
      {
        return (Dictionary<SpeciesTypeEnum, int>) null;
      }
      [Token(Token = "0x600C8D4"), Address(RVA = "0x1CE3624", Offset = "0x1CE3624", VA = "0x1CE3624")] private set
      {
      }
    }

    [Token(Token = "0x17002B89")]
    public string Name
    {
      [Token(Token = "0x600C8D5"), Address(RVA = "0x1CE362C", Offset = "0x1CE362C", VA = "0x1CE362C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002B8A")]
    public string EnglishName
    {
      [Token(Token = "0x600C8D6"), Address(RVA = "0x1CE3648", Offset = "0x1CE3648", VA = "0x1CE3648")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002B8B")]
    public int Level
    {
      [Token(Token = "0x600C8D7"), Address(RVA = "0x1CE3664", Offset = "0x1CE3664", VA = "0x1CE3664")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B8C")]
    public int NextLevelExp
    {
      [Token(Token = "0x600C8D8"), Address(RVA = "0x1CE3764", Offset = "0x1CE3764", VA = "0x1CE3764")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B8D")]
    public float NextLevelExpRate
    {
      [Token(Token = "0x600C8D9"), Address(RVA = "0x1CE3940", Offset = "0x1CE3940", VA = "0x1CE3940")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002B8E")]
    public int MaxLevel
    {
      [Token(Token = "0x600C8DA"), Address(RVA = "0x1CE3B44", Offset = "0x1CE3B44", VA = "0x1CE3B44")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B8F")]
    public bool IsMaxLevel
    {
      [Token(Token = "0x600C8DB"), Address(RVA = "0x1CE3BD8", Offset = "0x1CE3BD8", VA = "0x1CE3BD8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002B90")]
    public float AbilityBoardReleaseRate
    {
      [Token(Token = "0x600C8DC"), Address(RVA = "0x1CE3C08", Offset = "0x1CE3C08", VA = "0x1CE3C08")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002B91")]
    public ElementTypeEnum Element
    {
      [Token(Token = "0x600C8DD"), Address(RVA = "0x1CE0ED4", Offset = "0x1CE0ED4", VA = "0x1CE0ED4")] get
      {
        return new ElementTypeEnum();
      }
    }

    [Token(Token = "0x17002B92")]
    public EquipmentClassificationData MainEquipmentClassfication
    {
      [Token(Token = "0x600C8DE"), Address(RVA = "0x1CE4098", Offset = "0x1CE4098", VA = "0x1CE4098")] get
      {
        return (EquipmentClassificationData) null;
      }
    }

    [Token(Token = "0x17002B93")]
    public List<SpeciesTypeEnum> SpeciesType
    {
      [Token(Token = "0x600C8DF"), Address(RVA = "0x1CE413C", Offset = "0x1CE413C", VA = "0x1CE413C")] get
      {
        return (List<SpeciesTypeEnum>) null;
      }
    }

    [Token(Token = "0x17002B94")]
    public ArmyData ArmyData
    {
      [Token(Token = "0x600C8E0"), Address(RVA = "0x1CE4534", Offset = "0x1CE4534", VA = "0x1CE4534")] get
      {
        return (ArmyData) null;
      }
    }

    [Token(Token = "0x17002B95")]
    public MoveData MoveData
    {
      [Token(Token = "0x600C8E1"), Address(RVA = "0x1CE0EF0", Offset = "0x1CE0EF0", VA = "0x1CE0EF0")] get
      {
        return (MoveData) null;
      }
    }

    [Token(Token = "0x17002B96")]
    public ArmorData ArmorData
    {
      [Token(Token = "0x600C8E2"), Address(RVA = "0x1CE0F9C", Offset = "0x1CE0F9C", VA = "0x1CE0F9C")] get
      {
        return (ArmorData) null;
      }
    }

    [Token(Token = "0x17002B97")]
    public RideTypeEnum RideType
    {
      [Token(Token = "0x600C8E3"), Address(RVA = "0x1CE1048", Offset = "0x1CE1048", VA = "0x1CE1048")] get
      {
        return new RideTypeEnum();
      }
    }

    [Token(Token = "0x17002B98")]
    [Obsolete("仕様変更により将来的に使わない")]
    public RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C8E4"), Address(RVA = "0x1CE45D8", Offset = "0x1CE45D8", VA = "0x1CE45D8")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002B99")]
    public int InitialRarityStar
    {
      [Token(Token = "0x600C8E5"), Address(RVA = "0x1CE45F4", Offset = "0x1CE45F4", VA = "0x1CE45F4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B9A")]
    public RarityStarTypeEnum InitialRarityStarType
    {
      [Token(Token = "0x600C8E6"), Address(RVA = "0x1CE4610", Offset = "0x1CE4610", VA = "0x1CE4610")] get
      {
        return new RarityStarTypeEnum();
      }
    }

    [Token(Token = "0x17002B9B")]
    public int MoveAmount
    {
      [Token(Token = "0x600C8E7"), Address(RVA = "0x1CE46AC", Offset = "0x1CE46AC", VA = "0x1CE46AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B9C")]
    public int MinRange
    {
      [Token(Token = "0x600C8E8"), Address(RVA = "0x1CE483C", Offset = "0x1CE483C", VA = "0x1CE483C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B9D")]
    public int MaxRange
    {
      [Token(Token = "0x600C8E9"), Address(RVA = "0x1CE4844", Offset = "0x1CE4844", VA = "0x1CE4844")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B9E")]
    public string AssetBundleName
    {
      [Token(Token = "0x600C8EA"), Address(RVA = "0x1CE484C", Offset = "0x1CE484C", VA = "0x1CE484C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002B9F")]
    public string ClassAssetBundleName
    {
      [Token(Token = "0x600C8EB"), Address(RVA = "0x1CE48F4", Offset = "0x1CE48F4", VA = "0x1CE48F4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002BA0")]
    public string ImageName
    {
      [Token(Token = "0x600C8EC"), Address(RVA = "0x1CE499C", Offset = "0x1CE499C", VA = "0x1CE499C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002BA1")]
    public string ThumbnailImageName
    {
      [Token(Token = "0x600C8ED"), Address(RVA = "0x1CE4A04", Offset = "0x1CE4A04", VA = "0x1CE4A04")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002BA2")]
    public string ModelName
    {
      [Token(Token = "0x600C8EE"), Address(RVA = "0x1CE4AAC", Offset = "0x1CE4AAC", VA = "0x1CE4AAC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002BA3")]
    public string ClassRideModelName
    {
      [Token(Token = "0x600C8EF"), Address(RVA = "0x1CE4B7C", Offset = "0x1CE4B7C", VA = "0x1CE4B7C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002BA4")]
    public string DotModelName
    {
      [Token(Token = "0x600C8F0"), Address(RVA = "0x1CE4CC8", Offset = "0x1CE4CC8", VA = "0x1CE4CC8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002BA5")]
    public string EmblemImageName
    {
      [Token(Token = "0x600C8F1"), Address(RVA = "0x1CE4D30", Offset = "0x1CE4D30", VA = "0x1CE4D30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002BA6")]
    public bool IsUniqueName
    {
      [Token(Token = "0x600C8F2"), Address(RVA = "0x1CE4D8C", Offset = "0x1CE4D8C", VA = "0x1CE4D8C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C8F3")]
    [Address(RVA = "0x1CE4DA8", Offset = "0x1CE4DA8", VA = "0x1CE4DA8")]
    public Style()
    {
    }

    [Token(Token = "0x600C8F4")]
    [Address(RVA = "0x1CE51D8", Offset = "0x1CE51D8", VA = "0x1CE51D8")]
    public Style Copy() => (Style) null;

    [Token(Token = "0x600C8F5")]
    [Address(RVA = "0x1CE527C", Offset = "0x1CE527C", VA = "0x1CE527C")]
    private Style(int labelID, UniqueID uniqueID)
    {
    }

    [Token(Token = "0x600C8F6")]
    [Address(RVA = "0x1CE54F0", Offset = "0x1CE54F0", VA = "0x1CE54F0")]
    public void Apply(PlayerUnitType entity)
    {
    }

    [Token(Token = "0x600C8F7")]
    [Address(RVA = "0x1CE5558", Offset = "0x1CE5558", VA = "0x1CE5558")]
    public void Apply(PlayerUnitType entity, PlayerProfile playerProfile)
    {
    }

    [Token(Token = "0x600C8F8")]
    [Address(RVA = "0x1CE6C70", Offset = "0x1CE6C70", VA = "0x1CE6C70")]
    public void ApplyNpcData(int npcId)
    {
    }

    [Token(Token = "0x600C8F9")]
    [Address(RVA = "0x1CE7278", Offset = "0x1CE7278", VA = "0x1CE7278")]
    public void ApplyLevelupType(PlayerUnitLevelUpType playerUnitLevelUpType)
    {
    }

    [Token(Token = "0x600C8FA")]
    [Address(RVA = "0x1CE7280", Offset = "0x1CE7280", VA = "0x1CE7280")]
    public void ApplyWeaponProficiency(
      List<PlayerUnitCharacterWeaponProficiencyType> playerUnitCharacterWeaponProficiencyType)
    {
    }

    [Token(Token = "0x600C8FB")]
    [Address(RVA = "0x1CE72AC", Offset = "0x1CE72AC", VA = "0x1CE72AC")]
    public void AppryPararaData(Character character)
    {
    }

    [Token(Token = "0x600C8FC")]
    [Address(RVA = "0x1CE609C", Offset = "0x1CE609C", VA = "0x1CE609C")]
    private void CreateEnableEquipmentClassification()
    {
    }

    [Token(Token = "0x600C8FD")]
    [Address(RVA = "0x1CE64EC", Offset = "0x1CE64EC", VA = "0x1CE64EC")]
    private void UpdateAbilityBoardParameter()
    {
    }

    [Token(Token = "0x600C8FE")]
    [Address(RVA = "0x1CE6014", Offset = "0x1CE6014", VA = "0x1CE6014")]
    private void Reset()
    {
    }

    [Token(Token = "0x600C8FF")]
    [Address(RVA = "0x1CE72F0", Offset = "0x1CE72F0", VA = "0x1CE72F0")]
    public int GetPararaTotal() => new int();

    [Token(Token = "0x600C900")]
    [Address(RVA = "0x1CE731C", Offset = "0x1CE731C", VA = "0x1CE731C")]
    public int GetPararaLimitTotal() => new int();

    [Token(Token = "0x600C901")]
    [Address(RVA = "0x1CE73DC", Offset = "0x1CE73DC", VA = "0x1CE73DC")]
    public bool IsOrganization() => new bool();

    [Token(Token = "0x600C902")]
    [Address(RVA = "0x1CE77A4", Offset = "0x1CE77A4", VA = "0x1CE77A4")]
    public PlayerUnitType ConvertToPlayerUnitType() => (PlayerUnitType) null;

    [Token(Token = "0x600C903")]
    [Address(RVA = "0x1CE7A48", Offset = "0x1CE7A48", VA = "0x1CE7A48")]
    public static Style CreateNotPossessedData(StyleData master) => (Style) null;

    [Token(Token = "0x600C904")]
    [Address(RVA = "0x1CE7F08", Offset = "0x1CE7F08", VA = "0x1CE7F08")]
    public bool IsNotPossessed() => new bool();

    [Token(Token = "0x600C905")]
    [Address(RVA = "0x1CE7F64", Offset = "0x1CE7F64", VA = "0x1CE7F64")]
    public bool CheckSubEquipmentType(int equipmentClassification) => new bool();

    [Token(Token = "0x600C906")]
    [Address(RVA = "0x1CE8278", Offset = "0x1CE8278", VA = "0x1CE8278")]
    public float[] GetAveragePIN() => (float[]) null;

    [Token(Token = "0x600C907")]
    [Address(RVA = "0x1CE8494", Offset = "0x1CE8494", VA = "0x1CE8494")]
    public int CheckAddExpLvUp(int exp) => new int();

    [Token(Token = "0x600C908")]
    [Address(RVA = "0x1CE85A8", Offset = "0x1CE85A8", VA = "0x1CE85A8")]
    public bool CheckAddExpOver(int exp) => new bool();

    [Token(Token = "0x600C909")]
    [Address(RVA = "0x1CE86C0", Offset = "0x1CE86C0", VA = "0x1CE86C0")]
    public float GetAddExpNextLevelRate(int exp) => new float();

    [Token(Token = "0x600C90A")]
    [Address(RVA = "0x1CE88D0", Offset = "0x1CE88D0", VA = "0x1CE88D0")]
    public static Style CreateDebugData(string unique, int master) => (Style) null;

    [Token(Token = "0x600C90B")]
    [Address(RVA = "0x1CE8BE4", Offset = "0x1CE8BE4", VA = "0x1CE8BE4")]
    public static Style CreateDebugData(
      int unique,
      int master,
      int vitality,
      int strength,
      int intelligence,
      int defence,
      int mind,
      int agility,
      int dexterity,
      int lucky)
    {
      return (Style) null;
    }

    [Token(Token = "0x600C90C")]
    [Address(RVA = "0x1CE8F94", Offset = "0x1CE8F94", VA = "0x1CE8F94")]
    public static Style CreateByServerData(PlayerUnitType entity) => (Style) null;

    [Token(Token = "0x600C90D")]
    [Address(RVA = "0x1CE8FEC", Offset = "0x1CE8FEC", VA = "0x1CE8FEC")]
    public static Style CreateByServerData(PlayerUnitType entity, PlayerProfile playerProfile)
    {
      return (Style) null;
    }

    [Token(Token = "0x600C90E")]
    [Address(RVA = "0x1CE9064", Offset = "0x1CE9064", VA = "0x1CE9064")]
    public bool IsUnlockEquipSlot(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new bool();
    }

    [Token(Token = "0x600C90F")]
    [Address(RVA = "0x1CE9224", Offset = "0x1CE9224", VA = "0x1CE9224")]
    public bool IsUnlockMainWeapon() => new bool();

    [Token(Token = "0x600C910")]
    [Address(RVA = "0x1CE9254", Offset = "0x1CE9254", VA = "0x1CE9254")]
    public bool IsUnlockSubWeapon1() => new bool();

    [Token(Token = "0x600C911")]
    [Address(RVA = "0x1CE925C", Offset = "0x1CE925C", VA = "0x1CE925C")]
    public bool IsUnlockSubWeapon2() => new bool();

    [Token(Token = "0x600C912")]
    [Address(RVA = "0x1CE9264", Offset = "0x1CE9264", VA = "0x1CE9264")]
    public bool IsUnlockAccessories() => new bool();

    [Token(Token = "0x600C913")]
    [Address(RVA = "0x1CE7BAC", Offset = "0x1CE7BAC", VA = "0x1CE7BAC")]
    private static List<UnitSkill> GetSkillByStyleId(int styleId) => (List<UnitSkill>) null;

    [Token(Token = "0x600C914")]
    [Address(RVA = "0x1CE926C", Offset = "0x1CE926C", VA = "0x1CE926C")]
    public bool CheckEnhancedBadge() => new bool();

    [Token(Token = "0x600C915")]
    [Address(RVA = "0x1CE93D8", Offset = "0x1CE93D8", VA = "0x1CE93D8")]
    public void GetRarityUpItemAmount(out int possessionAmount, out int needAmount)
    {
    }

    [Token(Token = "0x600C916")]
    [Address(RVA = "0x1CE98A8", Offset = "0x1CE98A8", VA = "0x1CE98A8")]
    public void GetLimitBreakItemData(
      int limitBreakNum,
      out int possessionAmount,
      out int needAmount)
    {
    }
  }
}
