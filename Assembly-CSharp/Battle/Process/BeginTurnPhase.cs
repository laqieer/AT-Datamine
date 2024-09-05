// Decompiled with JetBrains decompiler
// Type: Battle.Process.BeginTurnPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002662")]
  public sealed class BeginTurnPhase : BattlePhaseBase
  {
    [Token(Token = "0x400A4AA")]
    [FieldOffset(Offset = "0x24")]
    private BeginTurnPhase.State state;

    [Token(Token = "0x600ED92")]
    [Address(RVA = "0x449D698", Offset = "0x449D698", VA = "0x449D698", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600ED93")]
    [Address(RVA = "0x449D6A8", Offset = "0x449D6A8", VA = "0x449D6A8", Slot = "15")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600ED94")]
    [Address(RVA = "0x449E0E4", Offset = "0x449E0E4", VA = "0x449E0E4", Slot = "11")]
    protected override void Finish(PhaseCode nextProcess)
    {
    }

    [Token(Token = "0x600ED95")]
    [Address(RVA = "0x449E088", Offset = "0x449E088", VA = "0x449E088")]
    private void ExecPassiveSkill()
    {
    }

    [Token(Token = "0x600ED96")]
    [Address(RVA = "0x449DF88", Offset = "0x449DF88", VA = "0x449DF88")]
    private void AddSecurityLog()
    {
    }

    [Token(Token = "0x600ED97")]
    [Address(RVA = "0x449D180", Offset = "0x449D180", VA = "0x449D180")]
    public BeginTurnPhase()
    {
    }

    [Token(Token = "0x2002663")]
    private enum State
    {
      [Token(Token = "0x400A4AC")] TurnCountUp,
      [Token(Token = "0x400A4AD")] SkillCooling,
      [Token(Token = "0x400A4AE")] SkillCharge,
      [Token(Token = "0x400A4AF")] PassiveSkill,
      [Token(Token = "0x400A4B0")] Exit,
    }
  }
}
