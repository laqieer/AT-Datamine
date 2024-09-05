// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.ReadyProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026D2")]
  public sealed class ReadyProcess : BattleProcessBase
  {
    [Token(Token = "0x400A631")]
    [FieldOffset(Offset = "0x24")]
    private ReadyProcess.State state;

    [Token(Token = "0x600F042")]
    [Address(RVA = "0x40EAAF0", Offset = "0x40EAAF0", VA = "0x40EAAF0", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600F043")]
    [Address(RVA = "0x40EAAF8", Offset = "0x40EAAF8", VA = "0x40EAAF8", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600F044")]
    [Address(RVA = "0x40DF354", Offset = "0x40DF354", VA = "0x40DF354")]
    public ReadyProcess()
    {
    }

    [Token(Token = "0x20026D3")]
    private enum State
    {
      [Token(Token = "0x400A633")] Init,
      [Token(Token = "0x400A634")] Finish,
    }
  }
}
