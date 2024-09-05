// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.UnitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002806")]
  public class UnitData
  {
    [Token(Token = "0x400AA45")]
    public const int DEFAULT_GRID_SIZE = 1;
    [Token(Token = "0x400AA46")]
    public const int DEFAULT_AI_TYPE = 1;
    [Token(Token = "0x400AA53")]
    [FieldOffset(Offset = "0x58")]
    public int[] ReinforceAttackType;
    [Token(Token = "0x400AA54")]
    [FieldOffset(Offset = "0x60")]
    public int[] ResistAttackType;
    [Token(Token = "0x400AA55")]
    [FieldOffset(Offset = "0x68")]
    public int[] ReinforceElementType;
    [Token(Token = "0x400AA56")]
    [FieldOffset(Offset = "0x70")]
    public int[] ResistElementType;
    [Token(Token = "0x400AA5C")]
    [FieldOffset(Offset = "0x98")]
    public Dictionary<WeaponTypeEnum, ProficiencyTypeEnum> Proficiency;

    [Token(Token = "0x17003694")]
    public int Id
    {
      [Token(Token = "0x600FAA4"), Address(RVA = "0x44C8FD8", Offset = "0x44C8FD8", VA = "0x44C8FD8")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAA5"), Address(RVA = "0x44C8FE0", Offset = "0x44C8FE0", VA = "0x44C8FE0")] private set
      {
      }
    }

    [Token(Token = "0x17003695")]
    public string UniqueId
    {
      [Token(Token = "0x600FAA6"), Address(RVA = "0x44C8FE8", Offset = "0x44C8FE8", VA = "0x44C8FE8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600FAA7"), Address(RVA = "0x44C8FF0", Offset = "0x44C8FF0", VA = "0x44C8FF0")] private set
      {
      }
    }

    [Token(Token = "0x17003696")]
    public int StyleId
    {
      [Token(Token = "0x600FAA8"), Address(RVA = "0x44C8FF8", Offset = "0x44C8FF8", VA = "0x44C8FF8")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAA9"), Address(RVA = "0x44C9000", Offset = "0x44C9000", VA = "0x44C9000")] private set
      {
      }
    }

    [Token(Token = "0x17003697")]
    public int Rarity
    {
      [Token(Token = "0x600FAAA"), Address(RVA = "0x44C9008", Offset = "0x44C9008", VA = "0x44C9008")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003698")]
    public int ReincarnationCount
    {
      [Token(Token = "0x600FAAB"), Address(RVA = "0x44C9024", Offset = "0x44C9024", VA = "0x44C9024")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAAC"), Address(RVA = "0x44C902C", Offset = "0x44C902C", VA = "0x44C902C")] private set
      {
      }
    }

    [Token(Token = "0x17003699")]
    public RarityStyleData RarityData
    {
      [Token(Token = "0x600FAAD"), Address(RVA = "0x44C9034", Offset = "0x44C9034", VA = "0x44C9034")] get
      {
        return (RarityStyleData) null;
      }
      [Token(Token = "0x600FAAE"), Address(RVA = "0x44C903C", Offset = "0x44C903C", VA = "0x44C903C")] private set
      {
      }
    }

    [Token(Token = "0x1700369A")]
    public int LimitBreak
    {
      [Token(Token = "0x600FAAF"), Address(RVA = "0x44C9044", Offset = "0x44C9044", VA = "0x44C9044")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAB0"), Address(RVA = "0x44C904C", Offset = "0x44C904C", VA = "0x44C904C")] private set
      {
      }
    }

    [Token(Token = "0x1700369B")]
    public int MaxLimitBreak
    {
      [Token(Token = "0x600FAB1"), Address(RVA = "0x44C9054", Offset = "0x44C9054", VA = "0x44C9054")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAB2"), Address(RVA = "0x44C905C", Offset = "0x44C905C", VA = "0x44C905C")] private set
      {
      }
    }

    [Token(Token = "0x1700369C")]
    public int InitialExp
    {
      [Token(Token = "0x600FAB3"), Address(RVA = "0x44C9064", Offset = "0x44C9064", VA = "0x44C9064")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAB4"), Address(RVA = "0x44C906C", Offset = "0x44C906C", VA = "0x44C906C")] private set
      {
      }
    }

    [Token(Token = "0x1700369D")]
    public int InitialLp
    {
      [Token(Token = "0x600FAB5"), Address(RVA = "0x44C9074", Offset = "0x44C9074", VA = "0x44C9074")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAB6"), Address(RVA = "0x44C907C", Offset = "0x44C907C", VA = "0x44C907C")] private set
      {
      }
    }

    [Token(Token = "0x1700369E")]
    public int InitialDamage
    {
      [Token(Token = "0x600FAB7"), Address(RVA = "0x44C9084", Offset = "0x44C9084", VA = "0x44C9084")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAB8"), Address(RVA = "0x44C908C", Offset = "0x44C908C", VA = "0x44C908C")] private set
      {
      }
    }

    [Token(Token = "0x1700369F")]
    public BasicParameter InitialParameter
    {
      [Token(Token = "0x600FAB9"), Address(RVA = "0x44C9094", Offset = "0x44C9094", VA = "0x44C9094")] get
      {
        return (BasicParameter) null;
      }
      [Token(Token = "0x600FABA"), Address(RVA = "0x44C909C", Offset = "0x44C909C", VA = "0x44C909C")] set
      {
      }
    }

    [Token(Token = "0x170036A0")]
    public Dictionary<int, BasicParameter> LvUpParams
    {
      [Token(Token = "0x600FABB"), Address(RVA = "0x44C90A4", Offset = "0x44C90A4", VA = "0x44C90A4")] get
      {
        return (Dictionary<int, BasicParameter>) null;
      }
      [Token(Token = "0x600FABC"), Address(RVA = "0x44C90AC", Offset = "0x44C90AC", VA = "0x44C90AC")] private set
      {
      }
    }

    [Token(Token = "0x170036A1")]
    public BattleParameter StyleMasterBonus
    {
      [Token(Token = "0x600FABD"), Address(RVA = "0x44C90B4", Offset = "0x44C90B4", VA = "0x44C90B4")] get
      {
        return (BattleParameter) null;
      }
      [Token(Token = "0x600FABE"), Address(RVA = "0x44C90BC", Offset = "0x44C90BC", VA = "0x44C90BC")] private set
      {
      }
    }

    [Token(Token = "0x170036A2")]
    public BattleParameter BaseRatedBuff
    {
      [Token(Token = "0x600FABF"), Address(RVA = "0x44C90C4", Offset = "0x44C90C4", VA = "0x44C90C4")] get
      {
        return (BattleParameter) null;
      }
      [Token(Token = "0x600FAC0"), Address(RVA = "0x44C90CC", Offset = "0x44C90CC", VA = "0x44C90CC")] private set
      {
      }
    }

    [Token(Token = "0x170036A3")]
    public ForceTypeEnum Force
    {
      [Token(Token = "0x600FAC1"), Address(RVA = "0x44C90D4", Offset = "0x44C90D4", VA = "0x44C90D4")] get
      {
        return new ForceTypeEnum();
      }
      [Token(Token = "0x600FAC2"), Address(RVA = "0x44C90DC", Offset = "0x44C90DC", VA = "0x44C90DC")] private set
      {
      }
    }

    [Token(Token = "0x170036A4")]
    public int GridSize
    {
      [Token(Token = "0x600FAC3"), Address(RVA = "0x44C90E4", Offset = "0x44C90E4", VA = "0x44C90E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAC4"), Address(RVA = "0x44C90EC", Offset = "0x44C90EC", VA = "0x44C90EC")] private set
      {
      }
    }

    [Token(Token = "0x170036A5")]
    public List<WeaponData> Weapons
    {
      [Token(Token = "0x600FAC5"), Address(RVA = "0x44C90F4", Offset = "0x44C90F4", VA = "0x44C90F4")] get
      {
        return (List<WeaponData>) null;
      }
      [Token(Token = "0x600FAC6"), Address(RVA = "0x44C90FC", Offset = "0x44C90FC", VA = "0x44C90FC")] private set
      {
      }
    }

    [Token(Token = "0x170036A6")]
    public List<AccessoryData> Accessories
    {
      [Token(Token = "0x600FAC7"), Address(RVA = "0x44C9104", Offset = "0x44C9104", VA = "0x44C9104")] get
      {
        return (List<AccessoryData>) null;
      }
      [Token(Token = "0x600FAC8"), Address(RVA = "0x44C910C", Offset = "0x44C910C", VA = "0x44C910C")] private set
      {
      }
    }

    [Token(Token = "0x170036A7")]
    public List<MindEquipmentData> MindEquipments
    {
      [Token(Token = "0x600FAC9"), Address(RVA = "0x44C9114", Offset = "0x44C9114", VA = "0x44C9114")] get
      {
        return (List<MindEquipmentData>) null;
      }
      [Token(Token = "0x600FACA"), Address(RVA = "0x44C911C", Offset = "0x44C911C", VA = "0x44C911C")] private set
      {
      }
    }

    [Token(Token = "0x170036A8")]
    public List<TrustData> Trusts
    {
      [Token(Token = "0x600FACB"), Address(RVA = "0x44C9124", Offset = "0x44C9124", VA = "0x44C9124")] get
      {
        return (List<TrustData>) null;
      }
      [Token(Token = "0x600FACC"), Address(RVA = "0x44C912C", Offset = "0x44C912C", VA = "0x44C912C")] private set
      {
      }
    }

    [Token(Token = "0x170036A9")]
    public List<SkillData> CustomSkills
    {
      [Token(Token = "0x600FACD"), Address(RVA = "0x44C9134", Offset = "0x44C9134", VA = "0x44C9134")] get
      {
        return (List<SkillData>) null;
      }
      [Token(Token = "0x600FACE"), Address(RVA = "0x44C913C", Offset = "0x44C913C", VA = "0x44C913C")] private set
      {
      }
    }

    [Token(Token = "0x170036AA")]
    public List<SkillData> UnitSkills
    {
      [Token(Token = "0x600FACF"), Address(RVA = "0x44C9144", Offset = "0x44C9144", VA = "0x44C9144")] get
      {
        return (List<SkillData>) null;
      }
      [Token(Token = "0x600FAD0"), Address(RVA = "0x44C914C", Offset = "0x44C914C", VA = "0x44C914C")] private set
      {
      }
    }

    [Token(Token = "0x170036AB")]
    public List<SkillData> CommuSkills
    {
      [Token(Token = "0x600FAD1"), Address(RVA = "0x44C9154", Offset = "0x44C9154", VA = "0x44C9154")] get
      {
        return (List<SkillData>) null;
      }
      [Token(Token = "0x600FAD2"), Address(RVA = "0x44C915C", Offset = "0x44C915C", VA = "0x44C915C")] private set
      {
      }
    }

    [Token(Token = "0x170036AC")]
    public int Troops
    {
      [Token(Token = "0x600FAD3"), Address(RVA = "0x44C9164", Offset = "0x44C9164", VA = "0x44C9164")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAD4"), Address(RVA = "0x44C916C", Offset = "0x44C916C", VA = "0x44C916C")] private set
      {
      }
    }

    [Token(Token = "0x170036AD")]
    public int BaseExp
    {
      [Token(Token = "0x600FAD5"), Address(RVA = "0x44C9174", Offset = "0x44C9174", VA = "0x44C9174")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAD6"), Address(RVA = "0x44C917C", Offset = "0x44C917C", VA = "0x44C917C")] private set
      {
      }
    }

    [Token(Token = "0x170036AE")]
    public int QuestCorrectMoveAmount
    {
      [Token(Token = "0x600FAD7"), Address(RVA = "0x44C9184", Offset = "0x44C9184", VA = "0x44C9184")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAD8"), Address(RVA = "0x44C918C", Offset = "0x44C918C", VA = "0x44C918C")] private set
      {
      }
    }

    [Token(Token = "0x170036AF")]
    public StyleData Style
    {
      [Token(Token = "0x600FAD9"), Address(RVA = "0x44C9194", Offset = "0x44C9194", VA = "0x44C9194")] get
      {
        return (StyleData) null;
      }
      [Token(Token = "0x600FADA"), Address(RVA = "0x44C919C", Offset = "0x44C919C", VA = "0x44C919C")] private set
      {
      }
    }

    [Token(Token = "0x170036B0")]
    public ClassData Class
    {
      [Token(Token = "0x600FADB"), Address(RVA = "0x44C91A4", Offset = "0x44C91A4", VA = "0x44C91A4")] get
      {
        return (ClassData) null;
      }
      [Token(Token = "0x600FADC"), Address(RVA = "0x44C91AC", Offset = "0x44C91AC", VA = "0x44C91AC")] private set
      {
      }
    }

    [Token(Token = "0x170036B1")]
    public ArmyData Army
    {
      [Token(Token = "0x600FADD"), Address(RVA = "0x44C91B4", Offset = "0x44C91B4", VA = "0x44C91B4")] get
      {
        return (ArmyData) null;
      }
      [Token(Token = "0x600FADE"), Address(RVA = "0x44C91BC", Offset = "0x44C91BC", VA = "0x44C91BC")] private set
      {
      }
    }

    [Token(Token = "0x170036B2")]
    public CharacterData Chara
    {
      [Token(Token = "0x600FADF"), Address(RVA = "0x44C91C4", Offset = "0x44C91C4", VA = "0x44C91C4")] get
      {
        return (CharacterData) null;
      }
      [Token(Token = "0x600FAE0"), Address(RVA = "0x44C91CC", Offset = "0x44C91CC", VA = "0x44C91CC")] private set
      {
      }
    }

    [Token(Token = "0x170036B3")]
    public StockCounterData StockCounter
    {
      [Token(Token = "0x600FAE1"), Address(RVA = "0x44C91D4", Offset = "0x44C91D4", VA = "0x44C91D4")] get
      {
        return (StockCounterData) null;
      }
      [Token(Token = "0x600FAE2"), Address(RVA = "0x44C91DC", Offset = "0x44C91DC", VA = "0x44C91DC")] private set
      {
      }
    }

    [Token(Token = "0x170036B4")]
    public string Name
    {
      [Token(Token = "0x600FAE3"), Address(RVA = "0x44C91E4", Offset = "0x44C91E4", VA = "0x44C91E4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170036B5")]
    public ArmorTypeEnum Armor
    {
      [Token(Token = "0x600FAE4"), Address(RVA = "0x44C9200", Offset = "0x44C9200", VA = "0x44C9200")] get
      {
        return new ArmorTypeEnum();
      }
      [Token(Token = "0x600FAE5"), Address(RVA = "0x44C9208", Offset = "0x44C9208", VA = "0x44C9208")] private set
      {
      }
    }

    [Token(Token = "0x170036B6")]
    public RideTypeEnum Ride
    {
      [Token(Token = "0x600FAE6"), Address(RVA = "0x44C9210", Offset = "0x44C9210", VA = "0x44C9210")] get
      {
        return new RideTypeEnum();
      }
      [Token(Token = "0x600FAE7"), Address(RVA = "0x44C9218", Offset = "0x44C9218", VA = "0x44C9218")] private set
      {
      }
    }

    [Token(Token = "0x170036B7")]
    public MoveData MoveData
    {
      [Token(Token = "0x600FAE8"), Address(RVA = "0x44C9220", Offset = "0x44C9220", VA = "0x44C9220")] get
      {
        return (MoveData) null;
      }
      [Token(Token = "0x600FAE9"), Address(RVA = "0x44C9228", Offset = "0x44C9228", VA = "0x44C9228")] private set
      {
      }
    }

    [Token(Token = "0x170036B8")]
    public int GroupId
    {
      [Token(Token = "0x600FAEA"), Address(RVA = "0x44C9230", Offset = "0x44C9230", VA = "0x44C9230")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036B9")]
    public StyleGroupTypeData[] Groups
    {
      [Token(Token = "0x600FAEB"), Address(RVA = "0x44C924C", Offset = "0x44C924C", VA = "0x44C924C")] get
      {
        return (StyleGroupTypeData[]) null;
      }
      [Token(Token = "0x600FAEC"), Address(RVA = "0x44C9254", Offset = "0x44C9254", VA = "0x44C9254")] private set
      {
      }
    }

    [Token(Token = "0x170036BA")]
    public SpeciesDescriptionData[] Species
    {
      [Token(Token = "0x600FAED"), Address(RVA = "0x44C925C", Offset = "0x44C925C", VA = "0x44C925C")] get
      {
        return (SpeciesDescriptionData[]) null;
      }
      [Token(Token = "0x600FAEE"), Address(RVA = "0x44C9264", Offset = "0x44C9264", VA = "0x44C9264")] private set
      {
      }
    }

    [Token(Token = "0x170036BB")]
    public int ArmorMoveAmountOffset
    {
      [Token(Token = "0x600FAEF"), Address(RVA = "0x44C926C", Offset = "0x44C926C", VA = "0x44C926C")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAF0"), Address(RVA = "0x44C9274", Offset = "0x44C9274", VA = "0x44C9274")] private set
      {
      }
    }

    [Token(Token = "0x170036BC")]
    public int MoveAmount
    {
      [Token(Token = "0x600FAF1"), Address(RVA = "0x44C927C", Offset = "0x44C927C", VA = "0x44C927C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036BD")]
    public ElementTypeEnum ElementType
    {
      [Token(Token = "0x600FAF2"), Address(RVA = "0x44C92A8", Offset = "0x44C92A8", VA = "0x44C92A8")] get
      {
        return new ElementTypeEnum();
      }
      [Token(Token = "0x600FAF3"), Address(RVA = "0x44C92B0", Offset = "0x44C92B0", VA = "0x44C92B0")] private set
      {
      }
    }

    [Token(Token = "0x170036BE")]
    public List<ActiveSkillData> ActiveSkills
    {
      [Token(Token = "0x600FAF4"), Address(RVA = "0x44C92B8", Offset = "0x44C92B8", VA = "0x44C92B8")] get
      {
        return (List<ActiveSkillData>) null;
      }
      [Token(Token = "0x600FAF5"), Address(RVA = "0x44C92C0", Offset = "0x44C92C0", VA = "0x44C92C0")] private set
      {
      }
    }

    [Token(Token = "0x170036BF")]
    public List<PassiveSkillData> PassiveSkills
    {
      [Token(Token = "0x600FAF6"), Address(RVA = "0x44C92C8", Offset = "0x44C92C8", VA = "0x44C92C8")] get
      {
        return (List<PassiveSkillData>) null;
      }
      [Token(Token = "0x600FAF7"), Address(RVA = "0x44C92D0", Offset = "0x44C92D0", VA = "0x44C92D0")] private set
      {
      }
    }

    [Token(Token = "0x170036C0")]
    public AITypeData AIType
    {
      [Token(Token = "0x600FAF8"), Address(RVA = "0x44C92D8", Offset = "0x44C92D8", VA = "0x44C92D8")] get
      {
        return (AITypeData) null;
      }
      [Token(Token = "0x600FAF9"), Address(RVA = "0x44C92E0", Offset = "0x44C92E0", VA = "0x44C92E0")] private set
      {
      }
    }

    [Token(Token = "0x170036C1")]
    public int MaxLevel
    {
      [Token(Token = "0x600FAFA"), Address(RVA = "0x44C92E8", Offset = "0x44C92E8", VA = "0x44C92E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAFB"), Address(RVA = "0x44C92F0", Offset = "0x44C92F0", VA = "0x44C92F0")] private set
      {
      }
    }

    [Token(Token = "0x170036C2")]
    public int LPMax
    {
      [Token(Token = "0x600FAFC"), Address(RVA = "0x44C92F8", Offset = "0x44C92F8", VA = "0x44C92F8")] get
      {
        return new int();
      }
      [Token(Token = "0x600FAFD"), Address(RVA = "0x44C9300", Offset = "0x44C9300", VA = "0x44C9300")] private set
      {
      }
    }

    [Token(Token = "0x170036C3")]
    public bool IsWeaponViewSwitchable
    {
      [Token(Token = "0x600FAFE"), Address(RVA = "0x44C9308", Offset = "0x44C9308", VA = "0x44C9308")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FAFF"), Address(RVA = "0x44C9310", Offset = "0x44C9310", VA = "0x44C9310")] private set
      {
      }
    }

    [Token(Token = "0x600FB00")]
    [Address(RVA = "0x44C931C", Offset = "0x44C931C", VA = "0x44C931C")]
    public static UnitData Create(UnitSource source) => (UnitData) null;

    [Token(Token = "0x170036C4")]
    public UnitData.GetPositionFromGridDataDelegate GetPositionFromGrid
    {
      [Token(Token = "0x600FB01"), Address(RVA = "0x44CA98C", Offset = "0x44CA98C", VA = "0x44CA98C")] get
      {
        return (UnitData.GetPositionFromGridDataDelegate) null;
      }
      [Token(Token = "0x600FB02"), Address(RVA = "0x44CA994", Offset = "0x44CA994", VA = "0x44CA994")] set
      {
      }
    }

    [Token(Token = "0x600FB03")]
    [Address(RVA = "0x44CA99C", Offset = "0x44CA99C", VA = "0x44CA99C")]
    public int GetCustomSkillIndexOf(SkillData skill) => new int();

    [Token(Token = "0x600FB04")]
    [Address(RVA = "0x44CA9F4", Offset = "0x44CA9F4", VA = "0x44CA9F4")]
    public IBasicParameter GetLvUpParam(int from, int to) => (IBasicParameter) null;

    [Token(Token = "0x600FB05")]
    [Address(RVA = "0x44CAAE8", Offset = "0x44CAAE8", VA = "0x44CAAE8", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600FB06")]
    [Address(RVA = "0x44CABA8", Offset = "0x44CABA8", VA = "0x44CABA8")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600FB07")]
    [Address(RVA = "0x44CA548", Offset = "0x44CA548", VA = "0x44CA548")]
    public UnitData()
    {
    }

    [Token(Token = "0x2002807")]
    public delegate Vector3 GetPositionFromGridDataDelegate(GridData gridData);
  }
}
