// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldUnitListManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002408")]
  public sealed class FieldUnitListManager
  {
    [Token(Token = "0x4009A0F")]
    [FieldOffset(Offset = "0x18")]
    private bool _disposed;
    [Token(Token = "0x4009A10")]
    [FieldOffset(Offset = "0x20")]
    private GameObject _elementPrefab;
    [Token(Token = "0x4009A11")]
    [FieldOffset(Offset = "0x28")]
    private readonly Dictionary<int, FieldUnitListElement> _unitElements;
    [Token(Token = "0x4009A12")]
    [FieldOffset(Offset = "0x30")]
    private readonly List<int> _unitIds;
    [Token(Token = "0x4009A13")]
    [FieldOffset(Offset = "0x38")]
    private BattlePlayerData _userPlayer;
    [Token(Token = "0x4009A14")]
    [FieldOffset(Offset = "0x40")]
    private FieldUnitListConnect _unitListConnect;
    [Token(Token = "0x4009A15")]
    [FieldOffset(Offset = "0x48")]
    private bool focusMoving;
    [Token(Token = "0x4009A16")]
    [FieldOffset(Offset = "0x50")]
    public Func<bool> IsEnableControl;

    [Token(Token = "0x17002F78")]
    public FieldUnitListController FieldUnitListController
    {
      [Token(Token = "0x600DCE4"), Address(RVA = "0x1E22E14", Offset = "0x1E22E14", VA = "0x1E22E14")] get
      {
        return (FieldUnitListController) null;
      }
      [Token(Token = "0x600DCE5"), Address(RVA = "0x1E22E1C", Offset = "0x1E22E1C", VA = "0x1E22E1C")] set
      {
      }
    }

    [Token(Token = "0x17002F79")]
    private float _contentAreaHeight
    {
      [Token(Token = "0x600DCE6"), Address(RVA = "0x1E22E24", Offset = "0x1E22E24", VA = "0x1E22E24")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002F7A")]
    private float _viewportHeight
    {
      [Token(Token = "0x600DCE7"), Address(RVA = "0x1E22FA4", Offset = "0x1E22FA4", VA = "0x1E22FA4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600DCE8")]
    [Address(RVA = "0x1E21A44", Offset = "0x1E21A44", VA = "0x1E21A44")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600DCE9")]
    [Address(RVA = "0x1E22FE4", Offset = "0x1E22FE4", VA = "0x1E22FE4")]
    public void Show()
    {
    }

    [Token(Token = "0x600DCEA")]
    [Address(RVA = "0x1E22FFC", Offset = "0x1E22FFC", VA = "0x1E22FFC")]
    public void Hide()
    {
    }

    [Token(Token = "0x600DCEB")]
    [Address(RVA = "0x1E23014", Offset = "0x1E23014", VA = "0x1E23014")]
    public void SelectUnit(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DCEC")]
    [Address(RVA = "0x1E230B0", Offset = "0x1E230B0", VA = "0x1E230B0")]
    public void UnSelectUnit()
    {
    }

    [Token(Token = "0x600DCED")]
    [Address(RVA = "0x1E230CC", Offset = "0x1E230CC", VA = "0x1E230CC")]
    public void SetIsEnableControl(Func<bool> action)
    {
    }

    [Token(Token = "0x600DCEE")]
    [Address(RVA = "0x1E230D4", Offset = "0x1E230D4", VA = "0x1E230D4")]
    private void MatchDoubleAnimationSequence(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      FieldUnitListManager.DoubleAnimationState state,
      FieldUnitListManager.SequenceCallback completeAction = null)
    {
    }

    [Token(Token = "0x600DCEF")]
    [Address(RVA = "0x1E23190", Offset = "0x1E23190", VA = "0x1E23190")]
    private void ReleaseDoubleAnimationSequence(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      FieldUnitListManager.DoubleAnimationState state,
      FieldUnitListManager.SequenceCallback completeAction = null)
    {
    }

    [Token(Token = "0x600DCF0")]
    [Address(RVA = "0x1E2324C", Offset = "0x1E2324C", VA = "0x1E2324C")]
    private void SwitchDoubleAnimationSequence(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      FieldUnitListManager.DoubleAnimationState state,
      FieldUnitListManager.SequenceCallback completeAction = null)
    {
    }

    [Token(Token = "0x600DCF1")]
    [Address(RVA = "0x1E23308", Offset = "0x1E23308", VA = "0x1E23308")]
    private void UpdateUnitAction(UnitParameterData frontUnit, UnitParameterData backUnit)
    {
    }

    [Token(Token = "0x600DCF2")]
    [Address(RVA = "0x1E233D0", Offset = "0x1E233D0", VA = "0x1E233D0")]
    private Task Focus(UnitParameterData unit, float elapsedTime = 1f) => (Task) null;

    [Token(Token = "0x600DCF3")]
    [Address(RVA = "0x1E234B8", Offset = "0x1E234B8", VA = "0x1E234B8")]
    private int GetViewElementTopIndex(float hoge) => new int();

    [Token(Token = "0x600DCF4")]
    [Address(RVA = "0x1E235EC", Offset = "0x1E235EC", VA = "0x1E235EC")]
    private void PlayTweenAnimation(
      string groupID,
      UnitParameterData unit,
      bool stopPlayingAnim = true,
      UnityAction callback = null)
    {
    }

    [Token(Token = "0x600DCF5")]
    [Address(RVA = "0x1E236A4", Offset = "0x1E236A4", VA = "0x1E236A4")]
    private Task FocusDirectionInternal(float startValue, float targetValue, float elapsedTime)
    {
      return (Task) null;
    }

    [Token(Token = "0x600DCF6")]
    [Address(RVA = "0x1E23798", Offset = "0x1E23798", VA = "0x1E23798")]
    public void MatchDouble(UnitParameterData frontUnit, UnitParameterData backUnit)
    {
    }

    [Token(Token = "0x600DCF7")]
    [Address(RVA = "0x1E23960", Offset = "0x1E23960", VA = "0x1E23960")]
    public void ReleaseDouble(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      Action callback = null)
    {
    }

    [Token(Token = "0x600DCF8")]
    [Address(RVA = "0x1E23A3C", Offset = "0x1E23A3C", VA = "0x1E23A3C")]
    public void SwitchDouble(UnitParameterData frontUnit, UnitParameterData backUnit)
    {
    }

    [Token(Token = "0x600DCF9")]
    [Address(RVA = "0x1E23AD4", Offset = "0x1E23AD4", VA = "0x1E23AD4")]
    public void UpdateUnitHpAndStockCounter(UnitParameterData front, UnitParameterData back = null)
    {
    }

    [Token(Token = "0x600DCFA")]
    [Address(RVA = "0x1E23D58", Offset = "0x1E23D58", VA = "0x1E23D58")]
    public void UpdateBadStatus(UnitParameterData front, UnitParameterData back = null)
    {
    }

    [Token(Token = "0x600DCFB")]
    [Address(RVA = "0x1E23330", Offset = "0x1E23330", VA = "0x1E23330")]
    public void Refresh(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DCFC")]
    [Address(RVA = "0x1E23E8C", Offset = "0x1E23E8C", VA = "0x1E23E8C")]
    public void DeadAction(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DCFD")]
    [Address(RVA = "0x1E23F5C", Offset = "0x1E23F5C", VA = "0x1E23F5C")]
    public void SelectAction(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DCFE")]
    [Address(RVA = "0x1E24040", Offset = "0x1E24040", VA = "0x1E24040")]
    public void SetUnitNumber()
    {
    }

    [Token(Token = "0x600DCFF")]
    [Address(RVA = "0x1E24428", Offset = "0x1E24428", VA = "0x1E24428")]
    public void DoAnimation()
    {
    }

    [Token(Token = "0x600DD00")]
    [Address(RVA = "0x1E24630", Offset = "0x1E24630", VA = "0x1E24630")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600DD01")]
    [Address(RVA = "0x1E246CC", Offset = "0x1E246CC", VA = "0x1E246CC")]
    private IEnumerator LoadUnitListElementPrefabAsset() => (IEnumerator) null;

    [Token(Token = "0x600DD02")]
    [Address(RVA = "0x1E2475C", Offset = "0x1E2475C", VA = "0x1E2475C")]
    public IEnumerator Initialize(
      BattleCore core,
      MapDirectorBase map,
      CameraDirector camera,
      BattlePlayerData userPlayer,
      IDirector mainDirector)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600DD03")]
    [Address(RVA = "0x1E24820", Offset = "0x1E24820", VA = "0x1E24820")]
    private bool IsScroll() => new bool();

    [Token(Token = "0x600DD04")]
    [Address(RVA = "0x1E2485C", Offset = "0x1E2485C", VA = "0x1E2485C")]
    private void ScrollUpButtonEvent()
    {
    }

    [Token(Token = "0x600DD05")]
    [Address(RVA = "0x1E248F0", Offset = "0x1E248F0", VA = "0x1E248F0")]
    private void ScrollDownButtonEvent()
    {
    }

    [Token(Token = "0x600DD06")]
    [Address(RVA = "0x1E22E28", Offset = "0x1E22E28", VA = "0x1E22E28")]
    private float GetContentAreaHeight() => new float();

    [Token(Token = "0x600DD07")]
    [Address(RVA = "0x1E22FA8", Offset = "0x1E22FA8", VA = "0x1E22FA8")]
    private float GetViewPortHeight() => new float();

    [Token(Token = "0x600DD08")]
    [Address(RVA = "0x1E21C6C", Offset = "0x1E21C6C", VA = "0x1E21C6C")]
    public FieldUnitListManager()
    {
    }

    [Token(Token = "0x2002409")]
    private enum DoubleAnimationState
    {
      [Token(Token = "0x4009A18")] None,
      [Token(Token = "0x4009A19")] FrontUnitFadeOut,
      [Token(Token = "0x4009A1A")] FrontUnitDisplayOff,
      [Token(Token = "0x4009A1B")] TargetFocus,
      [Token(Token = "0x4009A1C")] BackUnitDisplayOn,
      [Token(Token = "0x4009A1D")] BackUnitFadeIn,
      [Token(Token = "0x4009A1E")] BackUnitFadeOut,
      [Token(Token = "0x4009A1F")] BackUnitDisplayOff,
      [Token(Token = "0x4009A20")] FrontUnitDisplayOn,
      [Token(Token = "0x4009A21")] FrontUnitFadeIn,
      [Token(Token = "0x4009A22")] Finished,
    }

    [Token(Token = "0x200240A")]
    private delegate void SequenceCallback(UnitParameterData frontUnit, UnitParameterData backUnit);
  }
}
