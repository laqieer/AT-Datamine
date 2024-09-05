// Decompiled with JetBrains decompiler
// Type: Battle.Staging.InitiateStratagemSkillSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Direction.Skill;
using Battle.Grid;
using Battle.Particle;
using Battle.UI;
using Battle.Unit;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002583")]
  public sealed class InitiateStratagemSkillSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A130")]
    [FieldOffset(Offset = "0x18")]
    private readonly UnitParameterData owner;
    [Token(Token = "0x400A131")]
    [FieldOffset(Offset = "0x20")]
    private readonly CharacterActor ownerActor;
    [Token(Token = "0x400A132")]
    [FieldOffset(Offset = "0x28")]
    private readonly IReadOnlyList<UnitParameterData> supporters;
    [Token(Token = "0x400A133")]
    [FieldOffset(Offset = "0x30")]
    private readonly BattlePlayerData battlePlayerData;
    [Token(Token = "0x400A134")]
    [FieldOffset(Offset = "0x38")]
    private readonly Transform cameraLocator;
    [Token(Token = "0x400A135")]
    [FieldOffset(Offset = "0x40")]
    private readonly IDirector mainDirector;
    [Token(Token = "0x400A136")]
    [FieldOffset(Offset = "0x48")]
    private readonly ParticleEmitter particleEmitter;
    [Token(Token = "0x400A137")]
    [FieldOffset(Offset = "0x50")]
    private readonly int mnemnographId;
    [Token(Token = "0x400A138")]
    [FieldOffset(Offset = "0x58")]
    private readonly string stratagemEffectType;
    [Token(Token = "0x400A139")]
    [FieldOffset(Offset = "0x60")]
    private readonly CameraDirector cameraDirector;
    [Token(Token = "0x400A13A")]
    [FieldOffset(Offset = "0x68")]
    private readonly UIManager uiManager;
    [Token(Token = "0x400A13B")]
    [FieldOffset(Offset = "0x70")]
    private MapDirectorBase mapDirector;
    [Token(Token = "0x400A13C")]
    [FieldOffset(Offset = "0x78")]
    private bool isUIMainCameraOperated;
    [Token(Token = "0x400A13D")]
    [FieldOffset(Offset = "0x80")]
    private readonly ISystemFlags systemFlags;
    [Token(Token = "0x400A13E")]
    [FieldOffset(Offset = "0x88")]
    private readonly Action onCompleted;
    [Token(Token = "0x400A13F")]
    [FieldOffset(Offset = "0x90")]
    private AlignmentStratagemDirection alignmentStratagemDirector;
    [Token(Token = "0x400A140")]
    [FieldOffset(Offset = "0x98")]
    private PlayableDirector stratagemDirector;
    [Token(Token = "0x400A141")]
    [FieldOffset(Offset = "0xA0")]
    private Texture mnemnographImage;
    [Token(Token = "0x400A142")]
    [FieldOffset(Offset = "0xA8")]
    private float deltaCount;
    [Token(Token = "0x400A143")]
    [FieldOffset(Offset = "0xAC")]
    private InitiateStratagemSkillSequence.DelayEventState delayEventState;
    [Token(Token = "0x400A144")]
    [FieldOffset(Offset = "0xB0")]
    private PlayableDirector playableDirectorObject;
    [Token(Token = "0x400A145")]
    [FieldOffset(Offset = "0xB8")]
    private InitiateStratagemSkillSequence.Phase phase;

    [Token(Token = "0x600E782")]
    [Address(RVA = "0x48741EC", Offset = "0x48741EC", VA = "0x48741EC")]
    public static InitiateStratagemSkillSequence Create(
      UnitParameterData owner,
      GridObject castFrom,
      IReadOnlyList<UnitParameterData> supporters,
      BattlePlayerData battlePlayerData,
      IDirector director,
      GameCore.MasterData.SkillData useSkillData,
      Action onCompleted)
    {
      return (InitiateStratagemSkillSequence) null;
    }

    [Token(Token = "0x17003191")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E783"), Address(RVA = "0x487F224", Offset = "0x487F224", VA = "0x487F224", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E784"), Address(RVA = "0x487F22C", Offset = "0x487F22C", VA = "0x487F22C")] private set
      {
      }
    }

    [Token(Token = "0x17003192")]
    private bool IsEnableAlignmentStratagem
    {
      [Token(Token = "0x600E785"), Address(RVA = "0x487F238", Offset = "0x487F238", VA = "0x487F238")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E786")]
    [Address(RVA = "0x487EEA0", Offset = "0x487EEA0", VA = "0x487EEA0")]
    private InitiateStratagemSkillSequence(
      UnitParameterData owner,
      GridObject castFrom,
      IReadOnlyList<UnitParameterData> supporters,
      BattlePlayerData battlePlayerData,
      IDirector mainDirector,
      GameCore.MasterData.SkillData useSkillData,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E787")]
    [Address(RVA = "0x487F2E8", Offset = "0x487F2E8", VA = "0x487F2E8", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E788")]
    [Address(RVA = "0x487F360", Offset = "0x487F360", VA = "0x487F360")]
    private IEnumerator Load() => (IEnumerator) null;

    [Token(Token = "0x600E789")]
    [Address(RVA = "0x487F3C8", Offset = "0x487F3C8", VA = "0x487F3C8")]
    private void PlayStratagemFieldEffect()
    {
    }

    [Token(Token = "0x600E78A")]
    [Address(RVA = "0x487F550", Offset = "0x487F550", VA = "0x487F550")]
    private void SetUpStratagemDirection()
    {
    }

    [Token(Token = "0x600E78B")]
    [Address(RVA = "0x487F654", Offset = "0x487F654", VA = "0x487F654", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E78C")]
    [Address(RVA = "0x487F8E0", Offset = "0x487F8E0", VA = "0x487F8E0", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E78D")]
    [Address(RVA = "0x487FC64", Offset = "0x487FC64", VA = "0x487FC64", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E78E")]
    [Address(RVA = "0x487F780", Offset = "0x487F780", VA = "0x487F780")]
    private void Finish(PlayableDirector obj = null)
    {
    }

    [Token(Token = "0x600E78F")]
    [Address(RVA = "0x487F578", Offset = "0x487F578", VA = "0x487F578")]
    private void PlayAlignmentStratagemDirection()
    {
    }

    [Token(Token = "0x600E790")]
    [Address(RVA = "0x487FC68", Offset = "0x487FC68", VA = "0x487FC68")]
    private void PlayAlignmentStratagemDirectionWaitTime(PlayableDirector obj = null)
    {
    }

    [Token(Token = "0x600E791")]
    [Address(RVA = "0x487FC94", Offset = "0x487FC94", VA = "0x487FC94")]
    private void PlaySingleStratagemDirection()
    {
    }

    [Token(Token = "0x600E792")]
    [Address(RVA = "0x487F650", Offset = "0x487F650", VA = "0x487F650")]
    private void SetUpSingleStratagemDirection(PlayableDirector obj = null)
    {
    }

    [Token(Token = "0x600E793")]
    [Address(RVA = "0x487FAB0", Offset = "0x487FAB0", VA = "0x487FAB0")]
    private void UnloadPlayerEntity()
    {
    }

    [Token(Token = "0x600E794")]
    [Address(RVA = "0x487FA48", Offset = "0x487FA48", VA = "0x487FA48")]
    private void RestorationUIMainCamera()
    {
    }

    [Token(Token = "0x600E795")]
    [Address(RVA = "0x487FDD8", Offset = "0x487FDD8", VA = "0x487FDD8")]
    private int GetIllustrationStyleResourceId(int styleId) => new int();

    [Token(Token = "0x2002584")]
    private enum DelayEventState
    {
      [Token(Token = "0x400A147")] Ready,
      [Token(Token = "0x400A148")] Wait,
      [Token(Token = "0x400A149")] Finish,
    }

    [Token(Token = "0x2002585")]
    private enum Phase
    {
      [Token(Token = "0x400A14B")] Initialize,
      [Token(Token = "0x400A14C")] LoadWait,
      [Token(Token = "0x400A14D")] Playing,
    }
  }
}
