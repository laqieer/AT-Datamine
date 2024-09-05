// Decompiled with JetBrains decompiler
// Type: Battle.Process.EndTurnPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002664")]
  public sealed class EndTurnPhase : BattlePhaseBase
  {
    [Token(Token = "0x400A4B1")]
    [FieldOffset(Offset = "0x24")]
    private EndTurnPhase.State state;

    [Token(Token = "0x600ED98")]
    [Address(RVA = "0x449E180", Offset = "0x449E180", VA = "0x449E180", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600ED99")]
    [Address(RVA = "0x449E190", Offset = "0x449E190", VA = "0x449E190", Slot = "15")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600ED9A")]
    [Address(RVA = "0x449D1B0", Offset = "0x449D1B0", VA = "0x449D1B0")]
    public EndTurnPhase()
    {
    }

    [Token(Token = "0x2002665")]
    private enum State
    {
      [Token(Token = "0x400A4B3")] PassiveEnd,
      [Token(Token = "0x400A4B4")] WaitTurnCountUp,
      [Token(Token = "0x400A4B5")] Exit,
    }
  }
}
