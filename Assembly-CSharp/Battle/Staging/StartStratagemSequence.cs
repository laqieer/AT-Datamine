// Decompiled with JetBrains decompiler
// Type: Battle.Staging.StartStratagemSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Grid;
using Battle.Unit;
using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200258E")]
  public sealed class StartStratagemSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A184")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData owner;
    [Token(Token = "0x400A185")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor ownerActor;
    [Token(Token = "0x400A186")]
    [FieldOffset(Offset = "0x28")]
    private GridObject castFrom;
    [Token(Token = "0x400A187")]
    [FieldOffset(Offset = "0x30")]
    private GridObject castTo;
    [Token(Token = "0x400A188")]
    [FieldOffset(Offset = "0x38")]
    private SkillParameterData usingSkill;
    [Token(Token = "0x400A189")]
    [FieldOffset(Offset = "0x40")]
    private PlayableDirector castSkillEntity;
    [Token(Token = "0x400A18A")]
    [FieldOffset(Offset = "0x48")]
    private bool hasStartedPlayingSkill;
    [Token(Token = "0x400A18B")]
    [FieldOffset(Offset = "0x50")]
    private Action onCompleted;
    [Token(Token = "0x400A18C")]
    [FieldOffset(Offset = "0x58")]
    private IDirector mainDirector;

    [Token(Token = "0x600E7D8")]
    [Address(RVA = "0x4C3A678", Offset = "0x4C3A678", VA = "0x4C3A678")]
    public static StartStratagemSequence Create(
      UnitParameterData owner,
      CharacterActor ownerActor,
      GridObject castFrom,
      GridObject castTo,
      SkillParameterData usingSkill,
      IDirector mainDirector,
      Action onCompleted)
    {
      return (StartStratagemSequence) null;
    }

    [Token(Token = "0x1700319B")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E7D9"), Address(RVA = "0x4C3A77C", Offset = "0x4C3A77C", VA = "0x4C3A77C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E7DA"), Address(RVA = "0x4C3A784", Offset = "0x4C3A784", VA = "0x4C3A784")] private set
      {
      }
    }

    [Token(Token = "0x600E7DB")]
    [Address(RVA = "0x4C3A718", Offset = "0x4C3A718", VA = "0x4C3A718")]
    private StartStratagemSequence(
      UnitParameterData owner,
      CharacterActor ownerActor,
      GridObject castFrom,
      GridObject castTo,
      SkillParameterData usingSkill,
      IDirector mainDirector,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E7DC")]
    [Address(RVA = "0x4C3A790", Offset = "0x4C3A790", VA = "0x4C3A790", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E7DD")]
    [Address(RVA = "0x4C3AE90", Offset = "0x4C3AE90", VA = "0x4C3AE90", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E7DE")]
    [Address(RVA = "0x4C3AF2C", Offset = "0x4C3AF2C", VA = "0x4C3AF2C", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E7DF")]
    [Address(RVA = "0x4C3B02C", Offset = "0x4C3B02C", VA = "0x4C3B02C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E7E0")]
    [Address(RVA = "0x4C3AB38", Offset = "0x4C3AB38", VA = "0x4C3AB38")]
    private void PlayMotion()
    {
    }

    [Token(Token = "0x600E7E1")]
    [Address(RVA = "0x4C3ABF0", Offset = "0x4C3ABF0", VA = "0x4C3ABF0")]
    private void PlayCastSkill()
    {
    }

    [Token(Token = "0x600E7E2")]
    [Address(RVA = "0x4C3B030", Offset = "0x4C3B030", VA = "0x4C3B030")]
    private void OnPlayedCastSkill(PlayableDirector obj)
    {
    }

    [Token(Token = "0x600E7E3")]
    [Address(RVA = "0x4C3B03C", Offset = "0x4C3B03C", VA = "0x4C3B03C")]
    private void OnStopCastSkill(PlayableDirector obj)
    {
    }

    [Token(Token = "0x600E7E4")]
    [Address(RVA = "0x4C3AF88", Offset = "0x4C3AF88", VA = "0x4C3AF88")]
    private void UnloadCastSkillEntity()
    {
    }

    [Token(Token = "0x600E7E5")]
    [Address(RVA = "0x4C3ADD4", Offset = "0x4C3ADD4", VA = "0x4C3ADD4")]
    private void PlayVoice()
    {
    }
  }
}
