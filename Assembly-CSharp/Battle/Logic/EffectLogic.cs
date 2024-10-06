// Decompiled with JetBrains decompiler
// Type: Battle.Logic.EffectLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024D9")]
  public static class EffectLogic
  {
    [Token(Token = "0x600E2F0")]
    [Address(RVA = "0x401C020", Offset = "0x401C020", VA = "0x401C020")]
    public static void Apply(
      EffectData effect,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2F1")]
    [Address(RVA = "0x4021A7C", Offset = "0x4021A7C", VA = "0x4021A7C")]
    private static void ApplyActiveSkillDamageEffect(
      IDamageEffect damageEffect,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2F2")]
    [Address(RVA = "0x40240F0", Offset = "0x40240F0", VA = "0x40240F0")]
    private static List<IEffectValueCalculator> CollectTentativeDamageCalcs(
      IDamageEffect damageEffect,
      in EffectLogic.EffectLogicInputParam input,
      bool isCritical)
    {
      return (List<IEffectValueCalculator>) null;
    }

    [Token(Token = "0x600E2F3")]
    [Address(RVA = "0x4024DCC", Offset = "0x4024DCC", VA = "0x4024DCC")]
    private static IReadOnlyList<IEffectValueCalculator> CollectAfterTentativeDamageCalcs(
      int tentativeDamage,
      IDamageEffect damageEffect,
      in EffectLogic.EffectLogicInputParam input,
      out bool hasProtectionByBarrier)
    {
      return (IReadOnlyList<IEffectValueCalculator>) null;
    }

    [Token(Token = "0x600E2F4")]
    [Address(RVA = "0x4022488", Offset = "0x4022488", VA = "0x4022488")]
    private static void ApplyHealEffect(
      HealEffectData healEffect,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2F5")]
    [Address(RVA = "0x4022920", Offset = "0x4022920", VA = "0x4022920")]
    private static void AdditionalHeal(
      AdditionalHealEffectData additionalHeal,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2F6")]
    [Address(RVA = "0x40259C0", Offset = "0x40259C0", VA = "0x40259C0")]
    public static void ApplyRegenerationEffect(
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2F7")]
    [Address(RVA = "0x4022AF4", Offset = "0x4022AF4", VA = "0x4022AF4")]
    private static void ApplyEnchantBadStatus(
      EnchantBadStatusEffectData enchant,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2F8")]
    [Address(RVA = "0x4026158", Offset = "0x4026158", VA = "0x4026158")]
    private static EffectParameterData CreateBadStatusEffectParam(
      BadStatusEffectData badStatus,
      UnitParameterData activator,
      in EffectLogic.EffectLogicInputParam input)
    {
      return (EffectParameterData) null;
    }

    [Token(Token = "0x600E2F9")]
    [Address(RVA = "0x4022D50", Offset = "0x4022D50", VA = "0x4022D50")]
    private static void ApplyBarrierReviveEffect(
      BarrierReviveEffectData barrier,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2FA")]
    [Address(RVA = "0x4022F34", Offset = "0x4022F34", VA = "0x4022F34")]
    private static void ApplyClearBuffEffect(
      ClearEffectData clearBuff,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2FB")]
    [Address(RVA = "0x4023378", Offset = "0x4023378", VA = "0x4023378")]
    private static void ApplyClearBadStatus(
      ClearBadStatusEffectData clearBadStatus,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2FC")]
    [Address(RVA = "0x4023A54", Offset = "0x4023A54", VA = "0x4023A54")]
    private static void ApplyRecoverAction(
      ActionRecoveryEffectData recover,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2FD")]
    [Address(RVA = "0x4023BD8", Offset = "0x4023BD8", VA = "0x4023BD8")]
    private static void ApplyRecoverMove(
      MoveRecoveryEffectData recover,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E2FE")]
    [Address(RVA = "0x4024710", Offset = "0x4024710", VA = "0x4024710")]
    private static IReadOnlyList<IEffectValueCalculator> CollectStratagemDamageCalcs(
      StratagemDamageEffectData stratagemDamageEffect,
      out AlignmentStratagemSettingsData alignmentStratagemSettings,
      in EffectLogic.EffectLogicInputParam input)
    {
      return (IReadOnlyList<IEffectValueCalculator>) null;
    }

    [Token(Token = "0x600E2FF")]
    [Address(RVA = "0x4023DB4", Offset = "0x4023DB4", VA = "0x4023DB4")]
    private static void ApplyEffect(
      EffectData effect,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E300")]
    [Address(RVA = "0x4026014", Offset = "0x4026014", VA = "0x4026014")]
    private static bool LotBadStatus(
      EffectData effect,
      BoardData board,
      UnitParameterData from,
      UnitParameterData to)
    {
      return new bool();
    }

    [Token(Token = "0x600E301")]
    [Address(RVA = "0x40262B4", Offset = "0x40262B4", VA = "0x40262B4")]
    public static int CalcEnchantBadStatusChance(
      EnchantBadStatusEffectData effect,
      UnitParameterData from,
      UnitParameterData to)
    {
      return new int();
    }

    [Token(Token = "0x600E302")]
    [Address(RVA = "0x402639C", Offset = "0x402639C", VA = "0x402639C")]
    public static Decimal GetEnchantBadStatusEnhanceResistRate(
      BattleBadStatusTypeEnum badStatusType,
      UnitParameterData activator,
      UnitParameterData target)
    {
      return 0M;
    }

    [Token(Token = "0x600E303")]
    [Address(RVA = "0x4026480", Offset = "0x4026480", VA = "0x4026480")]
    public static int GetBadStatusEnhanceValue(
      BattleBadStatusTypeEnum badStatusType,
      UnitParameterData unit,
      WeaponParameterData weapon)
    {
      return new int();
    }

    [Token(Token = "0x600E304")]
    [Address(RVA = "0x40269A0", Offset = "0x40269A0", VA = "0x40269A0")]
    public static int GetBadStatusResistValue(
      BattleBadStatusTypeEnum badStatusType,
      UnitParameterData unit)
    {
      return new int();
    }

    [Token(Token = "0x600E305")]
    [Address(RVA = "0x4026D44", Offset = "0x4026D44", VA = "0x4026D44")]
    public static void ApplySystemEffect(
      BoardData board,
      UnitParameterData unit,
      int systemEffectId,
      out EffectData effect,
      out UnitParameterChange paramChange)
    {
    }

    [Token(Token = "0x600E306")]
    [Address(RVA = "0x4026E14", Offset = "0x4026E14", VA = "0x4026E14")]
    public static bool ApplyBadStatusDamage(
      BoardData board,
      BattleLogicConstData constData,
      UnitParameterData unit,
      out UnitParameterChange output)
    {
      return new bool();
    }

    [Token(Token = "0x600E307")]
    [Address(RVA = "0x401BAD8", Offset = "0x401BAD8", VA = "0x401BAD8")]
    public static (int, int, int)? GetReserveBarrierDamageBonus(
      UnitParameterData activator,
      TargetPair mainTargetPair,
      TargetPair targetPair,
      EffectData effect,
      AlignmentStratagemSettingsData alignmentStratagemSettings)
    {
      return new (int, int, int)?();
    }

    [Token(Token = "0x600E308")]
    [Address(RVA = "0x402383C", Offset = "0x402383C", VA = "0x402383C")]
    private static void ApplySkillStock(
      StockCounterEffectData stockCounter,
      in EffectLogic.EffectLogicInputParam input,
      out EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x20024DA")]
    public class EffectLogicInputParam
    {
      [Token(Token = "0x17003097")]
      public BoardData Board
      {
        [Token(Token = "0x600E309"), Address(RVA = "0x402742C", Offset = "0x402742C", VA = "0x402742C")] get
        {
          return (BoardData) null;
        }
        [Token(Token = "0x600E30A"), Address(RVA = "0x4027434", Offset = "0x4027434", VA = "0x4027434")] set
        {
        }
      }

      [Token(Token = "0x17003098")]
      public ITargettable Activator
      {
        [Token(Token = "0x600E30B"), Address(RVA = "0x402743C", Offset = "0x402743C", VA = "0x402743C")] get
        {
          return (ITargettable) null;
        }
        [Token(Token = "0x600E30C"), Address(RVA = "0x4027444", Offset = "0x4027444", VA = "0x4027444")] set
        {
        }
      }

      [Token(Token = "0x17003099")]
      public ICorrectableParameter<IBattleParameter> ActivatorBattleParam
      {
        [Token(Token = "0x600E30D"), Address(RVA = "0x402744C", Offset = "0x402744C", VA = "0x402744C")] get
        {
          return (ICorrectableParameter<IBattleParameter>) null;
        }
        [Token(Token = "0x600E30E"), Address(RVA = "0x4027454", Offset = "0x4027454", VA = "0x4027454")] set
        {
        }
      }

      [Token(Token = "0x1700309A")]
      public SkillParameterData AffectSkillParam
      {
        [Token(Token = "0x600E30F"), Address(RVA = "0x402745C", Offset = "0x402745C", VA = "0x402745C")] get
        {
          return (SkillParameterData) null;
        }
        [Token(Token = "0x600E310"), Address(RVA = "0x4027464", Offset = "0x4027464", VA = "0x4027464")] set
        {
        }
      }

      [Token(Token = "0x1700309B")]
      public Dictionary<EffectData, List<TargetPair>> EffectiveTargets
      {
        [Token(Token = "0x600E311"), Address(RVA = "0x402746C", Offset = "0x402746C", VA = "0x402746C")] get
        {
          return (Dictionary<EffectData, List<TargetPair>>) null;
        }
        [Token(Token = "0x600E312"), Address(RVA = "0x4027474", Offset = "0x4027474", VA = "0x4027474")] set
        {
        }
      }

      [Token(Token = "0x1700309C")]
      public ITargettable Target
      {
        [Token(Token = "0x600E313"), Address(RVA = "0x402747C", Offset = "0x402747C", VA = "0x402747C")] get
        {
          return (ITargettable) null;
        }
        [Token(Token = "0x600E314"), Address(RVA = "0x4027484", Offset = "0x4027484", VA = "0x4027484")] set
        {
        }
      }

      [Token(Token = "0x1700309D")]
      public ICorrectableParameter<IBattleParameter> TargetBattleParam
      {
        [Token(Token = "0x600E315"), Address(RVA = "0x402748C", Offset = "0x402748C", VA = "0x402748C")] get
        {
          return (ICorrectableParameter<IBattleParameter>) null;
        }
        [Token(Token = "0x600E316"), Address(RVA = "0x4027494", Offset = "0x4027494", VA = "0x4027494")] set
        {
        }
      }

      [Token(Token = "0x1700309E")]
      public List<EffectData> SupportGuardEffects
      {
        [Token(Token = "0x600E317"), Address(RVA = "0x402749C", Offset = "0x402749C", VA = "0x402749C")] get
        {
          return (List<EffectData>) null;
        }
        [Token(Token = "0x600E318"), Address(RVA = "0x40274A4", Offset = "0x40274A4", VA = "0x40274A4")] set
        {
        }
      }

      [Token(Token = "0x1700309F")]
      public ActionContext? Context
      {
        [Token(Token = "0x600E319"), Address(RVA = "0x40274AC", Offset = "0x40274AC", VA = "0x40274AC")] get
        {
          return new ActionContext?();
        }
        [Token(Token = "0x600E31A"), Address(RVA = "0x40274BC", Offset = "0x40274BC", VA = "0x40274BC")] set
        {
        }
      }

      [Token(Token = "0x170030A0")]
      public bool IsPutOperationEndure
      {
        [Token(Token = "0x600E31B"), Address(RVA = "0x40274D4", Offset = "0x40274D4", VA = "0x40274D4")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E31C"), Address(RVA = "0x40274DC", Offset = "0x40274DC", VA = "0x40274DC")] set
        {
        }
      }

      [Token(Token = "0x170030A1")]
      public bool IsDealBurned
      {
        [Token(Token = "0x600E31D"), Address(RVA = "0x40274E8", Offset = "0x40274E8", VA = "0x40274E8")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E31E"), Address(RVA = "0x40274F0", Offset = "0x40274F0", VA = "0x40274F0")] set
        {
        }
      }

      [Token(Token = "0x170030A2")]
      public int TotalEffectedDamage
      {
        [Token(Token = "0x600E31F"), Address(RVA = "0x40274FC", Offset = "0x40274FC", VA = "0x40274FC")] get
        {
          return new int();
        }
        [Token(Token = "0x600E320"), Address(RVA = "0x4027504", Offset = "0x4027504", VA = "0x4027504")] set
        {
        }
      }

      [Token(Token = "0x170030A3")]
      public ActiveSkillActionGroup DuelActionType
      {
        [Token(Token = "0x600E321"), Address(RVA = "0x402750C", Offset = "0x402750C", VA = "0x402750C")] get
        {
          return new ActiveSkillActionGroup();
        }
        [Token(Token = "0x600E322"), Address(RVA = "0x4027514", Offset = "0x4027514", VA = "0x4027514")] set
        {
        }
      }

      [Token(Token = "0x170030A4")]
      public EffectLogic.EffectLogicOption Option
      {
        [Token(Token = "0x600E323"), Address(RVA = "0x402751C", Offset = "0x402751C", VA = "0x402751C")] get
        {
          return (EffectLogic.EffectLogicOption) null;
        }
        [Token(Token = "0x600E324"), Address(RVA = "0x4027524", Offset = "0x4027524", VA = "0x4027524")] set
        {
        }
      }

      [Token(Token = "0x170030A5")]
      public BattleLogicConstData ConstData
      {
        [Token(Token = "0x600E325"), Address(RVA = "0x402752C", Offset = "0x402752C", VA = "0x402752C")] get
        {
          return (BattleLogicConstData) null;
        }
        [Token(Token = "0x600E326"), Address(RVA = "0x4027534", Offset = "0x4027534", VA = "0x4027534")] set
        {
        }
      }

      [Token(Token = "0x600E327")]
      [Address(RVA = "0x401BFB8", Offset = "0x401BFB8", VA = "0x401BFB8")]
      public EffectLogicInputParam()
      {
      }
    }

    [Token(Token = "0x20024DB")]
    public class EffectLogicOutputParam
    {
      [Token(Token = "0x4009E2E")]
      [FieldOffset(Offset = "0x38")]
      private List<SkillParameterData> triggeredSkills;
      [Token(Token = "0x4009E2F")]
      [FieldOffset(Offset = "0x40")]
      public AlignmentStratagemSettingsData AlignmentStratagemSettings;

      [Token(Token = "0x170030A6")]
      public ITargettable Activator
      {
        [Token(Token = "0x600E328"), Address(RVA = "0x4027544", Offset = "0x4027544", VA = "0x4027544")] get
        {
          return (ITargettable) null;
        }
        [Token(Token = "0x600E329"), Address(RVA = "0x402754C", Offset = "0x402754C", VA = "0x402754C")] private set
        {
        }
      }

      [Token(Token = "0x170030A7")]
      public ITargettable Target
      {
        [Token(Token = "0x600E32A"), Address(RVA = "0x4027554", Offset = "0x4027554", VA = "0x4027554")] get
        {
          return (ITargettable) null;
        }
        [Token(Token = "0x600E32B"), Address(RVA = "0x402755C", Offset = "0x402755C", VA = "0x402755C")] private set
        {
        }
      }

      [Token(Token = "0x170030A8")]
      public UnitParameterChange ActivatorParamChange
      {
        [Token(Token = "0x600E32C"), Address(RVA = "0x4027564", Offset = "0x4027564", VA = "0x4027564")] get
        {
          return (UnitParameterChange) null;
        }
        [Token(Token = "0x600E32D"), Address(RVA = "0x402756C", Offset = "0x402756C", VA = "0x402756C")] private set
        {
        }
      }

      [Token(Token = "0x170030A9")]
      public UnitParameterChange TargetParamChange
      {
        [Token(Token = "0x600E32E"), Address(RVA = "0x4027574", Offset = "0x4027574", VA = "0x4027574")] get
        {
          return (UnitParameterChange) null;
        }
        [Token(Token = "0x600E32F"), Address(RVA = "0x402757C", Offset = "0x402757C", VA = "0x402757C")] private set
        {
        }
      }

      [Token(Token = "0x170030AA")]
      public bool IsCritical
      {
        [Token(Token = "0x600E330"), Address(RVA = "0x4027584", Offset = "0x4027584", VA = "0x4027584")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E331"), Address(RVA = "0x402758C", Offset = "0x402758C", VA = "0x402758C")] private set
        {
        }
      }

      [Token(Token = "0x170030AB")]
      public bool IsDealBurned
      {
        [Token(Token = "0x600E332"), Address(RVA = "0x4027598", Offset = "0x4027598", VA = "0x4027598")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E333"), Address(RVA = "0x40275A0", Offset = "0x40275A0", VA = "0x40275A0")] private set
        {
        }
      }

      [Token(Token = "0x170030AC")]
      public bool HasResistByBarrier
      {
        [Token(Token = "0x600E334"), Address(RVA = "0x40275AC", Offset = "0x40275AC", VA = "0x40275AC")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E335"), Address(RVA = "0x40275B4", Offset = "0x40275B4", VA = "0x40275B4")] private set
        {
        }
      }

      [Token(Token = "0x170030AD")]
      public IReadOnlyList<SkillParameterData> TriggeredSkills
      {
        [Token(Token = "0x600E336"), Address(RVA = "0x40275C0", Offset = "0x40275C0", VA = "0x40275C0")] get
        {
          return (IReadOnlyList<SkillParameterData>) null;
        }
      }

      [Token(Token = "0x170030AE")]
      public bool IsModified
      {
        [Token(Token = "0x600E337"), Address(RVA = "0x40275C8", Offset = "0x40275C8", VA = "0x40275C8")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600E338")]
      [Address(RVA = "0x4025608", Offset = "0x4025608", VA = "0x4025608")]
      public EffectLogicOutputParam(
        ITargettable activator,
        ITargettable target,
        UnitParameterChange activatorParamChange,
        UnitParameterChange targetParamChange,
        IReadOnlyList<SkillParameterData> triggeredSkill,
        bool isCritical = false,
        bool hasResistByBarrier = false,
        AlignmentStratagemSettingsData alignmentStratagemSettings = null)
      {
      }
    }

    [Token(Token = "0x20024DD")]
    public class EffectLogicOption
    {
      [Token(Token = "0x4009E32")]
      [FieldOffset(Offset = "0x10")]
      public bool PredictionMode;

      [Token(Token = "0x170030AF")]
      public static EffectLogic.EffectLogicOption CreatePrediction
      {
        [Token(Token = "0x600E33C"), Address(RVA = "0x40276FC", Offset = "0x40276FC", VA = "0x40276FC")] get
        {
          return (EffectLogic.EffectLogicOption) null;
        }
      }

      [Token(Token = "0x600E33D")]
      [Address(RVA = "0x402753C", Offset = "0x402753C", VA = "0x402753C")]
      public EffectLogicOption()
      {
      }
    }
  }
}
