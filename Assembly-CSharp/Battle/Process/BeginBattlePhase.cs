// Decompiled with JetBrains decompiler
// Type: Battle.Process.BeginBattlePhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200265F")]
  public class BeginBattlePhase : BattlePhaseBase
  {
    [Token(Token = "0x400A4A3")]
    [FieldOffset(Offset = "0x24")]
    protected BeginBattlePhase.State state;

    [Token(Token = "0x600ED8C")]
    [Address(RVA = "0x449D2D8", Offset = "0x449D2D8", VA = "0x449D2D8", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600ED8D")]
    [Address(RVA = "0x449D318", Offset = "0x449D318", VA = "0x449D318", Slot = "15")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600ED8E")]
    [Address(RVA = "0x449D3E8", Offset = "0x449D3E8", VA = "0x449D3E8", Slot = "16")]
    protected virtual void SetupStartStaging()
    {
    }

    [Token(Token = "0x600ED8F")]
    [Address(RVA = "0x449D178", Offset = "0x449D178", VA = "0x449D178")]
    public BeginBattlePhase()
    {
    }

    [Token(Token = "0x2002660")]
    protected enum State
    {
      [Token(Token = "0x400A4A5")] Staging,
      [Token(Token = "0x400A4A6")] PassiveSkill,
      [Token(Token = "0x400A4A7")] BattleAdv,
      [Token(Token = "0x400A4A8")] Exit,
    }
  }
}
