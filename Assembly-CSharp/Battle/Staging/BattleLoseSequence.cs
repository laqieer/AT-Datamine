// Decompiled with JetBrains decompiler
// Type: Battle.Staging.BattleLoseSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025A7")]
  public class BattleLoseSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1ED")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A1EE")]
    [FieldOffset(Offset = "0x20")]
    private BattlePlayerData loser;
    [Token(Token = "0x400A1EF")]
    [FieldOffset(Offset = "0x28")]
    private BattleLoseSequence.SequencePhase phaseStatus;

    [Token(Token = "0x170031A7")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E882"), Address(RVA = "0x4C41BC4", Offset = "0x4C41BC4", VA = "0x4C41BC4", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E883"), Address(RVA = "0x4C41BCC", Offset = "0x4C41BCC", VA = "0x4C41BCC")] private set
      {
      }
    }

    [Token(Token = "0x600E884")]
    [Address(RVA = "0x4C41BD8", Offset = "0x4C41BD8", VA = "0x4C41BD8")]
    private BattleLoseSequence()
    {
    }

    [Token(Token = "0x600E885")]
    [Address(RVA = "0x4C41BE0", Offset = "0x4C41BE0", VA = "0x4C41BE0")]
    public static BattleLoseSequence Create(IDirector mainDirector, BattlePlayerData loser)
    {
      return (BattleLoseSequence) null;
    }

    [Token(Token = "0x600E886")]
    [Address(RVA = "0x4C41C50", Offset = "0x4C41C50", VA = "0x4C41C50", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E887")]
    [Address(RVA = "0x4C41DBC", Offset = "0x4C41DBC", VA = "0x4C41DBC", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E888")]
    [Address(RVA = "0x4C41FA4", Offset = "0x4C41FA4", VA = "0x4C41FA4", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E889")]
    [Address(RVA = "0x4C42070", Offset = "0x4C42070", VA = "0x4C42070", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x20025A8")]
    public enum SequencePhase
    {
      [Token(Token = "0x400A1F1")] Initialize,
      [Token(Token = "0x400A1F2")] InitializeWait,
      [Token(Token = "0x400A1F3")] Play,
      [Token(Token = "0x400A1F4")] End,
    }
  }
}
