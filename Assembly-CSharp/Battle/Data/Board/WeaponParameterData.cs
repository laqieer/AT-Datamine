// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.WeaponParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200281A")]
  public class WeaponParameterData : IBattleParameter, IItemData
  {
    [Token(Token = "0x400AB1A")]
    [FieldOffset(Offset = "0x10")]
    private WeaponData Data;
    [Token(Token = "0x400AB22")]
    [FieldOffset(Offset = "0x40")]
    private BattleParameter battleParameter;
    [Token(Token = "0x400AB25")]
    [FieldOffset(Offset = "0x50")]
    public int[] ReinforceAttack;
    [Token(Token = "0x400AB26")]
    [FieldOffset(Offset = "0x58")]
    public int[] ReinforceElement;
    [Token(Token = "0x400AB27")]
    [FieldOffset(Offset = "0x60")]
    public int[] ReinforceBadStat;

    [Token(Token = "0x1700374E")]
    public int Exp
    {
      [Token(Token = "0x600FC47"), Address(RVA = "0x4423D20", Offset = "0x4423D20", VA = "0x4423D20")] get
      {
        return new int();
      }
      [Token(Token = "0x600FC48"), Address(RVA = "0x4423D28", Offset = "0x4423D28", VA = "0x4423D28")] set
      {
      }
    }

    [Token(Token = "0x1700374F")]
    public int Durable
    {
      [Token(Token = "0x600FC49"), Address(RVA = "0x4423D30", Offset = "0x4423D30", VA = "0x4423D30")] get
      {
        return new int();
      }
      [Token(Token = "0x600FC4A"), Address(RVA = "0x4423D38", Offset = "0x4423D38", VA = "0x4423D38")] set
      {
      }
    }

    [Token(Token = "0x17003750")]
    public SkillParameterData NormalAttackSkillParam
    {
      [Token(Token = "0x600FC4B"), Address(RVA = "0x4423D40", Offset = "0x4423D40", VA = "0x4423D40")] get
      {
        return (SkillParameterData) null;
      }
      [Token(Token = "0x600FC4C"), Address(RVA = "0x4423D48", Offset = "0x4423D48", VA = "0x4423D48")] private set
      {
      }
    }

    [Token(Token = "0x17003751")]
    public List<SkillParameterData> ActiveSkillParams
    {
      [Token(Token = "0x600FC4D"), Address(RVA = "0x4423D50", Offset = "0x4423D50", VA = "0x4423D50")] get
      {
        return (List<SkillParameterData>) null;
      }
      [Token(Token = "0x600FC4E"), Address(RVA = "0x4423D58", Offset = "0x4423D58", VA = "0x4423D58")] private set
      {
      }
    }

    [Token(Token = "0x17003752")]
    public List<SkillParameterData> PassiveSkillParams
    {
      [Token(Token = "0x600FC4F"), Address(RVA = "0x4423D60", Offset = "0x4423D60", VA = "0x4423D60")] get
      {
        return (List<SkillParameterData>) null;
      }
      [Token(Token = "0x600FC50"), Address(RVA = "0x4423D68", Offset = "0x4423D68", VA = "0x4423D68")] private set
      {
      }
    }

    [Token(Token = "0x17003753")]
    public string Id
    {
      [Token(Token = "0x600FC51"), Address(RVA = "0x4423D70", Offset = "0x4423D70", VA = "0x4423D70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003754")]
    public UniqueID UniqueId
    {
      [Token(Token = "0x600FC52"), Address(RVA = "0x4423D8C", Offset = "0x4423D8C", VA = "0x4423D8C")] get
      {
        return new UniqueID();
      }
    }

    [Token(Token = "0x17003755")]
    public GameCore.MasterData.WeaponData MasterData
    {
      [Token(Token = "0x600FC53"), Address(RVA = "0x441B34C", Offset = "0x441B34C", VA = "0x441B34C")] get
      {
        return (GameCore.MasterData.WeaponData) null;
      }
    }

    [Token(Token = "0x17003756")]
    public int MaxDurable
    {
      [Token(Token = "0x600FC54"), Address(RVA = "0x4423DA8", Offset = "0x4423DA8", VA = "0x4423DA8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003757")]
    public WeaponAttackTypeEnum WeaponAttackType
    {
      [Token(Token = "0x600FC55"), Address(RVA = "0x4423DCC", Offset = "0x4423DCC", VA = "0x4423DCC")] get
      {
        return new WeaponAttackTypeEnum();
      }
    }

    [Token(Token = "0x17003758")]
    public ElementTypeEnum ElementType
    {
      [Token(Token = "0x600FC56"), Address(RVA = "0x4423DF0", Offset = "0x4423DF0", VA = "0x4423DF0")] get
      {
        return new ElementTypeEnum();
      }
    }

    [Token(Token = "0x17003759")]
    public EquipmentClassificationData Classification
    {
      [Token(Token = "0x600FC57"), Address(RVA = "0x4422C9C", Offset = "0x4422C9C", VA = "0x4422C9C")] get
      {
        return (EquipmentClassificationData) null;
      }
    }

    [Token(Token = "0x1700375A")]
    public WeaponTypeEnum WeaponType
    {
      [Token(Token = "0x600FC58"), Address(RVA = "0x4422D60", Offset = "0x4422D60", VA = "0x4422D60")] get
      {
        return new WeaponTypeEnum();
      }
    }

    [Token(Token = "0x1700375B")]
    public AttackTypeEnum AttackType
    {
      [Token(Token = "0x600FC59"), Address(RVA = "0x4423E14", Offset = "0x4423E14", VA = "0x4423E14")] get
      {
        return new AttackTypeEnum();
      }
    }

    [Token(Token = "0x1700375C")]
    public int Level
    {
      [Token(Token = "0x600FC5A"), Address(RVA = "0x4423E38", Offset = "0x4423E38", VA = "0x4423E38")] get
      {
        return new int();
      }
      [Token(Token = "0x600FC5B"), Address(RVA = "0x4423E40", Offset = "0x4423E40", VA = "0x4423E40")] private set
      {
      }
    }

    [Token(Token = "0x1700375D")]
    public int LevelCap
    {
      [Token(Token = "0x600FC5C"), Address(RVA = "0x4423E48", Offset = "0x4423E48", VA = "0x4423E48")] get
      {
        return new int();
      }
      [Token(Token = "0x600FC5D"), Address(RVA = "0x4423E50", Offset = "0x4423E50", VA = "0x4423E50")] private set
      {
      }
    }

    [Token(Token = "0x1700375E")]
    public int HP
    {
      [Token(Token = "0x600FC5E"), Address(RVA = "0x4423E58", Offset = "0x4423E58", VA = "0x4423E58", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700375F")]
    public int PhysicalAtk
    {
      [Token(Token = "0x600FC5F"), Address(RVA = "0x4423E74", Offset = "0x4423E74", VA = "0x4423E74", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003760")]
    public int PhysicalDef
    {
      [Token(Token = "0x600FC60"), Address(RVA = "0x4423E90", Offset = "0x4423E90", VA = "0x4423E90", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003761")]
    public int MagicalAtk
    {
      [Token(Token = "0x600FC61"), Address(RVA = "0x4423EAC", Offset = "0x4423EAC", VA = "0x4423EAC", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003762")]
    public int MagicalDef
    {
      [Token(Token = "0x600FC62"), Address(RVA = "0x4423EC8", Offset = "0x4423EC8", VA = "0x4423EC8", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003763")]
    public int Hit
    {
      [Token(Token = "0x600FC63"), Address(RVA = "0x4423EE4", Offset = "0x4423EE4", VA = "0x4423EE4", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003764")]
    public int Avoid
    {
      [Token(Token = "0x600FC64"), Address(RVA = "0x4423F00", Offset = "0x4423F00", VA = "0x4423F00", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003765")]
    public int Critical
    {
      [Token(Token = "0x600FC65"), Address(RVA = "0x4423F1C", Offset = "0x4423F1C", VA = "0x4423F1C", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003766")]
    public int CriticalAvoid
    {
      [Token(Token = "0x600FC66"), Address(RVA = "0x4423F38", Offset = "0x4423F38", VA = "0x4423F38", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003767")]
    public int AtkSpeed
    {
      [Token(Token = "0x600FC67"), Address(RVA = "0x4423F54", Offset = "0x4423F54", VA = "0x4423F54", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003768")]
    public int Power
    {
      [Token(Token = "0x600FC68"), Address(RVA = "0x4423F70", Offset = "0x4423F70", VA = "0x4423F70")] get
      {
        return new int();
      }
      [Token(Token = "0x600FC69"), Address(RVA = "0x4423F78", Offset = "0x4423F78", VA = "0x4423F78")] private set
      {
      }
    }

    [Token(Token = "0x17003769")]
    public int Weight
    {
      [Token(Token = "0x600FC6A"), Address(RVA = "0x4423F80", Offset = "0x4423F80", VA = "0x4423F80")] get
      {
        return new int();
      }
      [Token(Token = "0x600FC6B"), Address(RVA = "0x4423F88", Offset = "0x4423F88", VA = "0x4423F88")] private set
      {
      }
    }

    [Token(Token = "0x1700376A")]
    public string Name
    {
      [Token(Token = "0x600FC6C"), Address(RVA = "0x4423F90", Offset = "0x4423F90", VA = "0x4423F90", Slot = "18")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700376B")]
    public ItemTypeEnum ItemType
    {
      [Token(Token = "0x600FC6D"), Address(RVA = "0x4423FB4", Offset = "0x4423FB4", VA = "0x4423FB4", Slot = "14")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x1700376C")]
    public int ItemId
    {
      [Token(Token = "0x600FC6E"), Address(RVA = "0x4423FBC", Offset = "0x4423FBC", VA = "0x4423FBC", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700376D")]
    public int Amount
    {
      [Token(Token = "0x600FC6F"), Address(RVA = "0x4423FE0", Offset = "0x4423FE0", VA = "0x4423FE0", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700376E")]
    public int MaxAmount
    {
      [Token(Token = "0x600FC70"), Address(RVA = "0x4423FE8", Offset = "0x4423FE8", VA = "0x4423FE8", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700376F")]
    public WeaponParameterData Substitute
    {
      [Token(Token = "0x600FC71"), Address(RVA = "0x4423FEC", Offset = "0x4423FEC", VA = "0x4423FEC")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600FC72"), Address(RVA = "0x4423FF4", Offset = "0x4423FF4", VA = "0x4423FF4")] private set
      {
      }
    }

    [Token(Token = "0x17003770")]
    public int LimitBreak
    {
      [Token(Token = "0x600FC73"), Address(RVA = "0x4423FFC", Offset = "0x4423FFC", VA = "0x4423FFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003771")]
    public int MaxLimitBreak
    {
      [Token(Token = "0x600FC74"), Address(RVA = "0x4424018", Offset = "0x4424018", VA = "0x4424018")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003772")]
    public List<WeaponOptionEffect> Options
    {
      [Token(Token = "0x600FC75"), Address(RVA = "0x4424034", Offset = "0x4424034", VA = "0x4424034")] get
      {
        return (List<WeaponOptionEffect>) null;
      }
    }

    [Token(Token = "0x17003773")]
    public IBattleParameter MasterOffset
    {
      [Token(Token = "0x600FC76"), Address(RVA = "0x4424050", Offset = "0x4424050", VA = "0x4424050")] get
      {
        return (IBattleParameter) null;
      }
    }

    [Token(Token = "0x17003774")]
    public bool IsBroken
    {
      [Token(Token = "0x600FC77"), Address(RVA = "0x441CB94", Offset = "0x441CB94", VA = "0x441CB94")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003775")]
    public bool IsBreakable
    {
      [Token(Token = "0x600FC78"), Address(RVA = "0x442406C", Offset = "0x442406C", VA = "0x442406C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003776")]
    public bool IsUsers
    {
      [Token(Token = "0x600FC79"), Address(RVA = "0x442409C", Offset = "0x442409C", VA = "0x442409C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600FC7A")]
    [Address(RVA = "0x4424110", Offset = "0x4424110", VA = "0x4424110")]
    public static WeaponParameterData Create(WeaponParameterSource source)
    {
      return (WeaponParameterData) null;
    }

    [Token(Token = "0x600FC7B")]
    [Address(RVA = "0x44245B0", Offset = "0x44245B0", VA = "0x44245B0")]
    public static WeaponParameterData Clone(
      WeaponParameterData src,
      ISkillParameterDataHandler handler)
    {
      return (WeaponParameterData) null;
    }

    [Token(Token = "0x600FC7C")]
    [Address(RVA = "0x441F164", Offset = "0x441F164", VA = "0x441F164")]
    public WeaponParameterData Copy() => (WeaponParameterData) null;

    [Token(Token = "0x600FC7D")]
    [Address(RVA = "0x442495C", Offset = "0x442495C", VA = "0x442495C")]
    public GameCore.MasterData.WeaponData GetAppropriateMasterData() => (GameCore.MasterData.WeaponData) null;

    [Token(Token = "0x600FC7E")]
    [Address(RVA = "0x441B60C", Offset = "0x441B60C", VA = "0x441B60C")]
    public WeaponParameterData GetAppropriateWeaponParam() => (WeaponParameterData) null;

    [Token(Token = "0x600FC7F")]
    [Address(RVA = "0x4424310", Offset = "0x4424310", VA = "0x4424310")]
    public void UpdateBattleParameterByExp()
    {
    }

    [Token(Token = "0x600FC80")]
    [Address(RVA = "0x4422908", Offset = "0x4422908", VA = "0x4422908")]
    public int Consume(int value) => new int();

    [Token(Token = "0x600FC81")]
    [Address(RVA = "0x44249A8", Offset = "0x44249A8", VA = "0x44249A8", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600FC82")]
    [Address(RVA = "0x4424258", Offset = "0x4424258", VA = "0x4424258")]
    public WeaponParameterData()
    {
    }
  }
}
