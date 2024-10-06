// Decompiled with JetBrains decompiler
// Type: Battle.Staging.InitiateCommonSkillSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Particle;
using Battle.Unit;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002580")]
  public sealed class InitiateCommonSkillSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A11C")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData owner;
    [Token(Token = "0x400A11D")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor ownerActor;
    [Token(Token = "0x400A11E")]
    [FieldOffset(Offset = "0x28")]
    private bool isEnemy;
    [Token(Token = "0x400A11F")]
    [FieldOffset(Offset = "0x30")]
    private IDirector mainDirector;
    [Token(Token = "0x400A120")]
    [FieldOffset(Offset = "0x38")]
    private ParticleEmitter.Handle handle;
    [Token(Token = "0x400A121")]
    [FieldOffset(Offset = "0x48")]
    private SkillParameterData skill;
    [Token(Token = "0x400A122")]
    [FieldOffset(Offset = "0x50")]
    private Action onCompleted;

    [Token(Token = "0x600E766")]
    [Address(RVA = "0x487431C", Offset = "0x487431C", VA = "0x487431C")]
    public static InitiateCommonSkillSequence Create(
      UnitParameterData owner,
      CharacterActor ownerActor,
      bool isEnemy,
      IDirector mainDirector,
      SkillParameterData skill,
      Action onCompleted)
    {
      return (InitiateCommonSkillSequence) null;
    }

    [Token(Token = "0x1700318E")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E767"), Address(RVA = "0x487E5D0", Offset = "0x487E5D0", VA = "0x487E5D0", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E768"), Address(RVA = "0x487E5D8", Offset = "0x487E5D8", VA = "0x487E5D8")] private set
      {
      }
    }

    [Token(Token = "0x600E769")]
    [Address(RVA = "0x487E524", Offset = "0x487E524", VA = "0x487E524")]
    private InitiateCommonSkillSequence(
      UnitParameterData owner,
      CharacterActor ownerActor,
      bool isEnemy,
      IDirector mainDirecor,
      SkillParameterData skill,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E76A")]
    [Address(RVA = "0x487E5E4", Offset = "0x487E5E4", VA = "0x487E5E4", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E76B")]
    [Address(RVA = "0x487E8F0", Offset = "0x487E8F0", VA = "0x487E8F0", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E76C")]
    [Address(RVA = "0x487E9CC", Offset = "0x487E9CC", VA = "0x487E9CC", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E76D")]
    [Address(RVA = "0x487E9FC", Offset = "0x487E9FC", VA = "0x487E9FC", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E76E")]
    [Address(RVA = "0x487E5FC", Offset = "0x487E5FC", VA = "0x487E5FC")]
    private void ShowStartSkillVfx()
    {
    }

    [Token(Token = "0x600E76F")]
    [Address(RVA = "0x487E74C", Offset = "0x487E74C", VA = "0x487E74C")]
    private void PlayVoice()
    {
    }
  }
}
