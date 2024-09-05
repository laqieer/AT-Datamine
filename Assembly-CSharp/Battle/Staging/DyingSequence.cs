// Decompiled with JetBrains decompiler
// Type: Battle.Staging.DyingSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Particle;
using Battle.UI;
using Battle.Unit;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200257A")]
  public sealed class DyingSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A0F8")]
    [FieldOffset(Offset = "0x10")]
    private UnitParameterData targetUnit;
    [Token(Token = "0x400A0F9")]
    [FieldOffset(Offset = "0x18")]
    private CharacterActor targetActor;
    [Token(Token = "0x400A0FA")]
    [FieldOffset(Offset = "0x20")]
    private PlayerPhaseEffector effector;
    [Token(Token = "0x400A0FB")]
    [FieldOffset(Offset = "0x28")]
    private IDirector mainDirector;
    [Token(Token = "0x400A0FC")]
    [FieldOffset(Offset = "0x30")]
    private FloatCurve alphaCurve;
    [Token(Token = "0x400A0FD")]
    [FieldOffset(Offset = "0x38")]
    private ParticleEmitter.Handle handle;
    [Token(Token = "0x400A0FE")]
    [FieldOffset(Offset = "0x48")]
    private Action onCompleted;

    [Token(Token = "0x17003187")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E732"), Address(RVA = "0x487BD74", Offset = "0x487BD74", VA = "0x487BD74", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E733"), Address(RVA = "0x487BD7C", Offset = "0x487BD7C", VA = "0x487BD7C")] private set
      {
      }
    }

    [Token(Token = "0x600E734")]
    [Address(RVA = "0x487BD88", Offset = "0x487BD88", VA = "0x487BD88")]
    private DyingSequence()
    {
    }

    [Token(Token = "0x600E735")]
    [Address(RVA = "0x487BE24", Offset = "0x487BE24", VA = "0x487BE24")]
    public static StagingDirector.ISequence Create(
      UnitParameterData targetUnit,
      PlayerPhaseEffector effector,
      IDirector mainDirector,
      Action onCompleted)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E736")]
    [Address(RVA = "0x487BF30", Offset = "0x487BF30", VA = "0x487BF30", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E737")]
    [Address(RVA = "0x487C354", Offset = "0x487C354", VA = "0x487C354", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E738")]
    [Address(RVA = "0x487C488", Offset = "0x487C488", VA = "0x487C488", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E739")]
    [Address(RVA = "0x487C788", Offset = "0x487C788", VA = "0x487C788", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E73A")]
    [Address(RVA = "0x487C8C4", Offset = "0x487C8C4", VA = "0x487C8C4")]
    private void OnEndParticle()
    {
    }
  }
}
