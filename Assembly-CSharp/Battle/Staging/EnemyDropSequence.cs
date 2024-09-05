// Decompiled with JetBrains decompiler
// Type: Battle.Staging.EnemyDropSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Particle;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200257D")]
  public sealed class EnemyDropSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A106")]
    [FieldOffset(Offset = "0x10")]
    private UnitParameterData targetUnit;
    [Token(Token = "0x400A107")]
    [FieldOffset(Offset = "0x18")]
    private BattleConfigData battleConfig;
    [Token(Token = "0x400A108")]
    [FieldOffset(Offset = "0x20")]
    private IDirector mainDirector;
    [Token(Token = "0x400A109")]
    [FieldOffset(Offset = "0x28")]
    private ParticleEmitter.Handle handle;
    [Token(Token = "0x400A10A")]
    [FieldOffset(Offset = "0x38")]
    private Action onCompleted;

    [Token(Token = "0x17003189")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E746"), Address(RVA = "0x487D2F8", Offset = "0x487D2F8", VA = "0x487D2F8", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E747"), Address(RVA = "0x487D300", Offset = "0x487D300", VA = "0x487D300")] private set
      {
      }
    }

    [Token(Token = "0x600E748")]
    [Address(RVA = "0x487D30C", Offset = "0x487D30C", VA = "0x487D30C")]
    public static StagingDirector.ISequence Create(
      UnitParameterData targetUnit,
      IDirector mainDirector,
      BattleConfigData battleConfig,
      Action onCompleted)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E749")]
    [Address(RVA = "0x487D3F8", Offset = "0x487D3F8", VA = "0x487D3F8", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E74A")]
    [Address(RVA = "0x487D410", Offset = "0x487D410", VA = "0x487D410", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E74B")]
    [Address(RVA = "0x487D404", Offset = "0x487D404", VA = "0x487D404", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E74C")]
    [Address(RVA = "0x487D414", Offset = "0x487D414", VA = "0x487D414", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E74D")]
    [Address(RVA = "0x487D4D0", Offset = "0x487D4D0", VA = "0x487D4D0")]
    private void OnEndParticle()
    {
    }

    [Token(Token = "0x600E74E")]
    [Address(RVA = "0x487D390", Offset = "0x487D390", VA = "0x487D390")]
    public EnemyDropSequence()
    {
    }
  }
}
