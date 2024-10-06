// Decompiled with JetBrains decompiler
// Type: Battle.Staging.BattleAdvSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Process;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025A4")]
  public sealed class BattleAdvSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1E0")]
    [FieldOffset(Offset = "0x10")]
    private BattleAdvProcessor advProcess;
    [Token(Token = "0x400A1E1")]
    [FieldOffset(Offset = "0x18")]
    private BattleAdvData advData;
    [Token(Token = "0x400A1E2")]
    [FieldOffset(Offset = "0x20")]
    private Action completeAction;

    [Token(Token = "0x170031A5")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E871"), Address(RVA = "0x4C414BC", Offset = "0x4C414BC", VA = "0x4C414BC", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E872"), Address(RVA = "0x4C414C4", Offset = "0x4C414C4", VA = "0x4C414C4")] private set
      {
      }
    }

    [Token(Token = "0x600E873")]
    [Address(RVA = "0x4C414D0", Offset = "0x4C414D0", VA = "0x4C414D0")]
    private BattleAdvSequence()
    {
    }

    [Token(Token = "0x600E874")]
    [Address(RVA = "0x4C414D8", Offset = "0x4C414D8", VA = "0x4C414D8")]
    public static BattleAdvSequence Create(
      BattleAdvProcessor advProcessor,
      BattleAdvData advData,
      Action action = null)
    {
      return (BattleAdvSequence) null;
    }

    [Token(Token = "0x600E875")]
    [Address(RVA = "0x4C41550", Offset = "0x4C41550", VA = "0x4C41550", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E876")]
    [Address(RVA = "0x4C41640", Offset = "0x4C41640", VA = "0x4C41640", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E877")]
    [Address(RVA = "0x4C41610", Offset = "0x4C41610", VA = "0x4C41610", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E878")]
    [Address(RVA = "0x4C41644", Offset = "0x4C41644", VA = "0x4C41644", Slot = "6")]
    public void Abort()
    {
    }
  }
}
