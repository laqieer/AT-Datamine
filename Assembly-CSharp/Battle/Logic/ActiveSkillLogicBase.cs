// Decompiled with JetBrains decompiler
// Type: Battle.Logic.ActiveSkillLogicBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024D0")]
  public abstract class ActiveSkillLogicBase
  {
    [Token(Token = "0x4009DE9")]
    [FieldOffset(Offset = "0x20")]
    protected Dictionary<EffectData, List<TargetPair>> effectiveTargets;
    [Token(Token = "0x4009DEA")]
    [FieldOffset(Offset = "0x28")]
    protected Dictionary<EffectData, ActionData> effectActions;
    [Token(Token = "0x4009DEB")]
    [FieldOffset(Offset = "0x30")]
    protected List<ActiveSkillLogicBase.HitResult> hitResultList;
    [Token(Token = "0x4009DEC")]
    [FieldOffset(Offset = "0x38")]
    protected List<ActionData> results;
    [Token(Token = "0x4009DF0")]
    [FieldOffset(Offset = "0x50")]
    protected List<(UnitParameterData unit, int index, BarrierDamageLogic barrierDamageLogic)> reserveBarrierDamageList;

    [Token(Token = "0x1700308A")]
    public SkillParameterData ActiveSkillParam
    {
      [Token(Token = "0x600E2A2"), Address(RVA = "0x401C80C", Offset = "0x401C80C", VA = "0x401C80C")] get
      {
        return (SkillParameterData) null;
      }
      [Token(Token = "0x600E2A3"), Address(RVA = "0x401C814", Offset = "0x401C814", VA = "0x401C814")] protected set
      {
      }
    }

    [Token(Token = "0x1700308B")]
    public TargetPair MainTarget
    {
      [Token(Token = "0x600E2A4"), Address(RVA = "0x401C81C", Offset = "0x401C81C", VA = "0x401C81C")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E2A5"), Address(RVA = "0x401C824", Offset = "0x401C824", VA = "0x401C824")] protected set
      {
      }
    }

    [Token(Token = "0x1700308C")]
    public int TotalDamage
    {
      [Token(Token = "0x600E2A6"), Address(RVA = "0x401C82C", Offset = "0x401C82C", VA = "0x401C82C")] get
      {
        return new int();
      }
      [Token(Token = "0x600E2A7"), Address(RVA = "0x401C834", Offset = "0x401C834", VA = "0x401C834")] protected set
      {
      }
    }

    [Token(Token = "0x1700308D")]
    public int TotalHeal
    {
      [Token(Token = "0x600E2A8"), Address(RVA = "0x401C83C", Offset = "0x401C83C", VA = "0x401C83C")] get
      {
        return new int();
      }
      [Token(Token = "0x600E2A9"), Address(RVA = "0x401C844", Offset = "0x401C844", VA = "0x401C844")] protected set
      {
      }
    }

    [Token(Token = "0x1700308E")]
    public int NormalHealValue
    {
      [Token(Token = "0x600E2AA"), Address(RVA = "0x401C84C", Offset = "0x401C84C", VA = "0x401C84C")] get
      {
        return new int();
      }
      [Token(Token = "0x600E2AB"), Address(RVA = "0x401C854", Offset = "0x401C854", VA = "0x401C854")] protected set
      {
      }
    }

    [Token(Token = "0x1700308F")]
    public IReadOnlyList<(UnitParameterData unit, int index, BarrierDamageLogic barrierDamageLogic)> ReserveBarrierDamageList
    {
      [Token(Token = "0x600E2AC"), Address(RVA = "0x401C85C", Offset = "0x401C85C", VA = "0x401C85C")] get
      {
        return (IReadOnlyList<(UnitParameterData, int, BarrierDamageLogic)>) null;
      }
    }

    [Token(Token = "0x600E2AD")]
    public abstract IReadOnlyList<ActionData> Execute();

    [Token(Token = "0x600E2AE")]
    [Address(RVA = "0x40197F0", Offset = "0x40197F0", VA = "0x40197F0")]
    public ActiveSkillLogicBase(SkillParameterData activeSkillParam, TargetPair mainTarget)
    {
    }

    [Token(Token = "0x600E2AF")]
    [Address(RVA = "0x401BD80", Offset = "0x401BD80", VA = "0x401BD80")]
    protected void AddReserveBarrierDamageBonus(
      TargetPair target,
      int gridIndex,
      int weakElementBonus,
      int alignmentStratagemBonus)
    {
    }

    [Token(Token = "0x600E2B0")]
    [Address(RVA = "0x401B108", Offset = "0x401B108", VA = "0x401B108")]
    protected void CheckAdditionalHeal(EffectData effect, EffectData prevEffect)
    {
    }

    [Token(Token = "0x600E2B1")]
    [Address(RVA = "0x401B468", Offset = "0x401B468", VA = "0x401B468")]
    protected void AddHitResult(
      EffectData effect,
      UnitParameterData targetUnit,
      int hitRate,
      bool isHit)
    {
    }

    [Token(Token = "0x600E2B2")]
    [Address(RVA = "0x401AF94", Offset = "0x401AF94", VA = "0x401AF94")]
    protected ActiveSkillLogicBase.HitResult GetHitResult(
      EffectData effect,
      UnitParameterData targetUnit)
    {
      return (ActiveSkillLogicBase.HitResult) null;
    }

    [Token(Token = "0x20024D1")]
    protected class HitResult
    {
      [Token(Token = "0x17003090")]
      public EffectData Effect
      {
        [Token(Token = "0x600E2B3"), Address(RVA = "0x401C93C", Offset = "0x401C93C", VA = "0x401C93C")] get
        {
          return (EffectData) null;
        }
        [Token(Token = "0x600E2B4"), Address(RVA = "0x401C944", Offset = "0x401C944", VA = "0x401C944")] private set
        {
        }
      }

      [Token(Token = "0x17003091")]
      public UnitParameterData Unit
      {
        [Token(Token = "0x600E2B5"), Address(RVA = "0x401C94C", Offset = "0x401C94C", VA = "0x401C94C")] get
        {
          return (UnitParameterData) null;
        }
        [Token(Token = "0x600E2B6"), Address(RVA = "0x401C954", Offset = "0x401C954", VA = "0x401C954")] private set
        {
        }
      }

      [Token(Token = "0x17003092")]
      public int HitRate
      {
        [Token(Token = "0x600E2B7"), Address(RVA = "0x401C95C", Offset = "0x401C95C", VA = "0x401C95C")] get
        {
          return new int();
        }
        [Token(Token = "0x600E2B8"), Address(RVA = "0x401C964", Offset = "0x401C964", VA = "0x401C964")] private set
        {
        }
      }

      [Token(Token = "0x17003093")]
      public bool IsHit
      {
        [Token(Token = "0x600E2B9"), Address(RVA = "0x401C96C", Offset = "0x401C96C", VA = "0x401C96C")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E2BA"), Address(RVA = "0x401C974", Offset = "0x401C974", VA = "0x401C974")] private set
        {
        }
      }

      [Token(Token = "0x600E2BB")]
      [Address(RVA = "0x401C8F4", Offset = "0x401C8F4", VA = "0x401C8F4")]
      public HitResult(EffectData effect, UnitParameterData unit, int hitRate, bool isHit)
      {
      }
    }
  }
}
