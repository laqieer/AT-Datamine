// Decompiled with JetBrains decompiler
// Type: Battle.Staging.SingleSkillUniqueSequence
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
  [Token(Token = "0x200258C")]
  public sealed class SingleSkillUniqueSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A170")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData owner;
    [Token(Token = "0x400A171")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor ownerActor;
    [Token(Token = "0x400A172")]
    [FieldOffset(Offset = "0x28")]
    private GridObject castFrom;
    [Token(Token = "0x400A173")]
    [FieldOffset(Offset = "0x30")]
    private GridObject castTo;
    [Token(Token = "0x400A174")]
    [FieldOffset(Offset = "0x38")]
    private bool needMotion;
    [Token(Token = "0x400A175")]
    [FieldOffset(Offset = "0x40")]
    private SkillParameterData usingSkill;
    [Token(Token = "0x400A176")]
    [FieldOffset(Offset = "0x48")]
    private PlayableDirector castSkillEntity;
    [Token(Token = "0x400A177")]
    [FieldOffset(Offset = "0x50")]
    private bool hasStartedPlayingSkill;
    [Token(Token = "0x400A178")]
    [FieldOffset(Offset = "0x58")]
    private Action onCompleted;

    [Token(Token = "0x600E7C1")]
    [Address(RVA = "0x4C39538", Offset = "0x4C39538", VA = "0x4C39538")]
    public static StagingDirector.ISequence Create(
      UnitParameterData owner,
      CharacterActor ownerActor,
      GridObject castFrom,
      GridObject castTo,
      SkillParameterData usingSkill,
      bool needMotion,
      Action onCompleted)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x17003199")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E7C2"), Address(RVA = "0x4C39648", Offset = "0x4C39648", VA = "0x4C39648", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E7C3"), Address(RVA = "0x4C39650", Offset = "0x4C39650", VA = "0x4C39650")] private set
      {
      }
    }

    [Token(Token = "0x600E7C4")]
    [Address(RVA = "0x4C395E0", Offset = "0x4C395E0", VA = "0x4C395E0")]
    private SingleSkillUniqueSequence(
      UnitParameterData owner,
      CharacterActor ownerActor,
      GridObject castFrom,
      GridObject castTo,
      SkillParameterData usingSkill,
      bool needMotion,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E7C5")]
    [Address(RVA = "0x4C3965C", Offset = "0x4C3965C", VA = "0x4C3965C", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E7C6")]
    [Address(RVA = "0x4C39AF4", Offset = "0x4C39AF4", VA = "0x4C39AF4", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E7C7")]
    [Address(RVA = "0x4C39BA4", Offset = "0x4C39BA4", VA = "0x4C39BA4", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E7C8")]
    [Address(RVA = "0x4C39CEC", Offset = "0x4C39CEC", VA = "0x4C39CEC", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E7C9")]
    [Address(RVA = "0x4C39860", Offset = "0x4C39860", VA = "0x4C39860")]
    private void PlayMotion()
    {
    }

    [Token(Token = "0x600E7CA")]
    [Address(RVA = "0x4C39918", Offset = "0x4C39918", VA = "0x4C39918")]
    private void PlayCastSkill()
    {
    }

    [Token(Token = "0x600E7CB")]
    [Address(RVA = "0x4C39CF0", Offset = "0x4C39CF0", VA = "0x4C39CF0")]
    private void OnPlayedCastSkill(PlayableDirector obj)
    {
    }

    [Token(Token = "0x600E7CC")]
    [Address(RVA = "0x4C39CFC", Offset = "0x4C39CFC", VA = "0x4C39CFC")]
    private void OnStopCastSkill(PlayableDirector obj)
    {
    }

    [Token(Token = "0x600E7CD")]
    [Address(RVA = "0x4C39BD8", Offset = "0x4C39BD8", VA = "0x4C39BD8")]
    private void UnloadCastSkillEntity()
    {
    }
  }
}
