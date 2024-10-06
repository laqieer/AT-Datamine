// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.PredictionUnitResult
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
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024F8")]
  public class PredictionUnitResult
  {
    [Token(Token = "0x4009ECA")]
    [FieldOffset(Offset = "0x60")]
    public readonly BarrierParameter BeforeBarrierParameter;
    [Token(Token = "0x4009ECB")]
    [FieldOffset(Offset = "0x68")]
    public readonly BarrierParameter AfterBarrierParameter;
    [Token(Token = "0x4009ECE")]
    [FieldOffset(Offset = "0x78")]
    private HashSet<int> ActivatableSkills;
    [Token(Token = "0x4009ECF")]
    [FieldOffset(Offset = "0x80")]
    private HashSet<(int id, BattleEffectTypeEnum type)> ActivateSkillEffects;
    [Token(Token = "0x4009ED0")]
    [FieldOffset(Offset = "0x88")]
    private List<Tuple<BattleBadStatusTypeEnum, int>> CureBadStatuses;
    [Token(Token = "0x4009ED1")]
    [FieldOffset(Offset = "0x90")]
    private List<Tuple<BattleBadStatusTypeEnum, int>> DealBadStatuses;
    [Token(Token = "0x4009ED2")]
    [FieldOffset(Offset = "0x98")]
    private List<ClearEffectData> CureBuffDebuffEffects;
    [Token(Token = "0x4009ED3")]
    [FieldOffset(Offset = "0xA0")]
    private List<ModifierEffectData> DealBuffDebuffEffects;
    [Token(Token = "0x4009ED5")]
    [FieldOffset(Offset = "0xB0")]
    private HashSet<int> preDuelSkillIds;

    [Token(Token = "0x170030D2")]
    public int UnitId
    {
      [Token(Token = "0x600E3FC"), Address(RVA = "0x477F994", Offset = "0x477F994", VA = "0x477F994")] get
      {
        return new int();
      }
      [Token(Token = "0x600E3FD"), Address(RVA = "0x477F99C", Offset = "0x477F99C", VA = "0x477F99C")] private set
      {
      }
    }

    [Token(Token = "0x170030D3")]
    public HPStockData HpStock
    {
      [Token(Token = "0x600E3FE"), Address(RVA = "0x477F9A4", Offset = "0x477F9A4", VA = "0x477F9A4")] get
      {
        return (HPStockData) null;
      }
      [Token(Token = "0x600E3FF"), Address(RVA = "0x477F9AC", Offset = "0x477F9AC", VA = "0x477F9AC")] private set
      {
      }
    }

    [Token(Token = "0x170030D4")]
    public int HitRate
    {
      [Token(Token = "0x600E400"), Address(RVA = "0x477F9B4", Offset = "0x477F9B4", VA = "0x477F9B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600E401"), Address(RVA = "0x477F9BC", Offset = "0x477F9BC", VA = "0x477F9BC")] private set
      {
      }
    }

    [Token(Token = "0x600E402")]
    [Address(RVA = "0x477F9C4", Offset = "0x477F9C4", VA = "0x477F9C4")]
    private void SetHitRate(int value)
    {
    }

    [Token(Token = "0x170030D5")]
    public int CriticalRate
    {
      [Token(Token = "0x600E403"), Address(RVA = "0x477F9CC", Offset = "0x477F9CC", VA = "0x477F9CC")] get
      {
        return new int();
      }
      [Token(Token = "0x600E404"), Address(RVA = "0x477F9D4", Offset = "0x477F9D4", VA = "0x477F9D4")] private set
      {
      }
    }

    [Token(Token = "0x600E405")]
    [Address(RVA = "0x477F9DC", Offset = "0x477F9DC", VA = "0x477F9DC")]
    private void SetCriticalRate(int value)
    {
    }

    [Token(Token = "0x170030D6")]
    public int TotalDealDamage
    {
      [Token(Token = "0x600E406"), Address(RVA = "0x477F9E4", Offset = "0x477F9E4", VA = "0x477F9E4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170030D7")]
    public int DealDamage
    {
      [Token(Token = "0x600E407"), Address(RVA = "0x477F9F4", Offset = "0x477F9F4", VA = "0x477F9F4")] get
      {
        return new int();
      }
      [Token(Token = "0x600E408"), Address(RVA = "0x477F9FC", Offset = "0x477F9FC", VA = "0x477F9FC")] private set
      {
      }
    }

    [Token(Token = "0x600E409")]
    [Address(RVA = "0x477FA04", Offset = "0x477FA04", VA = "0x477FA04")]
    private void AddDealDamage(int value)
    {
    }

    [Token(Token = "0x170030D8")]
    public int ChaseDamage
    {
      [Token(Token = "0x600E40A"), Address(RVA = "0x477FA14", Offset = "0x477FA14", VA = "0x477FA14")] get
      {
        return new int();
      }
      [Token(Token = "0x600E40B"), Address(RVA = "0x477FA1C", Offset = "0x477FA1C", VA = "0x477FA1C")] private set
      {
      }
    }

    [Token(Token = "0x600E40C")]
    [Address(RVA = "0x477FA24", Offset = "0x477FA24", VA = "0x477FA24")]
    private void AddChaseDamage(int value)
    {
    }

    [Token(Token = "0x170030D9")]
    public int BeforeFieldDamage
    {
      [Token(Token = "0x600E40D"), Address(RVA = "0x477FA34", Offset = "0x477FA34", VA = "0x477FA34")] get
      {
        return new int();
      }
      [Token(Token = "0x600E40E"), Address(RVA = "0x477FA3C", Offset = "0x477FA3C", VA = "0x477FA3C")] private set
      {
      }
    }

    [Token(Token = "0x600E40F")]
    [Address(RVA = "0x477FA44", Offset = "0x477FA44", VA = "0x477FA44")]
    private void AddBeforeFieldDamage(int value)
    {
    }

    [Token(Token = "0x170030DA")]
    public int AfterFieldDamage
    {
      [Token(Token = "0x600E410"), Address(RVA = "0x477FA54", Offset = "0x477FA54", VA = "0x477FA54")] get
      {
        return new int();
      }
      [Token(Token = "0x600E411"), Address(RVA = "0x477FA5C", Offset = "0x477FA5C", VA = "0x477FA5C")] private set
      {
      }
    }

    [Token(Token = "0x600E412")]
    [Address(RVA = "0x477FA64", Offset = "0x477FA64", VA = "0x477FA64")]
    private void AddAfterFieldDamage(int value)
    {
    }

    [Token(Token = "0x170030DB")]
    public int TotalHealPoint
    {
      [Token(Token = "0x600E413"), Address(RVA = "0x477FA74", Offset = "0x477FA74", VA = "0x477FA74")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170030DC")]
    public int HealPoint
    {
      [Token(Token = "0x600E414"), Address(RVA = "0x477FA88", Offset = "0x477FA88", VA = "0x477FA88")] get
      {
        return new int();
      }
      [Token(Token = "0x600E415"), Address(RVA = "0x477FA90", Offset = "0x477FA90", VA = "0x477FA90")] private set
      {
      }
    }

    [Token(Token = "0x600E416")]
    [Address(RVA = "0x477FA98", Offset = "0x477FA98", VA = "0x477FA98")]
    private void AddHealPoint(int value)
    {
    }

    [Token(Token = "0x170030DD")]
    public int PreEffectHealPoint
    {
      [Token(Token = "0x600E417"), Address(RVA = "0x477FAA8", Offset = "0x477FAA8", VA = "0x477FAA8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E418"), Address(RVA = "0x477FAB0", Offset = "0x477FAB0", VA = "0x477FAB0")] private set
      {
      }
    }

    [Token(Token = "0x600E419")]
    [Address(RVA = "0x477FAB8", Offset = "0x477FAB8", VA = "0x477FAB8")]
    private void AddPreEffectHealPoint(int value)
    {
    }

    [Token(Token = "0x170030DE")]
    public int PostEffectHealPoint
    {
      [Token(Token = "0x600E41A"), Address(RVA = "0x477FAC8", Offset = "0x477FAC8", VA = "0x477FAC8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E41B"), Address(RVA = "0x477FAD0", Offset = "0x477FAD0", VA = "0x477FAD0")] private set
      {
      }
    }

    [Token(Token = "0x600E41C")]
    [Address(RVA = "0x477FAD8", Offset = "0x477FAD8", VA = "0x477FAD8")]
    private void AddPostEffectHealPoint(int value)
    {
    }

    [Token(Token = "0x170030DF")]
    public int SupportEffectValue
    {
      [Token(Token = "0x600E41D"), Address(RVA = "0x477FAE8", Offset = "0x477FAE8", VA = "0x477FAE8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E41E"), Address(RVA = "0x477FAF0", Offset = "0x477FAF0", VA = "0x477FAF0")] private set
      {
      }
    }

    [Token(Token = "0x600E41F")]
    [Address(RVA = "0x477FAF8", Offset = "0x477FAF8", VA = "0x477FAF8")]
    private void AddSupportEffectValue(int value)
    {
    }

    [Token(Token = "0x170030E0")]
    public UnitParameterData SupportUnitParam
    {
      [Token(Token = "0x600E420"), Address(RVA = "0x477FB08", Offset = "0x477FB08", VA = "0x477FB08")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600E421"), Address(RVA = "0x477FB10", Offset = "0x477FB10", VA = "0x477FB10")] private set
      {
      }
    }

    [Token(Token = "0x170030E1")]
    public SkillCategoryTypeEnum ActivateSupportSkillType
    {
      [Token(Token = "0x600E422"), Address(RVA = "0x477FB18", Offset = "0x477FB18", VA = "0x477FB18")] get
      {
        return new SkillCategoryTypeEnum();
      }
      [Token(Token = "0x600E423"), Address(RVA = "0x477FB20", Offset = "0x477FB20", VA = "0x477FB20")] private set
      {
      }
    }

    [Token(Token = "0x170030E2")]
    public int ActivateSupportSkillRate
    {
      [Token(Token = "0x600E424"), Address(RVA = "0x477FB28", Offset = "0x477FB28", VA = "0x477FB28")] get
      {
        return new int();
      }
      [Token(Token = "0x600E425"), Address(RVA = "0x477FB30", Offset = "0x477FB30", VA = "0x477FB30")] private set
      {
      }
    }

    [Token(Token = "0x170030E3")]
    public SupportRankTypeEnum SupportRank
    {
      [Token(Token = "0x600E426"), Address(RVA = "0x477FB38", Offset = "0x477FB38", VA = "0x477FB38")] get
      {
        return new SupportRankTypeEnum();
      }
      [Token(Token = "0x600E427"), Address(RVA = "0x477FB40", Offset = "0x477FB40", VA = "0x477FB40")] private set
      {
      }
    }

    [Token(Token = "0x170030E4")]
    public bool HasSupporter
    {
      [Token(Token = "0x600E428"), Address(RVA = "0x477FB48", Offset = "0x477FB48", VA = "0x477FB48")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170030E5")]
    public bool HasBarrier
    {
      [Token(Token = "0x600E429"), Address(RVA = "0x477FB58", Offset = "0x477FB58", VA = "0x477FB58")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170030E6")]
    public int EnhanceResistPercentage
    {
      [Token(Token = "0x600E42A"), Address(RVA = "0x477FB68", Offset = "0x477FB68", VA = "0x477FB68")] get
      {
        return new int();
      }
      [Token(Token = "0x600E42B"), Address(RVA = "0x477FB70", Offset = "0x477FB70", VA = "0x477FB70")] private set
      {
      }
    }

    [Token(Token = "0x170030E7")]
    public int SpecificValue
    {
      [Token(Token = "0x600E42C"), Address(RVA = "0x477FB78", Offset = "0x477FB78", VA = "0x477FB78")] get
      {
        return new int();
      }
      [Token(Token = "0x600E42D"), Address(RVA = "0x477FB80", Offset = "0x477FB80", VA = "0x477FB80")] private set
      {
      }
    }

    [Token(Token = "0x170030E8")]
    private bool HasPositiveEffect
    {
      [Token(Token = "0x600E42E"), Address(RVA = "0x477FB88", Offset = "0x477FB88", VA = "0x477FB88")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170030E9")]
    private bool HasNegativeAffect
    {
      [Token(Token = "0x600E42F"), Address(RVA = "0x477FD74", Offset = "0x477FD74", VA = "0x477FD74")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170030EA")]
    public bool HasFirstStrikeSkill
    {
      [Token(Token = "0x600E430"), Address(RVA = "0x477FF60", Offset = "0x477FF60", VA = "0x477FF60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E431"), Address(RVA = "0x477FF68", Offset = "0x477FF68", VA = "0x477FF68")] private set
      {
      }
    }

    [Token(Token = "0x600E432")]
    [Address(RVA = "0x477FF74", Offset = "0x477FF74", VA = "0x477FF74")]
    public void SetFirstStrikeSkill(bool value)
    {
    }

    [Token(Token = "0x170030EB")]
    public bool HasPreDuelSkill
    {
      [Token(Token = "0x600E433"), Address(RVA = "0x477FF80", Offset = "0x477FF80", VA = "0x477FF80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E434")]
    [Address(RVA = "0x477FFC8", Offset = "0x477FFC8", VA = "0x477FFC8")]
    public PredictionUnitResult(
      List<ActionResult> actionResults,
      TargetPair targetPair,
      int supporterUnitId,
      List<int> activatableSkills,
      List<(int unitId, int index, BarrierDamageLogic logic)> barrierDamages,
      int useItemId = -1)
    {
    }

    [Token(Token = "0x600E435")]
    [Address(RVA = "0x4780AFC", Offset = "0x4780AFC", VA = "0x4780AFC")]
    private void SetEffectResult(
      ActionResult actionResult,
      TargetPair targetPair,
      int supporterUnitId,
      PredictionUnitResult.AddDamageValueDelegate addDamageValue,
      PredictionUnitResult.AddHealValueDelegate addHealValue)
    {
    }

    [Token(Token = "0x600E436")]
    [Address(RVA = "0x478131C", Offset = "0x478131C", VA = "0x478131C")]
    private void SetMainEffectResult(
      ActionResult actionResult,
      TargetPair targetPair,
      int supporterUnitId,
      int useItemId)
    {
    }

    [Token(Token = "0x600E437")]
    [Address(RVA = "0x4782700", Offset = "0x4782700", VA = "0x4782700")]
    public void SetSupportData(
      UnitParameterData supporter,
      SkillCategoryTypeEnum category,
      int skillRate,
      SupportRankTypeEnum rank)
    {
    }

    [Token(Token = "0x600E438")]
    [Address(RVA = "0x4782710", Offset = "0x4782710", VA = "0x4782710")]
    public void Reset()
    {
    }

    [Token(Token = "0x600E439")]
    [Address(RVA = "0x4782288", Offset = "0x4782288", VA = "0x4782288")]
    private void AddCureBadStatus(BattleBadStatusTypeEnum type, int applyRate)
    {
    }

    [Token(Token = "0x600E43A")]
    [Address(RVA = "0x4782188", Offset = "0x4782188", VA = "0x4782188")]
    private void AddDealBadStatus(BattleBadStatusTypeEnum type, int applyRate)
    {
    }

    [Token(Token = "0x600E43B")]
    [Address(RVA = "0x4782430", Offset = "0x4782430", VA = "0x4782430")]
    private void AddCureBuffDebuffEffect(ClearEffectData effect)
    {
    }

    [Token(Token = "0x600E43C")]
    [Address(RVA = "0x4782388", Offset = "0x4782388", VA = "0x4782388")]
    private void AddDealBuffDebuffEffect(ModifierEffectData effect)
    {
    }

    [Token(Token = "0x600E43D")]
    [Address(RVA = "0x47824D8", Offset = "0x47824D8", VA = "0x47824D8")]
    private void AddActivateSkillEffects(int id, BattleEffectTypeEnum effectType)
    {
    }

    [Token(Token = "0x600E43E")]
    [Address(RVA = "0x47828C8", Offset = "0x47828C8", VA = "0x47828C8")]
    public void SetEnhanceResistValue(
      UnitParameterData attacker,
      List<ActionResult> actionResults,
      UnitParameterData defender)
    {
    }

    [Token(Token = "0x600E43F")]
    [Address(RVA = "0x4782DC0", Offset = "0x4782DC0", VA = "0x4782DC0")]
    public void SetSpecificValue(UnitParameterData attacker, UnitParameterData defender)
    {
    }

    [Token(Token = "0x600E440")]
    [Address(RVA = "0x4782DE4", Offset = "0x4782DE4", VA = "0x4782DE4")]
    public void CopyEffectedValue(PredictionUnitResult src)
    {
    }

    [Token(Token = "0x600E441")]
    [Address(RVA = "0x4783018", Offset = "0x4783018", VA = "0x4783018")]
    public PredictionUnitResult.OpponentAffectViewType GetOpponentAffectViewType()
    {
      return new PredictionUnitResult.OpponentAffectViewType();
    }

    [Token(Token = "0x170030EC")]
    public bool IsPositive
    {
      [Token(Token = "0x600E442"), Address(RVA = "0x47831EC", Offset = "0x47831EC", VA = "0x47831EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170030ED")]
    public bool IsNegativeWithoutDamage
    {
      [Token(Token = "0x600E443"), Address(RVA = "0x4783208", Offset = "0x4783208", VA = "0x4783208")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E444")]
    [Address(RVA = "0x4783220", Offset = "0x4783220", VA = "0x4783220")]
    private List<PredictionUnitResult.EffectIcon> GetEffectIcons(
      PredictionUnitResult.EffectIcon.AffectTypeEnum affectType)
    {
      return (List<PredictionUnitResult.EffectIcon>) null;
    }

    [Token(Token = "0x600E445")]
    [Address(RVA = "0x4784108", Offset = "0x4784108", VA = "0x4784108")]
    public List<PredictionUnitResult.EffectIcon> GetChangeStateEffectIcons()
    {
      return (List<PredictionUnitResult.EffectIcon>) null;
    }

    [Token(Token = "0x20024F9")]
    public enum OpponentAffectViewType
    {
      [Token(Token = "0x4009ED7")] Damage,
      [Token(Token = "0x4009ED8")] Heal,
      [Token(Token = "0x4009ED9")] BuffOnly,
      [Token(Token = "0x4009EDA")] DebuffOnly,
    }

    [Token(Token = "0x20024FA")]
    public class EffectIcon
    {
      [Token(Token = "0x4009EDB")]
      [FieldOffset(Offset = "0x10")]
      public PredictionUnitResult.EffectIcon.IconCategory Category;
      [Token(Token = "0x4009EDC")]
      [FieldOffset(Offset = "0x14")]
      public PredictionUnitResult.EffectIcon.AffectTypeEnum AffectType;
      [Token(Token = "0x4009EDD")]
      [FieldOffset(Offset = "0x18")]
      public int TypeEnumInteger;
      [Token(Token = "0x4009EDE")]
      [FieldOffset(Offset = "0x1C")]
      public int Probability;

      [Token(Token = "0x170030EE")]
      public bool IsCureBadge
      {
        [Token(Token = "0x600E446"), Address(RVA = "0x47841C8", Offset = "0x47841C8", VA = "0x47841C8")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600E447")]
      [Address(RVA = "0x478421C", Offset = "0x478421C", VA = "0x478421C")]
      public EffectIcon(
        PredictionUnitResult.EffectIcon.IconCategory category,
        PredictionUnitResult.EffectIcon.AffectTypeEnum affectType,
        int typeEnumInteger,
        int probability = -1)
      {
      }

      [Token(Token = "0x20024FB")]
      public enum IconCategory
      {
        [Token(Token = "0x4009EE0")] BadStatus,
        [Token(Token = "0x4009EE1")] StatusUp,
        [Token(Token = "0x4009EE2")] StatusDown,
        [Token(Token = "0x4009EE3")] Buff,
        [Token(Token = "0x4009EE4")] Debuff,
      }

      [Token(Token = "0x20024FC")]
      public enum AffectTypeEnum
      {
        [Token(Token = "0x4009EE6")] Positive,
        [Token(Token = "0x4009EE7")] Negative,
      }
    }

    [Token(Token = "0x20024FD")]
    private delegate void AddDamageValueDelegate(int value);

    [Token(Token = "0x20024FE")]
    private delegate void AddHealValueDelegate(int value);

    [Token(Token = "0x20024FF")]
    private delegate void SetHitRateDelegate(int value);

    [Token(Token = "0x2002500")]
    private delegate void SetCriticalRateDelegate(int value);
  }
}
