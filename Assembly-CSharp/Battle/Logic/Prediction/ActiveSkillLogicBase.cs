// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.ActiveSkillLogicBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024EC")]
  public abstract class ActiveSkillLogicBase
  {
    [Token(Token = "0x4009E61")]
    [FieldOffset(Offset = "0x20")]
    protected Dictionary<EffectData, List<TargetPair>> effectiveTargets;
    [Token(Token = "0x4009E62")]
    [FieldOffset(Offset = "0x28")]
    protected List<ActiveSkillLogicBase.HitResult> hitResultList;

    [Token(Token = "0x170030C5")]
    public SkillParameterData ActiveSkillParam
    {
      [Token(Token = "0x600E39F"), Address(RVA = "0x47770C8", Offset = "0x47770C8", VA = "0x47770C8")] get
      {
        return (SkillParameterData) null;
      }
      [Token(Token = "0x600E3A0"), Address(RVA = "0x47770D0", Offset = "0x47770D0", VA = "0x47770D0")] protected set
      {
      }
    }

    [Token(Token = "0x170030C6")]
    public TargetPair MainTargetPair
    {
      [Token(Token = "0x600E3A1"), Address(RVA = "0x47770D8", Offset = "0x47770D8", VA = "0x47770D8")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E3A2"), Address(RVA = "0x47770E0", Offset = "0x47770E0", VA = "0x47770E0")] protected set
      {
      }
    }

    [Token(Token = "0x170030C7")]
    public int NormalHealValue
    {
      [Token(Token = "0x600E3A3"), Address(RVA = "0x47770E8", Offset = "0x47770E8", VA = "0x47770E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E3A4"), Address(RVA = "0x47770F0", Offset = "0x47770F0", VA = "0x47770F0")] protected set
      {
      }
    }

    [Token(Token = "0x170030C8")]
    public List<(UnitParameterData unit, int index, BarrierDamageLogic barrierDamageLogic)> ReserveBarrierDamageList
    {
      [Token(Token = "0x600E3A5"), Address(RVA = "0x47770F8", Offset = "0x47770F8", VA = "0x47770F8")] get
      {
        return (List<(UnitParameterData, int, BarrierDamageLogic)>) null;
      }
      [Token(Token = "0x600E3A6"), Address(RVA = "0x4777100", Offset = "0x4777100", VA = "0x4777100")] private set
      {
      }
    }

    [Token(Token = "0x170030C9")]
    protected List<EffectResult> Results
    {
      [Token(Token = "0x600E3A7"), Address(RVA = "0x4777108", Offset = "0x4777108", VA = "0x4777108")] get
      {
        return (List<EffectResult>) null;
      }
      [Token(Token = "0x600E3A8"), Address(RVA = "0x4777110", Offset = "0x4777110", VA = "0x4777110")] set
      {
      }
    }

    [Token(Token = "0x600E3A9")]
    public abstract List<EffectResult> Execute();

    [Token(Token = "0x600E3AA")]
    [Address(RVA = "0x4777118", Offset = "0x4777118", VA = "0x4777118")]
    public ActiveSkillLogicBase(SkillParameterData activeSkillParam, TargetPair mainTargetPair)
    {
    }

    [Token(Token = "0x600E3AB")]
    [Address(RVA = "0x4777278", Offset = "0x4777278", VA = "0x4777278")]
    protected void AddReserveBarrierDamageBonus(
      TargetPair targetPair,
      int gridIndex,
      int weakElementBonus,
      int alignmentStratagemBonus)
    {
    }

    [Token(Token = "0x600E3AC")]
    [Address(RVA = "0x47774B8", Offset = "0x47774B8", VA = "0x47774B8")]
    protected void CheckAdditionalHeal(EffectData effect, EffectData prevEffect)
    {
    }

    [Token(Token = "0x600E3AD")]
    [Address(RVA = "0x4777648", Offset = "0x4777648", VA = "0x4777648")]
    protected void AddHitResult(EffectData effect, UnitParameterData targetUnit, bool isHit)
    {
    }

    [Token(Token = "0x600E3AE")]
    [Address(RVA = "0x477778C", Offset = "0x477778C", VA = "0x477778C")]
    protected ActiveSkillLogicBase.HitResult GetHitResult(
      EffectData effect,
      UnitParameterData targetUnit)
    {
      return (ActiveSkillLogicBase.HitResult) null;
    }

    [Token(Token = "0x20024ED")]
    protected class HitResult
    {
      [Token(Token = "0x170030CA")]
      public EffectData Effect
      {
        [Token(Token = "0x600E3AF"), Address(RVA = "0x4777900", Offset = "0x4777900", VA = "0x4777900")] get
        {
          return (EffectData) null;
        }
        [Token(Token = "0x600E3B0"), Address(RVA = "0x4777908", Offset = "0x4777908", VA = "0x4777908")] private set
        {
        }
      }

      [Token(Token = "0x170030CB")]
      public UnitParameterData Unit
      {
        [Token(Token = "0x600E3B1"), Address(RVA = "0x4777910", Offset = "0x4777910", VA = "0x4777910")] get
        {
          return (UnitParameterData) null;
        }
        [Token(Token = "0x600E3B2"), Address(RVA = "0x4777918", Offset = "0x4777918", VA = "0x4777918")] private set
        {
        }
      }

      [Token(Token = "0x170030CC")]
      public bool IsHit
      {
        [Token(Token = "0x600E3B3"), Address(RVA = "0x4777920", Offset = "0x4777920", VA = "0x4777920")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E3B4"), Address(RVA = "0x4777928", Offset = "0x4777928", VA = "0x4777928")] private set
        {
        }
      }

      [Token(Token = "0x600E3B5")]
      [Address(RVA = "0x477774C", Offset = "0x477774C", VA = "0x477774C")]
      public HitResult(EffectData effect, UnitParameterData unit, bool isHit)
      {
      }
    }
  }
}
