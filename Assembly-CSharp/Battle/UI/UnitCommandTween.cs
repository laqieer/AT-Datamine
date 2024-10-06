// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitCommandTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023CA")]
  public sealed class UnitCommandTween : TweenWrapper
  {
    [Token(Token = "0x40098AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x40098B0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup normalAttackButtonTweenGroup;
    [Token(Token = "0x40098B1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup skillCommandButtonTweenGroup;
    [Token(Token = "0x40098B2")]
    [FieldOffset(Offset = "0x38")]
    private UnitCommandPanel unitCommandPanel;
    [Token(Token = "0x40098B4")]
    [FieldOffset(Offset = "0x48")]
    private UnitCommandTween.LayoutCommand layoutCommand;
    [Token(Token = "0x40098B5")]
    [FieldOffset(Offset = "0x4C")]
    private UnitCommandTween.LatestInOut latestInOutElementCompatibility;
    [Token(Token = "0x40098B6")]
    [FieldOffset(Offset = "0x50")]
    private UnitCommandTween.Latest1To2 latest1To2ChangeWeapon;

    [Token(Token = "0x17002F3D")]
    public UITimelineController TimelineController
    {
      [Token(Token = "0x600DB40"), Address(RVA = "0x214D4D0", Offset = "0x214D4D0", VA = "0x214D4D0")] get
      {
        return (UITimelineController) null;
      }
    }

    [Token(Token = "0x17002F3E")]
    public IEnumerator currentRoutine
    {
      [Token(Token = "0x600DB41"), Address(RVA = "0x214D4D8", Offset = "0x214D4D8", VA = "0x214D4D8")] get
      {
        return (IEnumerator) null;
      }
      [Token(Token = "0x600DB42"), Address(RVA = "0x214D4E0", Offset = "0x214D4E0", VA = "0x214D4E0")] private set
      {
      }
    }

    [Token(Token = "0x17002F3F")]
    public UnitCommandTween.Latest1To2 Latest1To2ChangeWeapon
    {
      [Token(Token = "0x600DB43"), Address(RVA = "0x214D4E8", Offset = "0x214D4E8", VA = "0x214D4E8")] get
      {
        return new UnitCommandTween.Latest1To2();
      }
    }

    [Token(Token = "0x600DB44")]
    [Address(RVA = "0x214D4F0", Offset = "0x214D4F0", VA = "0x214D4F0")]
    private new Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x600DB45")]
    [Address(RVA = "0x21476E8", Offset = "0x21476E8", VA = "0x21476E8")]
    public IEnumerator InitializeCoroutine(UnitCommandPanel unitCommandPanel) => (IEnumerator) null;

    [Token(Token = "0x600DB46")]
    [Address(RVA = "0x214837C", Offset = "0x214837C", VA = "0x214837C")]
    public void PlayShowMainCommand(Action finishCallback = null)
    {
    }

    [Token(Token = "0x600DB47")]
    [Address(RVA = "0x214D55C", Offset = "0x214D55C", VA = "0x214D55C")]
    private IEnumerator IEPlayShowMainCommand(Action finishCallback) => (IEnumerator) null;

    [Token(Token = "0x600DB48")]
    [Address(RVA = "0x214946C", Offset = "0x214946C", VA = "0x214946C")]
    public void PlayShowNormalAttackCommand(Action finishCallback = null)
    {
    }

    [Token(Token = "0x600DB49")]
    [Address(RVA = "0x214D5F8", Offset = "0x214D5F8", VA = "0x214D5F8")]
    private IEnumerator IEPlayNormalAttackCommand(Action finishCallback) => (IEnumerator) null;

    [Token(Token = "0x600DB4A")]
    [Address(RVA = "0x2149490", Offset = "0x2149490", VA = "0x2149490")]
    public void PlayShowSkillCommand(Action finishCallback = null)
    {
    }

    [Token(Token = "0x600DB4B")]
    [Address(RVA = "0x214D694", Offset = "0x214D694", VA = "0x214D694")]
    private IEnumerator IEPlayShowSkillCommand(Action finishCallback) => (IEnumerator) null;

    [Token(Token = "0x600DB4C")]
    [Address(RVA = "0x214BA04", Offset = "0x214BA04", VA = "0x214BA04")]
    public void PlayChangeWeapon(Action finishCallback = null)
    {
    }

    [Token(Token = "0x600DB4D")]
    [Address(RVA = "0x214D730", Offset = "0x214D730", VA = "0x214D730")]
    private IEnumerator IEPlayChangeWeapon(Action finishCallback) => (IEnumerator) null;

    [Token(Token = "0x600DB4E")]
    [Address(RVA = "0x214C960", Offset = "0x214C960", VA = "0x214C960")]
    public void NormalAttackButtonSelectIn()
    {
    }

    [Token(Token = "0x600DB4F")]
    [Address(RVA = "0x214CC30", Offset = "0x214CC30", VA = "0x214CC30")]
    public void NormalAttackButtonDecisionIn()
    {
    }

    [Token(Token = "0x600DB50")]
    [Address(RVA = "0x214D1E4", Offset = "0x214D1E4", VA = "0x214D1E4")]
    public void NormalAttackButtonAllOut()
    {
    }

    [Token(Token = "0x600DB51")]
    [Address(RVA = "0x2149A30", Offset = "0x2149A30", VA = "0x2149A30")]
    public void SkillCommandButtonDecisionIn()
    {
    }

    [Token(Token = "0x600DB52")]
    [Address(RVA = "0x2149C94", Offset = "0x2149C94", VA = "0x2149C94")]
    public void SkillCommandButtonDecisionOut()
    {
    }

    [Token(Token = "0x600DB53")]
    [Address(RVA = "0x214C23C", Offset = "0x214C23C", VA = "0x214C23C")]
    public void PlayHideAll()
    {
    }

    [Token(Token = "0x600DB54")]
    [Address(RVA = "0x214D7CC", Offset = "0x214D7CC", VA = "0x214D7CC")]
    private IEnumerator IEPlayHideAll() => (IEnumerator) null;

    [Token(Token = "0x600DB55")]
    [Address(RVA = "0x2149BC0", Offset = "0x2149BC0", VA = "0x2149BC0")]
    public void PlayElementCompatibilityIn()
    {
    }

    [Token(Token = "0x600DB56")]
    [Address(RVA = "0x214CB54", Offset = "0x214CB54", VA = "0x214CB54")]
    public void PlayElementCompatibilityOut()
    {
    }

    [Token(Token = "0x600DB57")]
    [Address(RVA = "0x214D85C", Offset = "0x214D85C", VA = "0x214D85C", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600DB58")]
    [Address(RVA = "0x214D860", Offset = "0x214D860", VA = "0x214D860")]
    public UnitCommandTween()
    {
    }

    [Token(Token = "0x20023CB")]
    private enum LayoutCommand
    {
      [Token(Token = "0x40098B8")] None,
      [Token(Token = "0x40098B9")] Main,
      [Token(Token = "0x40098BA")] NormalAttack,
      [Token(Token = "0x40098BB")] Skill,
    }

    [Token(Token = "0x20023CC")]
    private enum LatestInOut
    {
      [Token(Token = "0x40098BD")] In,
      [Token(Token = "0x40098BE")] Out,
    }

    [Token(Token = "0x20023CD")]
    public enum Latest1To2
    {
      [Token(Token = "0x40098C0")] One,
      [Token(Token = "0x40098C1")] Two,
    }
  }
}
