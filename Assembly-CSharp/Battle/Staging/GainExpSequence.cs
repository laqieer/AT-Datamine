// Decompiled with JetBrains decompiler
// Type: Battle.Staging.GainExpSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Process;
using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.StyleLevelUp;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025AC")]
  public class GainExpSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A204")]
    [FieldOffset(Offset = "0x10")]
    private IDirector mainDirector;
    [Token(Token = "0x400A205")]
    [FieldOffset(Offset = "0x18")]
    private BattleExpInfo frontInfo;
    [Token(Token = "0x400A206")]
    [FieldOffset(Offset = "0x20")]
    private BattleExpInfo backInfo;
    [Token(Token = "0x400A207")]
    [FieldOffset(Offset = "0x28")]
    private bool isShowLevelUpEffect;
    [Token(Token = "0x400A208")]
    [FieldOffset(Offset = "0x29")]
    private bool isFrontLevelUp;
    [Token(Token = "0x400A209")]
    [FieldOffset(Offset = "0x2A")]
    private bool isBackLevelUp;
    [Token(Token = "0x400A20A")]
    [FieldOffset(Offset = "0x30")]
    private Sprite frontSprite;
    [Token(Token = "0x400A20B")]
    [FieldOffset(Offset = "0x38")]
    private Sprite backSprite;
    [Token(Token = "0x400A20C")]
    [FieldOffset(Offset = "0x40")]
    private bool isLoadStart;
    [Token(Token = "0x400A20D")]
    [FieldOffset(Offset = "0x41")]
    private bool endGetExpEffect;
    [Token(Token = "0x400A20E")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400A20F")]
    [FieldOffset(Offset = "0x50")]
    private StyleLevelUpEffect styleLevelUpObject;
    [Token(Token = "0x400A210")]
    [FieldOffset(Offset = "0x58")]
    private Sprite styleSprite;
    [Token(Token = "0x400A212")]
    [FieldOffset(Offset = "0x64")]
    private GainExpSequence.State currentState;
    [Token(Token = "0x400A213")]
    [FieldOffset(Offset = "0x68")]
    private bool isBattleAuto;
    [Token(Token = "0x400A214")]
    [FieldOffset(Offset = "0x70")]
    private Coroutine autoNextCoroutine;
    [Token(Token = "0x400A215")]
    [FieldOffset(Offset = "0x78")]
    private bool isStartShowFront;
    [Token(Token = "0x400A216")]
    [FieldOffset(Offset = "0x79")]
    private bool isStartShowBack;
    [Token(Token = "0x400A217")]
    [FieldOffset(Offset = "0x7A")]
    private bool endLevelUpEffect;

    [Token(Token = "0x170031AA")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E89A"), Address(RVA = "0x4C42A68", Offset = "0x4C42A68", VA = "0x4C42A68", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E89B"), Address(RVA = "0x4C42A70", Offset = "0x4C42A70", VA = "0x4C42A70")] private set
      {
      }
    }

    [Token(Token = "0x600E89C")]
    [Address(RVA = "0x4C42A7C", Offset = "0x4C42A7C", VA = "0x4C42A7C")]
    private GainExpSequence()
    {
    }

    [Token(Token = "0x600E89D")]
    [Address(RVA = "0x4C42A84", Offset = "0x4C42A84", VA = "0x4C42A84")]
    public static GainExpSequence Create(
      IDirector director,
      BattleExpInfo frontInfo,
      BattleExpInfo backInfo,
      bool isFrontLevelUp,
      bool isBackLevelUp)
    {
      return (GainExpSequence) null;
    }

    [Token(Token = "0x600E89E")]
    [Address(RVA = "0x4C42B1C", Offset = "0x4C42B1C", VA = "0x4C42B1C", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E89F")]
    [Address(RVA = "0x4C431C8", Offset = "0x4C431C8", VA = "0x4C431C8", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E8A0")]
    [Address(RVA = "0x4C438C4", Offset = "0x4C438C4", VA = "0x4C438C4")]
    private IEnumerator ShowLevelUpEffect(
      Style style,
      IBasicParameter levelUp,
      int fromLevel,
      int toLevel,
      Action endAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600E8A1")]
    [Address(RVA = "0x4C4398C", Offset = "0x4C4398C", VA = "0x4C4398C")]
    private IEnumerator DelayActionCoroutine(float time, Action endAction) => (IEnumerator) null;

    [Token(Token = "0x600E8A2")]
    [Address(RVA = "0x4C43738", Offset = "0x4C43738", VA = "0x4C43738", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E8A3")]
    [Address(RVA = "0x4C43A2C", Offset = "0x4C43A2C", VA = "0x4C43A2C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E8A4")]
    [Address(RVA = "0x4C42DF0", Offset = "0x4C42DF0", VA = "0x4C42DF0")]
    private void InitializeStyleLevelUpEffect()
    {
    }

    [Token(Token = "0x600E8A5")]
    [Address(RVA = "0x4C43A30", Offset = "0x4C43A30", VA = "0x4C43A30")]
    private void LoadSprite(int styleId, bool isFront)
    {
    }

    [Token(Token = "0x600E8A6")]
    [Address(RVA = "0x4C43350", Offset = "0x4C43350", VA = "0x4C43350")]
    private void ShowStyleLevelUpEffect(BattleExpInfo lvInfo, Sprite sprite, Action finishAction)
    {
    }

    [Token(Token = "0x600E8A7")]
    [Address(RVA = "0x4C4422C", Offset = "0x4C4422C", VA = "0x4C4422C")]
    private void LevelUpEffectEndAction(Action finishAction)
    {
    }

    [Token(Token = "0x600E8A8")]
    [Address(RVA = "0x4C43B54", Offset = "0x4C43B54", VA = "0x4C43B54")]
    private IBasicParameter AddIBasicParameter(IBasicParameter a, IBasicParameter b)
    {
      return (IBasicParameter) null;
    }

    [Token(Token = "0x20025AD")]
    private enum State
    {
      [Token(Token = "0x400A219")] None,
      [Token(Token = "0x400A21A")] LoadStart,
      [Token(Token = "0x400A21B")] GetExpEffect,
      [Token(Token = "0x400A21C")] WaitLoad,
      [Token(Token = "0x400A21D")] Completed,
      [Token(Token = "0x400A21E")] ShowFront,
      [Token(Token = "0x400A21F")] ShowBack,
      [Token(Token = "0x400A220")] Finish,
    }
  }
}
