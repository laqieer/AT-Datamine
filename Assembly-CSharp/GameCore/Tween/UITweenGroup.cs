// Decompiled with JetBrains decompiler
// Type: GameCore.Tween.UITweenGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace GameCore.Tween
{
  [Token(Token = "0x2000C2E")]
  [DisallowMultipleComponent]
  [AddComponentMenu("Tween/Tween Group")]
  [ExecuteAlways]
  public class UITweenGroup : MonoBehaviour
  {
    [Token(Token = "0x4003743")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<UITweenContainer> tweenContainers;
    [Token(Token = "0x4003744")]
    [FieldOffset(Offset = "0x20")]
    private UIAnimationController animationController;
    [Token(Token = "0x4003745")]
    [FieldOffset(Offset = "0x28")]
    private bool isEditorUpdate;
    [Token(Token = "0x4003746")]
    [FieldOffset(Offset = "0x2C")]
    private float playSpeedInEditor;
    [Token(Token = "0x4003747")]
    [FieldOffset(Offset = "0x30")]
    private string[] playingGroupIDs;

    [Token(Token = "0x17000A1E")]
    public List<UITweenContainer> TweenContainers
    {
      [Token(Token = "0x60045F1"), Address(RVA = "0x3513F60", Offset = "0x3513F60", VA = "0x3513F60")] get
      {
        return (List<UITweenContainer>) null;
      }
      [Token(Token = "0x60045F2"), Address(RVA = "0x3513F68", Offset = "0x3513F68", VA = "0x3513F68")] set
      {
      }
    }

    [Token(Token = "0x60045F3")]
    [Address(RVA = "0x3513F70", Offset = "0x3513F70", VA = "0x3513F70")]
    private void Awake()
    {
    }

    [Token(Token = "0x60045F4")]
    [Address(RVA = "0x3513F78", Offset = "0x3513F78", VA = "0x3513F78")]
    public void InitializeSystemIfNeed(bool force = false)
    {
    }

    [Token(Token = "0x60045F5")]
    [Address(RVA = "0x3514018", Offset = "0x3514018", VA = "0x3514018")]
    public void AddFinishedCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x60045F6")]
    [Address(RVA = "0x3514030", Offset = "0x3514030", VA = "0x3514030")]
    public void RemoveFinishedCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x60045F7")]
    [Address(RVA = "0x3514048", Offset = "0x3514048", VA = "0x3514048")]
    public void ClearFinishedCallback()
    {
    }

    [Token(Token = "0x60045F8")]
    [Address(RVA = "0x3514064", Offset = "0x3514064", VA = "0x3514064")]
    public void Play(string groupID, bool stopCurrent = true)
    {
    }

    [Token(Token = "0x60045F9")]
    [Address(RVA = "0x3514130", Offset = "0x3514130", VA = "0x3514130")]
    public void Play(string groupID, Action onFinished, bool stopCurrent = true)
    {
    }

    [Token(Token = "0x60045FA")]
    [Address(RVA = "0x3514174", Offset = "0x3514174", VA = "0x3514174")]
    public IEnumerator OnFinishedTween(string groupID, Action onFinished) => (IEnumerator) null;

    [Token(Token = "0x60045FB")]
    [Address(RVA = "0x3514218", Offset = "0x3514218", VA = "0x3514218")]
    private IEnumerator OnFinishedTween(Action onFinished) => (IEnumerator) null;

    [Token(Token = "0x60045FC")]
    [Address(RVA = "0x35142B4", Offset = "0x35142B4", VA = "0x35142B4")]
    public void PlayMultiGroup(params string[] groupID)
    {
    }

    [Token(Token = "0x60045FD")]
    [Address(RVA = "0x35142F4", Offset = "0x35142F4", VA = "0x35142F4")]
    public void PlayMultiGroup(string[] groupID, bool stopCurrent)
    {
    }

    [Token(Token = "0x60045FE")]
    [Address(RVA = "0x3514338", Offset = "0x3514338", VA = "0x3514338")]
    public void PlayMultiGroup(Action onFinished, params string[] groupID)
    {
    }

    [Token(Token = "0x60045FF")]
    [Address(RVA = "0x3514374", Offset = "0x3514374", VA = "0x3514374")]
    public void ResetToBeginning(string groupID)
    {
    }

    [Token(Token = "0x6004600")]
    [Address(RVA = "0x35143A8", Offset = "0x35143A8", VA = "0x35143A8")]
    public void ResetToEnd(string groupID, bool setDisabled = false)
    {
    }

    [Token(Token = "0x6004601")]
    [Address(RVA = "0x3514404", Offset = "0x3514404", VA = "0x3514404")]
    public void Stop()
    {
    }

    [Token(Token = "0x6004602")]
    [Address(RVA = "0x351443C", Offset = "0x351443C", VA = "0x351443C")]
    public void Hide()
    {
    }

    [Token(Token = "0x6004603")]
    [Address(RVA = "0x3514450", Offset = "0x3514450", VA = "0x3514450")]
    public void Skip()
    {
    }

    [Token(Token = "0x6004604")]
    [Address(RVA = "0x3514474", Offset = "0x3514474", VA = "0x3514474")]
    private void Update()
    {
    }

    [Token(Token = "0x6004605")]
    [Address(RVA = "0x3514484", Offset = "0x3514484", VA = "0x3514484")]
    public bool IsPlaying() => new bool();

    [Token(Token = "0x6004606")]
    [Address(RVA = "0x35144AC", Offset = "0x35144AC", VA = "0x35144AC")]
    public bool IsPlaying(string key) => new bool();

    [Token(Token = "0x6004607")]
    [Address(RVA = "0x35144C4", Offset = "0x35144C4", VA = "0x35144C4")]
    public UITweenGroup()
    {
    }
  }
}
