// Decompiled with JetBrains decompiler
// Type: Battle.Staging.BattleWinSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025A9")]
  public class BattleWinSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1F6")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A1F7")]
    [FieldOffset(Offset = "0x20")]
    private BattlePlayerData winner;
    [Token(Token = "0x400A1F8")]
    [FieldOffset(Offset = "0x28")]
    private BattleWinSequence.SequencePhase phaseStatus;

    [Token(Token = "0x170031A8")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E88A"), Address(RVA = "0x4C42074", Offset = "0x4C42074", VA = "0x4C42074", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E88B"), Address(RVA = "0x4C4207C", Offset = "0x4C4207C", VA = "0x4C4207C")] private set
      {
      }
    }

    [Token(Token = "0x600E88C")]
    [Address(RVA = "0x4C42088", Offset = "0x4C42088", VA = "0x4C42088")]
    private BattleWinSequence()
    {
    }

    [Token(Token = "0x600E88D")]
    [Address(RVA = "0x4C42090", Offset = "0x4C42090", VA = "0x4C42090")]
    public static BattleWinSequence Create(IDirector mainDirector, BattlePlayerData winner)
    {
      return (BattleWinSequence) null;
    }

    [Token(Token = "0x600E88E")]
    [Address(RVA = "0x4C42100", Offset = "0x4C42100", VA = "0x4C42100", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E88F")]
    [Address(RVA = "0x4C4226C", Offset = "0x4C4226C", VA = "0x4C4226C", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E890")]
    [Address(RVA = "0x4C42644", Offset = "0x4C42644", VA = "0x4C42644", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E891")]
    [Address(RVA = "0x4C42710", Offset = "0x4C42710", VA = "0x4C42710", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x20025AA")]
    public enum SequencePhase
    {
      [Token(Token = "0x400A1FA")] Initialize,
      [Token(Token = "0x400A1FB")] InitializeWait,
      [Token(Token = "0x400A1FC")] Play,
      [Token(Token = "0x400A1FD")] End,
    }
  }
}
