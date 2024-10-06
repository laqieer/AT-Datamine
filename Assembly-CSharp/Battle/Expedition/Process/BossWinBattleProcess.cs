// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.BossWinBattleProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Process;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Battle.Expedition.Process
{
  [Token(Token = "0x20025EE")]
  public class BossWinBattleProcess : BattleProcessBase
  {
    [Token(Token = "0x400A2FF")]
    [FieldOffset(Offset = "0x24")]
    private BossWinBattleProcess.State currentState;

    [Token(Token = "0x600EA42")]
    [Address(RVA = "0x4B8F7D0", Offset = "0x4B8F7D0", VA = "0x4B8F7D0", Slot = "12")]
    public override void Dispose()
    {
    }

    [Token(Token = "0x600EA43")]
    [Address(RVA = "0x4B8F7D4", Offset = "0x4B8F7D4", VA = "0x4B8F7D4", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EA44")]
    [Address(RVA = "0x4B8F92C", Offset = "0x4B8F92C", VA = "0x4B8F92C")]
    private IEnumerator GoResult() => (IEnumerator) null;

    [Token(Token = "0x600EA45")]
    [Address(RVA = "0x4B8AA00", Offset = "0x4B8AA00", VA = "0x4B8AA00")]
    public BossWinBattleProcess()
    {
    }

    [Token(Token = "0x20025EF")]
    private enum State
    {
      [Token(Token = "0x400A301")] ChangeSubScene,
      [Token(Token = "0x400A302")] Wait,
    }
  }
}
