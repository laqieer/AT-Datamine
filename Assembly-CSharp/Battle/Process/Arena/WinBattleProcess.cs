// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.WinBattleProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026DD")]
  public sealed class WinBattleProcess : SendResultProcess
  {
    [Token(Token = "0x400A647")]
    [FieldOffset(Offset = "0x24")]
    private WinBattleProcess.State currentState;

    [Token(Token = "0x170032C0")]
    private ArenaBattleConfig config
    {
      [Token(Token = "0x600F071"), Address(RVA = "0x41A6EF8", Offset = "0x41A6EF8", VA = "0x41A6EF8")] get
      {
        return (ArenaBattleConfig) null;
      }
    }

    [Token(Token = "0x600F072")]
    [Address(RVA = "0x41A6F7C", Offset = "0x41A6F7C", VA = "0x41A6F7C", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600F073")]
    [Address(RVA = "0x41A7138", Offset = "0x41A7138", VA = "0x41A7138", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600F074")]
    [Address(RVA = "0x41A757C", Offset = "0x41A757C", VA = "0x41A757C")]
    public WinBattleProcess()
    {
    }

    [Token(Token = "0x20026DE")]
    private enum State
    {
      [Token(Token = "0x400A649")] StartConnection,
      [Token(Token = "0x400A64A")] WaitConnection,
      [Token(Token = "0x400A64B")] Staging,
      [Token(Token = "0x400A64C")] Finish,
    }
  }
}
