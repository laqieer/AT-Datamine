// Decompiled with JetBrains decompiler
// Type: Battle.Process.PlayerPhaseEndStep
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002674")]
  public class PlayerPhaseEndStep : BattlePhaseStepBase
  {
    [Token(Token = "0x400A4FE")]
    [FieldOffset(Offset = "0x24")]
    protected PlayerPhaseEndStep.State state;

    [Token(Token = "0x600EE23")]
    [Address(RVA = "0x443DEE8", Offset = "0x443DEE8", VA = "0x443DEE8", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseStepCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600EE24")]
    [Address(RVA = "0x443DEF0", Offset = "0x443DEF0", VA = "0x443DEF0", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EE25")]
    [Address(RVA = "0x443E0C8", Offset = "0x443E0C8", VA = "0x443E0C8")]
    public PlayerPhaseEndStep()
    {
    }

    [Token(Token = "0x2002675")]
    protected enum State
    {
      [Token(Token = "0x400A500")] UpdateSkillEffectCount,
      [Token(Token = "0x400A501")] PassiveEnd,
      [Token(Token = "0x400A502")] Exit,
    }
  }
}
