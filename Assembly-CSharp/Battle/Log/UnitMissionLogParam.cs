// Decompiled with JetBrains decompiler
// Type: Battle.Log.UnitMissionLogParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002520")]
  public class UnitMissionLogParam
  {
    [Token(Token = "0x4009F7F")]
    [FieldOffset(Offset = "0x58")]
    public List<UseSkillParam> useSkillParams;
    [Token(Token = "0x4009F80")]
    [FieldOffset(Offset = "0x60")]
    public List<DealBadStatusParam> dealBadStatusParams;
    [Token(Token = "0x4009F81")]
    [FieldOffset(Offset = "0x68")]
    private WeakReference<UnitParameterData> unitRef;

    [Token(Token = "0x1700312A")]
    public int ID
    {
      [Token(Token = "0x600E52A"), Address(RVA = "0x478B028", Offset = "0x478B028", VA = "0x478B028")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700312B")]
    public int StyleId
    {
      [Token(Token = "0x600E52B"), Address(RVA = "0x478CF10", Offset = "0x478CF10", VA = "0x478CF10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700312C")]
    public int CharacterId
    {
      [Token(Token = "0x600E52C"), Address(RVA = "0x478D188", Offset = "0x478D188", VA = "0x478D188")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700312D")]
    public ForceTypeEnum ForceNo
    {
      [Token(Token = "0x600E52D"), Address(RVA = "0x4791020", Offset = "0x4791020", VA = "0x4791020")] get
      {
        return new ForceTypeEnum();
      }
      [Token(Token = "0x600E52E"), Address(RVA = "0x4791028", Offset = "0x4791028", VA = "0x4791028")] protected set
      {
      }
    }

    [Token(Token = "0x1700312E")]
    public int PlayerId
    {
      [Token(Token = "0x600E52F"), Address(RVA = "0x478CEF0", Offset = "0x478CEF0", VA = "0x478CEF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700312F")]
    public int MaxDealDamage
    {
      [Token(Token = "0x600E530"), Address(RVA = "0x4791030", Offset = "0x4791030", VA = "0x4791030")] get
      {
        return new int();
      }
      [Token(Token = "0x600E531"), Address(RVA = "0x4791038", Offset = "0x4791038", VA = "0x4791038")] protected set
      {
      }
    }

    [Token(Token = "0x17003130")]
    public int TotalDealDamage
    {
      [Token(Token = "0x600E532"), Address(RVA = "0x4791040", Offset = "0x4791040", VA = "0x4791040")] get
      {
        return new int();
      }
      [Token(Token = "0x600E533"), Address(RVA = "0x4791048", Offset = "0x4791048", VA = "0x4791048")] protected set
      {
      }
    }

    [Token(Token = "0x17003131")]
    public int MaxTakeDamage
    {
      [Token(Token = "0x600E534"), Address(RVA = "0x4791050", Offset = "0x4791050", VA = "0x4791050")] get
      {
        return new int();
      }
      [Token(Token = "0x600E535"), Address(RVA = "0x4791058", Offset = "0x4791058", VA = "0x4791058")] protected set
      {
      }
    }

    [Token(Token = "0x17003132")]
    public int TotalTakeDamage
    {
      [Token(Token = "0x600E536"), Address(RVA = "0x4791060", Offset = "0x4791060", VA = "0x4791060")] get
      {
        return new int();
      }
      [Token(Token = "0x600E537"), Address(RVA = "0x4791068", Offset = "0x4791068", VA = "0x4791068")] protected set
      {
      }
    }

    [Token(Token = "0x17003133")]
    public HPStockData HPStockData
    {
      [Token(Token = "0x600E538"), Address(RVA = "0x4791070", Offset = "0x4791070", VA = "0x4791070")] get
      {
        return (HPStockData) null;
      }
      [Token(Token = "0x600E539"), Address(RVA = "0x4791078", Offset = "0x4791078", VA = "0x4791078")] protected set
      {
      }
    }

    [Token(Token = "0x17003134")]
    public bool IsAlive
    {
      [Token(Token = "0x600E53A"), Address(RVA = "0x4791080", Offset = "0x4791080", VA = "0x4791080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E53B"), Address(RVA = "0x4791088", Offset = "0x4791088", VA = "0x4791088")] protected set
      {
      }
    }

    [Token(Token = "0x17003135")]
    protected StyleData Style
    {
      [Token(Token = "0x600E53C"), Address(RVA = "0x4790FE0", Offset = "0x4790FE0", VA = "0x4790FE0")] get
      {
        return (StyleData) null;
      }
    }

    [Token(Token = "0x17003136")]
    protected CharacterData Character
    {
      [Token(Token = "0x600E53D"), Address(RVA = "0x4791000", Offset = "0x4791000", VA = "0x4791000")] get
      {
        return (CharacterData) null;
      }
    }

    [Token(Token = "0x17003137")]
    public List<DeathParam> DeathParams
    {
      [Token(Token = "0x600E53E"), Address(RVA = "0x4791094", Offset = "0x4791094", VA = "0x4791094")] get
      {
        return (List<DeathParam>) null;
      }
      [Token(Token = "0x600E53F"), Address(RVA = "0x479109C", Offset = "0x479109C", VA = "0x479109C")] private set
      {
      }
    }

    [Token(Token = "0x17003138")]
    public ElementTypeEnum Element
    {
      [Token(Token = "0x600E540"), Address(RVA = "0x478DE50", Offset = "0x478DE50", VA = "0x478DE50")] get
      {
        return new ElementTypeEnum();
      }
    }

    [Token(Token = "0x17003139")]
    public HashSet<int> KilledUnits
    {
      [Token(Token = "0x600E541"), Address(RVA = "0x47910A4", Offset = "0x47910A4", VA = "0x47910A4")] get
      {
        return (HashSet<int>) null;
      }
      [Token(Token = "0x600E542"), Address(RVA = "0x47910AC", Offset = "0x47910AC", VA = "0x47910AC")] protected set
      {
      }
    }

    [Token(Token = "0x1700313A")]
    public int TotalDealHeal
    {
      [Token(Token = "0x600E543"), Address(RVA = "0x47910B4", Offset = "0x47910B4", VA = "0x47910B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600E544"), Address(RVA = "0x47910BC", Offset = "0x47910BC", VA = "0x47910BC")] protected set
      {
      }
    }

    [Token(Token = "0x1700313B")]
    public int TotalTakeHeal
    {
      [Token(Token = "0x600E545"), Address(RVA = "0x47910C4", Offset = "0x47910C4", VA = "0x47910C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600E546"), Address(RVA = "0x47910CC", Offset = "0x47910CC", VA = "0x47910CC")] protected set
      {
      }
    }

    [Token(Token = "0x1700313C")]
    public HashSet<int> UseWeaponIDs
    {
      [Token(Token = "0x600E547"), Address(RVA = "0x47910D4", Offset = "0x47910D4", VA = "0x47910D4")] get
      {
        return (HashSet<int>) null;
      }
      [Token(Token = "0x600E548"), Address(RVA = "0x47910DC", Offset = "0x47910DC", VA = "0x47910DC")] private set
      {
      }
    }

    [Token(Token = "0x1700313D")]
    private UnitParameterData unit
    {
      [Token(Token = "0x600E549"), Address(RVA = "0x4790F80", Offset = "0x4790F80", VA = "0x4790F80")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x1700313E")]
    public int DeathCount
    {
      [Token(Token = "0x600E54A"), Address(RVA = "0x478EC70", Offset = "0x478EC70", VA = "0x478EC70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700313F")]
    public int TotalDeathBadStatusCount
    {
      [Token(Token = "0x600E54B"), Address(RVA = "0x478F7F0", Offset = "0x478F7F0", VA = "0x478F7F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003140")]
    public int TotalNormalAttackCount
    {
      [Token(Token = "0x600E54C"), Address(RVA = "0x47910E4", Offset = "0x47910E4", VA = "0x47910E4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003141")]
    public int TotalUseSkillCount
    {
      [Token(Token = "0x600E54D"), Address(RVA = "0x479123C", Offset = "0x479123C", VA = "0x479123C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003142")]
    public int TotalDealBadStatusCount
    {
      [Token(Token = "0x600E54E"), Address(RVA = "0x478F3AC", Offset = "0x478F3AC", VA = "0x478F3AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E54F")]
    [Address(RVA = "0x478E604", Offset = "0x478E604", VA = "0x478E604")]
    public bool IsOverCurrentHPRate(int rate) => new bool();

    [Token(Token = "0x600E550")]
    [Address(RVA = "0x4791394", Offset = "0x4791394", VA = "0x4791394")]
    private UnitMissionLogParam(UnitMissionLogParam src, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600E551")]
    [Address(RVA = "0x4789D0C", Offset = "0x4789D0C", VA = "0x4789D0C")]
    public UnitMissionLogParam Clone() => (UnitMissionLogParam) null;

    [Token(Token = "0x600E552")]
    [Address(RVA = "0x4789EC4", Offset = "0x4789EC4", VA = "0x4789EC4")]
    public UnitMissionLogParam(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600E553")]
    [Address(RVA = "0x4791634", Offset = "0x4791634", VA = "0x4791634")]
    public void Apply(IEnumerable<UnitMissionLogParam.Diff> diffs)
    {
    }

    [Token(Token = "0x600E554")]
    [Address(RVA = "0x478B1B8", Offset = "0x478B1B8", VA = "0x478B1B8")]
    public void Apply(UnitMissionLogParam.Diff diff, bool updateText = true)
    {
    }

    [Token(Token = "0x600E555")]
    [Address(RVA = "0x4791DB8", Offset = "0x4791DB8", VA = "0x4791DB8")]
    public void Revert(IEnumerable<UnitMissionLogParam.Diff> diffs)
    {
    }

    [Token(Token = "0x600E556")]
    [Address(RVA = "0x478C50C", Offset = "0x478C50C", VA = "0x478C50C")]
    public void Revert(UnitMissionLogParam.Diff diff, bool updateText = true)
    {
    }

    [Token(Token = "0x600E557")]
    [Address(RVA = "0x4791910", Offset = "0x4791910", VA = "0x4791910")]
    public DeathParam GetDeathParam(CauseOfDeath cause) => (DeathParam) null;

    [Token(Token = "0x600E558")]
    [Address(RVA = "0x4791A74", Offset = "0x4791A74", VA = "0x4791A74")]
    public UseSkillParam GetUseSkillParam(int skillId = -1, int skillLevel = -1, int weaponId = -1)
    {
      return (UseSkillParam) null;
    }

    [Token(Token = "0x600E559")]
    [Address(RVA = "0x4791C54", Offset = "0x4791C54", VA = "0x4791C54")]
    public DealBadStatusParam GetDealBadStatusParam(int id) => (DealBadStatusParam) null;

    [Token(Token = "0x2002521")]
    public class Diff : UnitMissionLogParam
    {
      [Token(Token = "0x17003143")]
      public int HPStockCount
      {
        [Token(Token = "0x600E55A"), Address(RVA = "0x486893C", Offset = "0x486893C", VA = "0x486893C")] get
        {
          return new int();
        }
        [Token(Token = "0x600E55B"), Address(RVA = "0x4868944", Offset = "0x4868944", VA = "0x4868944")] private set
        {
        }
      }

      [Token(Token = "0x17003144")]
      public int CurrentHP
      {
        [Token(Token = "0x600E55C"), Address(RVA = "0x486894C", Offset = "0x486894C", VA = "0x486894C")] get
        {
          return new int();
        }
        [Token(Token = "0x600E55D"), Address(RVA = "0x4868954", Offset = "0x4868954", VA = "0x4868954")] private set
        {
        }
      }

      [Token(Token = "0x600E55E")]
      [Address(RVA = "0x486895C", Offset = "0x486895C", VA = "0x486895C")]
      public Diff(UnitMissionLogParam src, int maxDealDamage = 0, int maxTakeDamage = 0)
      {
      }

      [Token(Token = "0x600E55F")]
      [Address(RVA = "0x48689B8", Offset = "0x48689B8", VA = "0x48689B8")]
      public void AddTotalDealDamage(int damage)
      {
      }

      [Token(Token = "0x600E560")]
      [Address(RVA = "0x48689C8", Offset = "0x48689C8", VA = "0x48689C8")]
      public void AddMaxDealDamage(int damage)
      {
      }

      [Token(Token = "0x600E561")]
      [Address(RVA = "0x48689D8", Offset = "0x48689D8", VA = "0x48689D8")]
      public void AddTotalTakeDamage(int damage)
      {
      }

      [Token(Token = "0x600E562")]
      [Address(RVA = "0x48689E8", Offset = "0x48689E8", VA = "0x48689E8")]
      public void AddMaxTakeDamage(int damage)
      {
      }

      [Token(Token = "0x600E563")]
      [Address(RVA = "0x48689F8", Offset = "0x48689F8", VA = "0x48689F8")]
      public void AddTotalDealHeal(int heal)
      {
      }

      [Token(Token = "0x600E564")]
      [Address(RVA = "0x4868A08", Offset = "0x4868A08", VA = "0x4868A08")]
      public void AddTotalTakeHeal(int heal)
      {
      }

      [Token(Token = "0x600E565")]
      [Address(RVA = "0x4868A18", Offset = "0x4868A18", VA = "0x4868A18")]
      public void AddHP(int stockCount, int currentHP)
      {
      }

      [Token(Token = "0x600E566")]
      [Address(RVA = "0x4868A2C", Offset = "0x4868A2C", VA = "0x4868A2C")]
      public void SetIsAlive(bool isAlive)
      {
      }

      [Token(Token = "0x600E567")]
      [Address(RVA = "0x4868A38", Offset = "0x4868A38", VA = "0x4868A38")]
      public void AddDeathParam(CauseOfDeath cause, int count = 1)
      {
      }

      [Token(Token = "0x600E568")]
      [Address(RVA = "0x4868B84", Offset = "0x4868B84", VA = "0x4868B84")]
      public void AddUseSkillParam(
        int skillId,
        int skillLevel,
        int weaponId,
        bool isNormalAttack,
        int count = 1)
      {
      }

      [Token(Token = "0x600E569")]
      [Address(RVA = "0x4868D24", Offset = "0x4868D24", VA = "0x4868D24")]
      public void AddDealBadStatusParam(int id, int count = 1)
      {
      }

      [Token(Token = "0x600E56A")]
      [Address(RVA = "0x4868D5C", Offset = "0x4868D5C", VA = "0x4868D5C")]
      public void AddKilledUnit(int unitId)
      {
      }

      [Token(Token = "0x600E56B")]
      [Address(RVA = "0x4868DB4", Offset = "0x4868DB4", VA = "0x4868DB4")]
      public void AddUseWeaponId(int weaponId)
      {
      }
    }
  }
}
