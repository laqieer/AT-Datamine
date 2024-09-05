// Decompiled with JetBrains decompiler
// Type: Battle.Staging.TakenBadStatusSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Particle;
using Battle.Unit;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002598")]
  public sealed class TakenBadStatusSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1AA")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData target;
    [Token(Token = "0x400A1AB")]
    [FieldOffset(Offset = "0x20")]
    private IDirector mainDirector;
    [Token(Token = "0x400A1AC")]
    [FieldOffset(Offset = "0x28")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A1AD")]
    [FieldOffset(Offset = "0x30")]
    private ActorDirector actorDirector;
    [Token(Token = "0x400A1AE")]
    [FieldOffset(Offset = "0x38")]
    private BattleBadStatusData takenBadStatus;
    [Token(Token = "0x400A1AF")]
    [FieldOffset(Offset = "0x40")]
    private ParticleEmitter.Handle particleHandle;
    [Token(Token = "0x400A1B0")]
    [FieldOffset(Offset = "0x50")]
    private CharacterActor targetActor;
    [Token(Token = "0x400A1B1")]
    [FieldOffset(Offset = "0x58")]
    private Action onCompleted;

    [Token(Token = "0x600E81E")]
    [Address(RVA = "0x4C3E1DC", Offset = "0x4C3E1DC", VA = "0x4C3E1DC")]
    public static TakenBadStatusSequence Create(
      UnitParameterData target,
      BattleBadStatusData takenBadStatus,
      IDirector mainDirector,
      Action onCompleted)
    {
      return (TakenBadStatusSequence) null;
    }

    [Token(Token = "0x600E81F")]
    [Address(RVA = "0x4C3E30C", Offset = "0x4C3E30C", VA = "0x4C3E30C")]
    public static TakenBadStatusSequence Create(
      UnitParameterData target,
      BattleBadStatusData takenBadStatus,
      IDirector mainDirector,
      ParticleEmitter particleEmitter,
      ActorDirector actorDirector,
      Action onCompleted)
    {
      return (TakenBadStatusSequence) null;
    }

    [Token(Token = "0x1700319D")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E820"), Address(RVA = "0x4C3E470", Offset = "0x4C3E470", VA = "0x4C3E470", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E821"), Address(RVA = "0x4C3E478", Offset = "0x4C3E478", VA = "0x4C3E478")] private set
      {
      }
    }

    [Token(Token = "0x600E822")]
    [Address(RVA = "0x4C3E3AC", Offset = "0x4C3E3AC", VA = "0x4C3E3AC")]
    private TakenBadStatusSequence(
      UnitParameterData target,
      BattleBadStatusData takenBadStatus,
      IDirector mainDirector,
      ParticleEmitter particleEmitter,
      ActorDirector actorDirector,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E823")]
    [Address(RVA = "0x4C3E484", Offset = "0x4C3E484", VA = "0x4C3E484", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E824")]
    [Address(RVA = "0x4C3E688", Offset = "0x4C3E688", VA = "0x4C3E688", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E825")]
    [Address(RVA = "0x4C3E6C0", Offset = "0x4C3E6C0", VA = "0x4C3E6C0", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E826")]
    [Address(RVA = "0x4C3E81C", Offset = "0x4C3E81C", VA = "0x4C3E81C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E827")]
    [Address(RVA = "0x4C3E488", Offset = "0x4C3E488", VA = "0x4C3E488")]
    private void ShowRaiseEffect()
    {
    }
  }
}
