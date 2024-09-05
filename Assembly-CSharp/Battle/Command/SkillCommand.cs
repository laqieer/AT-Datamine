// Decompiled with JetBrains decompiler
// Type: Battle.Command.SkillCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Logic;
using Battle.Process;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024B0")]
  public class SkillCommand : SkillCommandBase
  {
    [Token(Token = "0x4009D4F")]
    [FieldOffset(Offset = "0x120")]
    private bool anyHit;

    [Token(Token = "0x1700305B")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E17E"), Address(RVA = "0x425E858", Offset = "0x425E858", VA = "0x425E858", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x600E17F")]
    [Address(RVA = "0x425E888", Offset = "0x425E888", VA = "0x425E888")]
    public SkillCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData ownerGrid,
      TargetPair mainTarget,
      Dictionary<int, List<TargetPair>> targetsByEffect,
      AttackableAreaSearcher effectable,
      SkillParameterData skillParam)
    {
    }

    [Token(Token = "0x600E180")]
    [Address(RVA = "0x425E88C", Offset = "0x425E88C", VA = "0x425E88C", Slot = "5")]
    public override void Prepare()
    {
    }

    [Token(Token = "0x600E181")]
    [Address(RVA = "0x425EEB4", Offset = "0x425EEB4", VA = "0x425EEB4", Slot = "15")]
    public override void RequestStaging()
    {
    }

    [Token(Token = "0x600E182")]
    [Address(RVA = "0x425EF48", Offset = "0x425EF48", VA = "0x425EF48", Slot = "13")]
    protected override void CreateDuelContext()
    {
    }

    [Token(Token = "0x600E183")]
    [Address(RVA = "0x425F1F0", Offset = "0x425F1F0", VA = "0x425F1F0", Slot = "14")]
    protected override void ExecSkillEffect()
    {
    }

    [Token(Token = "0x600E184")]
    [Address(RVA = "0x425F540", Offset = "0x425F540", VA = "0x425F540")]
    private void ExecMainAction(Team atkTeam, TargetPair tarPair, bool isSimpleView)
    {
    }

    [Token(Token = "0x600E185")]
    [Address(RVA = "0x425F354", Offset = "0x425F354", VA = "0x425F354")]
    private void ExecPreAction(Team atkTeam, TargetPair tarPair)
    {
    }

    [Token(Token = "0x600E186")]
    [Address(RVA = "0x425F738", Offset = "0x425F738", VA = "0x425F738")]
    private void ExecPostAction(Team atkTeam, TargetPair tarPair)
    {
    }

    [Token(Token = "0x600E187")]
    [Address(RVA = "0x425FAFC", Offset = "0x425FAFC", VA = "0x425FAFC", Slot = "16")]
    protected override SkillParameterData GetSecondAttackParam() => (SkillParameterData) null;
  }
}
