// Decompiled with JetBrains decompiler
// Type: Battle.Staging.BattleBeginSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025A5")]
  public class BattleBeginSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1E5")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A1E6")]
    [FieldOffset(Offset = "0x20")]
    private BattleBeginSequence.SequencePhase phaseStatus;

    [Token(Token = "0x170031A6")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E879"), Address(RVA = "0x4C41648", Offset = "0x4C41648", VA = "0x4C41648", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E87A"), Address(RVA = "0x4C41650", Offset = "0x4C41650", VA = "0x4C41650")] private set
      {
      }
    }

    [Token(Token = "0x600E87B")]
    [Address(RVA = "0x4C4165C", Offset = "0x4C4165C", VA = "0x4C4165C")]
    private BattleBeginSequence()
    {
    }

    [Token(Token = "0x600E87C")]
    [Address(RVA = "0x4C41664", Offset = "0x4C41664", VA = "0x4C41664")]
    public static BattleBeginSequence Create(IDirector mainDirector) => (BattleBeginSequence) null;

    [Token(Token = "0x600E87D")]
    [Address(RVA = "0x4C416C8", Offset = "0x4C416C8", VA = "0x4C416C8", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E87E")]
    [Address(RVA = "0x4C4178C", Offset = "0x4C4178C", VA = "0x4C4178C", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E87F")]
    [Address(RVA = "0x4C41A48", Offset = "0x4C41A48", VA = "0x4C41A48", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E880")]
    [Address(RVA = "0x4C41B0C", Offset = "0x4C41B0C", VA = "0x4C41B0C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x20025A6")]
    public enum SequencePhase
    {
      [Token(Token = "0x400A1E8")] Initialize,
      [Token(Token = "0x400A1E9")] InitializeWait,
      [Token(Token = "0x400A1EA")] Play,
      [Token(Token = "0x400A1EB")] End,
    }
  }
}
