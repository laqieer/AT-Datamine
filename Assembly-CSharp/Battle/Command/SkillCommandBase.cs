// Decompiled with JetBrains decompiler
// Type: Battle.Command.SkillCommandBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Logic;
using Battle.Process;
using Battle.RouteSearch;
using Battle.Staging;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024B2")]
  public abstract class SkillCommandBase : UnitCommandBase, IKillableCommand
  {
    [Token(Token = "0x4009D5B")]
    [FieldOffset(Offset = "0x70")]
    protected HashSet<UnitParameterData> killedUnits;
    [Token(Token = "0x4009D5C")]
    [FieldOffset(Offset = "0x78")]
    private AttackableAreaSearcher effectiveArea;
    [Token(Token = "0x4009D5D")]
    [FieldOffset(Offset = "0x80")]
    protected Dictionary<SkillTriggerTimingTypeEnum, List<StagingDirector.ISequence>> triggeredSkillSequenceDic;
    [Token(Token = "0x4009D5E")]
    [FieldOffset(Offset = "0x88")]
    public List<ActionResult> GeneratedActionResult;
    [Token(Token = "0x4009D62")]
    [FieldOffset(Offset = "0xA8")]
    protected List<(int unitId, int index, BarrierDamageLogic logic)> barrierDamages;
    [Token(Token = "0x4009D63")]
    [FieldOffset(Offset = "0xB0")]
    protected ActionContext duelContext;
    [Token(Token = "0x4009D64")]
    [FieldOffset(Offset = "0x118")]
    protected Queue<Duel> duelQueue;

    [Token(Token = "0x1700305C")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E18E"), Address(RVA = "0x425FBD8", Offset = "0x425FBD8", VA = "0x425FBD8", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x1700305D")]
    public GridData OwnerGrid
    {
      [Token(Token = "0x600E18F"), Address(RVA = "0x425FC08", Offset = "0x425FC08", VA = "0x425FC08")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600E190"), Address(RVA = "0x425FC10", Offset = "0x425FC10", VA = "0x425FC10")] private set
      {
      }
    }

    [Token(Token = "0x1700305E")]
    public TargetPair MainTarget
    {
      [Token(Token = "0x600E191"), Address(RVA = "0x425FC18", Offset = "0x425FC18", VA = "0x425FC18")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E192"), Address(RVA = "0x425FC20", Offset = "0x425FC20", VA = "0x425FC20")] private set
      {
      }
    }

    [Token(Token = "0x1700305F")]
    private Dictionary<int, List<TargetPair>> TargetsByEffect
    {
      [Token(Token = "0x600E193"), Address(RVA = "0x425FC28", Offset = "0x425FC28", VA = "0x425FC28")] get
      {
        return (Dictionary<int, List<TargetPair>>) null;
      }
      [Token(Token = "0x600E194"), Address(RVA = "0x425FC30", Offset = "0x425FC30", VA = "0x425FC30")] set
      {
      }
    }

    [Token(Token = "0x17003060")]
    public HashSet<TargetPair> Targets
    {
      [Token(Token = "0x600E195"), Address(RVA = "0x425FC38", Offset = "0x425FC38", VA = "0x425FC38")] get
      {
        return (HashSet<TargetPair>) null;
      }
      [Token(Token = "0x600E196"), Address(RVA = "0x425FC40", Offset = "0x425FC40", VA = "0x425FC40")] private set
      {
      }
    }

    [Token(Token = "0x17003061")]
    public SkillParameterData UsingSkillParam
    {
      [Token(Token = "0x600E197"), Address(RVA = "0x425FC48", Offset = "0x425FC48", VA = "0x425FC48")] get
      {
        return (SkillParameterData) null;
      }
      [Token(Token = "0x600E198"), Address(RVA = "0x425FC50", Offset = "0x425FC50", VA = "0x425FC50")] protected set
      {
      }
    }

    [Token(Token = "0x17003062")]
    public WeaponParameterData UsingWeapon
    {
      [Token(Token = "0x600E199"), Address(RVA = "0x425FC58", Offset = "0x425FC58", VA = "0x425FC58")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600E19A"), Address(RVA = "0x425FC60", Offset = "0x425FC60", VA = "0x425FC60")] protected set
      {
      }
    }

    [Token(Token = "0x17003063")]
    public List<UnitParameterData> KilledUnits
    {
      [Token(Token = "0x600E19B"), Address(RVA = "0x425FC68", Offset = "0x425FC68", VA = "0x425FC68", Slot = "11")] get
      {
        return (List<UnitParameterData>) null;
      }
    }

    [Token(Token = "0x17003064")]
    public ActionResult OnDuelResult
    {
      [Token(Token = "0x600E19C"), Address(RVA = "0x425FCB0", Offset = "0x425FCB0", VA = "0x425FCB0")] get
      {
        return (ActionResult) null;
      }
      [Token(Token = "0x600E19D"), Address(RVA = "0x425FCB8", Offset = "0x425FCB8", VA = "0x425FCB8")] protected set
      {
      }
    }

    [Token(Token = "0x17003065")]
    public ActionResult PreDuelResult
    {
      [Token(Token = "0x600E19E"), Address(RVA = "0x425FCC0", Offset = "0x425FCC0", VA = "0x425FCC0")] get
      {
        return (ActionResult) null;
      }
      [Token(Token = "0x600E19F"), Address(RVA = "0x425FCC8", Offset = "0x425FCC8", VA = "0x425FCC8")] protected set
      {
      }
    }

    [Token(Token = "0x17003066")]
    public ActionResult PostDuelResult
    {
      [Token(Token = "0x600E1A0"), Address(RVA = "0x425FCD0", Offset = "0x425FCD0", VA = "0x425FCD0")] get
      {
        return (ActionResult) null;
      }
      [Token(Token = "0x600E1A1"), Address(RVA = "0x425FCD8", Offset = "0x425FCD8", VA = "0x425FCD8")] protected set
      {
      }
    }

    [Token(Token = "0x600E1A2")]
    [Address(RVA = "0x4256C88", Offset = "0x4256C88", VA = "0x4256C88")]
    protected SkillCommandBase(
      BattleCore core,
      UnitParameterData ownerUnit,
      GridData ownerGrid,
      TargetPair mainTarget,
      Dictionary<int, List<TargetPair>> targetsByEffect,
      AttackableAreaSearcher effectable,
      SkillParameterData skillParam)
    {
    }

    [Token(Token = "0x600E1A3")]
    [Address(RVA = "0x425FCE0", Offset = "0x425FCE0", VA = "0x425FCE0", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E1A4")]
    [Address(RVA = "0x425FD90", Offset = "0x425FD90", VA = "0x425FD90", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E1A5")]
    [Address(RVA = "0x4260134", Offset = "0x4260134", VA = "0x4260134", Slot = "12")]
    protected virtual void Consume()
    {
    }

    [Token(Token = "0x600E1A6")]
    [Address(RVA = "0x4260058", Offset = "0x4260058", VA = "0x4260058")]
    protected void MarkAttackUnit()
    {
    }

    [Token(Token = "0x600E1A7")]
    [Address(RVA = "0x4260150", Offset = "0x4260150", VA = "0x4260150", Slot = "9")]
    protected override void CanceledInternal()
    {
    }

    [Token(Token = "0x600E1A8")]
    [Address(RVA = "0x4260198", Offset = "0x4260198", VA = "0x4260198", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E1A9")]
    protected abstract void CreateDuelContext();

    [Token(Token = "0x600E1AA")]
    protected abstract void ExecSkillEffect();

    [Token(Token = "0x600E1AB")]
    [Address(RVA = "0x4257EF0", Offset = "0x4257EF0", VA = "0x4257EF0")]
    protected void SetupSkillAwakeEffect()
    {
    }

    [Token(Token = "0x600E1AC")]
    [Address(RVA = "0x4258270", Offset = "0x4258270", VA = "0x4258270")]
    protected void SetupUniqueEffect(bool isSimpleView)
    {
    }

    [Token(Token = "0x600E1AD")]
    [Address(RVA = "0x42578FC", Offset = "0x42578FC", VA = "0x42578FC")]
    protected void RequestTriggerSkillStaging(SkillTriggerTimingTypeEnum timing)
    {
    }

    [Token(Token = "0x600E1AE")]
    public abstract void RequestStaging();

    [Token(Token = "0x600E1AF")]
    [Address(RVA = "0x4258958", Offset = "0x4258958", VA = "0x4258958")]
    protected void UpdateSkillEffectCount(EffectiveLengthTypeEnum length)
    {
    }

    [Token(Token = "0x600E1B0")]
    [Address(RVA = "0x425A8DC", Offset = "0x425A8DC", VA = "0x425A8DC")]
    protected void SwitchPassiveSkill(SkillTriggerTimingTypeEnum timing)
    {
    }

    [Token(Token = "0x600E1B1")]
    [Address(RVA = "0x425AA18", Offset = "0x425AA18", VA = "0x425AA18")]
    protected void DeactivePassiveSkill(SkillTriggerTimingTypeEnum timing)
    {
    }

    [Token(Token = "0x600E1B2")]
    [Address(RVA = "0x425A4F0", Offset = "0x425A4F0", VA = "0x425A4F0")]
    protected void IgnitionTriggerSkill(
      SkillTriggerTimingTypeEnum timing,
      SkillCommandBase.CreateConditionParamDelegate conditionParamDelegate)
    {
    }

    [Token(Token = "0x600E1B3")]
    [Address(RVA = "0x4261808", Offset = "0x4261808", VA = "0x4261808")]
    protected void IgnitionTriggerSkill(
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData activator,
      UnitParameterData target,
      SkillCommandBase.CreateConditionParamDelegate conditionParamDelegate,
      ref SkillLogic.EffectedTriggerSkillContainer container)
    {
    }

    [Token(Token = "0x600E1B4")]
    [Address(RVA = "0x42618B8", Offset = "0x42618B8", VA = "0x42618B8")]
    protected void AddTriggeredEffectSequence(
      SkillTriggerTimingTypeEnum timing,
      StagingDirector.ISequence seq)
    {
    }

    [Token(Token = "0x600E1B5")]
    [Address(RVA = "0x4261A0C", Offset = "0x4261A0C", VA = "0x4261A0C")]
    protected void RemoveBrokenWeaponSkill()
    {
    }

    [Token(Token = "0x600E1B6")]
    [Address(RVA = "0x4261D2C", Offset = "0x4261D2C", VA = "0x4261D2C")]
    protected void RemoveUntilTakeDamageEffect()
    {
    }

    [Token(Token = "0x600E1B7")]
    [Address(RVA = "0x4257718", Offset = "0x4257718", VA = "0x4257718")]
    protected void SolvePreActiveSkill()
    {
    }

    [Token(Token = "0x600E1B8")]
    [Address(RVA = "0x42606F8", Offset = "0x42606F8", VA = "0x42606F8")]
    private void SolvePostActiveSkill()
    {
    }

    [Token(Token = "0x600E1B9")]
    [Address(RVA = "0x4259990", Offset = "0x4259990", VA = "0x4259990")]
    protected void CollectKilledUnit(ActionResult result)
    {
    }

    [Token(Token = "0x600E1BA")]
    [Address(RVA = "0x42599EC", Offset = "0x42599EC", VA = "0x42599EC")]
    protected void CollectBarrierDamage(ActionResult result)
    {
    }

    [Token(Token = "0x600E1BB")]
    [Address(RVA = "0x4260D10", Offset = "0x4260D10", VA = "0x4260D10")]
    private void CollectDealtDamage(ActionResult actionResult)
    {
    }

    [Token(Token = "0x600E1BC")]
    [Address(RVA = "0x4262234", Offset = "0x4262234", VA = "0x4262234")]
    public BarrierDamageLogic GetBarrierDamageLogic(int unit, int index)
    {
      return (BarrierDamageLogic) null;
    }

    [Token(Token = "0x600E1BD")]
    protected abstract SkillParameterData GetSecondAttackParam();

    [Token(Token = "0x600E1BE")]
    [Address(RVA = "0x4261574", Offset = "0x4261574", VA = "0x4261574")]
    protected ConditionParam CreateConditionParams(
      UnitParameterData triggerSkillActivator,
      UnitParameterData target)
    {
      return (ConditionParam) null;
    }

    [Token(Token = "0x20024B3")]
    public delegate ConditionParam CreateConditionParamDelegate(
      UnitParameterData triggerSkillActivator,
      UnitParameterData target);
  }
}
