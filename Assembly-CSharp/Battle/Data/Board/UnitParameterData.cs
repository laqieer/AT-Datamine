// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.UnitParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Unit;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002812")]
  public class UnitParameterData : BattleBaseParameter, IReadableHPStockData, ITargettable
  {
    [Token(Token = "0x400AAAA")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<WeaponTypeEnum, int> achieveWeaponProficiencyDic;
    [Token(Token = "0x400AAB9")]
    [FieldOffset(Offset = "0xA0")]
    public int TotalDealtDamage;
    [Token(Token = "0x400AABA")]
    [FieldOffset(Offset = "0xA4")]
    public int HighestDealtDamage;
    [Token(Token = "0x400AABB")]
    [FieldOffset(Offset = "0xA8")]
    public int BreakBarrierCount;
    [Token(Token = "0x400AABC")]
    [FieldOffset(Offset = "0xB0")]
    public List<int> ArmorBreakUnitId;
    [Token(Token = "0x400AABD")]
    [FieldOffset(Offset = "0xB8")]
    public List<int> KillUnitId;
    [Token(Token = "0x400AABE")]
    [FieldOffset(Offset = "0xC0")]
    public int TurnNumberWhenDied;
    [Token(Token = "0x400AABF")]
    [FieldOffset(Offset = "0xC4")]
    public int DropItem;
    [Token(Token = "0x400AAC0")]
    [FieldOffset(Offset = "0xC8")]
    public int ExpGain;
    [Token(Token = "0x400AAC1")]
    [FieldOffset(Offset = "0xCC")]
    public int ExpPool;
    [Token(Token = "0x400AAC7")]
    [FieldOffset(Offset = "0xE8")]
    private UnitGridShapeData unitGridShape;
    [Token(Token = "0x400AAC9")]
    [FieldOffset(Offset = "0xF8")]
    private WeakReference<GridData> currentMainGrid;
    [Token(Token = "0x400AACA")]
    [FieldOffset(Offset = "0x100")]
    private List<WeakReference<GridData>> currentSubGrids;
    [Token(Token = "0x400AACB")]
    [FieldOffset(Offset = "0x108")]
    public UnitParameterData KilledUnit;
    [Token(Token = "0x400AAD0")]
    [FieldOffset(Offset = "0x130")]
    private WeakReference<UnitParameterData> frontUnitRef;
    [Token(Token = "0x400AAD1")]
    [FieldOffset(Offset = "0x138")]
    private WeakReference<UnitParameterData> backUnitRef;
    [Token(Token = "0x400AAD2")]
    [FieldOffset(Offset = "0x140")]
    private TargetState targetState;

    [Token(Token = "0x170036C5")]
    public UnitData Data
    {
      [Token(Token = "0x600FB32"), Address(RVA = "0x441B4E0", Offset = "0x441B4E0", VA = "0x441B4E0")] get
      {
        return (UnitData) null;
      }
      [Token(Token = "0x600FB33"), Address(RVA = "0x441B4E8", Offset = "0x441B4E8", VA = "0x441B4E8")] private set
      {
      }
    }

    [Token(Token = "0x170036C6")]
    public int Exp
    {
      [Token(Token = "0x600FB34"), Address(RVA = "0x441B4F0", Offset = "0x441B4F0", VA = "0x441B4F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB35"), Address(RVA = "0x441B4F8", Offset = "0x441B4F8", VA = "0x441B4F8")] set
      {
      }
    }

    [Token(Token = "0x170036C7")]
    public int LP
    {
      [Token(Token = "0x600FB36"), Address(RVA = "0x441B500", Offset = "0x441B500", VA = "0x441B500")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB37"), Address(RVA = "0x441B508", Offset = "0x441B508", VA = "0x441B508")] private set
      {
      }
    }

    [Token(Token = "0x170036C8")]
    public HPStockData HPStockData
    {
      [Token(Token = "0x600FB38"), Address(RVA = "0x441B510", Offset = "0x441B510", VA = "0x441B510")] get
      {
        return (HPStockData) null;
      }
      [Token(Token = "0x600FB39"), Address(RVA = "0x441B518", Offset = "0x441B518", VA = "0x441B518")] private set
      {
      }
    }

    [Token(Token = "0x170036C9")]
    public BarrierContainer Barrier
    {
      [Token(Token = "0x600FB3A"), Address(RVA = "0x441B520", Offset = "0x441B520", VA = "0x441B520")] get
      {
        return (BarrierContainer) null;
      }
      [Token(Token = "0x600FB3B"), Address(RVA = "0x441B528", Offset = "0x441B528", VA = "0x441B528")] private set
      {
      }
    }

    [Token(Token = "0x170036CA")]
    public List<WeaponParameterData> WeaponParams
    {
      [Token(Token = "0x600FB3C"), Address(RVA = "0x441B530", Offset = "0x441B530", VA = "0x441B530")] get
      {
        return (List<WeaponParameterData>) null;
      }
      [Token(Token = "0x600FB3D"), Address(RVA = "0x441B538", Offset = "0x441B538", VA = "0x441B538")] private set
      {
      }
    }

    [Token(Token = "0x170036CB")]
    public int CurrentWeaponIndex
    {
      [Token(Token = "0x600FB3E"), Address(RVA = "0x441B540", Offset = "0x441B540", VA = "0x441B540")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB3F"), Address(RVA = "0x441B548", Offset = "0x441B548", VA = "0x441B548")] private set
      {
      }
    }

    [Token(Token = "0x170036CC")]
    public WeaponParameterData CurrentWeaponParam
    {
      [Token(Token = "0x600FB40"), Address(RVA = "0x441B550", Offset = "0x441B550", VA = "0x441B550")] get
      {
        return (WeaponParameterData) null;
      }
    }

    [Token(Token = "0x170036CD")]
    public WeaponParameterData CurrentAppropriateWeaponParam
    {
      [Token(Token = "0x600FB41"), Address(RVA = "0x441B5D0", Offset = "0x441B5D0", VA = "0x441B5D0")] get
      {
        return (WeaponParameterData) null;
      }
    }

    [Token(Token = "0x170036CE")]
    public Dictionary<WeaponTypeEnum, int> AchieveWeaponProficiencyDic
    {
      [Token(Token = "0x600FB42"), Address(RVA = "0x441B63C", Offset = "0x441B63C", VA = "0x441B63C")] get
      {
        return (Dictionary<WeaponTypeEnum, int>) null;
      }
    }

    [Token(Token = "0x170036CF")]
    public int CurrentStockCounter
    {
      [Token(Token = "0x600FB43"), Address(RVA = "0x441B644", Offset = "0x441B644", VA = "0x441B644")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB44"), Address(RVA = "0x441B64C", Offset = "0x441B64C", VA = "0x441B64C")] private set
      {
      }
    }

    [Token(Token = "0x170036D0")]
    public List<SkillParameterData> SkillParams
    {
      [Token(Token = "0x600FB45"), Address(RVA = "0x441B654", Offset = "0x441B654", VA = "0x441B654")] get
      {
        return (List<SkillParameterData>) null;
      }
      [Token(Token = "0x600FB46"), Address(RVA = "0x441B65C", Offset = "0x441B65C", VA = "0x441B65C")] private set
      {
      }
    }

    [Token(Token = "0x170036D1")]
    public ActiveSkillChargingData SkillCharging
    {
      [Token(Token = "0x600FB47"), Address(RVA = "0x441B664", Offset = "0x441B664", VA = "0x441B664")] get
      {
        return (ActiveSkillChargingData) null;
      }
    }

    [Token(Token = "0x170036D2")]
    public bool IsCharging
    {
      [Token(Token = "0x600FB48"), Address(RVA = "0x441B66C", Offset = "0x441B66C", VA = "0x441B66C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170036D3")]
    public bool HadCharged
    {
      [Token(Token = "0x600FB49"), Address(RVA = "0x441B688", Offset = "0x441B688", VA = "0x441B688")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170036D4")]
    public Vector2Int Coordinate
    {
      [Token(Token = "0x600FB4A"), Address(RVA = "0x441B6A4", Offset = "0x441B6A4", VA = "0x441B6A4")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600FB4B"), Address(RVA = "0x441B6AC", Offset = "0x441B6AC", VA = "0x441B6AC")] private set
      {
      }
    }

    [Token(Token = "0x170036D5")]
    public int LeaderId
    {
      [Token(Token = "0x600FB4C"), Address(RVA = "0x441B6B4", Offset = "0x441B6B4", VA = "0x441B6B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB4D"), Address(RVA = "0x441B6BC", Offset = "0x441B6BC", VA = "0x441B6BC")] private set
      {
      }
    }

    [Token(Token = "0x170036D6")]
    public int DoubledAtId
    {
      [Token(Token = "0x600FB4E"), Address(RVA = "0x441B6C4", Offset = "0x441B6C4", VA = "0x441B6C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB4F"), Address(RVA = "0x441B6CC", Offset = "0x441B6CC", VA = "0x441B6CC")] private set
      {
      }
    }

    [Token(Token = "0x170036D7")]
    public SortieState SortieState
    {
      [Token(Token = "0x600FB50"), Address(RVA = "0x441B6D4", Offset = "0x441B6D4", VA = "0x441B6D4")] get
      {
        return new SortieState();
      }
      [Token(Token = "0x600FB51"), Address(RVA = "0x441B6DC", Offset = "0x441B6DC", VA = "0x441B6DC")] private set
      {
      }
    }

    [Token(Token = "0x170036D8")]
    public int WaitTurnCountFromSortied
    {
      [Token(Token = "0x600FB52"), Address(RVA = "0x441B6E4", Offset = "0x441B6E4", VA = "0x441B6E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB53"), Address(RVA = "0x441B6EC", Offset = "0x441B6EC", VA = "0x441B6EC")] set
      {
      }
    }

    [Token(Token = "0x170036D9")]
    public int PassedWaitTurnCountFromSortied
    {
      [Token(Token = "0x600FB54"), Address(RVA = "0x441B6F4", Offset = "0x441B6F4", VA = "0x441B6F4")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB55"), Address(RVA = "0x441B6FC", Offset = "0x441B6FC", VA = "0x441B6FC")] private set
      {
      }
    }

    [Token(Token = "0x170036DA")]
    public UnitActionState ActionState
    {
      [Token(Token = "0x600FB56"), Address(RVA = "0x441B704", Offset = "0x441B704", VA = "0x441B704")] get
      {
        return new UnitActionState();
      }
      [Token(Token = "0x600FB57"), Address(RVA = "0x441B70C", Offset = "0x441B70C", VA = "0x441B70C")] private set
      {
      }
    }

    [Token(Token = "0x170036DB")]
    public int CurrentMovePoint
    {
      [Token(Token = "0x600FB58"), Address(RVA = "0x441B714", Offset = "0x441B714", VA = "0x441B714")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB59"), Address(RVA = "0x441B71C", Offset = "0x441B71C", VA = "0x441B71C")] set
      {
      }
    }

    [Token(Token = "0x170036DC")]
    public int TotalMoveDistanceDuringATurn
    {
      [Token(Token = "0x600FB5A"), Address(RVA = "0x441B724", Offset = "0x441B724", VA = "0x441B724")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB5B"), Address(RVA = "0x441B72C", Offset = "0x441B72C", VA = "0x441B72C")] set
      {
      }
    }

    [Token(Token = "0x170036DD")]
    public int PrevAttackToUnitId
    {
      [Token(Token = "0x600FB5C"), Address(RVA = "0x441B734", Offset = "0x441B734", VA = "0x441B734")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB5D"), Address(RVA = "0x441B73C", Offset = "0x441B73C", VA = "0x441B73C")] set
      {
      }
    }

    [Token(Token = "0x170036DE")]
    public int BeAttackedUnitId
    {
      [Token(Token = "0x600FB5E"), Address(RVA = "0x441B744", Offset = "0x441B744", VA = "0x441B744")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB5F"), Address(RVA = "0x441B74C", Offset = "0x441B74C", VA = "0x441B74C")] set
      {
      }
    }

    [Token(Token = "0x170036DF")]
    public bool IsImmortal
    {
      [Token(Token = "0x600FB60"), Address(RVA = "0x441B754", Offset = "0x441B754", VA = "0x441B754")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FB61"), Address(RVA = "0x441B75C", Offset = "0x441B75C", VA = "0x441B75C")] set
      {
      }
    }

    [Token(Token = "0x170036E0")]
    public bool IsWeaponCare
    {
      [Token(Token = "0x600FB62"), Address(RVA = "0x441B768", Offset = "0x441B768", VA = "0x441B768")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FB63"), Address(RVA = "0x441B770", Offset = "0x441B770", VA = "0x441B770")] set
      {
      }
    }

    [Token(Token = "0x170036E1")]
    public int Id
    {
      [Token(Token = "0x600FB64"), Address(RVA = "0x441B77C", Offset = "0x441B77C", VA = "0x441B77C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036E2")]
    public string UniqueId
    {
      [Token(Token = "0x600FB65"), Address(RVA = "0x441B798", Offset = "0x441B798", VA = "0x441B798")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170036E3")]
    public int OwnerId
    {
      [Token(Token = "0x600FB66"), Address(RVA = "0x441B7B4", Offset = "0x441B7B4", VA = "0x441B7B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB67"), Address(RVA = "0x441B7BC", Offset = "0x441B7BC", VA = "0x441B7BC")] private set
      {
      }
    }

    [Token(Token = "0x170036E4")]
    public AITypeData AIType
    {
      [Token(Token = "0x600FB68"), Address(RVA = "0x441B7C4", Offset = "0x441B7C4", VA = "0x441B7C4")] get
      {
        return (AITypeData) null;
      }
    }

    [Token(Token = "0x170036E5")]
    public AIParameterData AIParam
    {
      [Token(Token = "0x600FB69"), Address(RVA = "0x441B7E0", Offset = "0x441B7E0", VA = "0x441B7E0")] get
      {
        return (AIParameterData) null;
      }
      [Token(Token = "0x600FB6A"), Address(RVA = "0x441B7E8", Offset = "0x441B7E8", VA = "0x441B7E8")] private set
      {
      }
    }

    [Token(Token = "0x170036E6")]
    public ForceTypeEnum Force
    {
      [Token(Token = "0x600FB6B"), Address(RVA = "0x441B7F0", Offset = "0x441B7F0", VA = "0x441B7F0")] get
      {
        return new ForceTypeEnum();
      }
    }

    [Token(Token = "0x170036E7")]
    public CharacterData Chara
    {
      [Token(Token = "0x600FB6C"), Address(RVA = "0x441B80C", Offset = "0x441B80C", VA = "0x441B80C")] get
      {
        return (CharacterData) null;
      }
    }

    [Token(Token = "0x170036E8")]
    public StyleData Style
    {
      [Token(Token = "0x600FB6D"), Address(RVA = "0x441B828", Offset = "0x441B828", VA = "0x441B828")] get
      {
        return (StyleData) null;
      }
    }

    [Token(Token = "0x170036E9")]
    public StockCounterData StockCounter
    {
      [Token(Token = "0x600FB6E"), Address(RVA = "0x441B844", Offset = "0x441B844", VA = "0x441B844")] get
      {
        return (StockCounterData) null;
      }
    }

    [Token(Token = "0x170036EA")]
    public string Name
    {
      [Token(Token = "0x600FB6F"), Address(RVA = "0x441B860", Offset = "0x441B860", VA = "0x441B860")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170036EB")]
    public ClassData Class
    {
      [Token(Token = "0x600FB70"), Address(RVA = "0x441B8AC", Offset = "0x441B8AC", VA = "0x441B8AC")] get
      {
        return (ClassData) null;
      }
    }

    [Token(Token = "0x170036EC")]
    public ArmyData Army
    {
      [Token(Token = "0x600FB71"), Address(RVA = "0x441B8C8", Offset = "0x441B8C8", VA = "0x441B8C8")] get
      {
        return (ArmyData) null;
      }
    }

    [Token(Token = "0x170036ED")]
    public MoveData MoveData
    {
      [Token(Token = "0x600FB72"), Address(RVA = "0x441B8E4", Offset = "0x441B8E4", VA = "0x441B8E4")] get
      {
        return (MoveData) null;
      }
    }

    [Token(Token = "0x170036EE")]
    public ElementTypeEnum ElementType
    {
      [Token(Token = "0x600FB73"), Address(RVA = "0x441B900", Offset = "0x441B900", VA = "0x441B900")] get
      {
        return new ElementTypeEnum();
      }
    }

    [Token(Token = "0x170036EF")]
    public ArmorTypeEnum Armor
    {
      [Token(Token = "0x600FB74"), Address(RVA = "0x441B91C", Offset = "0x441B91C", VA = "0x441B91C")] get
      {
        return new ArmorTypeEnum();
      }
    }

    [Token(Token = "0x170036F0")]
    public RideTypeEnum Ride
    {
      [Token(Token = "0x600FB75"), Address(RVA = "0x441B938", Offset = "0x441B938", VA = "0x441B938")] get
      {
        return new RideTypeEnum();
      }
    }

    [Token(Token = "0x170036F1")]
    public int GroupId
    {
      [Token(Token = "0x600FB76"), Address(RVA = "0x441B954", Offset = "0x441B954", VA = "0x441B954")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036F2")]
    public StyleGroupTypeData[] Groups
    {
      [Token(Token = "0x600FB77"), Address(RVA = "0x441B970", Offset = "0x441B970", VA = "0x441B970")] get
      {
        return (StyleGroupTypeData[]) null;
      }
    }

    [Token(Token = "0x170036F3")]
    public SpeciesDescriptionData[] Species
    {
      [Token(Token = "0x600FB78"), Address(RVA = "0x441B98C", Offset = "0x441B98C", VA = "0x441B98C")] get
      {
        return (SpeciesDescriptionData[]) null;
      }
    }

    [Token(Token = "0x170036F4")]
    public int Rarity
    {
      [Token(Token = "0x600FB79"), Address(RVA = "0x441B9A8", Offset = "0x441B9A8", VA = "0x441B9A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036F5")]
    public RarityStyleData RarityData
    {
      [Token(Token = "0x600FB7A"), Address(RVA = "0x441B9C4", Offset = "0x441B9C4", VA = "0x441B9C4")] get
      {
        return (RarityStyleData) null;
      }
    }

    [Token(Token = "0x170036F6")]
    public int ReinCarnationCount
    {
      [Token(Token = "0x600FB7B"), Address(RVA = "0x441B9E0", Offset = "0x441B9E0", VA = "0x441B9E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036F7")]
    public int Level
    {
      [Token(Token = "0x600FB7C"), Address(RVA = "0x441B9FC", Offset = "0x441B9FC", VA = "0x441B9FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600FB7D"), Address(RVA = "0x441BA04", Offset = "0x441BA04", VA = "0x441BA04")] private set
      {
      }
    }

    [Token(Token = "0x170036F8")]
    public int MaxLevel
    {
      [Token(Token = "0x600FB7E"), Address(RVA = "0x441BA0C", Offset = "0x441BA0C", VA = "0x441BA0C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036F9")]
    public int LimitBreak
    {
      [Token(Token = "0x600FB7F"), Address(RVA = "0x441BA28", Offset = "0x441BA28", VA = "0x441BA28")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036FA")]
    public int MaxLimitBreak
    {
      [Token(Token = "0x600FB80"), Address(RVA = "0x441BA44", Offset = "0x441BA44", VA = "0x441BA44")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036FB")]
    public int MaxStockCounter
    {
      [Token(Token = "0x600FB81"), Address(RVA = "0x441BA60", Offset = "0x441BA60", VA = "0x441BA60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036FC")]
    public bool IsLosted
    {
      [Token(Token = "0x600FB82"), Address(RVA = "0x441BA8C", Offset = "0x441BA8C", VA = "0x441BA8C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170036FD")]
    public int LPMax
    {
      [Token(Token = "0x600FB83"), Address(RVA = "0x441BA9C", Offset = "0x441BA9C", VA = "0x441BA9C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170036FE")]
    public IBattleParameter StyleMasterBonus
    {
      [Token(Token = "0x600FB84"), Address(RVA = "0x441BAB8", Offset = "0x441BAB8", VA = "0x441BAB8")] get
      {
        return (IBattleParameter) null;
      }
    }

    [Token(Token = "0x170036FF")]
    public IBattleParameter BaseRatedBuff
    {
      [Token(Token = "0x600FB85"), Address(RVA = "0x441BAD4", Offset = "0x441BAD4", VA = "0x441BAD4")] get
      {
        return (IBattleParameter) null;
      }
    }

    [Token(Token = "0x17003700")]
    public bool IsCalculatedFromParam
    {
      [Token(Token = "0x600FB86"), Address(RVA = "0x441BAF0", Offset = "0x441BAF0", VA = "0x441BAF0", Slot = "13")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003701")]
    public HP[] HPList
    {
      [Token(Token = "0x600FB87"), Address(RVA = "0x441BB0C", Offset = "0x441BB0C", VA = "0x441BB0C", Slot = "14")] get
      {
        return (HP[]) null;
      }
    }

    [Token(Token = "0x17003702")]
    public HP HP
    {
      [Token(Token = "0x600FB88"), Address(RVA = "0x441BB28", Offset = "0x441BB28", VA = "0x441BB28", Slot = "15")] get
      {
        return (HP) null;
      }
    }

    [Token(Token = "0x17003703")]
    public int CurrentHPStockIndex
    {
      [Token(Token = "0x600FB89"), Address(RVA = "0x441BB44", Offset = "0x441BB44", VA = "0x441BB44", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003704")]
    public int RemainingStock
    {
      [Token(Token = "0x600FB8A"), Address(RVA = "0x441BB60", Offset = "0x441BB60", VA = "0x441BB60", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003705")]
    public Decimal CurrentHPPercentage
    {
      [Token(Token = "0x600FB8B"), Address(RVA = "0x441BB7C", Offset = "0x441BB7C", VA = "0x441BB7C", Slot = "18")] get
      {
        return 0M;
      }
    }

    [Token(Token = "0x17003706")]
    public int CurrentHPPercentageInt
    {
      [Token(Token = "0x600FB8C"), Address(RVA = "0x441BB98", Offset = "0x441BB98", VA = "0x441BB98", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003707")]
    public float CurrentHPRatio
    {
      [Token(Token = "0x600FB8D"), Address(RVA = "0x441BBB4", Offset = "0x441BBB4", VA = "0x441BBB4", Slot = "20")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17003708")]
    public int BaseHP
    {
      [Token(Token = "0x600FB8E"), Address(RVA = "0x441BBD0", Offset = "0x441BBD0", VA = "0x441BBD0", Slot = "21")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003709")]
    public int MaxHP
    {
      [Token(Token = "0x600FB8F"), Address(RVA = "0x441BBEC", Offset = "0x441BBEC", VA = "0x441BBEC", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700370A")]
    public int CurrentHP
    {
      [Token(Token = "0x600FB90"), Address(RVA = "0x441BC08", Offset = "0x441BC08", VA = "0x441BC08", Slot = "23")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700370B")]
    public bool IsAlive
    {
      [Token(Token = "0x600FB91"), Address(RVA = "0x441BC24", Offset = "0x441BC24", VA = "0x441BC24", Slot = "24")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700370C")]
    public IReadableUnitGridShapeData UnitGridShape
    {
      [Token(Token = "0x600FB92"), Address(RVA = "0x441BC40", Offset = "0x441BC40", VA = "0x441BC40")] get
      {
        return (IReadableUnitGridShapeData) null;
      }
    }

    [Token(Token = "0x1700370D")]
    public int GridShapeSize
    {
      [Token(Token = "0x600FB93"), Address(RVA = "0x441BC48", Offset = "0x441BC48", VA = "0x441BC48")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700370E")]
    public bool IsLargeUnit
    {
      [Token(Token = "0x600FB94"), Address(RVA = "0x441BCEC", Offset = "0x441BCEC", VA = "0x441BCEC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700370F")]
    public UnitGridShapeTypeEnum GridShape
    {
      [Token(Token = "0x600FB95"), Address(RVA = "0x441BD10", Offset = "0x441BD10", VA = "0x441BD10")] get
      {
        return new UnitGridShapeTypeEnum();
      }
    }

    [Token(Token = "0x17003710")]
    public int MoveAmount
    {
      [Token(Token = "0x600FB96"), Address(RVA = "0x441BDB4", Offset = "0x441BDB4", VA = "0x441BDB4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003711")]
    public PassBlockType PassBlockType
    {
      [Token(Token = "0x600FB97"), Address(RVA = "0x441BDD0", Offset = "0x441BDD0", VA = "0x441BDD0")] get
      {
        return new PassBlockType();
      }
      [Token(Token = "0x600FB98"), Address(RVA = "0x441BDD8", Offset = "0x441BDD8", VA = "0x441BDD8")] private set
      {
      }
    }

    [Token(Token = "0x17003712")]
    public GridData CurrentMainGrid
    {
      [Token(Token = "0x600FB99"), Address(RVA = "0x441BDE0", Offset = "0x441BDE0", VA = "0x441BDE0")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600FB9A"), Address(RVA = "0x441BE44", Offset = "0x441BE44", VA = "0x441BE44")] set
      {
      }
    }

    [Token(Token = "0x17003713")]
    public bool IsPlacedGridMain
    {
      [Token(Token = "0x600FB9B"), Address(RVA = "0x441C058", Offset = "0x441C058", VA = "0x441C058")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003714")]
    public List<GridData> CurrentSubGrids
    {
      [Token(Token = "0x600FB9C"), Address(RVA = "0x441C070", Offset = "0x441C070", VA = "0x441C070")] get
      {
        return (List<GridData>) null;
      }
    }

    [Token(Token = "0x17003715")]
    public List<Vector2Int> Coordinates
    {
      [Token(Token = "0x600FB9D"), Address(RVA = "0x441C2A8", Offset = "0x441C2A8", VA = "0x441C2A8", Slot = "26")] get
      {
        return (List<Vector2Int>) null;
      }
    }

    [Token(Token = "0x17003716")]
    public List<AccessoryData> Accessories
    {
      [Token(Token = "0x600FB9E"), Address(RVA = "0x441C520", Offset = "0x441C520", VA = "0x441C520")] get
      {
        return (List<AccessoryData>) null;
      }
    }

    [Token(Token = "0x17003717")]
    public List<MindEquipmentData> MindEquipments
    {
      [Token(Token = "0x600FB9F"), Address(RVA = "0x441C53C", Offset = "0x441C53C", VA = "0x441C53C")] get
      {
        return (List<MindEquipmentData>) null;
      }
    }

    [Token(Token = "0x17003718")]
    public List<TrustData> Trusts
    {
      [Token(Token = "0x600FBA0"), Address(RVA = "0x441C558", Offset = "0x441C558", VA = "0x441C558")] get
      {
        return (List<TrustData>) null;
      }
    }

    [Token(Token = "0x17003719")]
    public List<SkillParameterData> ActiveSkillParams
    {
      [Token(Token = "0x600FBA1"), Address(RVA = "0x441C574", Offset = "0x441C574", VA = "0x441C574")] get
      {
        return (List<SkillParameterData>) null;
      }
      [Token(Token = "0x600FBA2"), Address(RVA = "0x441C57C", Offset = "0x441C57C", VA = "0x441C57C")] private set
      {
      }
    }

    [Token(Token = "0x1700371A")]
    public List<SkillParameterData> PassiveSkillParams
    {
      [Token(Token = "0x600FBA3"), Address(RVA = "0x441C584", Offset = "0x441C584", VA = "0x441C584")] get
      {
        return (List<SkillParameterData>) null;
      }
      [Token(Token = "0x600FBA4"), Address(RVA = "0x441C58C", Offset = "0x441C58C", VA = "0x441C58C")] private set
      {
      }
    }

    [Token(Token = "0x1700371B")]
    public List<SkillParameterData> TriggerSkillParams
    {
      [Token(Token = "0x600FBA5"), Address(RVA = "0x441C594", Offset = "0x441C594", VA = "0x441C594")] get
      {
        return (List<SkillParameterData>) null;
      }
      [Token(Token = "0x600FBA6"), Address(RVA = "0x441C59C", Offset = "0x441C59C", VA = "0x441C59C")] private set
      {
      }
    }

    [Token(Token = "0x1700371C")]
    public bool HasStratagemSkill
    {
      [Token(Token = "0x600FBA7"), Address(RVA = "0x441C5A4", Offset = "0x441C5A4", VA = "0x441C5A4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700371D")]
    public bool HasFierceSkill
    {
      [Token(Token = "0x600FBA8"), Address(RVA = "0x441C71C", Offset = "0x441C71C", VA = "0x441C71C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600FBA9")]
    [Address(RVA = "0x441C890", Offset = "0x441C890", VA = "0x441C890")]
    public List<SkillParameterData> GetCanUseActiveSkillParams() => (List<SkillParameterData>) null;

    [Token(Token = "0x600FBAA")]
    [Address(RVA = "0x441BF10", Offset = "0x441BF10", VA = "0x441BF10")]
    private void UpdateLandEffect()
    {
    }

    [Token(Token = "0x600FBAB")]
    [Address(RVA = "0x441CC4C", Offset = "0x441CC4C", VA = "0x441CC4C")]
    public List<SkillParameterData> GetCanUseActiveSkillParams(WeaponParameterData weaponParam)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x1700371E")]
    public UnitEffectContainer EffectedSkillEffects
    {
      [Token(Token = "0x600FBAC"), Address(RVA = "0x441CF28", Offset = "0x441CF28", VA = "0x441CF28")] get
      {
        return (UnitEffectContainer) null;
      }
      [Token(Token = "0x600FBAD"), Address(RVA = "0x441CF30", Offset = "0x441CF30", VA = "0x441CF30")] private set
      {
      }
    }

    [Token(Token = "0x1700371F")]
    public bool BadStatusDisableControl
    {
      [Token(Token = "0x600FBAE"), Address(RVA = "0x441CF38", Offset = "0x441CF38", VA = "0x441CF38")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003720")]
    public bool BadStatusDisableAction
    {
      [Token(Token = "0x600FBAF"), Address(RVA = "0x441CFE8", Offset = "0x441CFE8", VA = "0x441CFE8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003721")]
    public bool BadStatusDisableMove
    {
      [Token(Token = "0x600FBB0"), Address(RVA = "0x441D09C", Offset = "0x441D09C", VA = "0x441D09C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003722")]
    public bool BadStatusDisableSecondAttack
    {
      [Token(Token = "0x600FBB1"), Address(RVA = "0x441D150", Offset = "0x441D150", VA = "0x441D150")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003723")]
    public bool BadStatusDisableHit
    {
      [Token(Token = "0x600FBB2"), Address(RVA = "0x441D204", Offset = "0x441D204", VA = "0x441D204")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003724")]
    public bool BadStatusDisableAvoid
    {
      [Token(Token = "0x600FBB3"), Address(RVA = "0x441D2B8", Offset = "0x441D2B8", VA = "0x441D2B8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003725")]
    public bool BadStatusDisableBattle
    {
      [Token(Token = "0x600FBB4"), Address(RVA = "0x441D36C", Offset = "0x441D36C", VA = "0x441D36C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003726")]
    public List<BattleBadStatusDetailData> NullBadStatusDetailList
    {
      [Token(Token = "0x600FBB5"), Address(RVA = "0x441D420", Offset = "0x441D420", VA = "0x441D420")] get
      {
        return (List<BattleBadStatusDetailData>) null;
      }
    }

    [Token(Token = "0x17003727")]
    public UnitParameterData FrontUnit
    {
      [Token(Token = "0x600FBB6"), Address(RVA = "0x441D440", Offset = "0x441D440", VA = "0x441D440")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x17003728")]
    public UnitParameterData BackUnit
    {
      [Token(Token = "0x600FBB7"), Address(RVA = "0x441D4A4", Offset = "0x441D4A4", VA = "0x441D4A4")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x17003729")]
    public bool IsFront
    {
      [Token(Token = "0x600FBB8"), Address(RVA = "0x441D508", Offset = "0x441D508", VA = "0x441D508")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700372A")]
    public bool IsBack
    {
      [Token(Token = "0x600FBB9"), Address(RVA = "0x441D530", Offset = "0x441D530", VA = "0x441D530")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700372B")]
    public bool IsSingle
    {
      [Token(Token = "0x600FBBA"), Address(RVA = "0x441D558", Offset = "0x441D558", VA = "0x441D558")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700372C")]
    public bool HasBack
    {
      [Token(Token = "0x600FBBB"), Address(RVA = "0x441D594", Offset = "0x441D594", VA = "0x441D594")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700372D")]
    public UnitParameterData Partner
    {
      [Token(Token = "0x600FBBC"), Address(RVA = "0x441D5A4", Offset = "0x441D5A4", VA = "0x441D5A4")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x1700372E")]
    public int BaseExp
    {
      [Token(Token = "0x600FBBD"), Address(RVA = "0x441D5EC", Offset = "0x441D5EC", VA = "0x441D5EC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700372F")]
    public int InitialDamage
    {
      [Token(Token = "0x600FBBE"), Address(RVA = "0x441D608", Offset = "0x441D608", VA = "0x441D608")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600FBBF")]
    [Address(RVA = "0x441D624", Offset = "0x441D624", VA = "0x441D624")]
    public void InitHP(BoardData board)
    {
    }

    [Token(Token = "0x17003730")]
    public TargetState TargetState
    {
      [Token(Token = "0x600FBC0"), Address(RVA = "0x441DB08", Offset = "0x441DB08", VA = "0x441DB08")] get
      {
        return new TargetState();
      }
      [Token(Token = "0x600FBC1"), Address(RVA = "0x441DB10", Offset = "0x441DB10", VA = "0x441DB10")] set
      {
      }
    }

    [Token(Token = "0x17003731")]
    public bool IsForceWaiting
    {
      [Token(Token = "0x600FBC2"), Address(RVA = "0x441DB3C", Offset = "0x441DB3C", VA = "0x441DB3C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003732")]
    public bool IsNpc
    {
      [Token(Token = "0x600FBC3"), Address(RVA = "0x441DB4C", Offset = "0x441DB4C", VA = "0x441DB4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003733")]
    public bool HideWeapon
    {
      [Token(Token = "0x600FBC4"), Address(RVA = "0x441DB6C", Offset = "0x441DB6C", VA = "0x441DB6C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FBC5"), Address(RVA = "0x441DB74", Offset = "0x441DB74", VA = "0x441DB74")] set
      {
      }
    }

    [Token(Token = "0x17003734")]
    public bool HasBuff
    {
      [Token(Token = "0x600FBC6"), Address(RVA = "0x441DB80", Offset = "0x441DB80", VA = "0x441DB80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003735")]
    public int TroopsNo
    {
      [Token(Token = "0x600FBC7"), Address(RVA = "0x441DD00", Offset = "0x441DD00", VA = "0x441DD00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003736")]
    public bool IsWeaponViewSwitchable
    {
      [Token(Token = "0x600FBC8"), Address(RVA = "0x441DD1C", Offset = "0x441DD1C", VA = "0x441DD1C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600FBC9")]
    [Address(RVA = "0x441DD38", Offset = "0x441DD38", VA = "0x441DD38")]
    public bool IsSameOwner(UnitParameterData unitParam) => new bool();

    [Token(Token = "0x600FBCA")]
    [Address(RVA = "0x441DD5C", Offset = "0x441DD5C", VA = "0x441DD5C")]
    public UnitParameterData()
    {
    }

    [Token(Token = "0x600FBCB")]
    [Address(RVA = "0x441E04C", Offset = "0x441E04C", VA = "0x441E04C")]
    public UnitParameterData Copy() => (UnitParameterData) null;

    [Token(Token = "0x600FBCC")]
    [Address(RVA = "0x441F51C", Offset = "0x441F51C", VA = "0x441F51C")]
    public static UnitParameterData Create(UnitParameterSource source) => (UnitParameterData) null;

    [Token(Token = "0x600FBCD")]
    [Address(RVA = "0x441FF04", Offset = "0x441FF04", VA = "0x441FF04")]
    public static UnitParameterData Create(
      IBasicParameter basicParameter,
      int minDamage,
      int maxDamage)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FBCE")]
    [Address(RVA = "0x44200DC", Offset = "0x44200DC", VA = "0x44200DC")]
    public void UpdateBasicParameterByExp()
    {
    }

    [Token(Token = "0x600FBCF")]
    [Address(RVA = "0x4420244", Offset = "0x4420244", VA = "0x4420244")]
    public void ConsumeLP(int val)
    {
    }

    [Token(Token = "0x600FBD0")]
    [Address(RVA = "0x44202B8", Offset = "0x44202B8", VA = "0x44202B8")]
    public void ResetHP()
    {
    }

    [Token(Token = "0x600FBD1")]
    [Address(RVA = "0x44202D4", Offset = "0x44202D4", VA = "0x44202D4", Slot = "25")]
    public void SwitchNextHP()
    {
    }

    [Token(Token = "0x600FBD2")]
    [Address(RVA = "0x44202F0", Offset = "0x44202F0", VA = "0x44202F0")]
    public WeaponParameterData SwitchToNextWeapon() => (WeaponParameterData) null;

    [Token(Token = "0x600FBD3")]
    [Address(RVA = "0x441FFF0", Offset = "0x441FFF0", VA = "0x441FFF0")]
    public WeaponParameterData EquipWeaponAt(int index) => (WeaponParameterData) null;

    [Token(Token = "0x600FBD4")]
    [Address(RVA = "0x4420370", Offset = "0x4420370", VA = "0x4420370")]
    public void RemoveWeaponSkill(WeaponParameterData weaponParam)
    {
    }

    [Token(Token = "0x600FBD5")]
    [Address(RVA = "0x44207E8", Offset = "0x44207E8", VA = "0x44207E8")]
    public void AddWeaponSkill(WeaponParameterData weaponParam)
    {
    }

    [Token(Token = "0x600FBD6")]
    [Address(RVA = "0x441FF88", Offset = "0x441FF88", VA = "0x441FF88")]
    private UnitGridShapeData CreateShapeData(int gridSize) => (UnitGridShapeData) null;

    [Token(Token = "0x600FBD7")]
    [Address(RVA = "0x4420A6C", Offset = "0x4420A6C", VA = "0x4420A6C")]
    public bool IsEffected(
      SkillParameterData skill,
      EffectData effect,
      out EffectParameterData outParam)
    {
      return new bool();
    }

    [Token(Token = "0x600FBD8")]
    [Address(RVA = "0x4420C6C", Offset = "0x4420C6C", VA = "0x4420C6C")]
    public int GetReinforceRate(AttackTypeEnum type) => new int();

    [Token(Token = "0x600FBD9")]
    [Address(RVA = "0x4420CA4", Offset = "0x4420CA4", VA = "0x4420CA4")]
    public int GetReinforceRate(ElementTypeEnum type) => new int();

    [Token(Token = "0x600FBDA")]
    [Address(RVA = "0x4420CDC", Offset = "0x4420CDC", VA = "0x4420CDC")]
    public int GetResistRate(AttackTypeEnum type) => new int();

    [Token(Token = "0x600FBDB")]
    [Address(RVA = "0x4420D14", Offset = "0x4420D14", VA = "0x4420D14")]
    public int GetResistRate(ElementTypeEnum type) => new int();

    [Token(Token = "0x600FBDC")]
    [Address(RVA = "0x4420D4C", Offset = "0x4420D4C", VA = "0x4420D4C")]
    public List<EffectParameterData> GetEffectParam(SkillParameterData skill)
    {
      return (List<EffectParameterData>) null;
    }

    [Token(Token = "0x600FBDD")]
    [Address(RVA = "0x4421054", Offset = "0x4421054", VA = "0x4421054")]
    public void ResetActivatedPassiveSkills()
    {
    }

    [Token(Token = "0x600FBDE")]
    [Address(RVA = "0x44211A0", Offset = "0x44211A0", VA = "0x44211A0")]
    public void RemoveEffectsByUnit(List<EffectParameterData> effects)
    {
    }

    [Token(Token = "0x600FBDF")]
    [Address(RVA = "0x4421248", Offset = "0x4421248", VA = "0x4421248")]
    public List<EffectParameterData> RemoveExpiredSkillEffects()
    {
      return (List<EffectParameterData>) null;
    }

    [Token(Token = "0x17003737")]
    public EffectData PrimaryViewPositiveEffect
    {
      [Token(Token = "0x600FBE0"), Address(RVA = "0x4421264", Offset = "0x4421264", VA = "0x4421264")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x17003738")]
    public EffectData PrimaryViewNegativeEffect
    {
      [Token(Token = "0x600FBE1"), Address(RVA = "0x442126C", Offset = "0x442126C", VA = "0x442126C")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x17003739")]
    public List<BattleBadStatusData> IconOrderedBadStatuses
    {
      [Token(Token = "0x600FBE2"), Address(RVA = "0x4421274", Offset = "0x4421274", VA = "0x4421274")] get
      {
        return (List<BattleBadStatusData>) null;
      }
    }

    [Token(Token = "0x1700373A")]
    public List<BattleBadStatusData> EffectOrderedBadStatuses
    {
      [Token(Token = "0x600FBE3"), Address(RVA = "0x4421298", Offset = "0x4421298", VA = "0x4421298")] get
      {
        return (List<BattleBadStatusData>) null;
      }
    }

    [Token(Token = "0x1700373B")]
    public BattleBadStatusData MostDisplayPriorityBadStatus
    {
      [Token(Token = "0x600FBE4"), Address(RVA = "0x44212BC", Offset = "0x44212BC", VA = "0x44212BC")] get
      {
        return (BattleBadStatusData) null;
      }
    }

    [Token(Token = "0x600FBE5")]
    [Address(RVA = "0x44200A4", Offset = "0x44200A4", VA = "0x44200A4")]
    public void AddEffects(List<EffectParameterData> effects)
    {
    }

    [Token(Token = "0x600FBE6")]
    [Address(RVA = "0x4421340", Offset = "0x4421340", VA = "0x4421340")]
    public Dictionary<int, int> GetModifierEffectValue(EffectKey key)
    {
      return (Dictionary<int, int>) null;
    }

    [Token(Token = "0x600FBE7")]
    [Address(RVA = "0x442135C", Offset = "0x442135C", VA = "0x442135C")]
    public List<EffectParameterData> GetDeactivateTriggeredEffects(EffectiveLengthTypeEnum length)
    {
      return (List<EffectParameterData>) null;
    }

    [Token(Token = "0x600FBE8")]
    [Address(RVA = "0x4421378", Offset = "0x4421378", VA = "0x4421378")]
    public (bool, bool) CheckEffects() => ();

    [Token(Token = "0x600FBE9")]
    [Address(RVA = "0x442139C", Offset = "0x442139C", VA = "0x442139C")]
    public IDuelFlowControlEffect GetDuelFlowControl() => (IDuelFlowControlEffect) null;

    [Token(Token = "0x600FBEA")]
    [Address(RVA = "0x44213B8", Offset = "0x44213B8", VA = "0x44213B8")]
    public bool HasEffect(EffectKey key) => new bool();

    [Token(Token = "0x600FBEB")]
    [Address(RVA = "0x4421490", Offset = "0x4421490", VA = "0x4421490")]
    public bool HasEffect(EffectParameterData skillEffectParam) => new bool();

    [Token(Token = "0x600FBEC")]
    [Address(RVA = "0x442155C", Offset = "0x442155C", VA = "0x442155C")]
    public void RemoveAllSkillEffects()
    {
    }

    [Token(Token = "0x600FBED")]
    [Address(RVA = "0x4421578", Offset = "0x4421578", VA = "0x4421578")]
    public bool HasBadStatus(BattleBadStatusTypeEnum type) => new bool();

    [Token(Token = "0x1700373C")]
    public BattleBadStatusTypeEnum? ValidDontActionBadStatus
    {
      [Token(Token = "0x600FBEE"), Address(RVA = "0x442159C", Offset = "0x442159C", VA = "0x442159C")] get
      {
        return new BattleBadStatusTypeEnum?();
      }
    }

    [Token(Token = "0x1700373D")]
    public int ProvocationTargetId
    {
      [Token(Token = "0x600FBEF"), Address(RVA = "0x442161C", Offset = "0x442161C", VA = "0x442161C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600FBF0")]
    [Address(RVA = "0x441CBC4", Offset = "0x441CBC4", VA = "0x441CBC4")]
    public void ResetLandCorrect()
    {
    }

    [Token(Token = "0x600FBF1")]
    [Address(RVA = "0x4421624", Offset = "0x4421624", VA = "0x4421624")]
    public void AddLandCorrect(List<EffectParameterData> effects)
    {
    }

    [Token(Token = "0x600FBF2")]
    [Address(RVA = "0x44200C0", Offset = "0x44200C0", VA = "0x44200C0")]
    public void AddUseItemCorrect(List<EffectParameterData> effects)
    {
    }

    [Token(Token = "0x600FBF3")]
    [Address(RVA = "0x441CBE0", Offset = "0x441CBE0", VA = "0x441CBE0")]
    private void ApplyLandCorrect(GridData[] grids)
    {
    }

    [Token(Token = "0x600FBF4")]
    [Address(RVA = "0x4421640", Offset = "0x4421640", VA = "0x4421640")]
    private void ApplyLandCorrect(GridData grid)
    {
    }

    [Token(Token = "0x1700373E")]
    public UnitData.GetPositionFromGridDataDelegate GetPositionFromGrid
    {
      [Token(Token = "0x600FBF5"), Address(RVA = "0x4421868", Offset = "0x4421868", VA = "0x4421868")] get
      {
        return (UnitData.GetPositionFromGridDataDelegate) null;
      }
      [Token(Token = "0x600FBF6"), Address(RVA = "0x4421884", Offset = "0x4421884", VA = "0x4421884")] set
      {
      }
    }

    [Token(Token = "0x600FBF7")]
    [Address(RVA = "0x44218A0", Offset = "0x44218A0", VA = "0x44218A0")]
    public bool IsUnusableActiveSkillCategory(SkillCategoryTypeEnum type) => new bool();

    [Token(Token = "0x600FBF8")]
    [Address(RVA = "0x44218C4", Offset = "0x44218C4", VA = "0x44218C4")]
    public bool IsUnusableActiveSkillTag(SkillTagTypeEnum type) => new bool();

    [Token(Token = "0x600FBF9")]
    [Address(RVA = "0x44218E8", Offset = "0x44218E8", VA = "0x44218E8")]
    public bool IsNullBadStatus(BattleBadStatusDetailData detail) => new bool();

    [Token(Token = "0x600FBFA")]
    [Address(RVA = "0x4421944", Offset = "0x4421944", VA = "0x4421944")]
    public IEffectParameterContainer GetBadStatusEffects(BattleBadStatusTypeEnum badStatusType)
    {
      return (IEffectParameterContainer) null;
    }

    [Token(Token = "0x600FBFB")]
    [Address(RVA = "0x4421968", Offset = "0x4421968", VA = "0x4421968")]
    public IEffectValue GetBadStatusEffectValue(BattleBadStatusTypeEnum badStatusType)
    {
      return (IEffectValue) null;
    }

    [Token(Token = "0x600FBFC")]
    [Address(RVA = "0x442198C", Offset = "0x442198C", VA = "0x442198C")]
    public int GetEffectedEnhanceBadStatusValue(
      BattleBadStatusTypeEnum badStatusType,
      BattleEffectValueTypeEnum valueType)
    {
      return new int();
    }

    [Token(Token = "0x600FBFD")]
    [Address(RVA = "0x44219B0", Offset = "0x44219B0", VA = "0x44219B0")]
    public int GetEffectedResistBadStatusValue(
      BattleBadStatusTypeEnum badStatusType,
      BattleEffectValueTypeEnum valueType)
    {
      return new int();
    }

    [Token(Token = "0x1700373F")]
    public int EnableBarrierCount
    {
      [Token(Token = "0x600FBFE"), Address(RVA = "0x44219D4", Offset = "0x44219D4", VA = "0x44219D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600FBFF")]
    [Address(RVA = "0x44219F0", Offset = "0x44219F0", VA = "0x44219F0")]
    public List<SkillParameterData> SwitchPassiveSkill(
      SkillTriggerTimingTypeEnum trigger,
      ConditionParam conditionParam)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600FC00")]
    [Address(RVA = "0x4421C68", Offset = "0x4421C68", VA = "0x4421C68")]
    public void DeactivePassiveSkill(SkillTriggerTimingTypeEnum trigger)
    {
    }

    [Token(Token = "0x600FC01")]
    [Address(RVA = "0x4421DD4", Offset = "0x4421DD4", VA = "0x4421DD4")]
    public void ResetAction()
    {
    }

    [Token(Token = "0x600FC02")]
    [Address(RVA = "0x4421E38", Offset = "0x4421E38", VA = "0x4421E38")]
    public void EndAction()
    {
    }

    [Token(Token = "0x600FC03")]
    [Address(RVA = "0x4421E68", Offset = "0x4421E68", VA = "0x4421E68")]
    public void RecoverAction()
    {
    }

    [Token(Token = "0x600FC04")]
    [Address(RVA = "0x4421E98", Offset = "0x4421E98", VA = "0x4421E98")]
    public void EndMove()
    {
    }

    [Token(Token = "0x600FC05")]
    [Address(RVA = "0x4421EC8", Offset = "0x4421EC8", VA = "0x4421EC8")]
    public void RecoverMove()
    {
    }

    [Token(Token = "0x600FC06")]
    [Address(RVA = "0x4421EF8", Offset = "0x4421EF8", VA = "0x4421EF8")]
    public void MarkAsSortied(bool succeeded)
    {
    }

    [Token(Token = "0x600FC07")]
    [Address(RVA = "0x4421F68", Offset = "0x4421F68", VA = "0x4421F68")]
    public void CountUpWaitTurnCountFromSortied()
    {
    }

    [Token(Token = "0x600FC08")]
    [Address(RVA = "0x4421F8C", Offset = "0x4421F8C", VA = "0x4421F8C")]
    public void AddCurrentSubGrid(GridData grid)
    {
    }

    [Token(Token = "0x600FC09")]
    [Address(RVA = "0x4422084", Offset = "0x4422084", VA = "0x4422084")]
    public void ClearCurrentGrid()
    {
    }

    [Token(Token = "0x600FC0A")]
    [Address(RVA = "0x4422130", Offset = "0x4422130", VA = "0x4422130")]
    public void AssignPlayer(BattlePlayerData player)
    {
    }

    [Token(Token = "0x600FC0B")]
    [Address(RVA = "0x442214C", Offset = "0x442214C", VA = "0x442214C")]
    public void AssignDoubleBack(UnitParameterData backUnit)
    {
    }

    [Token(Token = "0x600FC0C")]
    [Address(RVA = "0x44221E8", Offset = "0x44221E8", VA = "0x44221E8")]
    public void AssignDoubleFront(UnitParameterData frontUnit)
    {
    }

    [Token(Token = "0x600FC0D")]
    [Address(RVA = "0x4422280", Offset = "0x4422280", VA = "0x4422280")]
    public UnitParameterData ReleaseDoubledUnit() => (UnitParameterData) null;

    [Token(Token = "0x600FC0E")]
    [Address(RVA = "0x442233C", Offset = "0x442233C", VA = "0x442233C")]
    public bool IsAssigneableDoubleUnitWith(UnitParameterData target) => new bool();

    [Token(Token = "0x600FC0F")]
    [Address(RVA = "0x44223E4", Offset = "0x44223E4", VA = "0x44223E4")]
    public void Apply(UnitParameterChange paramChange)
    {
    }

    [Token(Token = "0x600FC10")]
    [Address(RVA = "0x442297C", Offset = "0x442297C", VA = "0x442297C")]
    public List<SkillParameterData> GetActivePassiveSkills() => (List<SkillParameterData>) null;

    [Token(Token = "0x600FC11")]
    [Address(RVA = "0x441D748", Offset = "0x441D748", VA = "0x441D748")]
    public void UpdateBaseParameterOffsets(BoardData board)
    {
    }

    [Token(Token = "0x600FC12")]
    [Address(RVA = "0x4422B88", Offset = "0x4422B88", VA = "0x4422B88")]
    public void ClearStatusEffects()
    {
    }

    [Token(Token = "0x600FC13")]
    [Address(RVA = "0x4422BA4", Offset = "0x4422BA4", VA = "0x4422BA4")]
    public void RemoveUntilTakeDamageEffect()
    {
    }

    [Token(Token = "0x17003740")]
    public EquipmentClassificationData WeaponClassification
    {
      [Token(Token = "0x600FC14"), Address(RVA = "0x4422C78", Offset = "0x4422C78", VA = "0x4422C78")] get
      {
        return (EquipmentClassificationData) null;
      }
    }

    [Token(Token = "0x17003741")]
    public WeaponTypeEnum? WeaponType
    {
      [Token(Token = "0x600FC15"), Address(RVA = "0x4422CB8", Offset = "0x4422CB8", VA = "0x4422CB8")] get
      {
        return new WeaponTypeEnum?();
      }
    }

    [Token(Token = "0x600FC16")]
    [Address(RVA = "0x4422D84", Offset = "0x4422D84", VA = "0x4422D84")]
    public void AddAchieveWeaponProficiency(int value)
    {
    }

    [Token(Token = "0x600FC17")]
    [Address(RVA = "0x4422E9C", Offset = "0x4422E9C", VA = "0x4422E9C")]
    public ProficiencyTypeEnum GetWeaponProficiency(WeaponTypeEnum weaponType)
    {
      return new ProficiencyTypeEnum();
    }

    [Token(Token = "0x600FC18")]
    [Address(RVA = "0x4422F1C", Offset = "0x4422F1C", VA = "0x4422F1C", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
