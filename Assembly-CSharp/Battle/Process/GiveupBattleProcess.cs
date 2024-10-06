// Decompiled with JetBrains decompiler
// Type: Battle.Process.GiveupBattleProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200263B")]
  public sealed class GiveupBattleProcess : BattleProcessBase
  {
    [Token(Token = "0x400A443")]
    [FieldOffset(Offset = "0x24")]
    private GiveupBattleProcess.State state;
    [Token(Token = "0x400A444")]
    [FieldOffset(Offset = "0x28")]
    private bool apiCheck;

    [Token(Token = "0x600ECCD")]
    [Address(RVA = "0x448CA30", Offset = "0x448CA30", VA = "0x448CA30", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600ECCE")]
    [Address(RVA = "0x448CCC4", Offset = "0x448CCC4", VA = "0x448CCC4", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600ECCF")]
    [Address(RVA = "0x448D05C", Offset = "0x448D05C", VA = "0x448D05C")]
    private IEnumerator CallBattleRetreatAPI() => (IEnumerator) null;

    [Token(Token = "0x600ECD0")]
    [Address(RVA = "0x448CA20", Offset = "0x448CA20", VA = "0x448CA20")]
    public GiveupBattleProcess()
    {
    }

    [Token(Token = "0x200263C")]
    private enum State
    {
      [Token(Token = "0x400A446")] WebConnect,
      [Token(Token = "0x400A447")] Staging,
      [Token(Token = "0x400A448")] Finish,
    }
  }
}
