// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldPredictionPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023F1")]
  public sealed class FieldPredictionPanel : MonoBehaviour
  {
    [Token(Token = "0x400997E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FieldPredictionUnit activatorPanel;
    [Token(Token = "0x400997F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FieldPredictionUnit targetPanel;
    [Token(Token = "0x4009980")]
    [FieldOffset(Offset = "0x28")]
    private bool isTimelinePlaying;
    [Token(Token = "0x4009981")]
    [FieldOffset(Offset = "0x30")]
    private UIManager uiManager;
    [Token(Token = "0x4009982")]
    [FieldOffset(Offset = "0x38")]
    private bool beforeActivePlayConfigControl;
    [Token(Token = "0x4009983")]
    [FieldOffset(Offset = "0x39")]
    private bool beforeActiveGridInformation;
    [Token(Token = "0x4009984")]
    [FieldOffset(Offset = "0x3A")]
    private bool beforeActiveItemDroppedInformation;
    [Token(Token = "0x4009985")]
    [FieldOffset(Offset = "0x3C")]
    private FieldPredictionPanel.LatestTimeline targetLatestTimeline;
    [Token(Token = "0x4009986")]
    [FieldOffset(Offset = "0x40")]
    private Coroutine showCoroutine;
    [Token(Token = "0x4009987")]
    [FieldOffset(Offset = "0x48")]
    private Coroutine hideCoroutine;

    [Token(Token = "0x17002F5C")]
    public bool IsPanelShowing
    {
      [Token(Token = "0x600DC33"), Address(RVA = "0x2155304", Offset = "0x2155304", VA = "0x2155304")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600DC34")]
    [Address(RVA = "0x2155330", Offset = "0x2155330", VA = "0x2155330")]
    public IEnumerator InitializeCoroutine(IDirector director) => (IEnumerator) null;

    [Token(Token = "0x600DC35")]
    [Address(RVA = "0x21553CC", Offset = "0x21553CC", VA = "0x21553CC")]
    public bool Show(bool isSkill) => new bool();

    [Token(Token = "0x600DC36")]
    [Address(RVA = "0x215542C", Offset = "0x215542C", VA = "0x215542C")]
    private IEnumerator WaitShow(bool isSkill) => (IEnumerator) null;

    [Token(Token = "0x600DC37")]
    [Address(RVA = "0x214A0C8", Offset = "0x214A0C8", VA = "0x214A0C8")]
    public void Hide(Action finishCallback = null)
    {
    }

    [Token(Token = "0x600DC38")]
    [Address(RVA = "0x2155528", Offset = "0x2155528", VA = "0x2155528")]
    private IEnumerator WaitHide(Action finishCallback) => (IEnumerator) null;

    [Token(Token = "0x600DC39")]
    [Address(RVA = "0x21555C4", Offset = "0x21555C4", VA = "0x21555C4")]
    public void SetPrediction(
      BattleCore core,
      UnitParameterData activator,
      GridData actionFrom,
      SkillParameterData useSkill,
      IReadOnlyList<UnitParameterData> stratagemSupporters,
      IReadOnlyList<TargetPair> targets,
      IReadableCharacterSupportData activatorCharacterSupportData,
      IReadableCharacterSupportData targetCharacterSupportData)
    {
    }

    [Token(Token = "0x600DC3A")]
    [Address(RVA = "0x2155890", Offset = "0x2155890", VA = "0x2155890")]
    private void UpdatePredictions(
      BattleCore core,
      UnitParameterData activator,
      GridData actionFrom,
      SkillParameterData useSkill,
      List<UnitParameterData> stratagemSupporters,
      List<TargetPair> targets,
      IReadableCharacterSupportData activatorCharacterSupportData,
      IReadableCharacterSupportData targetCharacterSupportData)
    {
    }

    [Token(Token = "0x600DC3B")]
    [Address(RVA = "0x2156A78", Offset = "0x2156A78", VA = "0x2156A78")]
    public void SetPrediction(
      BattleCore core,
      BattlePlayerData player,
      ItemParameterData useItem,
      IReadOnlyList<TargetPair> targets)
    {
    }

    [Token(Token = "0x600DC3C")]
    [Address(RVA = "0x2156B40", Offset = "0x2156B40", VA = "0x2156B40")]
    private void UpdateItemPredictions(
      BattleCore core,
      BattlePlayerData player,
      ItemParameterData useItem,
      List<TargetPair> targets)
    {
    }

    [Token(Token = "0x600DC3D")]
    [Address(RVA = "0x2157120", Offset = "0x2157120", VA = "0x2157120")]
    public FieldPredictionPanel()
    {
    }

    [Token(Token = "0x20023F2")]
    private enum LatestTimeline
    {
      [Token(Token = "0x4009989")] In,
      [Token(Token = "0x400998A")] SkillIn,
      [Token(Token = "0x400998B")] Out,
    }
  }
}
