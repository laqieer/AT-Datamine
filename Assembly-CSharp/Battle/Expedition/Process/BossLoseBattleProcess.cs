// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.BossLoseBattleProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Process;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Battle.Expedition.Process
{
  [Token(Token = "0x20025E5")]
  public class BossLoseBattleProcess : BattleProcessBase
  {
    [Token(Token = "0x400A2E7")]
    [FieldOffset(Offset = "0x24")]
    private BossLoseBattleProcess.State currentState;

    [Token(Token = "0x600EA1E")]
    [Address(RVA = "0x4B8B90C", Offset = "0x4B8B90C", VA = "0x4B8B90C", Slot = "12")]
    public override void Dispose()
    {
    }

    [Token(Token = "0x600EA1F")]
    [Address(RVA = "0x4B8B910", Offset = "0x4B8B910", VA = "0x4B8B910", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EA20")]
    [Address(RVA = "0x4B8BA68", Offset = "0x4B8BA68", VA = "0x4B8BA68")]
    private IEnumerator GoResult() => (IEnumerator) null;

    [Token(Token = "0x600EA21")]
    [Address(RVA = "0x4B8AA08", Offset = "0x4B8AA08", VA = "0x4B8AA08")]
    public BossLoseBattleProcess()
    {
    }

    [Token(Token = "0x20025E6")]
    private enum State
    {
      [Token(Token = "0x400A2E9")] ChangeSubScene,
      [Token(Token = "0x400A2EA")] Wait,
    }
  }
}
