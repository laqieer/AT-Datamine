// Decompiled with JetBrains decompiler
// Type: Battle.Command.DuelCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Logic;
using Battle.Process;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024A9")]
  public class DuelCommand : SkillCommandBase
  {
    [Token(Token = "0x4009D30")]
    [FieldOffset(Offset = "0x128")]
    private Team atkTeam;
    [Token(Token = "0x4009D31")]
    [FieldOffset(Offset = "0x130")]
    private DuelLogicFluctuationParam atkFluctuation;
    [Token(Token = "0x4009D32")]
    [FieldOffset(Offset = "0x178")]
    private (UnitParameterData unit, SkillParameterData skill)? reservedAtkSupportHeal;
    [Token(Token = "0x4009D33")]
    [FieldOffset(Offset = "0x190")]
    private TargetPair defTargetPair;
    [Token(Token = "0x4009D34")]
    [FieldOffset(Offset = "0x198")]
    private DuelLogicFluctuationParam defFluctuation;
    [Token(Token = "0x4009D35")]
    [FieldOffset(Offset = "0x1E0")]
    private (UnitParameterData unit, SkillParameterData skill)? reservedDefSupportHeal;

    [Token(Token = "0x17003050")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E129"), Address(RVA = "0x4256C68", Offset = "0x4256C68", VA = "0x4256C68", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x17003051")]
    public bool DidReturnAttack
    {
      [Token(Token = "0x600E12A"), Address(RVA = "0x4256C70", Offset = "0x4256C70", VA = "0x4256C70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E12B"), Address(RVA = "0x4256C78", Offset = "0x4256C78", VA = "0x4256C78")] private set
      {
      }
    }

    [Token(Token = "0x600E12C")]
    [Address(RVA = "0x4256C84", Offset = "0x4256C84", VA = "0x4256C84")]
    public DuelCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData ownerGrid,
      TargetPair mainTarget,
      Dictionary<int, List<TargetPair>> targetsByEffect,
      AttackableAreaSearcher effectable,
      SkillParameterData skillParam)
    {
    }

    [Token(Token = "0x600E12D")]
    [Address(RVA = "0x425704C", Offset = "0x425704C", VA = "0x425704C", Slot = "5")]
    public override void Prepare()
    {
    }

    [Token(Token = "0x600E12E")]
    [Address(RVA = "0x4257850", Offset = "0x4257850", VA = "0x4257850", Slot = "15")]
    public override void RequestStaging()
    {
    }

    [Token(Token = "0x600E12F")]
    [Address(RVA = "0x4257B24", Offset = "0x4257B24", VA = "0x4257B24", Slot = "14")]
    protected override void ExecSkillEffect()
    {
    }

    [Token(Token = "0x600E130")]
    [Address(RVA = "0x4258AE8", Offset = "0x4258AE8", VA = "0x4258AE8", Slot = "13")]
    protected override void CreateDuelContext()
    {
    }

    [Token(Token = "0x600E131")]
    [Address(RVA = "0x4258460", Offset = "0x4258460", VA = "0x4258460")]
    private void ExecOnDuel()
    {
    }

    [Token(Token = "0x600E132")]
    [Address(RVA = "0x4258050", Offset = "0x4258050", VA = "0x4258050")]
    private void ExecPreDuel()
    {
    }

    [Token(Token = "0x600E133")]
    [Address(RVA = "0x4258738", Offset = "0x4258738", VA = "0x4258738")]
    private void ExecPostDuel()
    {
    }

    [Token(Token = "0x600E134")]
    [Address(RVA = "0x4259E10", Offset = "0x4259E10", VA = "0x4259E10")]
    private void CountUpSupport(DuelData duelData)
    {
    }

    [Token(Token = "0x600E135")]
    [Address(RVA = "0x425A2BC", Offset = "0x425A2BC", VA = "0x425A2BC", Slot = "16")]
    protected override SkillParameterData GetSecondAttackParam() => (SkillParameterData) null;

    [Token(Token = "0x600E136")]
    [Address(RVA = "0x42577B4", Offset = "0x42577B4", VA = "0x42577B4")]
    private void SolvePreDuel()
    {
    }

    [Token(Token = "0x600E137")]
    [Address(RVA = "0x4258A44", Offset = "0x4258A44", VA = "0x4258A44")]
    private void SolvePostDuel()
    {
    }

    [Token(Token = "0x600E138")]
    [Address(RVA = "0x425AAB4", Offset = "0x425AAB4", VA = "0x425AAB4")]
    private void ExecSupportHealEffect()
    {
    }

    [Token(Token = "0x600E139")]
    [Address(RVA = "0x425BA88", Offset = "0x425BA88", VA = "0x425BA88")]
    private ActionData CreateSupportHealAction(
      UnitParameterData supportUnit,
      EffectData effect,
      SkillParameterData supportSkill)
    {
      return (ActionData) null;
    }

    [Token(Token = "0x600E13A")]
    [Address(RVA = "0x425BBAC", Offset = "0x425BBAC", VA = "0x425BBAC")]
    private ActionTargetResultData CreateSupportHealActionResult(
      UnitParameterData support,
      UnitParameterData target,
      UnitParameterChange before,
      UnitParameterChange after)
    {
      return (ActionTargetResultData) null;
    }

    [Token(Token = "0x600E13B")]
    [Address(RVA = "0x425A184", Offset = "0x425A184", VA = "0x425A184")]
    private void CreateAfterDuelHpSequence()
    {
    }

    [Token(Token = "0x600E13C")]
    [Address(RVA = "0x4257D28", Offset = "0x4257D28", VA = "0x4257D28")]
    private void ShowFullDuelAnimationCheck()
    {
    }
  }
}
