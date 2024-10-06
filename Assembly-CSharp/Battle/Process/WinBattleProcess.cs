// Decompiled with JetBrains decompiler
// Type: Battle.Process.WinBattleProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026BA")]
  public sealed class WinBattleProcess : BattleProcessBase
  {
    [Token(Token = "0x400A604")]
    [FieldOffset(Offset = "0x24")]
    private WinBattleProcess.State currentState;

    [Token(Token = "0x600EFD7")]
    [Address(RVA = "0x40DEE0C", Offset = "0x40DEE0C", VA = "0x40DEE0C", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600EFD8")]
    [Address(RVA = "0x40DEEB0", Offset = "0x40DEEB0", VA = "0x40DEEB0", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EFD9")]
    [Address(RVA = "0x40DF1DC", Offset = "0x40DF1DC", VA = "0x40DF1DC")]
    public WinBattleProcess()
    {
    }

    [Token(Token = "0x20026BB")]
    private enum State
    {
      [Token(Token = "0x400A606")] BattleAdv,
      [Token(Token = "0x400A607")] Staging,
      [Token(Token = "0x400A608")] Finish,
    }
  }
}
