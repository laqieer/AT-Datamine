// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleAdvProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002681")]
  public class BattleAdvProcessor
  {
    [Token(Token = "0x400A53F")]
    [FieldOffset(Offset = "0x10")]
    private BoardData boardData;
    [Token(Token = "0x400A540")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A541")]
    [FieldOffset(Offset = "0x20")]
    private MonoBehaviour coroutineOwner;

    [Token(Token = "0x17003291")]
    public bool IsPlayingAdv
    {
      [Token(Token = "0x600EE64"), Address(RVA = "0x4446920", Offset = "0x4446920", VA = "0x4446920")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EE65"), Address(RVA = "0x4446928", Offset = "0x4446928", VA = "0x4446928")] private set
      {
      }
    }

    [Token(Token = "0x600EE66")]
    [Address(RVA = "0x4446934", Offset = "0x4446934", VA = "0x4446934")]
    private BattleAdvProcessor()
    {
    }

    [Token(Token = "0x600EE67")]
    [Address(RVA = "0x444693C", Offset = "0x444693C", VA = "0x444693C")]
    public BattleAdvProcessor(
      BoardData board,
      IDirector mainDirector,
      MonoBehaviour coroutineOwner)
    {
    }

    [Token(Token = "0x600EE68")]
    [Address(RVA = "0x4446978", Offset = "0x4446978", VA = "0x4446978")]
    public void ApplyBoard(BoardData board)
    {
    }

    [Token(Token = "0x600EE69")]
    [Address(RVA = "0x4446980", Offset = "0x4446980", VA = "0x4446980")]
    public void ReservePlayableAdv(BattleEventTimingTypeEnum timing)
    {
    }

    [Token(Token = "0x600EE6A")]
    [Address(RVA = "0x44469A4", Offset = "0x44469A4", VA = "0x44469A4")]
    public void ReservePlayableAdv(
      BattleEventTimingTypeEnum timing,
      UnitParameterData actionOwner,
      IReadOnlyList<UnitParameterData> actionTargets,
      SkillParameterData useSkill)
    {
    }

    [Token(Token = "0x600EE6B")]
    [Address(RVA = "0x44469D4", Offset = "0x44469D4", VA = "0x44469D4")]
    public void ReservePlayableAdv(
      BattleEventTimingTypeEnum timing,
      UnitParameterData actionOwner,
      FacilityData facility)
    {
    }

    [Token(Token = "0x600EE6C")]
    [Address(RVA = "0x4446A00", Offset = "0x4446A00", VA = "0x4446A00")]
    public IReadOnlyList<BattleAdvData> GetReservedAdv() => (IReadOnlyList<BattleAdvData>) null;

    [Token(Token = "0x600EE6D")]
    [Address(RVA = "0x4446A24", Offset = "0x4446A24", VA = "0x4446A24")]
    public void PlayReservedAdv(BattleAdvData advData, Action onFinished)
    {
    }

    [Token(Token = "0x600EE6E")]
    [Address(RVA = "0x4446C24", Offset = "0x4446C24", VA = "0x4446C24")]
    private IEnumerator AsyncPlayBattleAdv(BattleAdvData data, Action onFinished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600EE6F")]
    [Address(RVA = "0x4446CC8", Offset = "0x4446CC8", VA = "0x4446CC8")]
    private void AddShowAdvViewListFlag(int advId)
    {
    }
  }
}
