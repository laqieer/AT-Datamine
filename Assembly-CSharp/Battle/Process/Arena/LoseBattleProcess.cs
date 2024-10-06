// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.LoseBattleProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026C7")]
  public sealed class LoseBattleProcess : SendResultProcess
  {
    [Token(Token = "0x400A618")]
    [FieldOffset(Offset = "0x24")]
    private LoseBattleProcess.State currentState;

    [Token(Token = "0x170032B6")]
    private ArenaBattleConfig config
    {
      [Token(Token = "0x600F00F"), Address(RVA = "0x40E3A08", Offset = "0x40E3A08", VA = "0x40E3A08")] get
      {
        return (ArenaBattleConfig) null;
      }
    }

    [Token(Token = "0x600F010")]
    [Address(RVA = "0x40E3A8C", Offset = "0x40E3A8C", VA = "0x40E3A8C", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600F011")]
    [Address(RVA = "0x40E3C4C", Offset = "0x40E3C4C", VA = "0x40E3C4C", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600F012")]
    [Address(RVA = "0x40DF364", Offset = "0x40DF364", VA = "0x40DF364")]
    public LoseBattleProcess()
    {
    }

    [Token(Token = "0x20026C8")]
    private enum State
    {
      [Token(Token = "0x400A61A")] StartConnection,
      [Token(Token = "0x400A61B")] WaitConnection,
      [Token(Token = "0x400A61C")] Staging,
      [Token(Token = "0x400A61D")] Finish,
    }
  }
}
