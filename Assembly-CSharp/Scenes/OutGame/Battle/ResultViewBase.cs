// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x200377C")]
  public class ResultViewBase : MonoBehaviour, IBattleResultFlow
  {
    [Token(Token = "0x17004859")]
    protected BattleResultSubScene SubScene
    {
      [Token(Token = "0x6015DAC"), Address(RVA = "0x231E104", Offset = "0x231E104", VA = "0x231E104")] get
      {
        return (BattleResultSubScene) null;
      }
      [Token(Token = "0x6015DAD"), Address(RVA = "0x231E10C", Offset = "0x231E10C", VA = "0x231E10C")] set
      {
      }
    }

    [Token(Token = "0x1700485A")]
    protected bool IsSkipped
    {
      [Token(Token = "0x6015DAE"), Address(RVA = "0x231E114", Offset = "0x231E114", VA = "0x231E114")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015DAF"), Address(RVA = "0x231E11C", Offset = "0x231E11C", VA = "0x231E11C")] set
      {
      }
    }

    [Token(Token = "0x1700485B")]
    public bool IsPlaying
    {
      [Token(Token = "0x6015DB0"), Address(RVA = "0x231E128", Offset = "0x231E128", VA = "0x231E128")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015DB1"), Address(RVA = "0x231E130", Offset = "0x231E130", VA = "0x231E130")] set
      {
      }
    }

    [Token(Token = "0x1700485C")]
    public bool ClickedNextButton
    {
      [Token(Token = "0x6015DB2"), Address(RVA = "0x231E13C", Offset = "0x231E13C", VA = "0x231E13C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015DB3"), Address(RVA = "0x231E144", Offset = "0x231E144", VA = "0x231E144")] set
      {
      }
    }

    [Token(Token = "0x6015DB4")]
    [Address(RVA = "0x231E150", Offset = "0x231E150", VA = "0x231E150", Slot = "5")]
    public virtual void Initialize(BattleResultSubScene subScene)
    {
    }

    [Token(Token = "0x6015DB5")]
    [Address(RVA = "0x231E158", Offset = "0x231E158", VA = "0x231E158", Slot = "6")]
    public virtual void Play()
    {
    }

    [Token(Token = "0x6015DB6")]
    [Address(RVA = "0x231E15C", Offset = "0x231E15C", VA = "0x231E15C", Slot = "7")]
    public virtual void Skip()
    {
    }

    [Token(Token = "0x6015DB7")]
    [Address(RVA = "0x231E168", Offset = "0x231E168", VA = "0x231E168", Slot = "8")]
    protected virtual IEnumerator ExecutePlayFlow() => (IEnumerator) null;

    [Token(Token = "0x6015DB8")]
    [Address(RVA = "0x231E1F8", Offset = "0x231E1F8", VA = "0x231E1F8")]
    protected void PlayTweenMultiGroup(UITweenGroup group, string[] groupIds, Action finishAction = null)
    {
    }

    [Token(Token = "0x6015DB9")]
    [Address(RVA = "0x231E2E4", Offset = "0x231E2E4", VA = "0x231E2E4")]
    protected void PlayTweenGroup(UITweenGroup group, string groupId, Action finishAction = null)
    {
    }

    [Token(Token = "0x6015DBA")]
    [Address(RVA = "0x231E3D4", Offset = "0x231E3D4", VA = "0x231E3D4")]
    protected IEnumerator PlayTweenGroupCoroutine(UITweenGroup tweenGroup, string groudId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015DBB")]
    [Address(RVA = "0x231E478", Offset = "0x231E478", VA = "0x231E478")]
    protected IEnumerator PlayTweenMultiGroupCoroutine(
      UITweenGroup tweenGroup,
      params string[] groupIds)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015DBC")]
    [Address(RVA = "0x231E51C", Offset = "0x231E51C", VA = "0x231E51C", Slot = "4")]
    public IEnumerator PlayAndWait() => (IEnumerator) null;

    [Token(Token = "0x6015DBD")]
    [Address(RVA = "0x231E5AC", Offset = "0x231E5AC", VA = "0x231E5AC")]
    public ResultViewBase()
    {
    }
  }
}
