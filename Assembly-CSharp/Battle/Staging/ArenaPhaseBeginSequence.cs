// Decompiled with JetBrains decompiler
// Type: Battle.Staging.ArenaPhaseBeginSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025A2")]
  public class ArenaPhaseBeginSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1D9")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A1DA")]
    [FieldOffset(Offset = "0x20")]
    private ArenaPhaseBeginSequence.SequencePhase phaseStatus;

    [Token(Token = "0x170031A4")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E869"), Address(RVA = "0x4C41064", Offset = "0x4C41064", VA = "0x4C41064", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E86A"), Address(RVA = "0x4C4106C", Offset = "0x4C4106C", VA = "0x4C4106C")] private set
      {
      }
    }

    [Token(Token = "0x600E86B")]
    [Address(RVA = "0x4C41078", Offset = "0x4C41078", VA = "0x4C41078")]
    private ArenaPhaseBeginSequence()
    {
    }

    [Token(Token = "0x600E86C")]
    [Address(RVA = "0x4C41080", Offset = "0x4C41080", VA = "0x4C41080")]
    public static ArenaPhaseBeginSequence Create(IDirector mainDirector)
    {
      return (ArenaPhaseBeginSequence) null;
    }

    [Token(Token = "0x600E86D")]
    [Address(RVA = "0x4C410E4", Offset = "0x4C410E4", VA = "0x4C410E4", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E86E")]
    [Address(RVA = "0x4C411A8", Offset = "0x4C411A8", VA = "0x4C411A8", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E86F")]
    [Address(RVA = "0x4C413F4", Offset = "0x4C413F4", VA = "0x4C413F4", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E870")]
    [Address(RVA = "0x4C414B8", Offset = "0x4C414B8", VA = "0x4C414B8", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x20025A3")]
    public enum SequencePhase
    {
      [Token(Token = "0x400A1DC")] Initialize,
      [Token(Token = "0x400A1DD")] InitializeWait,
      [Token(Token = "0x400A1DE")] Play,
      [Token(Token = "0x400A1DF")] End,
    }
  }
}
