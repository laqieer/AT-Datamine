// Decompiled with JetBrains decompiler
// Type: Battle.Staging.BreakWeaponSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Particle;
using Battle.Unit;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002573")]
  public sealed class BreakWeaponSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A0BA")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData unit;
    [Token(Token = "0x400A0BB")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor actor;
    [Token(Token = "0x400A0BC")]
    [FieldOffset(Offset = "0x28")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A0BD")]
    [FieldOffset(Offset = "0x30")]
    private ParticleEmitter.Handle handle;

    [Token(Token = "0x600E6ED")]
    [Address(RVA = "0x4872668", Offset = "0x4872668", VA = "0x4872668")]
    public static BreakWeaponSequence Create(
      UnitParameterData unit,
      CharacterActor actor,
      ParticleEmitter particleEmitterd)
    {
      return (BreakWeaponSequence) null;
    }

    [Token(Token = "0x17003181")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E6EE"), Address(RVA = "0x4879478", Offset = "0x4879478", VA = "0x4879478", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E6EF"), Address(RVA = "0x4879480", Offset = "0x4879480", VA = "0x4879480")] private set
      {
      }
    }

    [Token(Token = "0x600E6F0")]
    [Address(RVA = "0x48793E8", Offset = "0x48793E8", VA = "0x48793E8")]
    private BreakWeaponSequence(
      UnitParameterData unit,
      CharacterActor actor,
      ParticleEmitter particleEmitter)
    {
    }

    [Token(Token = "0x600E6F1")]
    [Address(RVA = "0x487948C", Offset = "0x487948C", VA = "0x487948C", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E6F2")]
    [Address(RVA = "0x48795B8", Offset = "0x48795B8", VA = "0x48795B8", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E6F3")]
    [Address(RVA = "0x48795BC", Offset = "0x48795BC", VA = "0x48795BC", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E6F4")]
    [Address(RVA = "0x4879648", Offset = "0x4879648", VA = "0x4879648", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E6F5")]
    [Address(RVA = "0x48796C8", Offset = "0x48796C8", VA = "0x48796C8")]
    private void OnEndParticle()
    {
    }
  }
}
