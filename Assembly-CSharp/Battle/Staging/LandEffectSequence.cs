// Decompiled with JetBrains decompiler
// Type: Battle.Staging.LandEffectSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Particle;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002589")]
  public sealed class LandEffectSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A157")]
    [FieldOffset(Offset = "0x10")]
    private GridData grid;
    [Token(Token = "0x400A158")]
    [FieldOffset(Offset = "0x18")]
    private int effectId;
    [Token(Token = "0x400A159")]
    [FieldOffset(Offset = "0x20")]
    private IDirector mainDirector;
    [Token(Token = "0x400A15B")]
    private const string PARTICLE_NAME_PREFIX = "";
    [Token(Token = "0x400A15C")]
    [FieldOffset(Offset = "0x30")]
    private ParticleEmitter.Handle handle;

    [Token(Token = "0x17003196")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E7A8"), Address(RVA = "0x4C37A88", Offset = "0x4C37A88", VA = "0x4C37A88", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E7A9"), Address(RVA = "0x4C37A90", Offset = "0x4C37A90", VA = "0x4C37A90")] private set
      {
      }
    }

    [Token(Token = "0x600E7AA")]
    [Address(RVA = "0x4C37A9C", Offset = "0x4C37A9C", VA = "0x4C37A9C")]
    private LandEffectSequence()
    {
    }

    [Token(Token = "0x600E7AB")]
    [Address(RVA = "0x4C37B04", Offset = "0x4C37B04", VA = "0x4C37B04")]
    public static StagingDirector.ISequence Create(
      GridData grid,
      int effectId,
      IDirector mainDirector)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E7AC")]
    [Address(RVA = "0x4C37B7C", Offset = "0x4C37B7C", VA = "0x4C37B7C", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E7AD")]
    [Address(RVA = "0x4C37F50", Offset = "0x4C37F50", VA = "0x4C37F50", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E7AE")]
    [Address(RVA = "0x4C37FD4", Offset = "0x4C37FD4", VA = "0x4C37FD4", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E7AF")]
    [Address(RVA = "0x4C37FE0", Offset = "0x4C37FE0", VA = "0x4C37FE0", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E7B0")]
    [Address(RVA = "0x4C37FE4", Offset = "0x4C37FE4", VA = "0x4C37FE4")]
    private void OnEndParticle()
    {
    }
  }
}
