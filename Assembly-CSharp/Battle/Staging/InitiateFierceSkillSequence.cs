// Decompiled with JetBrains decompiler
// Type: Battle.Staging.InitiateFierceSkillSequence
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
  [Token(Token = "0x2002581")]
  public sealed class InitiateFierceSkillSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A124")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData owner;
    [Token(Token = "0x400A125")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor ownerActor;
    [Token(Token = "0x400A126")]
    [FieldOffset(Offset = "0x28")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A127")]
    [FieldOffset(Offset = "0x30")]
    private ParticleEmitter.Handle handle;
    [Token(Token = "0x400A128")]
    [FieldOffset(Offset = "0x40")]
    private Action onCompleted;

    [Token(Token = "0x600E770")]
    [Address(RVA = "0x4874294", Offset = "0x4874294", VA = "0x4874294")]
    public static InitiateFierceSkillSequence Create(
      UnitParameterData owner,
      CharacterActor ownerActor,
      IDirector mainDirector,
      Action onCompleted)
    {
      return (InitiateFierceSkillSequence) null;
    }

    [Token(Token = "0x1700318F")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E771"), Address(RVA = "0x487EB10", Offset = "0x487EB10", VA = "0x487EB10", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E772"), Address(RVA = "0x487EB18", Offset = "0x487EB18", VA = "0x487EB18")] private set
      {
      }
    }

    [Token(Token = "0x600E773")]
    [Address(RVA = "0x487EA00", Offset = "0x487EA00", VA = "0x487EA00")]
    private InitiateFierceSkillSequence(
      UnitParameterData owner,
      CharacterActor ownerActor,
      IDirector mainDirecor,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E774")]
    [Address(RVA = "0x487EB24", Offset = "0x487EB24", VA = "0x487EB24", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E775")]
    [Address(RVA = "0x487EBD0", Offset = "0x487EBD0", VA = "0x487EBD0", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E776")]
    [Address(RVA = "0x487EC1C", Offset = "0x487EC1C", VA = "0x487EC1C", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E777")]
    [Address(RVA = "0x487EC4C", Offset = "0x487EC4C", VA = "0x487EC4C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E778")]
    [Address(RVA = "0x487EB28", Offset = "0x487EB28", VA = "0x487EB28")]
    private void ShowStartSkillVfx()
    {
    }
  }
}
