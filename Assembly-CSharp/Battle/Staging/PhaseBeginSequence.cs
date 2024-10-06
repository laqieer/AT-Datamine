// Decompiled with JetBrains decompiler
// Type: Battle.Staging.PhaseBeginSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025B4")]
  public class PhaseBeginSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A238")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A239")]
    [FieldOffset(Offset = "0x20")]
    private BattlePlayerData player;
    [Token(Token = "0x400A23A")]
    [FieldOffset(Offset = "0x28")]
    private PhaseBeginSequence.SequencePhase phaseStatus;

    [Token(Token = "0x170031B0")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E8CA"), Address(RVA = "0x4C450E8", Offset = "0x4C450E8", VA = "0x4C450E8", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8CB"), Address(RVA = "0x4C450F0", Offset = "0x4C450F0", VA = "0x4C450F0")] private set
      {
      }
    }

    [Token(Token = "0x600E8CC")]
    [Address(RVA = "0x4C450FC", Offset = "0x4C450FC", VA = "0x4C450FC")]
    private PhaseBeginSequence()
    {
    }

    [Token(Token = "0x600E8CD")]
    [Address(RVA = "0x4C45104", Offset = "0x4C45104", VA = "0x4C45104")]
    public static PhaseBeginSequence Create(IDirector mainDirector, BattlePlayerData player)
    {
      return (PhaseBeginSequence) null;
    }

    [Token(Token = "0x600E8CE")]
    [Address(RVA = "0x4C45174", Offset = "0x4C45174", VA = "0x4C45174", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E8CF")]
    [Address(RVA = "0x4C454A8", Offset = "0x4C454A8", VA = "0x4C454A8", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E8D0")]
    [Address(RVA = "0x4C457BC", Offset = "0x4C457BC", VA = "0x4C457BC", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E8D1")]
    [Address(RVA = "0x4C4590C", Offset = "0x4C4590C", VA = "0x4C4590C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x20025B5")]
    public enum SequencePhase
    {
      [Token(Token = "0x400A23C")] Initialize,
      [Token(Token = "0x400A23D")] InitializeWait,
      [Token(Token = "0x400A23E")] Play,
      [Token(Token = "0x400A23F")] End,
    }
  }
}
